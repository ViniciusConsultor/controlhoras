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
            ContratoForm contrato = new ContratoForm();
            contrato.ShowDialog(this);
        }


        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(this, "Desea Salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( res == DialogResult.Yes)
                Application.Exit();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMClientes clientes = ABMClientes.getVentana();
            if (clientes.Visible == false)
                clientes.Show(this);
            else
                clientes.Focus();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCargos categ = ABMCargos.getVentana();
            if (categ.Visible == false)
                categ.Show(this);
            else
                categ.Focus();
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
            ABMEmpleados empls = ABMEmpleados.getVentana();
            if (empls.Visible == false)
                empls.Show(this);
            else
                empls.Focus();
        }

        private void emergenciasMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEmergenciasMedica eme = ABMEmergenciasMedica.getVentana();
            if (eme.Visible == false)
                eme.Show(this);
            else
                eme.Focus();
        }

        private void mutualistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMMutualistas mutu = ABMMutualistas.getVentana();
            if (mutu.Visible == false)
                mutu.Show(this);
            else
                mutu.Focus();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMBancos banco = ABMBancos.getVentana();
            if (banco.Visible == false)
                banco.Show(this);
            else
                banco.Focus();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMDepartamentos depa = ABMDepartamentos.getVentana();
            if (depa.Visible == false)
                depa.Show(this);
            else
                depa.Focus();
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMTiposDocumento tiposDoc = ABMTiposDocumento.getVentana();
            if (tiposDoc.Visible == false)
                tiposDoc.Show(this);
            else
                tiposDoc.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            ABMEmpleados em = ABMEmpleados.getVentana();
            if (em.IsDisposed == false)
            {
                em.Show(this);
            }
            else
            {
   //             em.Activate();
                em.Show(this);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           ABMClientes cli = ABMClientes.getVentana();
           if (cli.Visible == false)
               cli.Show(this);
           else
               cli.Focus();
        }

        private void tiposDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMTipoEventoHistorial tiposevento = ABMTipoEventoHistorial.getVentana();
            if (tiposevento.Visible == false)
                tiposevento.Show(this);
            else
                tiposevento.Focus();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCargos cargos = ABMCargos.getVentana();
            if (cargos.Visible == false)
                cargos.Show(this);
            else
                cargos.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ExportToExcel ex = new ExportToExcel();
            ex.ShowDialog(this);
        }




    }
}
