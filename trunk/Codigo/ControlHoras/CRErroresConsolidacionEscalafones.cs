using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;

namespace ControlHoras
{
    public partial class CRErroresConsolidacionEscalafones : Form
    {
        public CRErroresConsolidacionEscalafones()
        {
            InitializeComponent();
            
        }

        public CRErroresConsolidacionEscalafones(Dictionary<string,List<string>> ds)
        {
            InitializeComponent();
            ListaErroresConsolidacion cr = new ListaErroresConsolidacion();
            cr.SetDataSource(ds);
            cr.SetDatabaseLogon("user", "user");

            crvErrores.ReportSource = cr;
           
            crvErrores.Refresh();

            crvErrores.Show();    
        }
        
    }
}
