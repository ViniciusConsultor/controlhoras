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
    public partial class ReportePlanificacionFuncionario : Form
    {
        public ReportePlanificacionFuncionario()
        {
            InitializeComponent();
            CrystalReport2 cr = new CrystalReport2();
            cr.SetDataSource(Controlador.getControlador().obtenerListaFuncionarios());
            cr.SetDatabaseLogon("user", "user");
           /// foreach(CrystalDecisions.CrystalReports.Engine.ReportDocument sr in cr.Subreports)
           //     sr.SetDataSource(
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

            crystalReportViewer1.Show();
        }
    }
}
