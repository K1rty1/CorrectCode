using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeLibrary
{
    public class CorrectCodeClass
    {
        public static bool IsCorrectCode(string candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
             if (candidate.Length != 10)
            {
                return false;
            }
            int summ = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                summ +=Convert.ToInt32( Char.GetNumericValue(candidate, i));


            }
            if (summ % 10 == 0 && candidate[9] == '0')
            {
                return true;
            }
            if (summ % 3 == 0 && candidate[9]==1)
            {
                return true;
            }
            if (candidate[9]!=9)
            {
                return false;
            }
            else
            {
                return false;
            }
            
        }
    }
}

