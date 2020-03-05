using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLGParcel.Library
{
    public static class Constants
    {
        public const string DefaultTextboxValue = "0";

        public const string NotAvailable = "N/A";

        public const string DecimalFormat = "0.00";

        public const string Currency = "$ ";

        public const int WeightRejectLimit = 50;

        public const int WeightHeavyLimit = 10;

        public const int VolumeSmallLimit = 1500;

        public const int VolumeMediumLimit = 2500;

        public const string NoParcelInputData = "Try providing some porper values for the parcel and hit the calculate button again...";

        public const string InvalidInputValue = "'{0}' is not a valid value for '{1}' field of the parcel. please try again and hit the calculate button again...";
    }
}
