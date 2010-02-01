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
    public partial class Planificacion : Form
    {
        public Planificacion()
        {
            InitializeComponent();
        }

        public Planificacion(string cliente, string servicio, DataGridView dgv)
        {
            InitializeComponent();

            txtCliente.Text = cliente;
            txtServicio.Text = servicio;

            /*dgvPlan = dgv;
            dgvPlan.Show();*/
            MaskedTextBoxColumn mtbc;
            String maskHour = "00:00";
            int widthDaysColumn = 60;

            DataGridViewColumn col;
            col = new DataGridViewColumn();
            DataGridViewCell cel = new DataGridViewTextBoxCell();
            cel.Style.BackColor = System.Drawing.Color.LightGreen;
            col.CellTemplate = cel;
            col.HeaderText="Tipo";
            col.ReadOnly = true;
            dgvPlan.Columns.Add(col);

            // Agregamos la columna Lunes
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Lunes";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            mtbc.ReadOnly = true;
            this.dgvPlan.Columns.Add(mtbc);


            // Agregamos la columna Martes
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Martes";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            mtbc.ReadOnly = true;
            this.dgvPlan.Columns.Add(mtbc);

            // Agregamos la columna Miercoles
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Miercoles";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            mtbc.ReadOnly = true;
            this.dgvPlan.Columns.Add(mtbc);

            // Agregamos la columna Jueves
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Jueves";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            mtbc.ReadOnly = true;
            this.dgvPlan.Columns.Add(mtbc);

            // Agregamos la columna Viernes
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Viernes";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            mtbc.ReadOnly = true;
            this.dgvPlan.Columns.Add(mtbc);

            // Agregamos la columna Sabado
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Sabado";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            mtbc.ReadOnly = true;
            this.dgvPlan.Columns.Add(mtbc);

            // Agregamos la columna Domingo
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Domingo";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            mtbc.ReadOnly = true;
            this.dgvPlan.Columns.Add(mtbc);

            CargarDGV(dgv);
                
        }

        private void CargarDGV(DataGridView dgv)
        {
            int canCargos = dgv.RowCount;
            DataGridViewRow fila;
            DataGridViewRow insr;            
            int cant;

            DataGridViewCell cel = new DataGridViewTextBoxCell();
            cel.Style.BackColor = System.Drawing.Color.Black;

            for (int i = 0; i < canCargos; i++)
            {
                fila = dgv.Rows[i];
                
                object[] param = { fila.Cells[0].Value , fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value, fila.Cells[5].Value, fila.Cells[6].Value, fila.Cells[7].Value, fila.Cells[8].Value};
                insr = new DataGridViewRow();                
                insr.CreateCells(dgvPlan, param);                
                dgvPlan.Rows.Add(insr);

                cant = int.Parse(fila.Cells[1].Value.ToString());

                fila = dgv.Rows[++i];
                insr = new DataGridViewRow();
                object[] param2 = { "", fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value, fila.Cells[5].Value, fila.Cells[6].Value, fila.Cells[7].Value, fila.Cells[8].Value};
                insr.CreateCells(dgvPlan,param2 );
                insr.Cells[0].Style.BackColor = System.Drawing.Color.Gray;
                dgvPlan.Rows.Add(insr);
                cant--;

                insr = new DataGridViewRow();
                insr.Height = 5;
                insr.DefaultCellStyle = cel.Style;
                dgvPlan.Rows.Add(insr);


                while (cant > 0 )
                {
                    insr = new DataGridViewRow();
                    insr.CreateCells(dgvPlan, param);
                    dgvPlan.Rows.Add(insr);
                    insr = new DataGridViewRow();
                    insr.CreateCells(dgvPlan, param2);
                    insr.Cells[0].Style.BackColor = System.Drawing.Color.Gray;
                    dgvPlan.Rows.Add(insr);
                    cant--;

                    insr = new DataGridViewRow();
                    insr.Height = 5;
                    insr.DefaultCellStyle = cel.Style;
                    dgvPlan.Rows.Add(insr);

                }
            }
        }
    }
}
