namespace C19_Ex05
{
    partial class ColorSelectForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PurpleButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.WhiteButton = new System.Windows.Forms.Button();
            this.TurquoiseButton = new System.Windows.Forms.Button();
            this.BrownButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PurpleButton
            // 
            this.PurpleButton.BackColor = System.Drawing.Color.Purple;
            this.PurpleButton.Location = new System.Drawing.Point(1, -2);
            this.PurpleButton.Name = "PurpleButton";
            this.PurpleButton.Size = new System.Drawing.Size(48, 39);
            this.PurpleButton.TabIndex = 0;
            this.PurpleButton.UseVisualStyleBackColor = false;
            this.PurpleButton.Click += new System.EventHandler(this.PurpleButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.Blue;
            this.BlueButton.Location = new System.Drawing.Point(1, 34);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(48, 39);
            this.BlueButton.TabIndex = 0;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.Location = new System.Drawing.Point(45, -2);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(48, 39);
            this.RedButton.TabIndex = 0;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.Location = new System.Drawing.Point(45, 34);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(48, 39);
            this.YellowButton.TabIndex = 0;
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackColor = System.Drawing.Color.White;
            this.WhiteButton.Location = new System.Drawing.Point(133, 34);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(48, 39);
            this.WhiteButton.TabIndex = 0;
            this.WhiteButton.UseVisualStyleBackColor = false;
            this.WhiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // TurquoiseButton
            // 
            this.TurquoiseButton.BackColor = System.Drawing.Color.Turquoise;
            this.TurquoiseButton.Location = new System.Drawing.Point(133, -2);
            this.TurquoiseButton.Name = "TurquoiseButton";
            this.TurquoiseButton.Size = new System.Drawing.Size(48, 39);
            this.TurquoiseButton.TabIndex = 0;
            this.TurquoiseButton.UseVisualStyleBackColor = false;
            this.TurquoiseButton.Click += new System.EventHandler(this.TurquoiseButton_Click);
            // 
            // BrownButton
            // 
            this.BrownButton.BackColor = System.Drawing.Color.Brown;
            this.BrownButton.Location = new System.Drawing.Point(89, 34);
            this.BrownButton.Name = "BrownButton";
            this.BrownButton.Size = new System.Drawing.Size(48, 39);
            this.BrownButton.TabIndex = 0;
            this.BrownButton.UseVisualStyleBackColor = false;
            this.BrownButton.Click += new System.EventHandler(this.BrownButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.Green;
            this.GreenButton.Location = new System.Drawing.Point(89, -2);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(48, 39);
            this.GreenButton.TabIndex = 0;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // ColorSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(182, 75);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.TurquoiseButton);
            this.Controls.Add(this.BrownButton);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.PurpleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorSelectForm";
            this.Text = "ColorSelectForm";
            this.Load += new System.EventHandler(this.ColorSelectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button PurpleButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button WhiteButton;
        private System.Windows.Forms.Button TurquoiseButton;
        private System.Windows.Forms.Button BrownButton;
        private System.Windows.Forms.Button GreenButton;

        public System.Windows.Forms.Button getColorButton(eColors color)
        {
            if (color.ToString().Equals("Purple"))
                return PurpleButton;
            else if (color.ToString().Equals("Blue"))
                return BlueButton;
            else if (color.ToString().Equals("Red"))
                return RedButton;
            else if (color.ToString().Equals("Yellow"))
                return YellowButton;
            else if (color.ToString().Equals("White"))
                return WhiteButton;
            else if (color.ToString().Equals("Turquoise"))
                return TurquoiseButton;
            else if (color.ToString().Equals("Brown"))
                return BrownButton;
            else if (color.ToString().Equals("Green"))
                return GreenButton;
            return null;
        }
    }
}