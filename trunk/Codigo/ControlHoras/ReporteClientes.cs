using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;

namespace ControlHoras
{
    public partial class ReporteClientes : Form
    {
        

        public ReporteClientes()
        {
            InitializeComponent();
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(Controlador.getControlador().obtenerListaClientes());
            cr.SetDatabaseLogon("user", "user");

            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

            crystalReportViewer1.Show();
 
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
