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
            ContratoHoras contrato = new ContratoHoras();
            contrato.ShowDialog(this);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ControlDiario controldiario = new ControlDiario();
            controldiario.ShowDialog(this);

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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMUsuarios usu = new ABMUsuarios();
            usu.ShowDialog(this);
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMFuncionarios func = new ABMFuncionarios();
            func.ShowDialog(this);
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteClientes rc = new ReporteClientes();
            rc.Show();
        }

        private void planificacionFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportePlanificacionFuncionario rpf = new ReportePlanificacionFuncionario();
            rpf.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicioForm ser = new ServicioForm();
            DialogResult res = ser.ShowDialog(this);
        }


    }
}
