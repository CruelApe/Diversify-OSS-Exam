using FitLGParcel.Library;
using FitLGParcel.Library.Models;
using FitLGParcel.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLGParcel
{
    public partial class UxMainForm : Form
    {
        private ParcelModel Parcel { get; set; }

        public UxMainForm()
        {
            InitializeComponent();
        }

        private void UxMainForm_Load(object sender, EventArgs e)
        {
            ResetFormControls();
            MapEventsToControls();
        }


        #region [ M E T H O D S ]

        private void GetParcelInputData()
        {
            Parcel = new ParcelModel
            {
                Weight = Helper.ConvertValueToDouble(UxWeightText.Text),
                Height = Helper.ConvertValueToDouble(UxHeightText.Text),
                Width = Helper.ConvertValueToDouble(UxWidthText.Text),
                Depth = Helper.ConvertValueToDouble(UxDepthText.Text)
            };
        }

        private void ResetFormControls()
        {
            UxWeightText.Text = 
            UxHeightText.Text = 
            UxWidthText.Text = 
            UxDepthText.Text = string.Empty;

            UxWeightText.Focus();

            UxResultPanel.Controls.Clear();
            UxResultPanel.Controls.Add(new UcEmptyResult { Dock = DockStyle.Fill });
        }

        private void MapEventsToControls()
        {
            UxWeightText.KeyPress += new KeyPressEventHandler(NumericOnlyKeypress);
            UxHeightText.KeyPress += new KeyPressEventHandler(NumericOnlyKeypress);
            UxWidthText.KeyPress += new KeyPressEventHandler(NumericOnlyKeypress);
            UxDepthText.KeyPress += new KeyPressEventHandler(NumericOnlyKeypress);
        }

        /// <summary>
        /// Validation-Textboxes allowing only decimals
        /// Source: https://stackoverflow.com/questions/2108616/validation-textboxes-allowing-only-decimals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericOnlyKeypress(object sender, KeyPressEventArgs e)
        {

            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
            
            // checks to make sure only 1 negative sign is allowed
            if (e.KeyChar == 45)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        #endregion [ M E T H O D S ]


        #region [ V A L I D A T O R S ]

        private bool ValidateParcelInput()
        {
            string errorMessage = string.Empty;

            if (string.IsNullOrEmpty(string.Concat(UxWeightText.Text, UxHeightText.Text, UxWidthText.Text, UxDepthText.Text))) { errorMessage = Constants.NoParcelInputData; }
            else if (!Double.TryParse(UxWeightText.Text, out double number)) { errorMessage = string.Format(Constants.InvalidInputValue, UxWeightText.Text, "weight"); }
            else if (!Double.TryParse(UxHeightText.Text, out number)) { errorMessage = string.Format(Constants.InvalidInputValue, UxHeightText.Text, "height"); }
            else if (!Double.TryParse(UxWidthText.Text, out number)) { errorMessage = string.Format(Constants.InvalidInputValue, UxWidthText.Text, "width"); }
            else if (!Double.TryParse(UxDepthText.Text, out number)) { errorMessage = string.Format(Constants.InvalidInputValue, UxDepthText.Text, "depth"); }

            GetParcelInputData();

            if (Parcel.IsParcelEmpty) { errorMessage = Constants.NoParcelInputData; }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                UxResultPanel.Controls.Clear();
                UxResultPanel.Controls.Add(new UcEmptyResult { CustomMessage = errorMessage, Dock = DockStyle.Fill });
                return false;
            }

            return true;
        }
        

        #endregion [ V A L I D A T O R S ]

        #region [ E V E N T S ]

        private void UxClosePButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UxMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UxResetButton_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void UxCalculateButton_Click(object sender, EventArgs e)
        {
            if (ValidateParcelInput())
            {

                UxResultPanel.Controls.Clear();
                UxResultPanel.Controls.Add(new UcCostOfDeliveryResult
                {
                    CostOfDelivery = CalculationEngine.CalculateCostOfDelivery(Parcel),
                    Dock = DockStyle.Fill
                });
            }
        }

        #endregion [ E V E N T S ]


        #region [ B O R D E R L E S S   E V E N T S ] 
        /// <summary>
        /// Movable borderless form
        /// Source: https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable 
        /// </summary>

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        #endregion [ B O R D E R L E S S   E V E N T S ] 

    }
}
