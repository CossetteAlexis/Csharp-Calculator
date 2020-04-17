using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Multiply1
    {
        int m_Multiplier1, m_Multiplier2;

        public int MultNow()
        {
            int result = this.m_Multiplier1 * this.m_Multiplier2;
            return result;
        }

        public void setm_Multiplier1(int p_Multiplier1)
        {
            this.m_Multiplier1 = p_Multiplier1;
        }

        public int getm_Multiplier1()
        {
            return this.m_Multiplier1;
        }

        public void setm_Multiplier2(int p_Multiplier2)
        {
            this.m_Multiplier2 = p_Multiplier2;
        }

        public int getm_Multiplier2()
        {
            return this.m_Multiplier2;
        }
    }
}
