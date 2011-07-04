using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace Logica
{
    public class ControladorConfiguracion
    {
        static private ControladorConfiguracion config = null;


        private ControladorConfiguracion()
        {

        }

        //static public ControladorConfiguracion getInstancia()
        //{
        //    if (config == null)
        //        config = new ControladorConfiguracion();
        //    return config;
        //}

        static public System.Drawing.Color getColorEnterTextBoxPropertieValue()
        {
            System.Drawing.Color color; 
            //System.Console.WriteLine(System.Configuration.ConfigurationManager.AppSettings.Count.ToString());
            color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));

            return color;
        }

        static public System.Drawing.Color getColorLeaveTextBoxPropertieValue()
        {
            System.Drawing.Color color; 
           // object conf = System.Configuration.ConfigurationManager.GetSection("applicationSettings");
            color = System.Drawing.Color.White;

            return color;
        }
    }
}
