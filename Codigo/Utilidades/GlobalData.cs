using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public static class GlobalData
    {
        private static string m_UserNameLogged = "";

        public static string UserNameLogged
        {
            get { return m_UserNameLogged; }
            set { m_UserNameLogged = value; }
        }
    }
}
