using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Memory1
    {
        int m_Memory, m_Addens  , m_Subtrahen;

        public void setm_Memory(int p_Memory)
        {
            this.m_Memory = p_Memory;
        }

        public int getm_Memory()
        {
            return this.m_Memory;
        }

        public void MemoryClear()
        {
            this.m_Memory = 0;
            this.m_Addens = 0;
            this.m_Subtrahen = 0;
        }
        public void MemoryAdd()
        {
            int result = getm_Memory() + getm_Addens();
            setm_Memory(result);
        }

        public void MemoryMinus()
        {
            int result = getm_Memory() - getm_Subtrahem();
            setm_Memory(result);
        }

        public void setm_Addens(int p_Addens)
        {
            this.m_Addens = p_Addens;
        }

        public int getm_Addens()
        {
            return this.m_Addens;
        }
        public void setm_Subtrahem(int p_Subtrahem)
        {
            this.m_Subtrahen = p_Subtrahem;
        }

        public int getm_Subtrahem()
        {
            return this.m_Subtrahen;
        }
    }
}
