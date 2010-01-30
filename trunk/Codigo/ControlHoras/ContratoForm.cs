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
    public partial class ContratoForm : Form
    {
        public ContratoForm()
        {
            InitializeComponent();

            InicializarCargaHorariaDGV();
            
            CostoCB.SelectedIndex = 0;
            
                        


        }

        private void InicializarCargaHorariaDGV()
        {
            MaskedTextBoxColumn mtbc;

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Lunes";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Martes";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Miercoles";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Jueves";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Viernes";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Sabado";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Domingo";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);
        }

        private void CostoCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CostoCB.SelectedItem.ToString() == "fijo")
                MontoTB.ReadOnly = false;
            else
                MontoTB.ReadOnly = true;
        }
              
    }
}
