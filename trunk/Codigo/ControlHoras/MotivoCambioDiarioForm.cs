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
    public partial class MotivoCambioDiarioForm : Form
    {
        private IDatos datos = null;
        public MotIVOsCamBiosDiARioS motivoCambio { set; get; }
        private List<TipOsMotIVOCamBIoDiARio> listaTiposMotivos = null; 
        public MotivoCambioDiarioForm()
        {
            InitializeComponent();
            datos = ControladorDatos.getInstance();
            listaTiposMotivos = datos.obtenerTiposMotivoCambioDiario();
            cmbMotivosCambio.BeginUpdate();
            //foreach (TipOsMotIVOCamBIoDiARio tmcd in listaTiposMotivos)
            //{
            cmbMotivosCambio.DataSource = listaTiposMotivos;
            cmbMotivosCambio.DisplayMember = "Descripcion";
            cmbMotivosCambio.EndUpdate();
            //}
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtObservaciones.Text != "")
            {
                motivoCambio = new MotIVOsCamBiosDiARioS();
                motivoCambio.Fecha = DateTime.Now;
                motivoCambio.Observaciones = txtObservaciones.Text;
                motivoCambio.TipOsMotIVOCamBIoDiARio = ((TipOsMotIVOCamBIoDiARio)cmbMotivosCambio.SelectedValue);
            }
            else
                MessageBox.Show(this, "Debe ingresar una observacion.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
