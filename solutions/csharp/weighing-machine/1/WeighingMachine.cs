 class WeighingMachine
 {
     private double _TareAdjustment = 5.0;
     private double _Weight;

     public WeighingMachine(int precision)
     {
         Precision = precision;
     }

     public int Precision{ get; }

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
         get { return $"{(_Weight - _TareAdjustment).ToString($"F{Precision}")} kg"; }        
     }

     public double TareAdjustment 
     {
         get { return _TareAdjustment; } 
         set { _TareAdjustment = value; } 
     }
 }