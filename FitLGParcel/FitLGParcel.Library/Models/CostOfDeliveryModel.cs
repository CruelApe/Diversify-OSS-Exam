using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLGParcel.Library.Models
{
    public class CostOfDeliveryModel
    {
        public PriorityType Priority { get; set; } = PriorityType.Small;

        public double Cost { get; set; }

        public double Volume { get; set; }

        public ParcelModel Parcel { get; set; }

    }
}
