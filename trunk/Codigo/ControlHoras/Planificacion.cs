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

        public Planificacion(string cli, string ser, string cliente, string servicio, DataGridView dgv)
        {
            InitializeComponent();

            mtCliente.Text = cli;
            mtServicio.Text = ser;
            

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
            cel.Style.BackColor = System.Drawing.Color.Lavender;
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

            // Agregamos botones           
            col = new DataGridViewColumn();
            cel = new DataGridViewTextBoxCell();
            //cel.Style.BackColor = System.Drawing.Color.Lavender;
            col.CellTemplate = cel;
            //col.HeaderText = "";
            //col.ReadOnly = true;
            dgvPlan.Columns.Add(col);

            col = new DataGridViewColumn();
            cel = new DataGridViewTextBoxCell();
            //cel.Style.BackColor = System.Drawing.Color.Lavender;
            col.CellTemplate = cel;
            //col.HeaderText = "Tipo";
            col.ReadOnly = true;
            col.Visible = false;
            dgvPlan.Columns.Add(col);
            
            CargarDGV(dgv);

            dgvPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellContentClick);
                
        }

        private void CargarDGV(DataGridView dgv)
        {
            int canCargos = dgv.RowCount;
            DataGridViewRow fila;
            DataGridViewRow insr;            
            int cant;

            DataGridViewCell cel = new DataGridViewTextBoxCell();
            cel.Style.BackColor = System.Drawing.Color.Black;

            DataGridViewCell cel2;
            

            DataGridViewButtonCell celBut;            
                        

            for (int i = 0; i < canCargos; i++)
            {
                fila = dgv.Rows[i];
                
                object[] param = { fila.Cells[0].Value , fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value, fila.Cells[5].Value, fila.Cells[6].Value, fila.Cells[7].Value, fila.Cells[8].Value};
                insr = new DataGridViewRow();                
                insr.CreateCells(dgvPlan, param);
                insr.Cells[8].Style.BackColor = System.Drawing.Color.Gray;
                dgvPlan.Rows.Add(insr);

                cant = int.Parse(fila.Cells[1].Value.ToString());

                fila = dgv.Rows[++i];
                insr = new DataGridViewRow();
                object[] param2 = { "", fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value, fila.Cells[5].Value, fila.Cells[6].Value, fila.Cells[7].Value, fila.Cells[8].Value};
                insr.CreateCells(dgvPlan,param2 );
                insr.Cells[0].Style.BackColor = System.Drawing.Color.Gray;

                celBut = new DataGridViewButtonCell();
                celBut.Value = "Asignar";
                celBut.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                insr.Cells[8] = celBut;
                
                dgvPlan.Rows.Add(insr);
                cant--;

                insr = new DataGridViewRow();
                
                insr.Height = 5;
                insr.DefaultCellStyle = cel.Style;
                cel2 = new DataGridViewTextBoxCell();
                cel2.Style.BackColor = System.Drawing.Color.Black;
                insr.Cells.Add(cel2);

                dgvPlan.Rows.Add(insr);


                while (cant > 0 )
                {
                    insr = new DataGridViewRow();
                    insr.CreateCells(dgvPlan, param);
                    insr.Cells[8].Style.BackColor = System.Drawing.Color.Gray;
                    dgvPlan.Rows.Add(insr);
                    
                    insr = new DataGridViewRow();
                    insr.CreateCells(dgvPlan, param2);
                    insr.Cells[0].Style.BackColor = System.Drawing.Color.Gray;

                    celBut = new DataGridViewButtonCell();
                    celBut.Value = "Asignar";
                    celBut.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    insr.Cells[8] = celBut;
                    
                    dgvPlan.Rows.Add(insr);
                    cant--;

                    insr = new DataGridViewRow();
                    insr.Height = 5;

                    insr.DefaultCellStyle = cel.Style;
                    cel2 = new DataGridViewTextBoxCell();
                    cel2.Style.BackColor = System.Drawing.Color.Black;
                    insr.Cells.Add(cel2);
                    insr.DefaultCellStyle = cel.Style;
                    
                    dgvPlan.Rows.Add(insr);

                }
            }
        }


        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                PruebaTB.Text = e.RowIndex.ToString();

                Selección_de_Recurso Sel = new Selección_de_Recurso();
                DialogResult resp = Sel.ShowDialog(this);

                if (resp == DialogResult.OK)
                {
                    PruebaTB.Text = Sel.NomFunc;

                    DataGridViewCell cel = new DataGridViewTextBoxCell();
                    cel.Style.BackColor = System.Drawing.Color.LightSteelBlue;
                    cel.Value = Sel.NomFunc;
                    DataGridViewRow r = dgvPlan.Rows[e.RowIndex];
                    r.Cells[0] = cel;

                    r = dgvPlan.Rows[e.RowIndex - 1];
                    r.Cells[9].Value = Sel.NumFunc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      


    }
}
