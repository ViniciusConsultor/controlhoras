using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;


namespace ControlHoras
{
    public partial class ABMEmpleados : Form
    {
        
        IClientesServicios sistema;

        public ABMEmpleados()
        {
            InitializeComponent();
            sistema = ControladorClientesServicios.getInstance();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            btnCrear.Enabled = true;
            btnGuardar.Enabled = false;
            btnAgregarHistorial.Enabled = true;
            btnGuardarHistorial.Enabled = false;
            btnEliminarHistorial.Enabled = false;
        }


        private void limpiarForm()
        {
            foreach (TabPage tp in tcEmpleado.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    string tipoDelControl;
                    tipoDelControl = c.GetType().ToString();
                    if (tipoDelControl == "ControlHoras.TextBoxKeyDown" || tipoDelControl == "ControlHoras.MaskedTextBoxKeyDown")
                        c.Text = "";
                    else if (tipoDelControl == "System.Windows.Forms.GroupBox")
                    {
                        foreach (Control cgb in c.Controls)
                        {
                            if (cgb.GetType().ToString() == "ControlHoras.TextBoxKeyDown" || cgb.GetType().ToString() == "ControlHoras.MaskedTextBoxKeyDown")
                                cgb.Text = "";
                        }
                    }
                    else if (tipoDelControl == "System.Windows.Forms.ComboBoxKeyDown")
                    {
                        ((ComboBox) c).SelectedIndex = 0;
                    }
                    
                    
                }
            }
        }

        private void mtNumeroEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtNumeroEmpleado.MaskCompleted && e.KeyCode == Keys.Enter)
            { // traigo el cliente y lleno los datos de los campos.
                try
                {
                    //if (sistema.existeCliente(int.Parse(mtCliente.Text)))
                    //{
                    //    cliente = sistema.obtenerCliente(int.Parse(mtCliente.Text));
                    //    cargarCliente(cliente);
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (mtNumeroEmpleado.Text == "")
            {    // Obtengo el ultimo numero de cliente + 1;
            }
        }
    }
}
