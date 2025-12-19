using Airport.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Entities.Models;
using Services.Contracts;

namespace Airport.WebApp.Controllers
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="flightRegistryService">Сервис для ведения реестра рейсов</param>
    /// <param name="reportInfoService">Сервис для ведения отчета о рейсах</param>
    public class HomeController(IFlightRegistryService flightRegistryService, IReportInfoService reportInfoService)
        : Controller
    {
        /// <summary>
        /// Открывает View главной страницы
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Открывает View для работника
        /// </summary>
        public async Task<IActionResult> Worker()
        {
            var flights = await flightRegistryService.GetAllAsync(CancellationToken.None);
            return View(flights);
        }

        /// <summary>
        /// Открывает View для администратора
        /// </summary>
        public async Task<IActionResult> Administrator()
        {
            var viewModel = new AdministratorViewModel
            {
                TotalArrivingFlights = await reportInfoService.TotalArrivingFlightsAsync(CancellationToken.None),
                TotalPassengers = await reportInfoService.TotalPassangersAsync(CancellationToken.None),
                TotalCrew = await reportInfoService.TotalCrewAsync(CancellationToken.None),
                TotalRevenue = await reportInfoService.TotalRevenueAsync(CancellationToken.None)
            };
            return View(viewModel);
        }

        /// <summary>
        /// Открывает View для подтверждения удаления
        /// </summary>
        [HttpGet]
        public IActionResult Remove(Guid id)
        {
            return View(id);
        }
        
        /// <summary>
        /// Удаление рейса из списка по айди
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveConfirmed(Guid id)
        {
            var flight = await flightRegistryService.GetFlightAsync(id, CancellationToken.None);
            if (flight != null)
            {
                await flightRegistryService.DeleteFlightAsync(flight, CancellationToken.None);
            }

            return RedirectToAction(nameof(Worker));
        }
        /// <summary>
        /// Открывает View для редактирования рейса
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await flightRegistryService.GetFlightAsync(id.Value, CancellationToken.None);

            if (flight == null)
            {
                return NotFound();
            }
            return View(flight);
        }

        /// <summary>
        /// Редактирование рейса
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Flight flight)
        {
            if (!ModelState.IsValid)
            {
                return View(flight);
            }

            await flightRegistryService.UpdateFlightAsync(flight, CancellationToken.None);
            return RedirectToAction("Worker");
        }

        /// <summary>
        /// Открывает View для добавления рейса в список
        /// </summary>
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        
        /// <summary>
        /// Добавление рейса в список
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Flight flight)
        {
            if (!ModelState.IsValid)
            {
                return View(flight);
            }

            await flightRegistryService.AddFlightAsync(flight, CancellationToken.None);
            return RedirectToAction("Worker");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}