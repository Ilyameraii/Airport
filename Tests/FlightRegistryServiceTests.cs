using Entities.Models;
using FluentAssertions;
using Moq;
using Repository.Contracts;
using Services;
using System.ComponentModel;

namespace Tests
{
    /// <summary>
    /// Тестирование класса FlightRegistryService
    /// </summary>
    public class FlightRegistryServiceTests
    {
        /// <summary>
        /// Проверка на корректное добавление самолета в методе AddFlightAsync класса FlightRegistryService
        /// </summary>
        [Fact]
        public async Task AddFlight_Should_Add_The_Flight()
        {
            // Arrange
            var repositoryMock = new Mock<IFlightRegistry>();
            var service = new FlightRegistryService(repositoryMock.Object);
            var flight = new Flight();

            // Act
            await service.AddFlightAsync(flight, CancellationToken.None);

            // Assert
            repositoryMock.Verify(r => r.AddFlight(flight, It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное удаление самолета в методе DeleteFlightAsync класса FlightRegistryService
        /// </summary>
        [Fact]
        public async Task DeleteFlight_Should_Delete_The_Flight()
        {
            // Arrange
            var repositoryMock = new Mock<IFlightRegistry>();
            var service = new FlightRegistryService(repositoryMock.Object);
            var flight = new Flight();

            // Act
            await service.DeleteFlightAsync(flight, CancellationToken.None);

            // Assert
            repositoryMock.Verify(r => r.DeleteFlight(flight, It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное получение всего списка в методе GetAllAsync класса FlightRegistryService
        /// </summary>
        [Fact]
        public async Task GetAllFlights_Should_Return_All_Flights()
        {
            // Arrange
            var repositoryMock = new Mock<IFlightRegistry>();
            var expected = new BindingList<Flight> { new Flight(), new Flight() };

            repositoryMock.Setup(r => r.GetAll(It.IsAny<CancellationToken>()))
                .ReturnsAsync(expected);
            var service = new FlightRegistryService(repositoryMock.Object);

            // Act
            var result = await service.GetAllAsync(CancellationToken.None);

            // Assert
            result.Should().BeSameAs(expected);
            repositoryMock.Verify(r => r.GetAll(It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
