using Airport.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Entities.Models;
using Services.Contracts;

namespace Airport.WebApp.Controllers
{
    public class HomeController(IFlightRegistryService flightRegistryService, IReportInfoService reportInfoService)
        : Controller
    {
        private readonly IFlightRegistryService flightRegistryService = flightRegistryService;
        private readonly IReportInfoService reportInfoService = reportInfoService;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Worker()
        {
            var flights = await flightRegistryService.GetAllAsync(CancellationToken.None);
            return View(flights);
        }

        public IActionResult Administrator()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Remove(Guid id)
        {
            return View(id);
        }

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}