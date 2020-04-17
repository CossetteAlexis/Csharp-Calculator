using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Addition1
    {
        int m_Adden1, m_Adden2;

        public int AddNow()
        {
            int result = this.m_Adden1 + this.m_Adden2;
            return result;
        }

        public void setm_Adden1(int p_Adden1)
        {
            this.m_Adden1 = p_Adden1;
        }

        public int getm_Adden1()
        {
            return this.m_Adden1;
        }

        public void setm_Adden2(int p_Adden2)
        {
            this.m_Adden2 = p_Adden2;
        }

        public int getm_Adden2()
        {
            return this.m_Adden2;
        }
    }
}
