using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Datos;

namespace ControlHoras
{
    public partial class ShowContrato : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();
        private IDatos datos = ControladorDatos.getInstance();

        public ShowContrato()
        {
            InitializeComponent();
        }

        public ShowContrato(int NroContrato)
        {
            InitializeComponent();
            
            InicializarCargaHorariaDGV();
            CargarCargaHorariaDGV(NroContrato);
        }

        public ShowContrato(int NroCliente, int NroServicio, int NroContrato)
        {
            InitializeComponent();

            try
            {
                ClienteLBL.Text = NroCliente.ToString() + " - " + datos.getNombreCliente(NroCliente);
                ServicioLBL.Text = NroServicio.ToString() + " - " + datos.getNombreServicio(NroCliente,NroServicio);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                             
            }
            
            InicializarCargaHorariaDGV();
            CargarCargaHorariaDGV(NroContrato);
        }

        private void InicializarCargaHorariaDGV()
        {
            MaskedTextBoxColumn mtbc;

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Cantidad";
            mtbc.HeaderText = "Cantidad";
            mtbc.Mask = @"00";
            mtbc.Width = 86;            
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "PrecioXHora";
            mtbc.HeaderText = "PrecioXHora";
            mtbc.Mask = @"$ 00";
            mtbc.Width = 86;            
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Lunes";
            mtbc.HeaderText = "Lunes";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;            
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Martes";
            mtbc.HeaderText = "Martes";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;            
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Miercoles";
            mtbc.HeaderText = "Miercoles";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;            
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Jueves";
            mtbc.HeaderText = "Jueves";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;            
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Viernes";
            mtbc.HeaderText = "Viernes";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;            
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Sabado";
            mtbc.HeaderText = "Sabado";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;            
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Domingo";
            mtbc.HeaderText = "Domingo";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;            
            this.CargaHorariaDGV.Columns.Add(mtbc);
        }

        private void CargarCargaHorariaDGV(int NroCon)
        {
            try
            {
                ConSeguridadFisica con = null;
                
                if (datos.existeContrato(NroCon))
                {
                    con = sistema.getContrato(NroCon);
                    
                    int i = 0;
                    DataGridViewRow insr = null;
                    foreach (LineaDeHoras l in con.getLineas())
                    {
                        insr = new DataGridViewRow();
                        object[] param = { l.getPuesto(), (l.getArmado()) ? "1" : "0", l.getCantEmp().ToString(), "$U " + l.getCostoH().ToString() };

                        insr.CreateCells(CargaHorariaDGV, param);

                        CargaHorariaDGV.Rows.Add(insr);

                        foreach (HorarioXDia h in l.getHorario())
                        {
                            CargaHorariaDGV.Rows[i].Cells[h.getDia()].Value = h.getHoraIni() + " a " + h.getHoraFin();
                            //insr.Cells[h.getDia()].Value = h.getHoraIni() + " a " + h.getHoraFin();
                        }

                        // Carga los N/T
                        for (int j = 4; j < 11; j++)
                        {
                            if (CargaHorariaDGV.Rows[i].Cells[j].Value == null)
                                CargaHorariaDGV.Rows[i].Cells[j].Value = @"N/T";
                        }

                        i++;

                    }                   
                }
                //else
                //    FIniMTB.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
