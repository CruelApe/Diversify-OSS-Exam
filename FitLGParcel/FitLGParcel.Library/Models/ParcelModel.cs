using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLGParcel.Library.Models
{
    public class ParcelModel
    {

        public double Weight { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public string ErrorMessage { get; set; }

        public bool IsParcelEmpty {
            get
            {
                if ((Weight + Height + Width + Depth) == 0)
                {
                    ErrorMessage = Constants.NoParcelInputData;
                    return true;
                }
                
                return false;
            }
        }
    }
}
