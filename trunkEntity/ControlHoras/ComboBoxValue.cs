using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlHoras
{
    class ComboBoxValue
    {
        private string m_Display;
        private int m_Value;
        
        public ComboBoxValue(string Display, int Value)
        {
            m_Display = Display;
            m_Value = Value;
        }
        public string Display
        {
            get { return m_Display; }
        }
        public int Value
        {
            get { return m_Value; }
        }
    
    }
}
