using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     public static class SumOfMultiples
 {
     public static int Sum(IEnumerable<int> multiples, int max)
     {
         if (multiples == null || max == 0)
             return 0;

         HashSet<int> result = new();

         foreach (int multiple in multiples)
         {
             if (multiple != 0)
             {
                 for (int i = 1; i * multiple < max; i++)
                 {
                     result.Add(multiple * i);
                 }
             }
         }

         return result.Sum();
     }
 }