using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C19_Ex05
{
    public partial class FormGame : Form
    {
        private int m_YPoint = 20;
        private int m_TurnsCounter = 1;
        private int m_MaxGuesses;
        private Row[] m_Rows;
        private bool m_IsGameOver;
        private GameLogic m_GameLogic;
        private List<eColors> m_LastColors;
        private ColorSelectForm m_ColorSelectForm;
        private Button m_CurrentBtn;
        private List<Button> m_CurrentGuessButtons;
        public FormGame(int i_MaxGuesses)
        {
            m_LastColors = new List<eColors>();
            m_MaxGuesses = i_MaxGuesses;
            m_Rows = new Row[m_MaxGuesses];
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            InitializeComponent();
            CreateBoard();
            m_GameLogic = new GameLogic();
            m_CurrentGuessButtons = AddButtonListeners(0);
            m_ColorSelectForm = new ColorSelectForm();
            
        }
        private void CreateBoard()
        {
            int i = 0, gap = m_YPoint + 50;
            for (i = 0; i < m_MaxGuesses; i++)
            {
                CreateRow(i, gap);
                gap = gap + 50;
            }
        }
        private void CreateRow(int i_RowIndex, int i_Gap)
        {
            m_Rows[i_RowIndex] = new Row();
            Button guessButton1 = new System.Windows.Forms.Button();
            Button guessButton2 = new System.Windows.Forms.Button();
            Button guessButton3 = new System.Windows.Forms.Button();
            Button guessButton4 = new System.Windows.Forms.Button();
            Button getResultButton = new Button();
            Button resultButton1 = new System.Windows.Forms.Button();
            Button resultButton2 = new System.Windows.Forms.Button();
            Button resultButton3 = new System.Windows.Forms.Button();
            Button resultButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guessButton1
            // 
            guessButton1.BackColor = System.Drawing.Color.Gray;
            guessButton1.Enabled = false;
            guessButton1.Location = new System.Drawing.Point(20, i_Gap);
            guessButton1.Name = "guessButton1";
            guessButton1.Size = new System.Drawing.Size(40, 40);
            guessButton1.TabIndex = 0;
            guessButton1.UseVisualStyleBackColor = false;
            guessButton1.Enabled = false;
            this.Controls.Add(guessButton1);
            // 
            // guessButton2
            // 
            guessButton2.BackColor = System.Drawing.Color.Gray;
            guessButton2.Enabled = false;
            guessButton2.Location = new System.Drawing.Point(112, i_Gap);
            guessButton2.Name = "guessButton2";
            guessButton2.Size = new System.Drawing.Size(40, 40);
            guessButton2.TabIndex = 1;
            guessButton2.UseVisualStyleBackColor = false;
            guessButton2.Enabled = false;
            this.Controls.Add(guessButton2);
            // 
            // guessButton3
            // 
            guessButton3.BackColor = System.Drawing.Color.Gray;
            guessButton3.Location = new System.Drawing.Point(66, i_Gap);
            guessButton3.Name = "guessButton3";
            guessButton3.Size = new System.Drawing.Size(40, 40);
            guessButton3.TabIndex = 2;
            guessButton3.UseVisualStyleBackColor = false;
            guessButton3.Enabled = false;
            this.Controls.Add(guessButton3);
            // 
            // guessButton4
            // 
            guessButton4.BackColor = System.Drawing.Color.Gray;
            guessButton4.Location = new System.Drawing.Point(158, i_Gap);
            guessButton4.Name = "guessButton4";
            guessButton4.Size = new System.Drawing.Size(40, 40);
            guessButton4.TabIndex = 3;
            guessButton4.UseVisualStyleBackColor = false;
            guessButton4.Enabled = false;
            this.Controls.Add(guessButton4);
            // 
            // getResultButton
            // 
            getResultButton.BackColor = System.Drawing.Color.Gray;
            getResultButton.Location = new System.Drawing.Point(204, guessButton4.Location.Y + 10);
            getResultButton.Name = "getResultButton";
            getResultButton.Size = new System.Drawing.Size(60, 23);
            getResultButton.TabIndex = 0;
            getResultButton.Text = "-->>";
            getResultButton.UseVisualStyleBackColor = false;
            getResultButton.Enabled = true;
            getResultButton.Click += new EventHandler(this.ResultButton_Click);
            getResultButton.Enabled = false;
            this.Controls.Add(getResultButton);
            // 
            // resultButton1
            // 
            resultButton1.BackColor = System.Drawing.Color.Gray;
            resultButton1.Location = new System.Drawing.Point(316, guessButton4.Location.Y);
            resultButton1.Name = "resultButton1";
            resultButton1.Size = new System.Drawing.Size(20, 20);
            resultButton1.TabIndex = 0;
            resultButton1.UseVisualStyleBackColor = false;
            resultButton1.Enabled = false;
            this.Controls.Add(resultButton1);
            // 
            // resultButton2
            // 
            resultButton2.BackColor = System.Drawing.Color.Gray;
            resultButton2.Location = new System.Drawing.Point(283, guessButton4.Location.Y);
            resultButton2.Name = "resultButton2";
            resultButton2.Size = new System.Drawing.Size(20, 20);
            resultButton2.TabIndex = 0;
            resultButton2.UseVisualStyleBackColor = false;
            resultButton2.Enabled = false;
            this.Controls.Add(resultButton2);
            // 
            // resultButton3
            // 
            resultButton3.BackColor = System.Drawing.Color.Gray;
            resultButton3.Location = new System.Drawing.Point(316, guessButton4.Location.Y + 20);
            resultButton3.Name = "resultButton3";
            resultButton3.Size = new System.Drawing.Size(20, 20);
            resultButton3.TabIndex = 0;
            resultButton3.UseVisualStyleBackColor = false;
            resultButton3.Enabled = false;
            this.Controls.Add(resultButton3);
            // 
            // resultButton4
            // 
            resultButton4.BackColor = System.Drawing.Color.Gray;
            resultButton4.Location = new System.Drawing.Point(283, guessButton4.Location.Y + 20);
            resultButton4.Name = "resultButton4";
            resultButton4.Size = new System.Drawing.Size(20, 20);
            resultButton4.TabIndex = 0;
            resultButton4.UseVisualStyleBackColor = false;
            resultButton4.Enabled = false;
            this.Controls.Add(resultButton4);
            if (i_RowIndex == m_MaxGuesses - 1)
            {
                this.Size = new Size(new Point(resultButton3.Location.X + 40, guessButton4.Location.Y + 100));
            }
            m_Rows[i_RowIndex].setGetResultButton(getResultButton);
            this.m_Rows[i_RowIndex].setGuessButtons(guessButton1, guessButton2, 
                guessButton3, guessButton4);
            this.m_Rows[i_RowIndex].setResultButtons(resultButton1, resultButton2,
                resultButton3, resultButton4);
        }
        private List <Button> AddButtonListeners(int i_RowNum)
        {
            List<Button> guessButtons;
            guessButtons = m_Rows[i_RowNum].getGuessButtons();
            foreach (Button btn in guessButtons)
            {
                btn.Enabled = true;
                btn.Click += new EventHandler(this.GuessBtn_Click);
            }

            return guessButtons;
        }
        public void GuessBtn_Click(Object sender, EventArgs e)
        {
            Button currentColorButton;
            int numOfEmptyGuesses = 0;
            m_CurrentBtn = sender as Button;
            m_ColorSelectForm.DesignedButtonColor = m_CurrentBtn;
            m_ColorSelectForm.ShowDialog();
            EnableColorButtons();
            foreach (Button btnGuessButton in m_CurrentGuessButtons)
            {
                if (btnGuessButton.BackColor == Color.Gray)
                {
                    numOfEmptyGuesses++;
                }
                else
                {
                    eColors currentColor = convertToeColor(btnGuessButton.BackColor);
                    currentColorButton = m_ColorSelectForm.getColorButton(currentColor);
                    currentColorButton.Enabled = false;
                    m_LastColors.Add(currentColor);
                }
            }
            if (numOfEmptyGuesses == 0)
            {
                SetGuessData(m_CurrentGuessButtons);
                Button getResultButton = m_Rows[m_TurnsCounter - 1].getGetResultButton();
                getResultButton.Enabled = true;
                if (m_TurnsCounter < m_MaxGuesses)
                {
                    m_CurrentGuessButtons = AddButtonListeners(m_TurnsCounter);
                }
            }
        }
        private void SetGuessData(List<Button> io_GuessButtons)
        {
            m_Rows[m_TurnsCounter - 1].m_Guess = new List<eColors>(4);
            m_Rows[m_TurnsCounter -1].m_Guess.Add(convertToeColor(io_GuessButtons[0].BackColor));
            m_Rows[m_TurnsCounter - 1].m_Guess.Add(convertToeColor(io_GuessButtons[1].BackColor));
            m_Rows[m_TurnsCounter - 1].m_Guess.Add(convertToeColor(io_GuessButtons[2].BackColor));
            m_Rows[m_TurnsCounter - 1].m_Guess.Add(convertToeColor(io_GuessButtons[3].BackColor));
        }
        private void ResultButton_Click(object sender, EventArgs e)
        {
            List<Button> resultButtonsList;
            bool isCorrectGuess = false;
            EnableColorButtons();
            m_LastColors.Clear();
            SetRowResult();
            resultButtonsList = m_Rows[m_TurnsCounter - 1].getResultButtons();
            m_Rows[m_TurnsCounter - 1].getGetResultButton().Enabled = false;
            if (m_Rows[m_TurnsCounter - 1].m_Result == null)
                return;
            for (int i = 0; i < m_Rows[m_TurnsCounter - 1].m_Result.Count; i++)
            {
                if (m_Rows[m_TurnsCounter - 1].m_Result[i] == eColors.Black)
                {
                    resultButtonsList[i].BackColor = Color.Black;
                }
                else if (m_Rows[m_TurnsCounter - 1].m_Result[i] == eColors.Yellow)
                {
                    resultButtonsList[i].BackColor = Color.Yellow;
                }
            }
            isCorrectGuess = m_GameLogic.CheckIfWon(m_Rows[m_TurnsCounter - 1].m_Result);
            if (isCorrectGuess || m_TurnsCounter == m_MaxGuesses)
            {
                m_IsGameOver = true;
                DisplayComputerColors(m_GameLogic.m_RandomColors);
                GameOver();
            }
            else
            {
                m_TurnsCounter++;
            }
        }
        private void EnableColorButtons()
        {
            foreach (eColors color in m_LastColors)
            {
                Button currentColorButton = m_ColorSelectForm.getColorButton(color);
                currentColorButton.Enabled = true;
            }
        }
        private void SetRowResult()
        {
            m_Rows[m_TurnsCounter - 1].m_Result = new List<eColors>();
            m_Rows[m_TurnsCounter - 1].m_Result = m_GameLogic.CheckSubmit(m_Rows[m_TurnsCounter - 1].m_Guess);
        }
        private void GameOver()
        {
            DisableBoardControllers(this);
        }
        private void DisplayComputerColors(List<eColors> io_GenereatedColors)
        {
            computerGuess1Button.BackColor = convertToColor(io_GenereatedColors[0]);
            computerGuess2Button.BackColor = convertToColor(io_GenereatedColors[1]);
            computerGuess3Button.BackColor = convertToColor(io_GenereatedColors[2]);
            computerGuess4Button.BackColor = convertToColor(io_GenereatedColors[3]);
        }
        private void DisableBoardControllers(FormGame io_Form)
        {
            foreach (Control ctrl in io_Form.Controls)
            {
                ctrl.Enabled = false;
            }
        }
        private Color convertToColor(eColors i_Color)
        {
            if (i_Color.ToString().Equals("Green"))
                return Color.Green;
            if (i_Color.ToString().Equals("Blue"))
                return Color.Blue;
            if (i_Color.ToString().Equals("Yellow"))
                return Color.Yellow;
            if (i_Color.ToString().Equals("Brown"))
                return Color.Brown;
            if (i_Color.ToString().Equals("Green"))
                return Color.Green;
            if (i_Color.ToString().Equals("Purple"))
                return Color.Purple;
            if (i_Color.ToString().Equals("Turquoise"))
                return Color.Turquoise;
            if (i_Color.ToString().Equals("Red"))
                return Color.Red;
            if (i_Color.ToString().Equals("white"))
                return Color.White;
            return Color.Black;
        }
        private eColors convertToeColor(Color i_Color)
        {
            if (i_Color.Name == "Green")
                return eColors.Green;
            if (i_Color.Name == "Blue")
                return eColors.Blue;
            if (i_Color.Name == "Yellow")
                return eColors.Yellow;
            if (i_Color.Name == "Brown")
                return eColors.Brown;
            if (i_Color.Name == "Green")
                return eColors.Green;
            if (i_Color.Name == "Purple")
                return eColors.Purple;
            if (i_Color.Name == "Turquoise")
                return eColors.Turquoise;
            if (i_Color.Name == "Red")
                return eColors.Red;
            if (i_Color.Name == "White")
                return eColors.White;
            return eColors.Black;
        }
    }
}

    



