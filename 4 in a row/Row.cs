
using System.Collections.Generic;
using System.Windows.Forms;

namespace C19_Ex05
{
    public class Row
    {
        internal List<eColors> m_Guess;
        internal List<eColors> m_Result;
        internal Button m_GuessButton1;
        internal Button m_GuessButton2;
        internal Button m_GuessButton3;
        internal Button m_GuessButton4;
        internal Button m_GetResultButton = new Button();
        internal Button m_ResultButton1 = new Button();
        internal Button m_ResultButton2 = new Button();
        internal Button m_ResultButton3 = new Button();
        internal Button m_ResultButton4 = new Button();
        public List<Button> getGuessButtons()
        {
            List<Button> guessList = new List<Button>();
            guessList.Add(this.m_GuessButton1);
            guessList.Add(this.m_GuessButton2);
            guessList.Add(this.m_GuessButton3);
            guessList.Add(this.m_GuessButton4);

            return guessList;
        }
        public Button getGetResultButton()
        {
            return m_GetResultButton;
        }
        public void setGetResultButton(Button i_GetResultButton)
        {
            m_GetResultButton = i_GetResultButton;
        }
        public List<Button> getResultButtons()
        {
            List<Button> resultList = new List<Button>();
            resultList.Add(this.m_ResultButton1);
            resultList.Add(this.m_ResultButton2);
            resultList.Add(this.m_ResultButton3);
            resultList.Add(this.m_ResultButton4);

            return resultList;
        }
        public void setGuessButtons(Button io_GuessButton1, Button io_GuessButton2,
            Button io_GuessButton3, Button io_GuessButton4)
        {
            this.m_GuessButton1 = io_GuessButton1;
            this.m_GuessButton2 = io_GuessButton3;
            this.m_GuessButton3 = io_GuessButton2;
            this.m_GuessButton4 = io_GuessButton4;
        }
        public void setResultButtons(Button io_ResultButton1, Button io_ResultButton2, 
            Button io_ResultButton3, Button io_ResultButton4)
        {
            this.m_ResultButton1 = io_ResultButton1;
            this.m_ResultButton2 = io_ResultButton2;
            this.m_ResultButton3 = io_ResultButton3;
            this.m_ResultButton4 = io_ResultButton4;
        }
    }
}
