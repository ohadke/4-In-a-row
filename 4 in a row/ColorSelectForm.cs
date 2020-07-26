using System;
using System.Drawing;
using System.Windows.Forms;

namespace C19_Ex05
{
    public partial class ColorSelectForm : Form
    {
        private Button m_DesignedButtonColor;
        public ColorSelectForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Pick a color";
            InitializeComponent();
        }

        public Button DesignedButtonColor
        {
            set { m_DesignedButtonColor = value; }
            get { return m_DesignedButtonColor; }
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            m_DesignedButtonColor.BackColor = Color.Green;
            this.Close();
        }

        private void ColorSelectForm_Load(object sender, EventArgs e)
        {
        }

        private void PurpleButton_Click(object sender, EventArgs e)
        {
            m_DesignedButtonColor.BackColor = Color.Purple;
            this.Close();
        }
        private void RedButton_Click(object sender, EventArgs e)
        {
            m_DesignedButtonColor.BackColor = Color.Red;
            this.Close();
        }
        private void TurquoiseButton_Click(object sender, EventArgs e)
        {
            m_DesignedButtonColor.BackColor = Color.Turquoise;
            this.Close();
        }
        private void BlueButton_Click(object sender, EventArgs e)
        {
            m_DesignedButtonColor.BackColor = Color.Blue;
            this.Close();
        }
        private void YellowButton_Click(object sender, EventArgs e)
        {
            m_DesignedButtonColor.BackColor = Color.Yellow;
            this.Close();
        }
        private void BrownButton_Click(object sender, EventArgs e)
        {
            m_DesignedButtonColor.BackColor = Color.Brown;
            this.Close();
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            m_DesignedButtonColor.BackColor = Color.White;
            this.Close();
        }
    }
}
