using Xunit;

namespace Exercism_Exercises.Exercises.BuildingTelemetry
{
    public class BuildingTelemetryTests
	{
        [Fact]
        public void UsagePerMeterGood()
        {
            var car = RemoteControlCar.Buy();
            car.Drive(); car.Drive();
            var tc = new TelemetryClient(car);
            Assert.Equal("usage-per-meter=5", tc.GetBatteryUsagePerMeter(serialNum: 1));
        }
        [Fact]
        public void UsagePerMeterNotStated()
        {
            var car = RemoteControlCar.Buy();
            var tc = new TelemetryClient(car);
            Assert.Equal("no data", tc.GetBatteryUsagePerMeter(serialNum: 1));
        }
    }
}//Made by ericssonGamerz4

                