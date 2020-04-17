using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Misc
    {
        int m_BaseNumber, m_Percentage;

        public void setm_BaseNumber(int p_BaseNumber)
        {
            this.m_BaseNumber = p_BaseNumber;
        }

        public int getm_BaseNumber()
        {
            return this.m_BaseNumber;
        }

        public void setm_Percentage(int p_Percentage)
        {
            this.m_Percentage = p_Percentage;
        }

        public int getm_Percentage()
        {
            return this.m_Percentage;
        }

        public float SolvePercentNow()
        {
            float result = (getm_BaseNumber() / 100) * getm_Percentage();
            return result;
        }

    }
}
