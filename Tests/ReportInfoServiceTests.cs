using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Repository.Contracts;
using Services;

namespace Tests
{
    /// <summary>
    /// Тестирование класса ReportInfoService
    /// </summary>
    public class ReportInfoServiceTests
    {
        private readonly Mock<ILogger<ReportInfoService>> loggerMock;
        private readonly Mock<IReportInfo> repositoryMock;
        private readonly ReportInfoService service;

        /// <summary>
        /// Конструктор
        /// </summary>
        public ReportInfoServiceTests() 
        {
            loggerMock = new();
            repositoryMock = new();
            service = new(repositoryMock.Object, loggerMock.Object);
        }

        /// <summary>
        /// Проверка на корректное получение количества всех рейсов в методе TotalArrivingFlightsAsync класса ReportInfoService
        /// </summary>
        [Fact]
        public async Task TotalArrivingFlightsShouldReturnsCountOfFlights()
        {
            // Arrange
            repositoryMock.Setup(r => r.TotalArrivingFlightsAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(5);

            // Act
            var result = await service.TotalArrivingFlightsAsync(CancellationToken.None);

            // Assert
            result.Should().Be(5);
            repositoryMock.Verify(r=>r.TotalArrivingFlightsAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное получение суммы всего экипажа в методе TotalCrewAsync класса ReportInfoService
        /// </summary>
        [Fact]
        public async Task TotalCrewShouldReturnsSumOfCrews()
        {
            // Arrange
            repositoryMock.Setup(r => r.TotalCrewAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(5);

            // Act
            var result = await service.TotalCrewAsync(CancellationToken.None);

            // Assert
            result.Should().Be(5);
            repositoryMock.Verify(r => r.TotalCrewAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное получение суммы всех пассажиров в методе TotalPassangersAsync класса ReportInfoService
        /// </summary>
        [Fact]
        public async Task TotalPassangersShouldReturnsSumOfPassangers()
        {
            // Arrange
            repositoryMock.Setup(r => r.TotalPassangersAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(5);

            // Act
            var result = await service.TotalPassangersAsync(CancellationToken.None);

            // Assert
            result.Should().Be(5);
            repositoryMock.Verify(r => r.TotalPassangersAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное получение суммы всей выручки в методе TotalRevenueAsync класса ReportInfoService
        /// </summary>
        [Fact]
        public async Task TotalRevenueShouldReturnsSumOfRevenue()
        {
            // Arrange
            repositoryMock.Setup(r => r.TotalRevenueAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(5);

            // Act
            var result = await service.TotalRevenueAsync(CancellationToken.None);

            // Assert
            result.Should().Be(5);
            repositoryMock.Verify(r => r.TotalRevenueAsync(It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
