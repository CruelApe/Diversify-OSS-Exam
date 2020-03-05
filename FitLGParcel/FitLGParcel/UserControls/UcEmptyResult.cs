using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLGParcel.UserControls
{
    public partial class UcEmptyResult : UserControl
    {
        public string CustomMessage { get; set; }

        public UcEmptyResult()
        {
            InitializeComponent();
        }

        private void SetCustomMessageResource()
        {
            UxResultLabel.Text = String.IsNullOrEmpty(CustomMessage) ? UxResultLabel.Text : CustomMessage;
        }

        private void UcEmptyResult_Load(object sender, EventArgs e)
        {
            SetCustomMessageResource();
        }
    }
}
