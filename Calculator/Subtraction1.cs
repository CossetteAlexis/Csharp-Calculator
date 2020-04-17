using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Subtraction1
    {
        int m_Subtrahen1, m_Subtrahen2;

        public int MinusNow()
        {
            int result = this.m_Subtrahen1 - this.m_Subtrahen2;
            return result;
        }

        public void setm_Subtrahen1(int p_Subtrahen1)
        {
            this.m_Subtrahen1 = p_Subtrahen1;
        }

        public int getm_Subtrahen1()
        {
            return this.m_Subtrahen1;
        }

        public void setm_Subtrahen2(int p_Subtrahen2)
        {
            this.m_Subtrahen2 = p_Subtrahen2;
        }

        public int getm_Subtrahen2()
        {
            return this.m_Subtrahen2;
        }
    }
}
