using System;

namespace Exercism_Exercises.Exercises.WeatherStation
{
    public class WeatherStation
    {
        private Reading reading;
        private List<DateTime> recordDates = new();
        private List<decimal> temperatures = new();

        public void AcceptReading(Reading reading)
        {
            this.reading = reading;
            recordDates.Add(DateTime.Now);
            temperatures.Add(reading.Temperature);
        }

        public void ClearAll()
        {
            reading = new Reading();
            recordDates.Clear();
            temperatures.Clear();
        }

        public decimal LatestTemperature => reading.Temperature;

        public decimal LatestPressure => reading.Pressure;

        public decimal LatestRainfall => reading.Rainfall;

        public bool HasHistory => recordDates.Count > 1;

        public Outlook ShortTermOutlook => reading switch
        {
            var r when r.Equals(new Reading()) => throw new ArgumentException(),
            { Pressure: < 10m, Temperature: < 30m } => Outlook.Cool,
            { Temperature: > 50 } => Outlook.Good,
            _ => Outlook.Warm
        };

        public Outlook LongTermOutlook1 => reading switch
        {
            { WindDirection: WindDirection.Southerly } => Outlook.Good,
            { WindDirection: WindDirection.Easterly, Temperature: > 20 } => Outlook.Good,
            { WindDirection: WindDirection.Northerly } => Outlook.Cool,
            { WindDirection: WindDirection.Easterly, Temperature: <= 20 } => Outlook.Warm,
            { WindDirection: WindDirection.Westerly } => Outlook.Rainy,
            _ => throw new ArgumentException()
        };
        //LongTermOutlook and LongTermOutlook1 do the same
        public Outlook LongTermOutlook
        {
            get
            {
                return reading.WindDirection switch
                {
                    WindDirection.Southerly => Outlook.Good,
                    WindDirection.Easterly when reading.Temperature > 20 => Outlook.Good,
                    WindDirection.Northerly => Outlook.Cool,
                    WindDirection.Easterly when reading.Temperature <= 20  => Outlook.Warm,
                    WindDirection.Westerly => Outlook.Rainy,
                    _ => throw new ArgumentException()
                };
            }
        }
        public State RunSelfTest() => reading.Equals(new Reading()) ? State.Bad : State.Good;
    }
}//Made by ericssonGamerz4

