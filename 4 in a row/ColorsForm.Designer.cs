using System;

namespace C19_Ex05
{
    partial class ColorsForm
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
            this.purple = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.lightBlue = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.brown = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.purple.Location = new System.Drawing.Point(12, 12);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(30, 30);
            this.purple.TabIndex = 0;
            this.purple.UseVisualStyleBackColor = false;
            this.purple.Click += new System.EventHandler(this.purple_OnClick);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(48, 12);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(30, 30);
            this.red.TabIndex = 1;
            this.red.UseVisualStyleBackColor = false;
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.Location = new System.Drawing.Point(84, 12);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(30, 30);
            this.green.TabIndex = 2;
            this.green.UseVisualStyleBackColor = false;
            // 
            // lightBlue
            // 
            this.lightBlue.BackColor = System.Drawing.Color.Aqua;
            this.lightBlue.Location = new System.Drawing.Point(119, 12);
            this.lightBlue.Name = "lightBlue";
            this.lightBlue.Size = new System.Drawing.Size(30, 30);
            this.lightBlue.TabIndex = 3;
            this.lightBlue.UseVisualStyleBackColor = false;
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(12, 48);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(30, 30);
            this.blue.TabIndex = 4;
            this.blue.UseVisualStyleBackColor = false;
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(48, 48);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(30, 30);
            this.yellow.TabIndex = 5;
            this.yellow.UseVisualStyleBackColor = false;
            // 
            // brown
            // 
            this.brown.BackColor = System.Drawing.Color.Brown;
            this.brown.Location = new System.Drawing.Point(84, 48);
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(30, 30);
            this.brown.TabIndex = 6;
            this.brown.UseVisualStyleBackColor = false;
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(120, 48);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(30, 30);
            this.white.TabIndex = 7;
            this.white.UseVisualStyleBackColor = false;
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(202, 84);
            this.Controls.Add(this.white);
            this.Controls.Add(this.brown);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.lightBlue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.purple);
            this.Name = "ColorsForm";
            this.Text = " Pick A Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button purple;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button lightBlue;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button brown;
        private System.Windows.Forms.Button white;
    }
}