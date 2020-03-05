using FitLGParcel.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLGParcel.Library
{
    public static class CalculationEngine
    {

        public static CostOfDeliveryModel CalculateCostOfDelivery(ParcelModel parcel)
        {
            CostOfDeliveryModel costOfDelivery = new CostOfDeliveryModel { Parcel = parcel };
            costOfDelivery.Volume = CalculateVolume(parcel.Height, parcel.Width, parcel.Depth);
            costOfDelivery.Priority = DeterminePriority(parcel.Weight, costOfDelivery.Volume);
            CalculateCost(costOfDelivery);
            return costOfDelivery;
        }

        private static PriorityType DeterminePriority(double weight, double volume)
        {
            var priorityType = PriorityType.Large;

            if (weight > Constants.WeightRejectLimit)
            {
                priorityType = PriorityType.Rejected;
            }
            else if(weight > Constants.WeightHeavyLimit)
            {
                priorityType = PriorityType.Heavy;
            }
            else
            {
                if (volume < Constants.VolumeSmallLimit)
                {
                    priorityType = PriorityType.Small;
                }
                else if (volume < Constants.VolumeMediumLimit)
                {
                    priorityType = PriorityType.Medium;
                }
            }

            return priorityType;
        }

        private static void CalculateCost(CostOfDeliveryModel costOfDelivery)
        {
            switch (costOfDelivery.Priority)
            {
                case PriorityType.Rejected:
                    costOfDelivery.Cost = 0;
                    break;
                case PriorityType.Heavy:
                    costOfDelivery.Cost = 15 * costOfDelivery.Parcel.Weight;
                    break;
                case PriorityType.Small:
                    costOfDelivery.Cost = 0.05 * costOfDelivery.Volume;
                    break;
                case PriorityType.Medium:
                    costOfDelivery.Cost = 0.04 * costOfDelivery.Volume;
                    break;
                case PriorityType.Large:
                    costOfDelivery.Cost = 0.03 * costOfDelivery.Volume;
                    break;
                default:
                    break;
            }
        }

        private static double CalculateVolume(double height, double width, double depth)
        {
            return height * width * depth;
        }

    }
}
