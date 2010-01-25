using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;


namespace ControlHoras
{
    public partial class ContratoHoras : Form
    {
        Controlador controller=null;
        int[] diasNL = new int[9];
        Color ColorOriginalFila = Color.White;
        Color ColorEntradaFila = Color.SlateGray;
        Color ColorSalidaFila = Color.Yellow;


        public ContratoHoras()
        {
            InitializeComponent();
            InitializeDataGridViewHoras();
            controller = Controlador.getControlador();

            IniDias();
           // mtCliente.Focus();
            //Prueba p = new Prueba();
            //p.Show();
        }

        private void InitializeDataGridViewHoras()
        {
            
            MaskedTextBoxColumn mtbc;
            String maskHour = "00:00";
            int widthDaysColumn = 60;

            // Agregamos una columna ComboBox
            DataGridViewComboBoxColumn dgvtbc = new DataGridViewComboBoxColumn();
            dgvtbc.HeaderText = "Tipo";
            this.dgvHoras.Columns.Add(dgvtbc);


            // Agregamos la columna Lunes
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Cantidad";
            mtbc.Mask = "00";
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            // Agregamos la columna Lunes
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Lunes";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);


            // Agregamos la columna Martes
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Martes";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            // Agregamos la columna Miercoles
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Miercoles";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            // Agregamos la columna Jueves
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Jueves";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            // Agregamos la columna Viernes
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Viernes";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            // Agregamos la columna Sabado
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Sabado";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            // Agregamos la columna Domingo
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Domingo";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell cbc = new DataGridViewComboBoxCell();
            cbc.Items.Add("Vigilante");
            cbc.Items.Add("Vigilante Auxiliar");
            cbc.Items.Add("Vigilante Armado");
            cbc.Items.Add("Supervisor");
            

            // Se crea una fila seteandole a la primer columna el combobox
            DataGridViewRow dgvr = new DataGridViewRow();
            dgvHoras.Rows.Add(dgvr);
            dgvr.Cells[0] = cbc;

            for (int i = 2; i < 9; i++)
            {
                if (diasNL[i] == 1)
                {
                    DataGridViewTextBoxCell dgvtc = new DataGridViewTextBoxCell();
                    dgvtc.Value = "N/T";
                    dgvr.Cells[i] = dgvtc;
                    //dgvtc.ReadOnly = true;
                }
            }

            // Se crea otra fila en blando.
            DataGridViewTextBoxCell dgvtbc = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dgvtbc2 = new DataGridViewTextBoxCell();
            dgvr = new DataGridViewRow();
            dgvHoras.Rows.Add(dgvr);
            dgvr.Cells[0] = dgvtbc;
            dgvr.Cells[0].Style.BackColor = System.Drawing.Color.Gray;
            dgvr.Cells[1] = dgvtbc2;
            dgvr.Cells[1].Style.BackColor = System.Drawing.Color.Gray; 
            //dgvtbc.ReadOnly = true;
            //dgvtbc2.ReadOnly = true;

            for (int i = 2; i < 9; i++)
            {
                if (diasNL[i] == 1)
                {
                    DataGridViewTextBoxCell dgvtc = new DataGridViewTextBoxCell();
                    dgvtc.Value = "N/T";
                    dgvr.Cells[i] = dgvtc;
                    //dgvtc.ReadOnly = true;
                }
            }
        }

        private void martesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataGridView dgvHoras.Columns["Martes"];
            
        }

        private void btnPlanificar_Click(object sender, EventArgs e)
        {
            Planificacion pl = new Planificacion(mtCliente.Text, mtServicio.Text, txtCliente.Text, txtServicio.Text, dgvHoras);
            DialogResult res = pl.ShowDialog(this);

            if (res == DialogResult.OK)
                this.Dispose();
        }



        private void mtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && mtCliente.MaskCompleted)
            {
                Cliente cli = controller.obtenerCliente(int.Parse(mtCliente.Text));
                txtCliente.Text = cli.getNombre();
                mtServicio.Text = "";
                txtServicio.Text = "";
                // e.Handled = true;
                SendKeys.Send("{TAB}");

            }
            if (e.KeyCode == Keys.F2)
            {
                // Abrir ventana de busqueda de clientes
            }
        }

        private void mtServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && mtServicio.Text != "")
            {
                try
                {
                    Servicio ser = controller.obtenerServicioCliente(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text));
                    txtServicio.Text = ser.getNombre();
                    SendKeys.Send("{TAB}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.KeyCode == Keys.F2)
            {
                // Abrir ventana de busqueda de servicios de ese cliente.
            }
        }


        private void mtCliente_Leave(object sender, EventArgs e)
        {
            mtCliente.BackColor = Color.White;
        }

        private void mtCliente_Enter(object sender, EventArgs e)
        {
            mtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
        }

        private void mtServicio_Enter(object sender, EventArgs e)
        {
            mtServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
        }

        private void mtServicio_Leave(object sender, EventArgs e)
        {
            mtServicio.BackColor = Color.White;
        }



        private void IniDias()
        {
            int i;
            for (i=0; i<7; i++)
            {
                diasNL[i] = 0;
            }
        }


        private void DehsabilitarDia_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cel = dgvHoras.SelectedCells;
            //diasNL[dgvHoras.SelectedColumns[0].Index] = 1;
            //diasNL[cel[0].ColumnIndex] = 1;
            int j = cel[0].ColumnIndex;
            diasNL[j] = 1;
            int cant = cel.Count;
            int i;
            for (i = 0; i < cant; i++)
            {
                cel[i].Value = "N/T";
                cel[i].ReadOnly = true;
            }
        }



    }
}
