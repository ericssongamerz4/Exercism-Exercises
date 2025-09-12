using System;

namespace Exercism_Exercises.Exercises.WeighingMachine
{
    class WeighingMachine
    {         
        private double _Weight = 0;
       
        public WeighingMachine(int precision)
        {
            Precision = precision;
        }

        public int Precision { get; }

        public double Weight
        {
            get { return _Weight; }
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                _Weight = value;
            }
        }

        public string DisplayWeight
        {
            get { return $"{(_Weight - TareAdjustment).ToString($"F{Precision}")} kg"; }
        }

        public double TareAdjustment { get; set; } = 5.0;
    }

}//Made by ericssonGamerz4