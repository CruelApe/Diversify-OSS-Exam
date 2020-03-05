namespace FitLGParcel.UserControls
{
    partial class UcEmptyResult
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UxResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxResultLabel
            // 
            this.UxResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxResultLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxResultLabel.ForeColor = System.Drawing.Color.White;
            this.UxResultLabel.Location = new System.Drawing.Point(0, 0);
            this.UxResultLabel.Name = "UxResultLabel";
            this.UxResultLabel.Size = new System.Drawing.Size(342, 355);
            this.UxResultLabel.TabIndex = 1;
            this.UxResultLabel.Text = "Calculate to see the result...";
            this.UxResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcEmptyResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.UxResultLabel);
            this.Name = "UcEmptyResult";
            this.Size = new System.Drawing.Size(342, 355);
            this.Load += new System.EventHandler(this.UcEmptyResult_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UxResultLabel;
    }
}
