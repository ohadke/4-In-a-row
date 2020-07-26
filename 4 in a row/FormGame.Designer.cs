using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace C19_Ex05
{
    public partial class FormGame 
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
            this.computerGuess2Button = new System.Windows.Forms.Button();
            this.computerGuess3Button = new System.Windows.Forms.Button();
            this.computerGuess4Button = new System.Windows.Forms.Button();
            this.computerGuess1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // computerGuess2Button
            // 
            this.computerGuess2Button.BackColor = System.Drawing.Color.Black;
            this.computerGuess2Button.Enabled = false;
            this.computerGuess2Button.Location = new System.Drawing.Point(66, 20);
            this.computerGuess2Button.Name = "computerGuess2Button";
            this.computerGuess2Button.Size = new System.Drawing.Size(40, 40);
            this.computerGuess2Button.TabIndex = 1;
            this.computerGuess2Button.UseVisualStyleBackColor = false;
            // 
            // computerGuess3Button
            // 
            this.computerGuess3Button.BackColor = System.Drawing.Color.Black;
            this.computerGuess3Button.Enabled = false;
            this.computerGuess3Button.Location = new System.Drawing.Point(112, 20);
            this.computerGuess3Button.Name = "computerGuess3Button";
            this.computerGuess3Button.Size = new System.Drawing.Size(40, 40);
            this.computerGuess3Button.TabIndex = 2;
            this.computerGuess3Button.UseVisualStyleBackColor = false;
            // 
            // computerGuess4Button
            // 
            this.computerGuess4Button.BackColor = System.Drawing.Color.Black;
            this.computerGuess4Button.Enabled = false;
            this.computerGuess4Button.Location = new System.Drawing.Point(158, 20);
            this.computerGuess4Button.Name = "computerGuess4Button";
            this.computerGuess4Button.Size = new System.Drawing.Size(40, 40);
            this.computerGuess4Button.TabIndex = 3;
            this.computerGuess4Button.UseVisualStyleBackColor = false;
            // 
            // computerGuess1Button
            // 
            this.computerGuess1Button.BackColor = System.Drawing.Color.Black;
            this.computerGuess1Button.Enabled = false;
            this.computerGuess1Button.Location = new System.Drawing.Point(20, 20);
            this.computerGuess1Button.Name = "computerGuess1Button";
            this.computerGuess1Button.Size = new System.Drawing.Size(40, 40);
            this.computerGuess1Button.TabIndex = 0;
            this.computerGuess1Button.UseVisualStyleBackColor = false;
            // 
            // FormGame
            // 
            this.ClientSize = new System.Drawing.Size(357, 400);
            this.Controls.Add(this.computerGuess1Button);
            this.Controls.Add(this.computerGuess2Button);
            this.Controls.Add(this.computerGuess3Button);
            this.Controls.Add(this.computerGuess4Button);
            this.Name = "FormGame";
            this.ResumeLayout(false);

        }
        private Button computerGuess2Button;
        private Button computerGuess3Button;
        private Button computerGuess4Button;
        private Button computerGuess1Button;
    }
}


#endregion

