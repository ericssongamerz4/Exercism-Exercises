using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_Exercises.Exercises
{
    public static class Hamming
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            if (firstStrand.Length != secondStrand.Length)
                throw new ArgumentException("Strands must have the same length.");

            int result = 0;

            if(firstStrand == secondStrand)
                return result;


            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                    result++;
            }

            return result;
        }
    }
}
