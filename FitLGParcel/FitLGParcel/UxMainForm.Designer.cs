namespace FitLGParcel
{
    partial class UxMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxMainForm));
            this.UxTitleBarPanel = new System.Windows.Forms.Panel();
            this.UxAuthorLabel = new System.Windows.Forms.Label();
            this.UxMinimizeButton = new System.Windows.Forms.PictureBox();
            this.UxCloseButton = new System.Windows.Forms.PictureBox();
            this.UxSubTitleLabel = new System.Windows.Forms.Label();
            this.UxTitleLabel = new System.Windows.Forms.Label();
            this.UxWeightText = new System.Windows.Forms.TextBox();
            this.UxWeightLabel = new System.Windows.Forms.Label();
            this.UxHeightLabel = new System.Windows.Forms.Label();
            this.UxWidthLabel = new System.Windows.Forms.Label();
            this.UxDepthLabel = new System.Windows.Forms.Label();
            this.UxHeightText = new System.Windows.Forms.TextBox();
            this.UxWidthText = new System.Windows.Forms.TextBox();
            this.UxDepthText = new System.Windows.Forms.TextBox();
            this.UxCalculateButton = new System.Windows.Forms.Button();
            this.UxResultPanel = new System.Windows.Forms.Panel();
            this.UxInstructionLabel = new System.Windows.Forms.Label();
            this.UxResetButton = new System.Windows.Forms.PictureBox();
            this.UxTitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UxMinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UxCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UxResetButton)).BeginInit();
            this.SuspendLayout();
            // 
            // UxTitleBarPanel
            // 
            this.UxTitleBarPanel.Controls.Add(this.UxAuthorLabel);
            this.UxTitleBarPanel.Controls.Add(this.UxMinimizeButton);
            this.UxTitleBarPanel.Controls.Add(this.UxCloseButton);
            this.UxTitleBarPanel.Controls.Add(this.UxSubTitleLabel);
            this.UxTitleBarPanel.Controls.Add(this.UxTitleLabel);
            this.UxTitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UxTitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.UxTitleBarPanel.Name = "UxTitleBarPanel";
            this.UxTitleBarPanel.Size = new System.Drawing.Size(663, 46);
            this.UxTitleBarPanel.TabIndex = 0;
            // 
            // UxAuthorLabel
            // 
            this.UxAuthorLabel.AutoSize = true;
            this.UxAuthorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UxAuthorLabel.Location = new System.Drawing.Point(383, 17);
            this.UxAuthorLabel.Name = "UxAuthorLabel";
            this.UxAuthorLabel.Size = new System.Drawing.Size(49, 15);
            this.UxAuthorLabel.TabIndex = 4;
            this.UxAuthorLabel.Text = "TJ Gono";
            // 
            // UxMinimizeButton
            // 
            this.UxMinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UxMinimizeButton.Image = global::FitLGParcel.Properties.Resources.Minimize_32px;
            this.UxMinimizeButton.Location = new System.Drawing.Point(571, 12);
            this.UxMinimizeButton.Name = "UxMinimizeButton";
            this.UxMinimizeButton.Size = new System.Drawing.Size(23, 23);
            this.UxMinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UxMinimizeButton.TabIndex = 3;
            this.UxMinimizeButton.TabStop = false;
            this.UxMinimizeButton.Tag = "Minimize";
            this.UxMinimizeButton.Click += new System.EventHandler(this.UxMinimizeButton_Click);
            // 
            // UxCloseButton
            // 
            this.UxCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UxCloseButton.Image = global::FitLGParcel.Properties.Resources.Close_32px;
            this.UxCloseButton.Location = new System.Drawing.Point(619, 12);
            this.UxCloseButton.Name = "UxCloseButton";
            this.UxCloseButton.Size = new System.Drawing.Size(23, 23);
            this.UxCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UxCloseButton.TabIndex = 2;
            this.UxCloseButton.TabStop = false;
            this.UxCloseButton.Tag = "Close";
            this.UxCloseButton.Click += new System.EventHandler(this.UxClosePButton_Click);
            // 
            // UxSubTitleLabel
            // 
            this.UxSubTitleLabel.AutoSize = true;
            this.UxSubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxSubTitleLabel.ForeColor = System.Drawing.Color.White;
            this.UxSubTitleLabel.Location = new System.Drawing.Point(276, 17);
            this.UxSubTitleLabel.Name = "UxSubTitleLabel";
            this.UxSubTitleLabel.Size = new System.Drawing.Size(110, 15);
            this.UxSubTitleLabel.TabIndex = 1;
            this.UxSubTitleLabel.Text = "Parcel calculator by";
            // 
            // UxTitleLabel
            // 
            this.UxTitleLabel.AutoSize = true;
            this.UxTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxTitleLabel.ForeColor = System.Drawing.Color.White;
            this.UxTitleLabel.Location = new System.Drawing.Point(12, 5);
            this.UxTitleLabel.Name = "UxTitleLabel";
            this.UxTitleLabel.Size = new System.Drawing.Size(261, 30);
            this.UxTitleLabel.TabIndex = 0;
            this.UxTitleLabel.Text = "Fitness and Lifestyle Group";
            // 
            // UxWeightText
            // 
            this.UxWeightText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UxWeightText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UxWeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxWeightText.ForeColor = System.Drawing.Color.White;
            this.UxWeightText.Location = new System.Drawing.Point(126, 150);
            this.UxWeightText.Name = "UxWeightText";
            this.UxWeightText.Size = new System.Drawing.Size(125, 29);
            this.UxWeightText.TabIndex = 1;
            this.UxWeightText.Text = "0";
            this.UxWeightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UxWeightLabel
            // 
            this.UxWeightLabel.AutoSize = true;
            this.UxWeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxWeightLabel.ForeColor = System.Drawing.Color.White;
            this.UxWeightLabel.Location = new System.Drawing.Point(27, 154);
            this.UxWeightLabel.Name = "UxWeightLabel";
            this.UxWeightLabel.Size = new System.Drawing.Size(93, 21);
            this.UxWeightLabel.TabIndex = 2;
            this.UxWeightLabel.Text = "Weight (kg):";
            // 
            // UxHeightLabel
            // 
            this.UxHeightLabel.AutoSize = true;
            this.UxHeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxHeightLabel.ForeColor = System.Drawing.Color.White;
            this.UxHeightLabel.Location = new System.Drawing.Point(27, 208);
            this.UxHeightLabel.Name = "UxHeightLabel";
            this.UxHeightLabel.Size = new System.Drawing.Size(94, 21);
            this.UxHeightLabel.TabIndex = 3;
            this.UxHeightLabel.Text = "Height (cm):";
            // 
            // UxWidthLabel
            // 
            this.UxWidthLabel.AutoSize = true;
            this.UxWidthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxWidthLabel.ForeColor = System.Drawing.Color.White;
            this.UxWidthLabel.Location = new System.Drawing.Point(27, 260);
            this.UxWidthLabel.Name = "UxWidthLabel";
            this.UxWidthLabel.Size = new System.Drawing.Size(90, 21);
            this.UxWidthLabel.TabIndex = 4;
            this.UxWidthLabel.Text = "Width (cm):";
            // 
            // UxDepthLabel
            // 
            this.UxDepthLabel.AutoSize = true;
            this.UxDepthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxDepthLabel.ForeColor = System.Drawing.Color.White;
            this.UxDepthLabel.Location = new System.Drawing.Point(27, 311);
            this.UxDepthLabel.Name = "UxDepthLabel";
            this.UxDepthLabel.Size = new System.Drawing.Size(90, 21);
            this.UxDepthLabel.TabIndex = 5;
            this.UxDepthLabel.Text = "Depth (cm):";
            // 
            // UxHeightText
            // 
            this.UxHeightText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UxHeightText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UxHeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxHeightText.ForeColor = System.Drawing.Color.White;
            this.UxHeightText.Location = new System.Drawing.Point(126, 204);
            this.UxHeightText.Name = "UxHeightText";
            this.UxHeightText.Size = new System.Drawing.Size(125, 29);
            this.UxHeightText.TabIndex = 6;
            this.UxHeightText.Text = "0";
            this.UxHeightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UxWidthText
            // 
            this.UxWidthText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UxWidthText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UxWidthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxWidthText.ForeColor = System.Drawing.Color.White;
            this.UxWidthText.Location = new System.Drawing.Point(126, 256);
            this.UxWidthText.Name = "UxWidthText";
            this.UxWidthText.Size = new System.Drawing.Size(125, 29);
            this.UxWidthText.TabIndex = 7;
            this.UxWidthText.Text = "0";
            this.UxWidthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UxDepthText
            // 
            this.UxDepthText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UxDepthText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UxDepthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxDepthText.ForeColor = System.Drawing.Color.White;
            this.UxDepthText.Location = new System.Drawing.Point(126, 307);
            this.UxDepthText.Name = "UxDepthText";
            this.UxDepthText.Size = new System.Drawing.Size(125, 29);
            this.UxDepthText.TabIndex = 8;
            this.UxDepthText.Text = "0";
            this.UxDepthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UxCalculateButton
            // 
            this.UxCalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UxCalculateButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.UxCalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UxCalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxCalculateButton.ForeColor = System.Drawing.Color.White;
            this.UxCalculateButton.Location = new System.Drawing.Point(71, 365);
            this.UxCalculateButton.Name = "UxCalculateButton";
            this.UxCalculateButton.Size = new System.Drawing.Size(180, 34);
            this.UxCalculateButton.TabIndex = 10;
            this.UxCalculateButton.Tag = "Calculate";
            this.UxCalculateButton.Text = "Calculate";
            this.UxCalculateButton.UseVisualStyleBackColor = false;
            this.UxCalculateButton.Click += new System.EventHandler(this.UxCalculateButton_Click);
            // 
            // UxResultPanel
            // 
            this.UxResultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.UxResultPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UxResultPanel.Location = new System.Drawing.Point(279, 46);
            this.UxResultPanel.Name = "UxResultPanel";
            this.UxResultPanel.Size = new System.Drawing.Size(384, 383);
            this.UxResultPanel.TabIndex = 11;
            // 
            // UxInstructionLabel
            // 
            this.UxInstructionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxInstructionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.UxInstructionLabel.Location = new System.Drawing.Point(17, 70);
            this.UxInstructionLabel.Name = "UxInstructionLabel";
            this.UxInstructionLabel.Size = new System.Drawing.Size(256, 69);
            this.UxInstructionLabel.TabIndex = 12;
            this.UxInstructionLabel.Text = "Indicate the weight and size of the parcel for postage to calculate the cost of d" +
    "elivery.";
            // 
            // UxResetButton
            // 
            this.UxResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UxResetButton.Image = global::FitLGParcel.Properties.Resources.Restart_32px;
            this.UxResetButton.Location = new System.Drawing.Point(33, 369);
            this.UxResetButton.Name = "UxResetButton";
            this.UxResetButton.Size = new System.Drawing.Size(25, 25);
            this.UxResetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UxResetButton.TabIndex = 4;
            this.UxResetButton.TabStop = false;
            this.UxResetButton.Tag = "Reset";
            this.UxResetButton.Click += new System.EventHandler(this.UxResetButton_Click);
            // 
            // UxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(663, 429);
            this.Controls.Add(this.UxInstructionLabel);
            this.Controls.Add(this.UxResetButton);
            this.Controls.Add(this.UxResultPanel);
            this.Controls.Add(this.UxCalculateButton);
            this.Controls.Add(this.UxDepthText);
            this.Controls.Add(this.UxWidthText);
            this.Controls.Add(this.UxHeightText);
            this.Controls.Add(this.UxDepthLabel);
            this.Controls.Add(this.UxWidthLabel);
            this.Controls.Add(this.UxHeightLabel);
            this.Controls.Add(this.UxWeightLabel);
            this.Controls.Add(this.UxWeightText);
            this.Controls.Add(this.UxTitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UxMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UxMainForm_Load);
            this.UxTitleBarPanel.ResumeLayout(false);
            this.UxTitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UxMinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UxCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UxResetButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UxTitleBarPanel;
        private System.Windows.Forms.Label UxSubTitleLabel;
        private System.Windows.Forms.Label UxTitleLabel;
        private System.Windows.Forms.TextBox UxWeightText;
        private System.Windows.Forms.Label UxWeightLabel;
        private System.Windows.Forms.Label UxHeightLabel;
        private System.Windows.Forms.Label UxWidthLabel;
        private System.Windows.Forms.Label UxDepthLabel;
        private System.Windows.Forms.TextBox UxHeightText;
        private System.Windows.Forms.TextBox UxWidthText;
        private System.Windows.Forms.TextBox UxDepthText;
        private System.Windows.Forms.Button UxCalculateButton;
        private System.Windows.Forms.Panel UxResultPanel;
        private System.Windows.Forms.PictureBox UxCloseButton;
        private System.Windows.Forms.PictureBox UxMinimizeButton;
        private System.Windows.Forms.PictureBox UxResetButton;
        private System.Windows.Forms.Label UxInstructionLabel;
        private System.Windows.Forms.Label UxAuthorLabel;
    }
}

