namespace SusReticle
{
    partial class susRet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.crosshairToggle = new System.Windows.Forms.Button();
            this.redLabel = new System.Windows.Forms.Label();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.greenLabel = new System.Windows.Forms.Label();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.blueLabel = new System.Windows.Forms.Label();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.header.Controls.Add(this.headerLabel);
            this.header.Controls.Add(this.exitButton);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(391, 35);
            this.header.TabIndex = 0;
            this.header.Click += new System.EventHandler(this.header_Click);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(3, 6);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(169, 23);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Sus Crosshair";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            this.headerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerLabel_MouseDown);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(352, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 35);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "x";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 44);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(70, 23);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Size: ";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.ForeColor = System.Drawing.Color.Black;
            this.sizeTextBox.Location = new System.Drawing.Point(79, 41);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(128, 32);
            this.sizeTextBox.TabIndex = 2;
            this.sizeTextBox.Text = "32";
            this.sizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeTextBox_KeyPress);
            this.sizeTextBox.Validated += new System.EventHandler(this.sizeTextBox_Validated);
            // 
            // crosshairToggle
            // 
            this.crosshairToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.crosshairToggle.FlatAppearance.BorderSize = 0;
            this.crosshairToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crosshairToggle.Location = new System.Drawing.Point(12, 79);
            this.crosshairToggle.Name = "crosshairToggle";
            this.crosshairToggle.Size = new System.Drawing.Size(195, 67);
            this.crosshairToggle.TabIndex = 3;
            this.crosshairToggle.Text = "Enable Crosshair";
            this.crosshairToggle.UseVisualStyleBackColor = false;
            this.crosshairToggle.Click += new System.EventHandler(this.crosshairToggle_Click);
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(213, 44);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(28, 23);
            this.redLabel.TabIndex = 6;
            this.redLabel.Text = "R:";
            this.redLabel.Click += new System.EventHandler(this.redLabel_Click);
            // 
            // redTextBox
            // 
            this.redTextBox.ForeColor = System.Drawing.Color.Black;
            this.redTextBox.Location = new System.Drawing.Point(247, 41);
            this.redTextBox.MaxLength = 3;
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(132, 32);
            this.redTextBox.TabIndex = 7;
            this.redTextBox.Text = "0";
            this.redTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.redTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.redTextBox_KeyPress);
            this.redTextBox.Validated += new System.EventHandler(this.redTextBox_Validated);
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(213, 82);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(28, 23);
            this.greenLabel.TabIndex = 8;
            this.greenLabel.Text = "G:";
            this.greenLabel.Click += new System.EventHandler(this.greenLabel_Click);
            // 
            // greenTextBox
            // 
            this.greenTextBox.ForeColor = System.Drawing.Color.Black;
            this.greenTextBox.Location = new System.Drawing.Point(247, 79);
            this.greenTextBox.MaxLength = 3;
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(132, 32);
            this.greenTextBox.TabIndex = 9;
            this.greenTextBox.Text = "255";
            this.greenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.greenTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.greenTextBox_KeyPress);
            this.greenTextBox.Validated += new System.EventHandler(this.greenTextBox_Validated);
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(213, 120);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(28, 23);
            this.blueLabel.TabIndex = 10;
            this.blueLabel.Text = "B:";
            this.blueLabel.Click += new System.EventHandler(this.blueLabel_Click);
            // 
            // blueTextBox
            // 
            this.blueTextBox.ForeColor = System.Drawing.Color.Black;
            this.blueTextBox.Location = new System.Drawing.Point(247, 117);
            this.blueTextBox.MaxLength = 3;
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(132, 32);
            this.blueTextBox.TabIndex = 11;
            this.blueTextBox.Text = "0";
            this.blueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.blueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blueTextBox_KeyPress);
            this.blueTextBox.Validated += new System.EventHandler(this.blueTextBox_Validated);
            // 
            // susRet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(391, 161);
            this.Controls.Add(this.blueTextBox);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenTextBox);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redTextBox);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.crosshairToggle);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("ArcadeClassic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "susRet";
            this.Text = "Sus Crosshair";
            this.Load += new System.EventHandler(this.susRet_Load);
            this.Click += new System.EventHandler(this.SusRet_Click);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel header;
        private Label headerLabel;
        private Button exitButton;
        private Label sizeLabel;
        private TextBox sizeTextBox;
        private Button crosshairToggle;
        private Label redLabel;
        private TextBox redTextBox;
        private Label greenLabel;
        private TextBox greenTextBox;
        private Label blueLabel;
        private TextBox blueTextBox;
    }
}