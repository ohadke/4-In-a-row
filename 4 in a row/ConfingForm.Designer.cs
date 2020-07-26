namespace C19_Ex05
{
    partial class ConfingForm
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
            this.NumOfGuessButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumOfGuessButton
            // 
            this.NumOfGuessButton.Location = new System.Drawing.Point(32, 10);
            this.NumOfGuessButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumOfGuessButton.Name = "NumOfGuessButton";
            this.NumOfGuessButton.Size = new System.Drawing.Size(207, 45);
            this.NumOfGuessButton.TabIndex = 0;
            this.NumOfGuessButton.Text = "The Number of chances is: 4";
            this.NumOfGuessButton.UseVisualStyleBackColor = true;
            this.NumOfGuessButton.Click += new System.EventHandler(this.NumOfGuessButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(84, 59);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 37);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Click here to start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ConfingForm
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(271, 105);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NumOfGuessButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfingForm";
            this.Text = "Bool Pgia - Game Settings";
            this.Load += new System.EventHandler(this.ConfingForm_Load);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button NumOfGuessButton;
        private System.Windows.Forms.Button StartButton;
    }

        #endregion
    
}