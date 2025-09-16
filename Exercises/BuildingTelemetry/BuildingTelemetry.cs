using System;

namespace Exercism_Exercises.Exercises.BuildingTelemetry
{
    public class RemoteControlCar
    {
        private int batteryPercentage = 100;
        private int distanceDrivenInMeters = 0;
        private string[] sponsors = [];
        private int latestSerialNum = 0;
        public void Drive()
        {
            if (batteryPercentage > 0)
            {
                batteryPercentage -= 10;
                distanceDrivenInMeters += 2;
            }
        }
        public void SetSponsors(params string[] sponsors) => this.sponsors = sponsors;
        public string DisplaySponsor(int sponsorNum) => sponsors[sponsorNum];
        public bool GetTelemetryData(ref int serialNum, out int batteryPercentage, out int distanceDrivenInMeters)
        {
            if (latestSerialNum == 0)  
                latestSerialNum = serialNum;
            
            if (serialNum == latestSerialNum)
            {
                batteryPercentage = this.batteryPercentage;
                distanceDrivenInMeters =  this.distanceDrivenInMeters;
                return true;
            }
            else
            {
                serialNum = latestSerialNum;
                batteryPercentage = -1;
                distanceDrivenInMeters = -1;
                return false;
            }
        }
        public static RemoteControlCar Buy() => new RemoteControlCar();
    }

    public class TelemetryClient
    {
        private RemoteControlCar car;
        public TelemetryClient(RemoteControlCar car) => this.car = car;
        public string GetBatteryUsagePerMeter(int serialNum) => (car.GetTelemetryData(ref serialNum, out int batteryPercentage, out int distanceDrivenInMeters)
                                                                 && distanceDrivenInMeters != 0) ?
                                                                 $"usage-per-meter={ (100 - batteryPercentage) / distanceDrivenInMeters}" : "no data";        
    }
}//Made by ericssonGamerz4