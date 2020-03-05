using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLGParcel.Library
{
    public static class Helper
    {
        public static double ConvertValueToDouble(string inputValue)
        {
            double number;

            if (Double.TryParse(inputValue, out number))
            {
                return number;
            }

            return 0;
        }


    }
}
