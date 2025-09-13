namespace Exercism_Exercises.Exercises.WeatherStation
{
    /*** Please do not modify this struct ***/
    public struct Reading
    {
        public decimal Temperature { get; }
        public decimal Pressure { get; }
        public decimal Rainfall { get; }
        public WindDirection WindDirection { get; }

        public Reading(decimal temperature, decimal pressure,
            decimal rainfall, WindDirection windDirection)
        {
            Temperature = temperature;
            Pressure = pressure;
            Rainfall = rainfall;
            WindDirection = windDirection;
        }
    }

    /*** Please do not modify this enum ***/
    public enum State
    {
        Good,
        Bad
    }

    /*** Please do not modify this enum ***/
    public enum Outlook
    {
        Cool,
        Rainy,
        Warm,
        Good
    }

    /*** Please do not modify this enum ***/
    public enum WindDirection
    {
        Unknown, // default
        Northerly,
        Easterly,
        Southerly,
        Westerly
    }
}//Made by ericssonGamerz4

                