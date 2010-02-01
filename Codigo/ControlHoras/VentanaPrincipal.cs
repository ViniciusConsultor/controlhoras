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
            ABMClientes clientes = new ABMClientes();
            DialogResult res = clientes.ShowDialog(this);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCategorias categ = new ABMCategorias();
            categ.ShowDialog(this);
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
            ABMEmpleados empls = new ABMEmpleados();
            empls.ShowDialog(this);
        }

        private void emergenciasMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEmergenciasMedica eme = new ABMEmergenciasMedica();
            eme.ShowDialog(this);
        }

        private void mutualistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMMutualistas mutu = new ABMMutualistas();
            mutu.ShowDialog(this);
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMBancos banco = new ABMBancos();
            banco.ShowDialog(this);
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMDepartamentos depa = new ABMDepartamentos();
            depa.ShowDialog(this);
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMTiposDocumento tiposDoc = new ABMTiposDocumento();
            tiposDoc.ShowDialog(this);
        }



    }
}
