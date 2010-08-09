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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            try
            {
                ContratoForm contrato = new ContratoForm();
                contrato.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(this, "Desea Salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( res == DialogResult.Yes)
                Application.Exit();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMClientes clientes = ABMClientes.getVentana();
                if (clientes.Visible == false)
                    clientes.Show(this);
                else
                    clientes.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMCargos categ = ABMCargos.getVentana();
                if (categ.Visible == false)
                    categ.Show(this);
                else
                    categ.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            
        }


        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicioForm ser = new ServicioForm();
            DialogResult res = ser.ShowDialog(this);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMEmpleados empls = ABMEmpleados.getVentana();
                if (empls.Visible == false)
                    empls.Show(this);
                else
                    empls.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emergenciasMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMEmergenciasMedica eme = ABMEmergenciasMedica.getVentana();
                if (eme.Visible == false)
                    eme.Show(this);
                else
                    eme.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mutualistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMMutualistas mutu = ABMMutualistas.getVentana();
                if (mutu.Visible == false)
                    mutu.Show(this);
                else
                    mutu.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMBancos banco = ABMBancos.getVentana();
                if (banco.Visible == false)
                    banco.Show(this);
                else
                    banco.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMDepartamentos depa = ABMDepartamentos.getVentana();
                if (depa.Visible == false)
                    depa.Show(this);
                else
                    depa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMTiposDocumento tiposDoc = ABMTiposDocumento.getVentana();
                if (tiposDoc.Visible == false)
                    tiposDoc.Show(this);
                else
                    tiposDoc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ABMEmpleados em = ABMEmpleados.getVentana();
                if (em.Visible == true)
                {
                    em.Focus();
                }
                else
                {
                    em.Show(this);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
               ABMClientes cli = ABMClientes.getVentana();
               if (cli.Visible == false)
                   cli.Show(this);
               else
                   cli.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tiposDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
           {
                ABMTipoEventoHistorial tiposevento = ABMTipoEventoHistorial.getVentana();
                if (tiposevento.Visible == false)
                    tiposevento.Show(this);
                else
                    tiposevento.Focus();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMCargos cargos = ABMCargos.getVentana();
                if (cargos.Visible == false)
                    cargos.Show(this);
                else
                    cargos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel ex = ExportToExcel.getInstance();
                if (ex.Visible == false)
                    ex.Show(this);
                else
                    ex.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cambiarNúmeroEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarNumeroEmpleado cambiarNumEmpleado = CambiarNumeroEmpleado.getVentana();
                if (cambiarNumEmpleado.Visible == false)
                    cambiarNumEmpleado.Show(this);
                else
                    cambiarNumEmpleado.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaNegraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMLNegra listaNegra = ABMLNegra.getVentana();
                if (listaNegra.Visible == false)
                    listaNegra.Show(this);
                else
                    listaNegra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMCiudades depa = ABMCiudades.getVentana();
                if (depa.Visible == false)
                    depa.Show(this);
                else
                    depa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMBarrios depa = ABMBarrios.getVentana();
                if (depa.Visible == false)
                    depa.Show(this);
                else
                    depa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEscalafon_Click(object sender, EventArgs e)
        {
            try
            {
                Escalafon depa = Escalafon.getVentana();
                if (depa.Visible == false)
                    depa.Show(this);
                else
                    depa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ControlDiario ex = ControlDiario.getInstance();
                if (ex.Visible == false)
                    ex.Show(this);
                else
                    ex.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
