using System;
using System.Windows.Forms;

namespace C19_Ex05
{
    public partial class ConfingForm : Form
    {
        private int m_numOfGuess = 4;

        public ConfingForm()
        {
            InitializeComponent();
        }
        private void NumOfGuessButton_Click(object sender, EventArgs e)
        {
            m_numOfGuess++;
            if (m_numOfGuess > 10)
            {
                m_numOfGuess = 4;
            }
            this.NumOfGuessButton.Text = string.Format("The Number of chances is:{0}", m_numOfGuess);
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
            FormGame board = new FormGame(m_numOfGuess);
            board.ShowDialog();
        }
        private void ConfingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
