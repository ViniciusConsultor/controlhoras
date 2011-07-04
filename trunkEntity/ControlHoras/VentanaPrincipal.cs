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
        List<string> listaControles;
        public String userName { get; set; }
        public int idUsuarioLogueado { get; set; }

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            try
            {
                ContratoForm contrato = new ContratoForm();
                contrato.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(this, "Desea Salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( res == DialogResult.Yes)
                Application.Exit();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMClientes clientes = ABMClientes.getVentana();
                if (clientes.Visible == false)
                    clientes.Show(this);
                else
                    clientes.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMCargos categ = ABMCargos.getVentana();
                if (categ.Visible == false)
                    categ.Show(this);
                else
                    categ.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                login.StartPosition = FormStartPosition.CenterParent;
                DialogResult res = login.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    userName = login.username;
                    idUsuarioLogueado = login.idUsuarioLogueado;
                    tsslUsuario.Text = login.username;
                    tsslIdUsuarioLogueado.Text = login.idUsuarioLogueado.ToString();
                    cargarPermisos(tsslUsuario.Text);
                }
                else
                    Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarPermisos(string UserName)
        {
            try
            {
                List<Datos.PerMisOControl> listapermisos = Datos.DatosABMTipos.getInstance().obtenerListaPermisosUsuarioPantalla(UserName,this.Name);
                listaControles = new List<string>();
                bool encontrado;
                foreach(Datos.PerMisOControl pc in listapermisos)
                {
                    encontrado = false;
                    foreach (ToolStripItem c in menuBotones.Items)
                    {
                        if (c.GetType().ToString() == pc.NettYpe && c.Name == pc.Nombre)
                        {
                            c.Enabled = true;
                            encontrado = true;
                            break;
                        }
                        //else
                        //    c.Enabled = false;
                    }
                    if (!encontrado)
                        foreach (ToolStripItem c in menuStripSuperior.Items)
                        {
                            if (c.GetType().ToString() == pc.NettYpe && c.Name == pc.Nombre)
                            {
                                encontrado = true;
                                c.Enabled = true;
                                break;
                            }
                            if (!encontrado)
                            {
                                if (c.GetType() == typeof(ToolStripMenuItem))
                                    foreach (ToolStripItem cc in ((ToolStripMenuItem)c).DropDownItems)
                                    {
                                        if (cc.GetType().ToString() == pc.NettYpe && cc.Name == pc.Nombre)
                                        {
                                            encontrado = true;
                                            cc.Enabled = true;
                                            break;
                                        }

                                    }
                            }
                           
                        }

                }
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        


        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicioForm ser = new ServicioForm();
            DialogResult res = ser.ShowDialog(this);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMEmpleados empls = ABMEmpleados.getVentana();
                
                if (empls.Visible == false)
                    empls.Show(this);
                else
                    empls.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emergenciasMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMEmergenciasMedica eme = ABMEmergenciasMedica.getVentana();
                if (eme.Visible == false)
                    eme.Show(this);
                else
                    eme.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mutualistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMMutualistas mutu = ABMMutualistas.getVentana();
                if (mutu.Visible == false)
                    mutu.Show(this);
                else
                    mutu.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMBancos banco = ABMBancos.getVentana();
                if (banco.Visible == false)
                    banco.Show(this);
                else
                    banco.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMDepartamentos depa = ABMDepartamentos.getVentana();
                if (depa.Visible == false)
                    depa.Show(this);
                else
                    depa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMTiposDocumento tiposDoc = ABMTiposDocumento.getVentana();
                if (tiposDoc.Visible == false)
                    tiposDoc.Show(this);
                else
                    tiposDoc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ABMEmpleados em = ABMEmpleados.getVentana();
                if (em.Visible == true)
                {
                    em.Focus();
                }
                else
                {
                    em.Show(this);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
               ABMClientes cli = ABMClientes.getVentana();
               if (cli.Visible == false)
                   cli.Show(this);
               else
                   cli.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tiposDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
           {
                ABMTipoEventoHistorial tiposevento = ABMTipoEventoHistorial.getVentana();
                if (tiposevento.Visible == false)
                    tiposevento.Show(this);
                else
                    tiposevento.Focus();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMCargos cargos = ABMCargos.getVentana();
                if (cargos.Visible == false)
                    cargos.Show(this);
                else
                    cargos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel ex = ExportToExcel.getInstance();
                if (ex.Visible == false)
                    ex.Show(this);
                else
                    ex.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cambiarNúmeroEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarNumeroEmpleado cambiarNumEmpleado = CambiarNumeroEmpleado.getVentana();
                if (cambiarNumEmpleado.Visible == false)
                    cambiarNumEmpleado.Show(this);
                else
                    cambiarNumEmpleado.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaNegraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMLNegra listaNegra = ABMLNegra.getVentana();
                if (listaNegra.Visible == false)
                    listaNegra.Show(this);
                else
                    listaNegra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMTipoExtraLiquidacion depa = ABMTipoExtraLiquidacion.getVentana();
                if (depa.Visible == false)
                    depa.Show(this);
                else
                    depa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMBarrios depa = ABMBarrios.getVentana();
                if (depa.Visible == false)
                    depa.Show(this);
                else
                    depa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEscalafon_Click(object sender, EventArgs e)
        {
            try
            {
                EscalafonForm depa = EscalafonForm.getVentana();
                if (depa.Visible == false)
                    depa.Show(this);
                else
                    depa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ControlDiario ex = ControlDiario.getInstance();
                if (ex.Visible == false)
                    ex.Show(this);
                else
                    ex.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tiposMotivosCambioDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMTiposMotivoCambioDiario depa = ABMTiposMotivoCambioDiario.getVentana();
                if (depa.Visible == false)
                    depa.Show(this);
                else
                    depa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generarHorasDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarHorasDiariasForm ghdf = new GenerarHorasDiariasForm();
            ghdf.ShowDialog(this);
        }

        private void sustituirEnEscalafonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SustituirFuncionarioEsc ex = SustituirFuncionarioEsc.getVentana();
                if (ex.Visible == false)
                    ex.Show(this);
                else
                    ex.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consolidarEscalafonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ConsolidarEscalafonesForm cef = new ConsolidarEscalafonesForm();
                cef.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ABMUsuarios cef = new ABMUsuarios();
                cef.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarPasswordUsuario cpu = new CambiarPasswordUsuario(int.Parse(tsslIdUsuarioLogueado.Text));
                cpu.StartPosition = FormStartPosition.CenterParent;
                cpu.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = ofdCargarArchivoImportacionConsultas.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                
              //   = ofdCargarArchivoImportacionConsultas.FileName.ToString();
              //  Bitmap imgAchicada = new Bitmap(img, pbFoto.Width, pbFoto.Height);
              //  pbFoto.Image = (System.Drawing.Image)imgAchicada;
            }
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                LiquidaciónEmpleados cef = new LiquidaciónEmpleados();
                cef.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FacturacionClientes cef = new FacturacionClientes();
                cef.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tspTipoExtraLiquidacion_Click(object sender, EventArgs e)
        {
            try
            {
                ABMTipoExtraLiquidacion ventana = ABMTipoExtraLiquidacion.getVentana();
                if (ventana.Visible == false)
                    ventana.Show(this);
                else
                    ventana.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }
    }
}
