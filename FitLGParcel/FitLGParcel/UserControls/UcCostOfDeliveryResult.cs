using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitLGParcel.Library.Models;
using FitLGParcel.Library;

namespace FitLGParcel.UserControls
{
    public partial class UcCostOfDeliveryResult : UserControl
    {
        public CostOfDeliveryModel CostOfDelivery { get; set; }

        public UcCostOfDeliveryResult()
        {
            InitializeComponent();
        }

        private void UcCostOfDeliveryResult_Load(object sender, EventArgs e)
        {
            SetResources();
        }

        private void SetResources()
        {
            UxCategoryLabel.ForeColor = SetColorToCategory(CostOfDelivery.Priority);
            UxCategoryLabel.Text = String.Format(UxCategoryLabel.Text, CostOfDelivery.Priority.ToString());
            UxWeightLabel.Text = String.Format(UxWeightLabel.Text, CostOfDelivery.Parcel.Weight.ToString(Constants.DecimalFormat));
            UxHeightLabel.Text = String.Format(UxHeightLabel.Text, CostOfDelivery.Parcel.Height.ToString(Constants.DecimalFormat));
            UxWidthLabel.Text = String.Format(UxWidthLabel.Text, CostOfDelivery.Parcel.Width.ToString(Constants.DecimalFormat));
            UxDepthLabel.Text = String.Format(UxDepthLabel.Text, CostOfDelivery.Parcel.Depth.ToString(Constants.DecimalFormat));

            UxVolumeLabel.Text = String.Format(UxVolumeLabel.Text, CostOfDelivery.Volume.ToString(Constants.DecimalFormat));

            if (CostOfDelivery.Priority == PriorityType.Rejected)
            {
                UxCostLabel.Text = Constants.NotAvailable;
            }
            else
            {
                UxCostLabel.Text = String.Format(UxCostLabel.Text, String.Concat(Constants.Currency, CostOfDelivery.Cost.ToString(Constants.DecimalFormat)));
            }
            
        }

        private Color SetColorToCategory(PriorityType priority)
        {
            Color setColor = new Color();

            switch (priority)
            {
                case PriorityType.Rejected:
                    setColor = Color.Red;
                    break;
                case PriorityType.Heavy:
                    setColor = Color.MediumOrchid;
                    break;
                case PriorityType.Small:
                    setColor = Color.DarkGreen;
                    break;
                case PriorityType.Medium:
                    setColor = Color.LightGreen;
                    break;
                case PriorityType.Large:
                    setColor = Color.Yellow;
                    break;
                default:
                    break;
            }

            return setColor;
        }
    }
}
