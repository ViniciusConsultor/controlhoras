using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace ControlHoras
{
    public partial class VerObservaciones : Form
    {
        List<MotIVOsCamBiosDiARioS> motivos;

        public VerObservaciones()
        {
            InitializeComponent();
            motivos = null;
        }

        public VerObservaciones(List<MotIVOsCamBiosDiARioS> mots)
        {            
            InitializeComponent();            
            
            motivos = mots;
        }

        private void VerObservaciones_Load(object sender, EventArgs e)
        {
            this.Location = MousePosition;
            string aux="";
            foreach (MotIVOsCamBiosDiARioS m in motivos)
            {
                aux = aux + "* " + m.Observaciones + "\n";
            }
            
            HojaTB.Text = aux;
        }
    }
}
