using Entities.Models;
using FluentAssertions;
using Microsoft.Extensions.Logging;
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
        private readonly Mock<ILogger<FlightRegistryService>> loggerMock;
        private readonly Mock<IFlightRegistry> repositoryMock;
        private readonly FlightRegistryService service;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FlightRegistryServiceTests()
        {
            loggerMock = new();
            repositoryMock = new();
            service = new(repositoryMock.Object, loggerMock.Object);
        }

        /// <summary>
        /// Проверка на корректное добавление самолета в методе AddFlightAsync класса FlightRegistryService
        /// </summary>
        [Fact]
        public async Task AddFlightShouldAddTheFlight()
        {
            // Arrange
            var flight = new Flight();

            // Act
            await service.AddFlightAsync(flight, CancellationToken.None);

            // Assert
            repositoryMock.Verify(r => r.AddFlightAsync(flight, It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное удаление самолета в методе DeleteFlightAsync класса FlightRegistryService
        /// </summary>
        [Fact]
        public async Task DeleteFlightShouldDeleteTheFlight()
        {
            // Arrange
            var flight = new Flight();

            // Act
            await service.DeleteFlightAsync(flight, CancellationToken.None);

            // Assert
            repositoryMock.Verify(r => r.DeleteFlightAsync(flight, It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное получение всего списка в методе GetAllAsync класса FlightRegistryService
        /// </summary>
        [Fact]
        public async Task GetAllFlightsShouldReturnAllFlights()
        {
            // Arrange
            var expected = new List<Flight> { new(), new() };
            repositoryMock.Setup(r => r.GetAllAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(expected);

            // Act
            var result = await service.GetAllAsync(CancellationToken.None);

            // Assert
            result.Should().BeSameAs(expected);
            repositoryMock.Verify(r => r.GetAllAsync(It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
