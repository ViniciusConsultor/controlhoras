using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlHoras
{
    public partial class Prueba_2 : Form
    {
        Dictionary<string, List<string>> errores;

        public Prueba_2()
        {
            InitializeComponent();
            errores = null;
        }

        public Prueba_2(Dictionary<string, List<string>> ers)
        {
            InitializeComponent();

            errores = ers;
        }


        private void Prueba_2_Load(object sender, EventArgs e)
        {
            string aux = "";
            Dictionary<string, List<string>>.Enumerator iter = errores.GetEnumerator();

            while (iter.MoveNext())
            {
                aux = aux + iter.Current.Key + "\n";
                foreach (string er in iter.Current.Value)
                {
                    aux = aux + "\t" + er + "\n ";
                }
            }
               
            erroresTB.Text = aux;
        }
    }
}
