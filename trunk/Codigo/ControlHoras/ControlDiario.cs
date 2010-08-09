using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace ControlHoras
{
    public partial class ControlDiario : Form
    {
        private static ControlDiario ventana = null;

        private IDatos datos;
        private string fechaMask = @"  /  /";

        //Controlador controller;
        Color ColorOriginalFila = Color.White;
        Color ColorEntradaFila = Color.SlateGray;
        Color ColorSalidaFila = Color.Yellow;

        private ControlDiario()
        {
            datos = ControladorDatos.getInstance();
            //InitializeDataGridViewHoras();
            InitializeComponent();
            //controller = Controlador.getControlador();
        }

         public static ControlDiario getInstance()
        {
            if (ventana == null)
                ventana = new ControlDiario();
            return ventana;
        }
/*
        private void InitializeDataGridViewHoras()
        {

            MaskedTextBoxColumn mtbc;
            String maskHour = "00:00";
            int widthDaysColumn = 70;

            // Agregamos una columna ComboBox
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Num Funcionario";
            mtbc.Name="Numero";
            mtbc.Mask = "0000";
            this.dgvHoras.Columns.Add(mtbc);


            // Agregamos la columna Lunes
            DataGridViewTextBoxColumn dgvtb = new DataGridViewTextBoxColumn();
            dgvtb.HeaderText = "Funcionario";
            dgvtb.Name = "Funcionario";
            dgvtb.Width = 180;
            this.dgvHoras.Columns.Add(dgvtb);

            // Agregamos la columna Lunes
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "HoraInicio";
            mtbc.Name = "HoraInicio";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            // Agregamos la columna Martes
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "HoraFin";
            mtbc.Name = "HoraFin";
            mtbc.Mask = maskHour;
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            // Agregamos la columna Miercoles
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Entrada";
            mtbc.Name = "Entrada";
            mtbc.Mask = "L";
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            // Agregamos la columna Jueves
            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Salida";
            mtbc.Name = "Salida";
            mtbc.Mask = "L";
            mtbc.Width = widthDaysColumn;
            this.dgvHoras.Columns.Add(mtbc);

            
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
        
        private void mtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            mtFecha.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtFecha.Text == "" )
            {
                mtFecha.Text = System.DateTime.Now.ToShortDateString();
            }
            mtFecha.TextMaskFormat = MaskFormat.IncludeLiterals;
            if (e.KeyCode == Keys.Enter && mtFecha.MaskFull)
            {
                int numFila = dgvHoras.Rows.Count;
                while (numFila > 0)
                {
                    numFila--;
                    dgvHoras.Rows.RemoveAt(numFila);
                    
                }
                dgvHoras.Refresh();
                
                List<Funcionario> listFunc = controller.obtenerFuncionariosControlDiaClienteServicio(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text),System.DateTime.Parse(mtFecha.Text));
                rellenarDatosDgvHoras(listFunc);
            }
            mtFecha.TextMaskFormat = MaskFormat.IncludeLiterals;
            
        }

        private void rellenarDatosDgvHoras(List<Funcionario> funcControlDiario)
        {
            foreach (Funcionario f in funcControlDiario)
            {
                List<DiaPlanificacion> listPlan = f.obtenerPlanificacionFuncionarioServicioDia(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text), System.DateTime.Parse(mtFecha.Text));
                foreach (DiaPlanificacion dp in listPlan)
                {
                    int num = dgvHoras.Rows.Add();
                    dgvHoras.Rows[num].Cells["Numero"].Value = f.getNumero().ToString();
                    dgvHoras.Rows[num].Cells["Funcionario"].Value = f.getNombre() + " " + f.getApellido();
                    dgvHoras.Rows[num].Cells["HoraInicio"].Value = dp.getHoraMinInicio().ToString();
                    dgvHoras.Rows[num].Cells["HoraFin"].Value = dp.getHoraMinFin().ToString();
                    dgvHoras.Rows[num].Cells["Entrada"].Value = "";
                    dgvHoras.Rows[num].Cells["Salida"].Value = "";
                    if (dp.getEntradaMarcada())
                        dgvHoras_MarcarFilas(num);
                    if (dp.getSalidaMarcada())
                        dgvHoras_MarcarFilas(num);
                }
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

        private void mtFecha_Enter(object sender, EventArgs e)
        {
            mtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
        }

        private void mtFecha_Leave(object sender, EventArgs e)
        {
            mtFecha.BackColor = Color.White;
        }


        private bool entradaMarcada(int numFila)
        {
            return (dgvHoras.Rows[numFila].Cells["Entrada"].Value.ToString() == "X");
            
        }

        private bool salidaMarcada(int numFila)
        {
            return (dgvHoras.Rows[numFila].Cells["Salida"].Value.ToString() == "X");
        }

        private void cancelarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dgvHoras.SelectedRows[0].Index;
            if (salidaMarcada(filaSeleccionada))
            {
                dgvHoras.Rows[filaSeleccionada].Cells["Salida"].Value = "";
                foreach (DataGridViewCell celda in dgvHoras.Rows[filaSeleccionada].Cells)
                {
                    celda.Style.BackColor = ColorEntradaFila;
                }
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dgvHoras.SelectedRows[0].Index;
            if (salidaMarcada(filaSeleccionada))
            {
                Type p = e.GetType();
                
                
                MessageBox.Show("No se puede cancelar la entrada, porque el registro tiene marcada la salida.");
            }
            else if (entradaMarcada(filaSeleccionada))
            {
                dgvHoras.Rows[filaSeleccionada].Cells["Entrada"].Value = "";
                foreach (DataGridViewCell celda in dgvHoras.Rows[filaSeleccionada].Cells)
                {
                    celda.Style.BackColor = ColorOriginalFila;
                }
            }

        }

        private void dgvHoras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                dgvHoras.Rows[e.RowIndex].Selected = true;
                menuStripdgvHoras.Show(dgvHoras,e.Location);
            }
        }

        private void dgvHoras_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                //MessageBox.Show("Mouse Tecla Izquierda clickeada dos veces");
                dgvHoras_MarcarFilas(e.RowIndex);
            }

        }
        private void dgvHoras_MarcarFilas(int numFila)
        {
            if (mtFecha.MaskFull)
            {
                try
                {
                    Funcionario fsel = controller.obtenerFuncionario(int.Parse(dgvHoras.Rows[numFila].Cells["Numero"].Value.ToString()));
                    int idCliente = int.Parse(mtCliente.Text);
                    int idServicio = int.Parse(mtServicio.Text);
                    string HoraIni = dgvHoras.Rows[numFila].Cells["HoraInicio"].Value.ToString();
                    DateTime fecha = DateTime.Parse(mtFecha.Text);
                    if (!entradaMarcada(numFila))
                    {
                        fsel.setEntradaPlanificacionDeFuncionarioServicioDia(idCliente, idServicio, fecha, HoraIni);
                        dgvHoras.Rows[numFila].Cells["Entrada"].Value = "X";

                        foreach (DataGridViewCell celda in dgvHoras.Rows[numFila].Cells)
                        {
                            celda.Style.BackColor = ColorEntradaFila;
                        }
                    }
                    else if (!salidaMarcada(numFila))
                    {
                        fsel.setSalidaPlanificacionDeFuncionarioServicioDia(idCliente, idServicio, fecha, HoraIni);
                        dgvHoras.Rows[numFila].Cells["Salida"].Value = "X";
                        foreach (DataGridViewCell celda in dgvHoras.Rows[numFila].Cells)
                        {
                            celda.Style.BackColor = ColorSalidaFila;
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
            else
                MessageBox.Show(this, "El campo de Fecha debe estar completado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cambiarFuncionario_Click(object sender, EventArgs e)
        {
           if (dgvHoras.SelectedRows[0].Cells["Entrada"].Value.ToString() != "")
                MessageBox.Show(this,"No se puede cambiar el funcionario si tiene marcada la entrada.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
           else
           {
                try
                {
                    int idFuncSeleccionado = int.Parse(dgvHoras.SelectedRows[0].Cells["Numero"].Value.ToString() );
                    string nombreFunc = dgvHoras.SelectedRows[0].Cells["Funcionario"].Value.ToString();
                    CambiarFuncionario change = new CambiarFuncionario(idFuncSeleccionado,nombreFunc);
                    DialogResult dg = change.ShowDialog(this);

                    if (dg == DialogResult.OK)
                    {
                        cambiarFuncionarioTabla(dgvHoras.SelectedRows[0].Index,change.getFuncionarioNuevo());

                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           }
        }

        private void cambiarFuncionarioTabla(int numFila, int idNuevoFunc)
        {
            try
            {
                // Elimino el dia planificacion del funcionario actual
                Funcionario f_actual = controller.obtenerFuncionario(int.Parse(dgvHoras.Rows[numFila].Cells["Numero"].Value.ToString()));
                string HoraIni = dgvHoras.Rows[numFila].Cells["HoraInicio"].Value.ToString();
                string HoraFin = dgvHoras.Rows[numFila].Cells["HoraFin"].Value.ToString();
                f_actual.eliminarDiaPlanificacion(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text), DateTime.Parse(mtFecha.Text), HoraIni, HoraFin);

                // Agrego el dia planificacion del funcionario nuevo
                Funcionario f_nuevo = controller.obtenerFuncionario(idNuevoFunc);
                f_nuevo.agregarDiaPlanificacion(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text), DateTime.Parse(mtFecha.Text), HoraIni, HoraFin);

                // Edito el funcionario en la fila del DataGridView
                dgvHoras.Rows[numFila].Cells["Numero"].Value = idNuevoFunc;
                dgvHoras.Rows[numFila].Cells["Funcionario"].Value = f_nuevo.getNombre() + " " + f_nuevo.getApellido();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void btnDiaSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                mtFecha.Text = DateTime.Parse(mtFecha.Text).AddDays(1).ToShortDateString();
                mtFecha.Focus();
                SendKeys.Send("{ENTER}");
            }
            catch (Exception ex)
            {
            }
        }

        private void btnDiaAnterior_Click(object sender, EventArgs e)
        {
            try
            {

                mtFecha.Text = DateTime.Parse(mtFecha.Text).AddDays(-1).ToShortDateString();
                mtFecha.Focus();
                SendKeys.Send("{ENTER}");
            }
            catch (Exception ex)
            {
            }
        }


        private void cambiarHoraIngreso_Click(object sender, EventArgs e)
        {
            if (dgvHoras.SelectedRows[0].Cells["Entrada"].Value.ToString() != "")
                MessageBox.Show(this, "No se puede cambiar lo hora de entrada si tiene marcada la entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    int idFuncSeleccionado = int.Parse(dgvHoras.SelectedRows[0].Cells["Numero"].Value.ToString());
                    string nombreFunc = dgvHoras.SelectedRows[0].Cells["Funcionario"].Value.ToString();
                    string horaini = dgvHoras.SelectedRows[0].Cells["HoraInicio"].Value.ToString();
                    CambiarHoraFuncionario changeHourForm = new CambiarHoraFuncionario(idFuncSeleccionado, nombreFunc,"Cambio de Hora de Entrada" , horaini);
                    DialogResult dg = changeHourForm.ShowDialog(this);

                    if (dg == DialogResult.OK)
                    {
                        cambiarHoraEntradaFuncionario(dgvHoras.SelectedRows[0].Index, changeHourForm.getHoraNueva());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cambiarHoraEntradaFuncionario(int numFila, string HoraNueva)
        {
            try
            {
                Funcionario f = controller.obtenerFuncionario(int.Parse(dgvHoras.Rows[numFila].Cells["Numero"].Value.ToString()));
                int idCliente = int.Parse(mtCliente.Text);
                int idServ = int.Parse(mtServicio.Text);
                DateTime fecha = DateTime.Parse(mtFecha.Text);
                string HoraIni = dgvHoras.Rows[numFila].Cells["HoraInicio"].Value.ToString();
                
                f.setHoraEntradaFuncionarioServicioDia(idCliente,idServ,fecha,HoraIni,HoraNueva);
                dgvHoras.Rows[numFila].Cells["HoraInicio"].Value = HoraNueva;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private void cambiarHoraFin_Click(object sender, EventArgs e)
        {
            if (dgvHoras.SelectedRows[0].Cells["Salida"].Value.ToString() != "")
                MessageBox.Show(this, "No se puede cambiar el funcionario si tiene marcada la salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    int idFuncSeleccionado = int.Parse(dgvHoras.SelectedRows[0].Cells["Numero"].Value.ToString());
                    string nombreFunc = dgvHoras.SelectedRows[0].Cells["Funcionario"].Value.ToString();
                    string horafin = dgvHoras.SelectedRows[0].Cells["HoraFin"].Value.ToString();
                    CambiarHoraFuncionario changeHourForm = new CambiarHoraFuncionario(idFuncSeleccionado, nombreFunc, "Cambio de Hora de Salida", horafin);
                    DialogResult dg = changeHourForm.ShowDialog(this);

                    if (dg == DialogResult.OK)
                    {
                        cambiarHoraSalidaFuncionario(dgvHoras.SelectedRows[0].Index, changeHourForm.getHoraNueva());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cambiarHoraSalidaFuncionario(int numFila, string HoraNueva)
        {
            try
            {
                Funcionario f = controller.obtenerFuncionario(int.Parse(dgvHoras.Rows[numFila].Cells["Numero"].Value.ToString()));
                // Un dia planificacion esta identificado por el cliente, servicio, dia y HoraInicio
                int idCliente = int.Parse(mtCliente.Text);
                int idServ = int.Parse(mtServicio.Text);
                DateTime fecha = DateTime.Parse(mtFecha.Text);
                string HoraIni = dgvHoras.Rows[numFila].Cells["HoraInicio"].Value.ToString();

                f.setHoraSalidaFuncionarioServicioDia(idCliente, idServ, fecha, HoraIni, HoraNueva);
                dgvHoras.Rows[numFila].Cells["HoraFin"].Value = HoraNueva;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
       


    */   
    }
}
