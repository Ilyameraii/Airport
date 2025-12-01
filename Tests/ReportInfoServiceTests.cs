using FluentAssertions;
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
        /// <summary>
        /// Проверка на корректное получение количества всех рейсов в методе TotalArrivingFlightsAsync класса ReportInfoService
        /// </summary>
        [Fact]
        public async Task TotalArrivingFlights_Should_Returns_Count_Of_Flights()
        {
            // Arrange
            var repositoryMock = new Mock<IReportInfo>();

            repositoryMock.Setup(r => r.TotalArrivingFlights(It.IsAny<CancellationToken>()))
                .ReturnsAsync(5);

            var service = new ReportInfoService(repositoryMock.Object);

            // Act
            var result = await service.TotalArrivingFlightsAsync(CancellationToken.None);

            // Assert
            result.Should().Be(5);
            repositoryMock.Verify(r=>r.TotalArrivingFlights(It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное получение суммы всего экипажа в методе TotalCrewAsync класса ReportInfoService
        /// </summary>
        [Fact]
        public async Task TotalCrew_Should_Returns_Sum_Of_Crews()
        {
            // Arrange
            var repositoryMock = new Mock<IReportInfo>();

            repositoryMock.Setup(r => r.TotalCrew(It.IsAny<CancellationToken>()))
                .ReturnsAsync(5);

            var service = new ReportInfoService(repositoryMock.Object);

            // Act
            var result = await service.TotalCrewAsync(CancellationToken.None);

            // Assert
            result.Should().Be(5);
            repositoryMock.Verify(r => r.TotalCrew(It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное получение суммы всех пассажиров в методе TotalPassangersAsync класса ReportInfoService
        /// </summary>
        [Fact]
        public async Task TotalPassangers_Should_Returns_Sum_Of_Passangers()
        {
            // Arrange
            var repositoryMock = new Mock<IReportInfo>();

            repositoryMock.Setup(r => r.TotalPassangers(It.IsAny<CancellationToken>()))
                .ReturnsAsync(5);

            var service = new ReportInfoService(repositoryMock.Object);

            // Act
            var result = await service.TotalPassangersAsync(CancellationToken.None);

            // Assert
            result.Should().Be(5);
            repositoryMock.Verify(r => r.TotalPassangers(It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// Проверка на корректное получение суммы всей выручки в методе TotalRevenueAsync класса ReportInfoService
        /// </summary>
        [Fact]
        public async Task TotalRevenue_Should_Returns_Sum_Of_Revenue()
        {
            // Arrange
            var repositoryMock = new Mock<IReportInfo>();

            repositoryMock.Setup(r => r.TotalRevenue(It.IsAny<CancellationToken>()))
                .ReturnsAsync(5);

            var service = new ReportInfoService(repositoryMock.Object);

            // Act
            var result = await service.TotalRevenueAsync(CancellationToken.None);

            // Assert
            result.Should().Be(5);
            repositoryMock.Verify(r => r.TotalRevenue(It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
