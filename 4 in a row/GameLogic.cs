using System;
using System.Collections.Generic;
using System.Linq;
namespace C19_Ex05
{
    public class GameLogic
    {
        internal List<eColors> m_RandomColors;
        private Random m_Rnd;
        public GameLogic()
        {
            m_Rnd = new Random();
            GenerateRandomColorList();
        }
        internal void GenerateRandomColorList(int i_Range = 7, int i_Length = 4)
        {
            int num;
            this.m_RandomColors = new List<eColors>();
            for (int i = 0; i < i_Length; i++)
            {
                num = m_Rnd.Next(0, i_Range);
                m_RandomColors.Add((eColors)(num));
            }
            if ((CheckColorsDuplication(m_RandomColors)))
            {
                this.m_RandomColors.Clear();
                GenerateRandomColorList();
            }
        }
        internal List<eColors> CheckSubmit(List<eColors> i_Guess)
        {
            int numOfBlack = 0,i;
            int numOfYellow = 0;
            List<eColors> answer = new List<eColors>(4);
            eColors tempColor;
            if (i_Guess == null || i_Guess.Count < 4)
                return null;

            for ( i = 0; i < 4; i++)
            {
                tempColor = i_Guess[i];
                if (m_RandomColors[i] == i_Guess[i])
                {
                    answer.Add(eColors.Black);
                    numOfBlack++;
                }
                if (m_RandomColors.Contains(tempColor))
                {
                    numOfYellow++;
                }
            }
            numOfYellow = numOfYellow - numOfBlack;
            for (i = 0; i < numOfYellow; i++)
            {
                answer.Add(eColors.Yellow);
            }

            return answer;
        }
        internal bool CheckIfWon(List<eColors> i_Answer)
        {
            bool Won = false;
            for (int i = 0; i < i_Answer.Count; i++)
            {
                if (CountColors(i_Answer, eColors.Black) == 4)
                {
                    Won = true;
                }
                else
                {
                    Won = false;
                }
            }

            return Won;
        }
        internal static bool CheckColorsDuplication(List<eColors> io_Input,int i_LengthOfList=4)
        {
            bool ColorDuplication = false;
            for (int i = 0; i < i_LengthOfList; i++)
            {
                if (CountColors(io_Input, io_Input[i]) > 1)
                {
                    ColorDuplication = true;
                    break;
                }
            }

            return ColorDuplication;
        }
        internal static int CountColors(List<eColors> io_Input, eColors i_Color)
        {
            int counter = 0;
            foreach (eColors currentColor in io_Input)
            {
                if (i_Color == currentColor)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}


