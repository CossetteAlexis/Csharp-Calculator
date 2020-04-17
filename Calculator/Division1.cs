using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Division1
    {
        int m_Divisor1, m_Divisor2;

        public int DivNow()
        {
            int result = this.m_Divisor1 / this.m_Divisor2;
            return result;
        }

        public void setm_Divisor1(int p_Divisor1)
        {
            this.m_Divisor1 = p_Divisor1;
        }

        public int getm_Divisor1()
        {
            return this.m_Divisor1;
        }

        public void setm_Divisor2(int p_Divisor2)
        {
            this.m_Divisor2 = p_Divisor2;
        }

        public int getm_Divisor2()
        {
            return this.m_Divisor2;
        }
    }
}
