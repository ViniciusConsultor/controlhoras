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
        private bool botonAceptar = false;
        private IDatos datos = null;
        public MotIVOsCamBiosDiARioS motivoCambio { set; get; }
        private DateTime FechaCorresponde;
        private List<TipOsMotIVOCamBIoDiARio> listaTiposMotivos = null; 
        
        public MotivoCambioDiarioForm(DateTime fechaCorresponde)
        {
            InitializeComponent();
            try
            {
                datos = ControladorDatos.getInstance();

                listaTiposMotivos = datos.obtenerTiposMotivoCambioDiario(true);
                cmbMotivosCambio.BeginUpdate();

                cmbMotivosCambio.DataSource = listaTiposMotivos;
                cmbMotivosCambio.DisplayMember = "Descripcion";
                cmbMotivosCambio.EndUpdate();
                botonAceptar = false;
                FechaCorresponde = fechaCorresponde;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtObservaciones.Text != "")
            {
                motivoCambio = new MotIVOsCamBiosDiARioS();
                motivoCambio.FechaCambio = DateTime.Now;
                motivoCambio.FechaCorresponde = FechaCorresponde.Date;
                motivoCambio.Observaciones = txtObservaciones.Text;
                motivoCambio.TipOsMotIVOCamBIoDiARio = ((TipOsMotIVOCamBIoDiARio)cmbMotivosCambio.SelectedValue);
                
            }
            else
            {
                MessageBox.Show(this, "Debe ingresar una observacion.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            botonAceptar = true;
        }

        private void MotivoCambioDiarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (botonAceptar && txtObservaciones.Text == "")
            {
                e.Cancel = true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            botonAceptar = false;
        }
    }
}
