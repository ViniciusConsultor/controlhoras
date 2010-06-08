using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using System.Drawing;
using System.IO;
using System.Globalization;
using Utilidades;
using Datos;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Configuration;


namespace ControlHoras
{
    public partial class ABMEmpleados : Form
    {

        private IEmpleados sistema;
        private IDatos datos;
        private IDatosABMTipos datosTipos;
        private IABMTipos tipos;


        // Lista de datos que se mantienen para su posterior consulta
        private List<TipOsEventOHistOrIal> listaTiposEventos;
        private List<TipOscarGoS> cargos;

        private string LlenarCamposObligatorios = "Debe llenar todos los campos obligatorios.";
        private string fechaMask = @"  /  /";

        // Para impresiones
        private object missing = null;//System.Reflection.Missing.Value;
        private string exefile = null;//Application.ExecutablePath;
        private FileInfo Info = null;//new FileInfo(exefile);
        private string dirbase = null;//Info.Directory.Parent.Parent.FullName;
        private string dirRelativaDocs = "Docs";



        static ABMEmpleados ventana = null;
        public static ABMEmpleados getVentana()
        {
            if (ventana == null)
                ventana = new ABMEmpleados();
            return ventana;
        }

        public ABMEmpleados()
        {
            InitializeComponent();
            //   this.Disposed += new EventHandler(Disposed);
            try
            {
                sistema = ControladorEmpleados.getInstance();
                datos = ControladorDatos.getInstance();
                datosTipos = DatosABMTipos.getInstance();
                tipos = ControladorABMTipos.getInstance();
            }
            catch (Exception ex1)
            {
                throw ex1;
            }
            try
            {
                missing = System.Reflection.Missing.Value;
                exefile = Application.ExecutablePath;
                Info = new FileInfo(exefile);
                //dirbase = Info.Directory.Parent.Parent.FullName;
                dirbase = Info.DirectoryName;//System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                
                try
                {
                    dirRelativaDocs = ConfigurationManager.AppSettings["DirectorioRelativoDocs"].ToString();
                }
                catch (Exception exDirDocs)
                {
                    // no hago nada. Queda con el valor que tiene por default.
                }
                try
                {
                    //dirbase = ConfigurationManager.AppSettings["DocsPath"].ToString();
                }
                catch (Exception exDir)
                {
                    // no hago nada. Queda con el valor que tiene por default.
                }
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
        }

        private void ABMEmpleados_Load(object sender, EventArgs e)
        {
            #region CargaCombos



            // Combo TiposDocumentos
            //try
            //{
            //    Dictionary<int, string> docs = tipos.obtenerTipoDocumentos(false);                
            //    CargarCombo(cmbTipoDocumento, docs);

            //}catch(Exception ex){
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


          
            // Combo Departamentos
            try
            {
                updateListOfDepartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Combo Ciudades
            try
            {
                updateListOfCiudades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Combo Barrios
            try
            {
                updateListOfBarrios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Combo EmergenciaMedica
            try
            {
                updateListOfEmergenciaMedica();

                //cmbEmergenciaMedica.BeginUpdate();                
                //foreach (int key in docs.Keys)
                //{
                //    ComboBoxValue cbval = new ComboBoxValue(docs[key], key);
                //    cmbEmergenciaMedica.Items.Add(cbval);
                //}
                //cmbEmergenciaMedica.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Combo Mutualistas
            try
            {
                updateListOfMutualistas();
                //cmbMutualista.ValueMember = "Value";
                //cmbMutualista.DisplayMember = "Display";
                //cmbMutualista.BeginUpdate();
                //foreach (int key in docs.Keys)
                //{
                //    ComboBoxValue cbval = new ComboBoxValue(docs[key], key);
                //    cmbMutualista.Items.Add(cbval);
                //}
                //cmbMutualista.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Combo TipoEventosHistorial
            try
            {
                updateListOfTiposEventoHistorialCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cargar TiposCargos
            try
            {
                cargos = datosTipos.obtenerTiposCargosList(true);
                updateListOfCargos();


                /*cmbTiposCargos.ValueMember = "Value";
                cmbTiposCargos.DisplayMember = "Display";
                cmbTiposCargos.BeginUpdate();
                foreach (TipOscarGoS tipo in cargos)
                {
                    ComboBoxValue cbval = new ComboBoxValue(tipo.Nombre, (int)tipo.IDCargo);
                    cmbTiposCargos.Items.Add(cbval);
                }
                cmbTiposCargos.EndUpdate();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error Cargando las Cargos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

          //  btnCancelar.PerformClick();
            mtNumeroDocumento.ContextMenu = new ContextMenu();
           
            mtNumeroDocumento.Focus();
        }

        private void CargarCombo(ComboBox cmb, Dictionary<int, string> docs)
        {


            BindingSource bs = new BindingSource();
            bs.DataSource = docs;
           
            cmb.ValueMember = "Key";
            cmb.DisplayMember = "Value";
           
            if (cmb.DataSource != null)
            {
                cmb.BindingContext[cmb.DataSource].SuspendBinding();
                cmb.DataSource = bs;
                cmb.BindingContext[cmb.DataSource].ResumeBinding();
            }
            else
                cmb.DataSource = bs;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            dgvExtrasLiquidacion.Rows.Clear();
            limpiarTabExtrasLiquidacion();
            dgvHistorialEmpleado.Rows.Clear();
            limpiarTabHistorial();
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = false;
            BtnReactivar.Visible = false;
            btnAgregarHistorial.Enabled = false;
            btnGuardarHistorial.Enabled = false;
            btnEliminarHistorial.Enabled = false;
            btnExtrasAgregar.Enabled = false;
            btnExtrasEliminar.Enabled = false;
            btnExtrasGuardar.Enabled = false;
            ImprimirTSB.Enabled = false;
            dtpFechaIngreso.Text = DateTime.Now.ToString();
            dtpFechaAltaBPS.Text = DateTime.Now.ToString();
            tcEmpleado.SelectedIndex = 0;
            //mtNumeroEmpleado.Focus();
            mtNumeroDocumento.Focus();
        }


        private void limpiarForm()
        {
            cmbNivelEducativo.SelectedIndex = 0;
            rbAntecedentes_NO.Checked = true;
            lblEstadoEmpleado.Visible = false;

            foreach (TabPage tp in tcEmpleado.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    string tipoDelControl;
                    tipoDelControl = c.GetType().ToString();
                    if (tipoDelControl == "ControlHoras.TextBoxKeyDown" || tipoDelControl == "ControlHoras.MaskedTextBoxKeyDown")
                        c.Text = "";
                    else if (tipoDelControl == "System.Windows.Forms.CheckBox")
                        ((CheckBox)c).Checked = false;
                    else if (tipoDelControl == "System.Windows.Forms.GroupBox")
                    {
                        foreach (Control cgb in c.Controls)
                        {
                            if (cgb.GetType().ToString() == "ControlHoras.TextBoxKeyDown" || cgb.GetType().ToString() == "ControlHoras.MaskedTextBoxKeyDown")
                                cgb.Text = "";
                            else if (cgb.GetType().ToString() == "ControlHoras.ComboBoxKeyDown")
                            {
                                if (((ComboBox)cgb).Items.Count > 0)
                                    ((ComboBox)cgb).SelectedIndex = 0;
                            }
                            else if (cgb.GetType().ToString() == "System.Windows.Forms.CheckBox")
                                ((CheckBox)cgb).Checked = false;
                        }
                    }

                    else if (tipoDelControl == "System.Windows.Forms.PictureBox")
                    {
                        ((PictureBox)c).Image = null;
                    }

                    lblEmpleadoCargado.Text = "";
                    lblEdad.Text = "";

                }
            }
        }

        private void limpiarForm2()
        {
            cmbNivelEducativo.SelectedIndex = 0;
            rbAntecedentes_NO.Checked = true;
            lblEstadoEmpleado.Visible = false;

            foreach (TabPage tp in tcEmpleado.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    string tipoDelControl;
                    tipoDelControl = c.GetType().ToString();
                    if (tipoDelControl == "ControlHoras.TextBoxKeyDown" || tipoDelControl == "ControlHoras.MaskedTextBoxKeyDown")
                    {
                        if (c.Name != "mtNumeroEmpleado" && c.Name != "mtNumeroDocumento")
                            c.Text = "";
                    }
                    else if (tipoDelControl == "System.Windows.Forms.CheckBox")
                        ((CheckBox)c).Checked = false;
                    else if (tipoDelControl == "System.Windows.Forms.GroupBox")
                    {
                        foreach (Control cgb in c.Controls)
                        {
                            if (cgb.GetType().ToString() == "ControlHoras.TextBoxKeyDown" || cgb.GetType().ToString() == "ControlHoras.MaskedTextBoxKeyDown")
                            {
                                if (cgb.Name != "mtNumeroEmpleado" && cgb.Name != "mtNumeroDocumento")
                                    cgb.Text = "";
                            }
                            else if (cgb.GetType().ToString() == "ControlHoras.ComboBoxKeyDown")
                            {
                                if (((ComboBox)cgb).Items.Count > 0)
                                    ((ComboBox)cgb).SelectedIndex = 0;
                            }
                            else if (cgb.GetType().ToString() == "System.Windows.Forms.CheckBox")
                                ((CheckBox)cgb).Checked = false;
                        }
                    }

                    else if (tipoDelControl == "System.Windows.Forms.PictureBox")
                    {
                        ((PictureBox)c).Image = null;
                    }

                    lblEmpleadoCargado.Text = "";
                    lblEdad.Text = "";
                }
            }
        }

        private void limpiarForm3()
        {
            cmbNivelEducativo.SelectedIndex = 0;
            rbAntecedentes_NO.Checked = true;
            lblEstadoEmpleado.Visible = false;
            lblEmpleadoCargado.Text = "";
            lblEdad.Text = "";

            foreach (TabPage tp in tcEmpleado.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    string tipoDelControl;
                    tipoDelControl = c.GetType().ToString();
                    if (tipoDelControl == "ControlHoras.TextBoxKeyDown" || tipoDelControl == "ControlHoras.MaskedTextBoxKeyDown")
                    {
                        if (c.Name != "mtNumeroDocumento")
                            c.Text = "";
                    }
                    else if (tipoDelControl == "System.Windows.Forms.CheckBox")
                        ((CheckBox)c).Checked = false;
                    else if (tipoDelControl == "System.Windows.Forms.GroupBox")
                    {
                        foreach (Control cgb in c.Controls)
                        {
                            if (cgb.GetType().ToString() == "ControlHoras.TextBoxKeyDown" || cgb.GetType().ToString() == "ControlHoras.MaskedTextBoxKeyDown")
                            {
                                if (cgb.Name != "mtNumeroDocumento")
                                    cgb.Text = "";
                            }
                            else if (cgb.GetType().ToString() == "ControlHoras.ComboBoxKeyDown")
                            {
                                if (((ComboBox)cgb).Items.Count > 0)
                                    ((ComboBox)cgb).SelectedIndex = 0;
                            }
                            else if (cgb.GetType().ToString() == "System.Windows.Forms.CheckBox")
                                ((CheckBox)cgb).Checked = false;
                        }
                    }

                    else if (tipoDelControl == "System.Windows.Forms.PictureBox")
                    {
                        ((PictureBox)c).Image = null;
                    }                    
                }
            }
        }

        private void mtNumeroEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtNumeroEmpleado.Text != "" && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                // traigo el empleado y lleno los datos de los campos.                
                EmPleadOs empleado;

                try
                {                    
                    if (sistema.existeEmpleado(int.Parse(mtNumeroEmpleado.Text)))
                    {
                        empleado = datos.obtenerEmpleado(int.Parse(mtNumeroEmpleado.Text));
                        limpiarForm();
                        if (empleado.Activo == 1)
                        {
                            
                            habilitarPermisosEmpleado(true);
                            //lblEstadoEmpleado.Visible = true;
                            //lblEmpleadoCargado.Text = mtNumeroEmpleado.Text + " - " + txtNombre.Text + " " + txtApellido.Text;
                            //btnAgregar.Enabled = false;
                            //btnGuardar.Enabled = true;
                            //BtnReactivar.Visible = false;
                            //btnExtrasAgregar.Enabled = true;
                            //btnAgregarHistorial.Enabled = true;
                            //ImprimirTSB.Enabled = true;
                        }
                        else
                        {
                            habilitarPermisosEmpleado(false);
                            //lblEstadoEmpleado.Visible = true;
                            //lblEmpleadoCargado.Text = mtNumeroEmpleado.Text + " - " + txtNombre.Text + " " + txtApellido.Text;
                            //btnAgregar.Enabled = false;
                            //btnGuardar.Enabled = false;
                            //BtnReactivar.Visible = true;
                            //btnExtrasAgregar.Enabled = false;
                            //btnAgregarHistorial.Enabled = false;
                            //ImprimirTSB.Enabled = false;
                        }
                        cargarEmpleado(empleado);
                    }
                    else
                    {
                        limpiarForm2();
                        btnAgregar.Enabled = true;
                        btnGuardar.Enabled = false;
                        btnExtrasAgregar.Enabled = false;
                        btnAgregarHistorial.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                // abro la ventana de busqueda de empleados.
                btnBuscarEmpleado.PerformClick();

            }
            else if (mtNumeroEmpleado.Text == "" && e.KeyCode == Keys.Enter)
            {
                mtNumeroEmpleado.Text = (datos.obtenerMaxIdEmpleado() + 1).ToString();
                //limpiarForm2();
                btnAgregar.Enabled = true;
                btnGuardar.Enabled = false;
                btnExtrasAgregar.Enabled = false;
                btnAgregarHistorial.Enabled = false;
                //txtApellido.Focus();
            }
        }

        private void cargarEmpleado(EmPleadOs empleado)
        {
            //try
            //{
            //    empleado.Antecedentes = false;
            //}
            //catch (Exception e) { }
            if (empleado.AntecedentesPolicialesOmIlitares == 1)
                cbAntecedentePolicialoMilitar.Checked = true;
            else
                cbAntecedentePolicialoMilitar.Checked = false;
            if (empleado.PolicialesoMilitar != null)
                cmbPolicialMilitar.SelectedIndex = (int)empleado.PolicialesoMilitar;

            try
            {
                txtApellido.Text = empleado.Apellido;
            }
            catch (Exception e) { }
            try
            {
                cmbTurno.SelectedItem = empleado.Turno;
            }
            catch (Exception e) { }
            //try
            //{
            //    txtBarrio.Text = empleado.Barrio;
            //}
            //catch (Exception e) { }
            try
            {
                txtCodigoPostal.Text = empleado.CodigoPostal;
            }
            catch (Exception e) { }
            try
            {
                mtAcumulacionBPS.Text = empleado.BpsaCumulacionLaboral.ToString();

            }
            catch (Exception e) { }
            try
            {
                if (empleado.BpsfEchaAlta != null)
                    dtpFechaAltaBPS.Text = empleado.BpsfEchaAlta.Value.ToString();
            }
            catch (Exception e) { }

            try
            {
                cbBajadoBPS.Checked = (empleado.BpseSBaja == 1);
            }
            catch (Exception e) { }


            try
            {
                if (empleado.BpsfEchaBaja != null)
                    dtpFechaBajaBPS.Text = empleado.BpsfEchaBaja.Value.ToString();
            }
            catch (Exception e) { }

            //try
            //{
            //    if (empleado.MtssfEchaAlta != null)
            //        dtpFechaAltaMTSS.Text = empleado.MtssfEchaAlta.Value.ToString();
            //}
            //catch (Exception e) { }

            //try
            //{
            //    cbBajadoMTSS.Checked = (empleado.MtsseSBaja == 1);
            //}
            //catch (Exception e) { }

            //try
            //{
            //    if (empleado.MtssfEchaBaja != null)
            //        dtpFechaBajaMTSS.Text = empleado.MtssfEchaBaja.Value.ToString();
            //}
            //catch (Exception e) { }

            try
            {
                if (empleado.FechaPagoEfectuado != null)
                    mtFechaPagoEfectuado.Text = empleado.FechaPagoEfectuado.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.FechaPrevistaPago != null)
                    mtFechaPrevistaPago.Text = empleado.FechaPrevistaPago.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.CajfEchaEmision != null)
                    dtpFechaEmisionCAJ.Text = empleado.CajfEchaEmision.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.CajfEchaEntrega != null)
                    dtpFechaEntregaCAJ.Text = empleado.CajfEchaEntrega.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                txtNumeroCAJ.Text = empleado.CajnUmero;
            }
            catch (Exception e) { }
            try
            {
                mtCantidadHijos.Text = empleado.CantidadMenoresAcArgo.ToString();
            }
            catch (Exception e) { }
            if (empleado.CapacitadoPortarArma == 1)
                cbCapacitadoPorteArma.Checked = true;
            else
                cbCapacitadoPorteArma.Checked = false;
            try
            {
                txtCelular.Text = empleado.Celular;
            }
            catch (Exception e) { }
            try
            {
                txtCelularConvenio.Text = empleado.CelularenConvenio;
            }
            catch (Exception e) { }
            //try
            //{
            //    txtCiudad.Text = empleado.Ciudad;
            //}
            //catch (Exception e) { }
            try
            {
                if (empleado.CombatienteMilitar == 1)
                    cbCombatiente.Checked = true;
                else
                    cbCombatiente.Checked = false;
            }
            catch (Exception e) { }
            try
            {
                cmbDepartamento.SelectedValue = (int)empleado.IDDepartamento;
            }
            catch (Exception e) { }
            try
            {
                cmbCiudades.SelectedValue = (int)empleado.IDCiudad;
            }
            catch (Exception e) { }
            try
            {
                cmbBarrios.SelectedValue = (int)empleado.IDBarrio;
            }
            catch (Exception e) { }

            try
            {
                txtDireccion.Text = empleado.Direccion;
            }
            catch (Exception e) { }
            try
            {
                txtPuntoEncuentro.Text = empleado.DireccionDeEncuentro;
            }
            catch (Exception e) { }
            try
            {
                lblEdad.Text = empleado.Edad.ToString();
            }
            catch (Exception e) { }
            try
            {
                txtEmail.Text = empleado.Email;
            }
            catch (Exception e) { }
            try
            {
                cmbEmergenciaMedica.SelectedValue = (int)empleado.IDEmergenciaMedica;
                //cmbEmergenciaMedica.SelectedIndex = cmbEmergenciaMedica.Items.IndexOf((int)empleado.IDEmergenciaMedica);

            }
            catch (Exception e) { }
            try
            {
                txtEntreCalles.Text = empleado.EntreCalles;
            }
            catch (Exception e) { }
            try
            {
                cmbEstadoCivil.SelectedItem = empleado.EstadoCivil;
            }
            catch (Exception e) { }

            try
            {
                if (empleado.Activo == 1)
                {
                    lblEstadoEmpleado.Text = "Activo";
                    lblEstadoEmpleado.ForeColor = Color.LimeGreen;
                }
                else
                {
                    cbNoActivo.Checked = true;
                    lblEstadoEmpleado.Text = "Inactivo";
                    lblEstadoEmpleado.ForeColor = Color.Red;
                }
            }
            catch (Exception e) { }

            try
            {
                if (empleado.FechaBaja != null)
                    dtpFechaBaja.Text = empleado.FechaBaja.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.FechaEgresoPolicialoMilitar != null)
                    dtpFechaEgresoPolicialMilitar.Text = empleado.FechaEgresoPolicialoMilitar.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.FechaIngreso != null)
                    dtpFechaIngreso.Text = empleado.FechaIngreso.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.RenaemsefEchaIngreso != null)
                    dtpFechaIngresoRenaemse.Text = empleado.RenaemsefEchaIngreso.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.FechaIngresoPolicialoMilitar != null)
                    dtpFechaIngresoPolicialMilitar.Text = empleado.FechaIngresoPolicialoMilitar.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.FechaNacimiento != null)
                    dtpFechaNacimiento.Text = empleado.FechaNacimiento.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.FechaTestPsicologico != null)
                    dtpPsicologo.Text = empleado.FechaTestPsicologico.Value.ToString();
            }
            catch (Exception e) { }

            try
            {
                if (empleado.FechaEntregaCelular != null)
                    dtpFechaEntregaCelular.Text = empleado.FechaEntregaCelular.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                if (empleado.ConstanciaDomicilio == 1)
                    cbConstanciaDomicilio.Checked = true;
            }
            catch (Exception e) { }

            try
            {
                if (empleado.FechaVencimientoCarneDeSalud != null)
                    dtpFechaVencimientoCarneSalud.Text = empleado.FechaVencimientoCarneDeSalud.Value.ToString();
            }
            catch (Exception e) { }
            try
            {
                System.Drawing.Image img = ControladorUtilidades.convertByteArrayToImage(empleado.Foto);
                if (img != null)
                    pbFoto.Image = img;
            }
            catch (Exception e) { }
            try
            {
                txtLugarNacimiento.Text = empleado.LugarDeNacimiento;
            }
            catch (Exception e) { }
            try
            {
                txtMotivoBaja.Text = empleado.MotivoBaja;
            }
            catch (Exception e) { }
            try
            {
                cmbMutualista.SelectedValue = (int)empleado.IDMutualista;
            }
            catch (Exception e) { }           
            try
            {
                txtNombre.Text = empleado.Nombre;
            }
            catch (Exception e) { }
            try
            {
                txtNumAsuntoRenaemse.Text = empleado.RenaemsenUmeroAsunto;
            }
            catch (Exception e) { }
            try
            {
                txtServicioActual.Text = empleado.ServicioActual;
            }
            catch (Exception e) { }
            try
            {
                mtNumeroDocumento.Text = empleado.NumeroDocumento;
            }
            catch (Exception e) { }
            try
            {
                mtNumeroEmpleado.Text = empleado.NroEmpleado.ToString();
            }
            catch (Exception e) { }
            try
            {
                empleado.Observaciones = empleado.Observaciones;
            }
            catch (Exception e) { }

            if (empleado.EnServicioArmado == 0)
                cbEnServicioArmado.Checked = false;
            else
                cbEnServicioArmado.Checked = true;
            try
            {
                if (empleado.SexO == "F")
                    rbFemenino.Checked = true;
                else
                    rbMasculino.Checked = true;
            }
            catch (Exception e) { }
            try
            {
                txtPolicialSubEscalafon.Text = empleado.SubEscalafonPolicial;
            }
            catch (Exception e) { }
            try
            {
                txtValorHora.Text = empleado.ValorHora.ToString();
            }
            catch (Exception e) { }
            try
            {
                txtTallePantalon.Text = empleado.TalleCamisa;
            }
            catch (Exception e) { }
            try
            {
                txtTalleCampera.Text = empleado.TalleCampera;
            }
            catch (Exception e) { }
            try
            {
                txtTalleCamisa.Text = empleado.TallePantalon;
            }
            catch (Exception e) { }
            try
            {
                mtTalleZapatos.Text = empleado.TalleZapatos.ToString();
            }
            catch (Exception e) { }
            try
            {
                txtTelefono.Text = empleado.Telefonos;
            }
            catch (Exception e) { }
            try
            {
                txtObservaciones.Text = empleado.Observaciones;
            }
            catch (Exception e) { }
            try
            {
                if (empleado.ObservacionesAntecedentes != null)
                {
                    rbAntecedentes_SI.Checked = true;
                    txtObservacionesAntecedentes.Text = empleado.ObservacionesAntecedentes;
                }
            }
            catch (Exception e) { }
            //try
            //{
            //    // Chequear porque el Selected index no deberia ser igual al IdTipoDocumento.
            //    cmbTipoDocumento.SelectedValue = (int)empleado.IDTipoDocumento;
            //}
            //catch (Exception e) { }
            try
            {
                // Chequear porque el Selected index no deberia ser igual al IdTipoDocumento.
                cmbNivelEducativo.Text = empleado.NivelEducativo;
            }
            catch (Exception e) { }
            try
            {
                // Chequear porque el Selected index no deberia ser igual al IdTipoDocumento.
                cmbTiposCargos.SelectedValue = (int)empleado.IDCargo;
            }
            catch (Exception e) { }

            if (empleado.FechaNacimiento != null)
                lblEdad.Text = calcularEdad(DateTime.ParseExact(dtpFechaNacimiento.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo)).ToString();

            //try
            //{
            //    if (empleado.FechaPagoFinal != null)
            //    {
            //        cbEgresadoEmpresa.Checked = true;
            //        mtFechaPagoEfectuado.Text = empleado.FechaPagoFinal.Value.ToString();
            //    }
            //}
            //catch (Exception e) { }

            cargarHistorialEmpleado((int)empleado.NroEmpleado);
            dtpExtrasFecha.Value = DateTime.Today;
            cargarGrillaExtraLiquidacionEmpleado();
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {

            if (pbFoto.Image != null)
            {
                pbFoto.Image.Dispose();
                pbFoto.Image = null;
            }
            try
            {
                DialogResult res = ofdFoto.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    System.Drawing.Image img = devolverImagen(ofdFoto.FileName.ToString());
                    Bitmap imgAchicada = new Bitmap(img, pbFoto.Width, pbFoto.Height);
                    pbFoto.Image = (System.Drawing.Image)imgAchicada;
                }

            }
            catch (Exception ioe)
            {
                MessageBox.Show(this, ioe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private System.Drawing.Image devolverImagen(string fileName)
        {
            System.Drawing.Image result;

            long size = (new FileInfo(fileName)).Length;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[size];
            try
            {
                fs.Read(data, 0, (int)size);
            }
            finally
            {
                fs.Close();
                fs.Dispose();
            }

            // Convertir bytes a imagen

            MemoryStream ms = new MemoryStream();
            ms.Write(data, 0, (int)size);
            result = new Bitmap(ms);
            ms.Close();

            return result;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkDatosObligatorios())
            {

                try
                {
                    agregarOModificarEmpleado(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool checkDatosObligatorios()
        {
            return (mtNumeroEmpleado.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && mtNumeroDocumento.MaskCompleted);
        }

        private void agregarOModificarEmpleado(bool agregar)
        {
            DateTime? dtpsicologo;
            DateTime? dtpFechaNac;
            DateTime? dtpFechaEnCelu;
            DateTime? dtpFechaIng;
            DateTime? dtpBaja = null; 
            DateTime? dtpFechaIngRen;
            DateTime? dtpFechaAlBPS;
            DateTime? dtpFechaBaBPS;            
            DateTime? dtpFechaEmCAJ;
            DateTime? dtpFechaEnCAJ;
            DateTime? dtpFechaIngPolMil;
            DateTime? dtpFechaEgrPolMil;
            DateTime? dtpFechaVenCarSal;
            DateTime? dtpFechaPagoPrevisto;
            DateTime? dtpFechaPagoEfectuado;


            try
            {
                byte[] foto = null;
                if (pbFoto.Image != null)
                    foto = ControladorUtilidades.convertImagenToByte(pbFoto.Image);

                char sexo = 'F';
                if (rbMasculino.Checked)
                    sexo = 'M';
                bool activo = !cbNoActivo.Checked;
                if (cbNoActivo.Checked)
                {
                    if (dtpFechaBaja.Text == fechaMask)
                        dtpBaja = null;
                    else
                        dtpBaja = DateTime.ParseExact(dtpFechaBaja.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                }
                bool combatiente = cbCombatiente.Checked;
                bool antecedentesPolicialesOMilitares = cbAntecedentePolicialoMilitar.Checked;
                int idcargo=-1;
                try
                {
                    idcargo = (int)cmbTiposCargos.SelectedValue;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - " + ex.InnerException);
                }
                int iddepartamento = (int)cmbDepartamento.SelectedValue;
                int idciudad = (int)cmbCiudades.SelectedValue;
                int idbarrio = (int)cmbBarrios.SelectedValue;
                int idtipodocumento = 0;
                int idmutualista = -1;
                if (cmbMutualista.SelectedItem != null)
                    idmutualista = (int)cmbMutualista.SelectedValue;
                //int idbanco = -1;
                //if (cmbTurno.SelectedItem != null)
                //    idbanco = (int)cmbTurno.SelectedValue;
                int idemergenciamovil = -1;
                if (cmbEmergenciaMedica.SelectedItem != null)
                    idemergenciamovil = (int)cmbEmergenciaMedica.SelectedValue;
                string estadoCivil = cmbEstadoCivil.Text;
                int acumulacionLaboral = 0;
                if (mtAcumulacionBPS.Text != "")
                    if (!int.TryParse(mtAcumulacionBPS.Text, out acumulacionLaboral))
                        throw new Exception("Error de parseo al obtener la AcumulacionLaboral.");
                    
                int cantMenoresACargo = 0;
                if (mtCantidadHijos.Text != "")
                    if (!int.TryParse(mtCantidadHijos.Text, out cantMenoresACargo))
                        throw new Exception("Error de parseo al obtener la Cantidad de Hijos a Cargo.");

                bool capacitadoPortarArma = cbCapacitadoPorteArma.Checked;
                bool enServicioArmado = cbEnServicioArmado.Checked;
                int edad = 0;
                if (lblEdad.Text != "")
                    edad = int.Parse(lblEdad.Text);
                bool antecedentesEmpleado = rbAntecedentes_SI.Checked;

                // *** CONTROL DE FECHAS ***
                if (dtpPsicologo.Text == fechaMask)
                    dtpsicologo = null;
                else
                    dtpsicologo = DateTime.ParseExact(dtpPsicologo.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (dtpFechaNacimiento.Text == fechaMask)
                    dtpFechaNac = null;
                else
                    dtpFechaNac = DateTime.ParseExact(dtpFechaNacimiento.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                
                if (dtpFechaEntregaCelular.Text == fechaMask)
                    dtpFechaEnCelu = null;
                else
                    dtpFechaEnCelu = DateTime.ParseExact(dtpFechaEntregaCelular.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                
                if (dtpFechaIngreso.Text == fechaMask)
                    dtpFechaIng = null;
                else
                    dtpFechaIng = DateTime.ParseExact(dtpFechaIngreso.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (dtpFechaIngresoRenaemse.Text == fechaMask)
                    dtpFechaIngRen = null;
                else
                    dtpFechaIngRen = DateTime.ParseExact(dtpFechaIngresoRenaemse.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (dtpFechaAltaBPS.Text == fechaMask)
                    dtpFechaAlBPS = null;
                else
                    dtpFechaAlBPS = DateTime.ParseExact(dtpFechaAltaBPS.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (dtpFechaBajaBPS.Text == fechaMask)
                    dtpFechaBaBPS = null;
                else
                    dtpFechaBaBPS = DateTime.ParseExact(dtpFechaBajaBPS.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                
                string ServicioActual = txtServicioActual.Text;
                string Turno = cmbTurno.Text;
                float valorHora = 0;
                if (txtValorHora.Text != "")
                    valorHora = float.Parse(txtValorHora.Text);
                if (mtFechaPrevistaPago.Text == fechaMask)
                    dtpFechaPagoPrevisto = null;
                else
                    dtpFechaPagoPrevisto = DateTime.ParseExact(mtFechaPrevistaPago.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (mtFechaPagoEfectuado.Text == fechaMask)
                    dtpFechaPagoEfectuado = null;
                else
                    dtpFechaPagoEfectuado = DateTime.ParseExact(mtFechaPagoEfectuado.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
   
                if (dtpFechaEmisionCAJ.Text == fechaMask)
                    dtpFechaEmCAJ = null;
                else
                    dtpFechaEmCAJ = DateTime.ParseExact(dtpFechaEmisionCAJ.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (dtpFechaEntregaCAJ.Text == fechaMask)
                    dtpFechaEnCAJ = null;
                else
                    dtpFechaEnCAJ = DateTime.ParseExact(dtpFechaEntregaCAJ.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (dtpFechaIngresoPolicialMilitar.Text == fechaMask)
                    dtpFechaIngPolMil = null;
                else
                    dtpFechaIngPolMil = DateTime.ParseExact(dtpFechaIngresoPolicialMilitar.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (dtpFechaEgresoPolicialMilitar.Text == fechaMask)
                    dtpFechaEgrPolMil = null;
                else
                    dtpFechaEgrPolMil = DateTime.ParseExact(dtpFechaEgresoPolicialMilitar.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (dtpFechaVencimientoCarneSalud.Text == fechaMask)
                    dtpFechaVenCarSal = null;
                else
                    dtpFechaVenCarSal = DateTime.ParseExact(dtpFechaVencimientoCarneSalud.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);


                if (agregar)
                {
                    datos.altaEmpleado(int.Parse(mtNumeroEmpleado.Text), TranfaTitulo(txtNombre.Text), txtApellido.Text, idtipodocumento, mtNumeroDocumento.Text, txtLugarNacimiento.Text, sexo, dtpsicologo, dtpFechaNac, edad, dtpFechaIng, txtTelefono.Text, txtCelular.Text, txtCelularConvenio.Text, txtEmail.Text, estadoCivil, cantMenoresACargo, foto, valorHora, activo, dtpBaja, txtMotivoBaja.Text, iddepartamento, idciudad, idbarrio, txtCodigoPostal.Text, txtDireccion.Text, txtEntreCalles.Text, txtPuntoEncuentro.Text, txtNumAsuntoRenaemse.Text, dtpFechaIngRen, acumulacionLaboral, dtpFechaAlBPS, cbBajadoBPS.Checked, dtpFechaBaBPS, txtNumeroCAJ.Text, dtpFechaEmCAJ, dtpFechaEnCAJ, antecedentesEmpleado, txtObservacionesAntecedentes.Text, antecedentesPolicialesOMilitares, cmbPolicialMilitar.Text, dtpFechaIngPolMil, dtpFechaEgrPolMil, txtPolicialSubEscalafon.Text, combatiente, txtTallePantalon.Text, txtTalleCamisa.Text, mtTalleZapatos.Text, txtTalleCampera.Text, dtpFechaVenCarSal, idmutualista, idemergenciamovil, capacitadoPortarArma, enServicioArmado, txtObservaciones.Text, cmbNivelEducativo.SelectedItem.ToString(), idcargo, dtpFechaPagoEfectuado, dtpFechaPagoPrevisto, ServicioActual, Turno, cbConstanciaDomicilio.Checked, dtpFechaEnCelu);
                    MessageBox.Show("Empleado agregado Correctamente.", "Alta Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    habilitarPermisosEmpleado(true);
                }
                else
                {
                    string nivEdu = "";
                    if (cmbNivelEducativo.SelectedItem != null)
                        nivEdu = cmbNivelEducativo.SelectedItem.ToString();
                    datos.modificarEmpleado(int.Parse(mtNumeroEmpleado.Text), TranfaTitulo(txtNombre.Text), txtApellido.Text, idtipodocumento, mtNumeroDocumento.Text, txtLugarNacimiento.Text, sexo, dtpsicologo, dtpFechaNac, edad, dtpFechaIng, txtTelefono.Text, txtCelular.Text, txtCelularConvenio.Text, txtEmail.Text, estadoCivil, cantMenoresACargo, foto, valorHora, activo, dtpBaja, txtMotivoBaja.Text, iddepartamento, idciudad, idbarrio, txtCodigoPostal.Text, txtDireccion.Text, txtEntreCalles.Text, txtPuntoEncuentro.Text, txtNumAsuntoRenaemse.Text, dtpFechaIngRen, acumulacionLaboral, dtpFechaAlBPS, cbBajadoBPS.Checked, dtpFechaBaBPS, txtNumeroCAJ.Text, dtpFechaEmCAJ, dtpFechaEnCAJ, antecedentesEmpleado, txtObservacionesAntecedentes.Text, antecedentesPolicialesOMilitares, cmbPolicialMilitar.Text, dtpFechaIngPolMil, dtpFechaEgrPolMil, txtPolicialSubEscalafon.Text, combatiente, txtTallePantalon.Text, txtTalleCamisa.Text, mtTalleZapatos.Text, txtTalleCampera.Text, dtpFechaVenCarSal, idmutualista, idemergenciamovil, capacitadoPortarArma, enServicioArmado, txtObservaciones.Text, cmbNivelEducativo.SelectedItem.ToString(), idcargo, dtpFechaPagoEfectuado, dtpFechaPagoPrevisto, ServicioActual, Turno, cbConstanciaDomicilio.Checked, dtpFechaEnCelu);
                    MessageBox.Show("Datos guardados correctamente.", "Guardado de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              // JG. Se comenta para que al guardar permanezca cargado el funcionario.
              //  btnCancelar.PerformClick();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message + " - " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Chequeo Campos Obligatorios
            if (checkDatosObligatorios())
            {
                agregarOModificarEmpleado(true);
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cbNoActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoActivo.Checked)
            {
                dtpFechaBaja.Enabled = true;
                txtMotivoBaja.Enabled = true;
                mtFechaPagoEfectuado.Enabled = true;
                mtFechaPrevistaPago.Enabled = true;
                dtpFechaBaja.Text = DateTime.Today.ToString();
            }
            else
            {
                dtpFechaBaja.Enabled = false;
                txtMotivoBaja.Enabled = false;
                mtFechaPagoEfectuado.Enabled = false;
                mtFechaPrevistaPago.Enabled = false;
            }
        }

        private void cbAntecedentePolicialoMilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAntecedentePolicialoMilitar.Checked)
            {
                cmbPolicialMilitar.Enabled = true;
                cmbPolicialMilitar.SelectedIndex = 0;
                dtpFechaIngresoPolicialMilitar.Enabled = true;
                dtpFechaEgresoPolicialMilitar.Enabled = true;
                txtPolicialSubEscalafon.Enabled = true;
                cbCombatiente.Enabled = true;


            }
            else
            {
                cmbPolicialMilitar.Enabled = false;
                dtpFechaIngresoPolicialMilitar.Enabled = false;
                dtpFechaEgresoPolicialMilitar.Enabled = false;
                txtPolicialSubEscalafon.Enabled = false;
                cbCombatiente.Enabled = false;
            }

        }
       

        private int calcularEdad(DateTime fecha)
        {
            DateTime FechaNac = DateTime.ParseExact(dtpFechaNacimiento.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
            int anio = (DateTime.Now.Year - FechaNac.Year);
            if (DateTime.Now.Month < FechaNac.Month)
                anio = anio - 1;
            else if (DateTime.Now.Month == FechaNac.Month)
                if (DateTime.Now.Day < FechaNac.Day)
                    anio = anio - 1;
            return anio;
        }

        private int calcularAnos(DateTime fi, DateTime ff)
        {
            int anio = (ff.Year - fi.Year);
            if (ff.Month < fi.Month)
                anio = anio - 1;
            else if (ff.Month == fi.Month)
                if (ff.Day < fi.Day)
                    anio = anio - 1;
            return anio;
        }

        private void tcEmpleado_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(tcEmpleado.TabIndex.ToString() + " - " + tcEmpleado.TabPages[tcEmpleado.TabIndex].Name);
        }


        #region HistorialEmpleado

        private void btnAgregarHistorial_Click(object sender, EventArgs e)
        {
            DateTime FechaIni = DateTime.ParseExact(dtpFechaInicioHistorial.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
            DateTime FechaFin = DateTime.ParseExact(dtpFechaFinHistorial.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

            if (FechaIni > FechaFin)
                MessageBox.Show("La Fecha Fin tiene que ser mayor que la Fecha Inicio.");
            else if (cmbTipoEventoHistorial.SelectedIndex >= 0 && txtDescripcionHistorial.Text != "")
            {
                int n = -10;
                try
                {

                    int idTipoEventoSelected = ((ComboBoxValue)cmbTipoEventoHistorial.Items[cmbTipoEventoHistorial.SelectedIndex]).Value;
                    int numEventoNuevo = datos.agregarEventoHistorialEmpleado(int.Parse(mtNumeroEmpleado.Text), FechaIni, FechaFin, idTipoEventoSelected, txtDescripcionHistorial.Text);
                    // Una vez agregado el registro, insertamos una nueva fila en el datagrid
                    n = dgvHistorialEmpleado.Rows.Add();
                    dgvHistorialEmpleado.Rows[n].Cells["IdEventoHistorialEmpleado"].Value = numEventoNuevo.ToString();
                    dgvHistorialEmpleado.Rows[n].Cells["FechaInicio"].Value = FechaIni.ToShortDateString();
                    dgvHistorialEmpleado.Rows[n].Cells["FechaFin"].Value = FechaFin.ToShortDateString();

                    dgvHistorialEmpleado.Rows[n].Cells["Descripcion"].Value = txtDescripcionHistorial.Text;
                    dgvHistorialEmpleado.Rows[n].Cells["IdTipoEvento"].Value = idTipoEventoSelected;
                    dgvHistorialEmpleado.Rows[n].Cells["TipoEvento"].Value = cmbTipoEventoHistorial.Text;

                    limpiarTabHistorial();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Debe llenar todos los datos.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void limpiarTabHistorial()
        {
            dtpFechaInicioHistorial.Text = DateTime.Today.ToString();
            dtpFechaFinHistorial.Text = DateTime.Today.ToString();
            //cmbTipoEventoHistorial.SelectedIndex = 0;
            txtDescripcionHistorial.Text = "";
            btnAddTipoEvento.Enabled = true;
            btnEliminarHistorial.Enabled = false;
            btnGuardarHistorial.Enabled = false;
        }

        private void btnGuardarHistorial_Click(object sender, EventArgs e)
        {
            DateTime FechaIni = DateTime.ParseExact(dtpFechaInicioHistorial.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
            DateTime FechaFin = DateTime.ParseExact(dtpFechaFinHistorial.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

            int numFila = 0;
            while (dgvHistorialEmpleado.RowCount > numFila && lblIdEventoHistorialEmpleado.Text != dgvHistorialEmpleado.Rows[numFila].Cells["IdEventoHistorialEmpleado"].Value.ToString())
            {
                numFila++;
            }
            if (numFila != dgvHistorialEmpleado.RowCount)
            {

                if (FechaIni > FechaFin)
                    MessageBox.Show("La Fecha Fin tiene que ser mayor que la Fecha Inicio.");
                else if (cmbTipoEventoHistorial.SelectedIndex >= 0 && txtDescripcionHistorial.Text != "")
                {
                    int idEvento = ((ComboBoxValue)cmbTipoEventoHistorial.SelectedItem).Value;
                    datos.modificarEventoHistorialEmpleado(int.Parse(lblIdEventoHistorialEmpleado.Text), int.Parse(mtNumeroEmpleado.Text), FechaIni, FechaFin, idEvento, txtDescripcionHistorial.Text);
                    dgvHistorialEmpleado.Rows[numFila].Cells["IdEventoHistorialEmpleado"].Value = lblIdEventoHistorialEmpleado.Text;
                    dgvHistorialEmpleado.Rows[numFila].Cells["FechaInicio"].Value = FechaIni.ToShortDateString();
                    dgvHistorialEmpleado.Rows[numFila].Cells["FechaFin"].Value = FechaFin.ToShortDateString();

                    dgvHistorialEmpleado.Rows[numFila].Cells["Descripcion"].Value = txtDescripcionHistorial.Text;
                    dgvHistorialEmpleado.Rows[numFila].Cells["IdTipoEvento"].Value = idEvento;
                    dgvHistorialEmpleado.Rows[numFila].Cells["TipoEvento"].Value = cmbTipoEventoHistorial.Text;

                    limpiarTabHistorial();
                    btnAgregarHistorial.Enabled = true;
                }
                else
                    MessageBox.Show("Debe llenar todos los datos.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEliminarHistorial_Click(object sender, EventArgs e)
        {
            DateTime FechaIni = DateTime.ParseExact(dtpFechaInicioHistorial.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
            DateTime FechaFin = DateTime.ParseExact(dtpFechaFinHistorial.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

            if (FechaIni > FechaFin)
                MessageBox.Show("La Fecha Fin tiene que ser mayor que la Fecha Inicio.", "Error Fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cmbTipoEventoHistorial.SelectedIndex >= 0 && txtDescripcionHistorial.Text != "")
            {
                DialogResult dr = MessageBox.Show("Seguro que desea eliminar el Evento del Empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int numFila = 0;
                    while (dgvHistorialEmpleado.RowCount > numFila && lblIdEventoHistorialEmpleado.Text != dgvHistorialEmpleado.Rows[numFila].Cells["IdEventoHistorialEmpleado"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvHistorialEmpleado.RowCount)
                    {
                        try
                        {
                            datos.eliminarEventoHistorialEmpleado(int.Parse(lblIdEventoHistorialEmpleado.Text), int.Parse(mtNumeroEmpleado.Text));
                            dgvHistorialEmpleado.Rows.RemoveAt(numFila);

                            MessageBox.Show("Evento eliminado correctamente.", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarTabHistorial();
                            btnAgregarHistorial.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Debe llenar todos los datos.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cargarHistorialEmpleado(int idEmpleado)
        {
            int n = -10;
            try
            {
                List<EventOsHistOrIalEmPleadO> listaHistorial = datos.obtenerEventosHistorialEmpleado(int.Parse(mtNumeroEmpleado.Text));
                // llenado de la grilla con estos datos

                foreach (EventOsHistOrIalEmPleadO historial in listaHistorial)
                {
                    n = dgvHistorialEmpleado.Rows.Add();
                    dgvHistorialEmpleado.Rows[n].Cells["IdEventoHistorialEmpleado"].Value = historial.IDEventoHistorialEmpleado;
                    dgvHistorialEmpleado.Rows[n].Cells["FechaInicio"].Value = historial.FechaInicio.ToShortDateString();
                    dgvHistorialEmpleado.Rows[n].Cells["FechaFin"].Value = historial.FechaFin.ToShortDateString();

                    dgvHistorialEmpleado.Rows[n].Cells["Descripcion"].Value = historial.Descripcion;
                    dgvHistorialEmpleado.Rows[n].Cells["IdTipoEvento"].Value = historial.IDTipoEvento;

                    int index = -1;
                    foreach (TipOsEventOHistOrIal tipo in listaTiposEventos)
                    {
                        if (tipo.IDTipoEventoHistorial == historial.IDTipoEvento)
                        {
                            index = listaTiposEventos.IndexOf(tipo);
                            break;
                        }
                    }
                    if (index == -1)
                        throw new Excepciones.NoExisteException("No existe un Tipo Evento con identificador: " + historial.IDTipoEvento.ToString());
                    dgvHistorialEmpleado.Rows[n].Cells["TipoEvento"].Value = listaTiposEventos.ElementAt<TipOsEventOHistOrIal>(index).Nombre;

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al obtener los Extras de la liquidacion del empleado para la fecha " + dtpExtrasFecha.Text);
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (n > -10)
                    try
                    {
                        dgvHistorialEmpleado.Rows.RemoveAt(n);
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(this, ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }

        }

        private void dgvHistorialEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime FechaIni = DateTime.ParseExact(dtpFechaInicioHistorial.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
            DateTime FechaFin = DateTime.ParseExact(dtpFechaFinHistorial.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                lblIdEventoHistorialEmpleado.Text = dgvHistorialEmpleado.Rows[e.RowIndex].Cells["IdEventoHistorialEmpleado"].Value.ToString();
                dtpFechaInicioHistorial.Text = dgvHistorialEmpleado.Rows[e.RowIndex].Cells["FechaInicio"].Value.ToString();
                dtpFechaFinHistorial.Text = dgvHistorialEmpleado.Rows[e.RowIndex].Cells["FechaFin"].Value.ToString();
                txtDescripcionHistorial.Text = dgvHistorialEmpleado.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                int numIndice = 0;
                foreach (ComboBoxValue v in cmbTipoEventoHistorial.Items)
                {
                    if (v.Value == int.Parse(dgvHistorialEmpleado.Rows[e.RowIndex].Cells["IdTipoEvento"].Value.ToString()))
                    {
                        cmbTipoEventoHistorial.SelectedIndex = cmbTipoEventoHistorial.Items.IndexOf(v);
                        break;
                    }
                    numIndice++;
                }

                //cmbTipoEventoHistorial.SelectedIndex = numIndice;

                btnAgregarHistorial.Enabled = false;
                btnGuardarHistorial.Enabled = true;
                btnEliminarHistorial.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion


        #region ExtraLiquidacionEmpleado

        private void btnExtrasAgregar_Click(object sender, EventArgs e)
        {
            if (txtExtrasDescripcion.Text != "" && mtExtrasValor.Text != "" && cmbExtrasSigno.SelectedIndex >= 0 && mtExtrasCantCuotas.Text != "")
            {
                try
                {
                    char signo = cmbExtrasSigno.Text.ToCharArray()[0];
                    bool signoPositivo = false;
                    if (signo == '+')
                        signoPositivo = true;
                    mtExtrasValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    mtExtrasCantCuotas.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    int numNuevoExtra = datos.agregarExtraLiquidacionEmpleado(int.Parse(mtNumeroEmpleado.Text), dtpExtrasFecha.Value, txtExtrasDescripcion.Text, signoPositivo, float.Parse(mtExtrasValor.Text), int.Parse(mtExtrasCantCuotas.Text));
                    limpiarTabExtrasLiquidacion();
                    cargarGrillaExtraLiquidacionEmpleado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
                MessageBox.Show("Debe llenar todos los datos.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void limpiarTabExtrasLiquidacion()
        {
            dtpExtrasFecha.Value = DateTime.Today;
            txtExtrasDescripcion.Text = "";
            mtExtrasValor.Text = "";
            mtExtrasCantCuotas.Text = "";
            cmbExtrasSigno.SelectedIndex = 0;
            btnExtrasAgregar.Enabled = true;
            btnExtrasGuardar.Enabled = false;
            btnExtrasEliminar.Enabled = false;
        }

        private void btnExtrasGuardar_Click(object sender, EventArgs e)
        {
            if (txtExtrasDescripcion.Text != "" && mtExtrasValor.Text != "" && cmbExtrasSigno.SelectedIndex >= 0 && mtExtrasCantCuotas.Text != "")
            {
                int numFila = 0;
                while (dgvExtrasLiquidacion.RowCount > numFila && lblIdExtraLiquidacion.Text != dgvExtrasLiquidacion.Rows[numFila].Cells["IdExtraLiquidacion"].Value.ToString())
                {
                    numFila++;
                }
                if (numFila != dgvHistorialEmpleado.RowCount)
                {
                    char signo = cmbExtrasSigno.Text.ToCharArray()[0];
                    bool signoPositivo = false;
                    if (signo == '+')
                        signoPositivo = true;
                    try
                    {
                        datos.modificarExtraLiquidacionEmpleado(int.Parse(mtNumeroEmpleado.Text), int.Parse(lblIdExtraLiquidacion.Text), dtpExtrasFecha.Value, txtExtrasDescripcion.Text, signoPositivo, float.Parse(mtExtrasValor.Text), int.Parse(mtExtrasCantCuotas.Text));
                        dgvExtrasLiquidacion.Rows[numFila].Cells["DescripcionEvento"].Value = txtExtrasDescripcion.Text;
                        if (cmbExtrasSigno.SelectedItem == "+")
                            dgvExtrasLiquidacion.Rows[numFila].Cells["Signo"].Value = "+";
                        else
                            dgvExtrasLiquidacion.Rows[numFila].Cells["Signo"].Value = "-";
                        dgvExtrasLiquidacion.Rows[numFila].Cells["Valor"].Value = mtExtrasValor.Text;
                        dgvExtrasLiquidacion.Rows[numFila].Cells["CantidadCuotas"].Value = mtExtrasCantCuotas.Text;
                        limpiarTabExtrasLiquidacion();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Debe llenar todos los datos.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExtrasEliminar_Click(object sender, EventArgs e)
        {
            if (txtExtrasDescripcion.Text != "" && mtExtrasValor.Text != "" && cmbExtrasSigno.SelectedIndex >= 0 && mtExtrasCantCuotas.Text != "")
            {
                char signo = cmbExtrasSigno.Text.ToCharArray()[0];
                DialogResult dr = MessageBox.Show("Seguro que desea eliminar el Extra Liquidación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        datos.eliminarExtraLiquidacionEmpleado(int.Parse(mtNumeroEmpleado.Text), int.Parse(lblIdExtraLiquidacion.Text), dtpExtrasFecha.Value);
                        limpiarTabExtrasLiquidacion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Debe llenar todos los datos.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dtpExtrasFecha_ValueChanged(object sender, EventArgs e)
        {
            if (mtNumeroEmpleado.Text != "")
            {
                cargarGrillaExtraLiquidacionEmpleado();
            }

        }

        private void cargarGrillaExtraLiquidacionEmpleado()
        {
            int n = -10;
            try
            {
                //List<ExtrasLiquidAcIon> listaExtras = datos.obtenerExtrasLiquidacionEmpleado(int.Parse(mtNumeroEmpleado.Text), dtpExtrasFecha.Value);
                // Vacio la grilla
                dgvExtrasLiquidacion.Rows.Clear();


                // llenado de la grilla con estos datos

                //foreach (ExtrasLiquidAcIonEmPleadO extra in listaExtras)
                //{
                //    n = dgvExtrasLiquidacion.Rows.Add();
                //    dgvExtrasLiquidacion.Rows[n].Cells["IdExtraLiquidacion"].Value = extra.IDExtrasLiquidacionEmpleado;
                //    dgvExtrasLiquidacion.Rows[n].Cells["Fecha"].Value = extra.Fecha.ToShortDateString();
                //    dgvExtrasLiquidacion.Rows[n].Cells["DescripcionEvento"].Value = extra.Descripcion;
                //    if (extra.Signo == 1)
                //        dgvExtrasLiquidacion.Rows[n].Cells["Signo"].Value = "+";
                //    else
                //        dgvExtrasLiquidacion.Rows[n].Cells["Signo"].Value = "-";
                //    dgvExtrasLiquidacion.Rows[n].Cells["Valor"].Value = extra.Valor;
                //    dgvExtrasLiquidacion.Rows[n].Cells["CuotaActual"].Value = extra.CuotaActual;
                //    dgvExtrasLiquidacion.Rows[n].Cells["CantidadCuotas"].Value = extra.CantidadCuotas;
                //    if (extra.Liquidado == 1)
                //        dgvExtrasLiquidacion.Rows[n].Cells["Liquidado"].Value = "Si";
                //    else
                //        dgvExtrasLiquidacion.Rows[n].Cells["Liquidado"].Value = "No";

                //}
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al obtener los Extras de la liquidacion del empleado para la fecha " + dtpExtrasFecha.Text);
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (n > -10)
                    try
                    {
                        dgvExtrasLiquidacion.Rows.RemoveAt(n);
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(this, ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }

        }


        private void dgvExtrasLiquidacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            try
            {
                lblIdExtraLiquidacion.Text = dgvExtrasLiquidacion.Rows[e.RowIndex].Cells["IdExtraLiquidacion"].Value.ToString();
                txtExtrasDescripcion.Text = dgvExtrasLiquidacion.Rows[e.RowIndex].Cells["DescripcionEvento"].Value.ToString();
                cmbExtrasSigno.SelectedItem = dgvExtrasLiquidacion.Rows[e.RowIndex].Cells["Signo"].Value.ToString();
                mtExtrasValor.Text = dgvExtrasLiquidacion.Rows[e.RowIndex].Cells["Valor"].Value.ToString();
                mtExtrasCantCuotas.Text = dgvExtrasLiquidacion.Rows[e.RowIndex].Cells["CantidadCuotas"].Value.ToString();
                btnExtrasAgregar.Enabled = false;
                btnExtrasGuardar.Enabled = true;
                btnExtrasEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion

        private void cbBajadoBPS_CheckedChanged(object sender, EventArgs e)
        {
            //dtpFechaBajaBPS.Enabled = cbBajadoBPS.Checked;
            //dtpFechaBajaBPS.Text = DateTime.Today.ToString();
            if (cbBajadoBPS.Checked)
                dtpFechaBajaBPS.Text = DateTime.Today.ToString();
            else
                dtpFechaBajaBPS.Text = "";
        }

        private void cmbPolicialMilitar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbNoActivo.Checked)
            {
                if (cmbPolicialMilitar.SelectedItem.ToString() == "Policia")
                {
                    txtPolicialSubEscalafon.Visible = true;
                    txtPolicialSubEscalafon.Enabled = true;
                    lblSubEscalafon.Visible = true;
                    cbCombatiente.Visible = false;
                    cbCombatiente.Enabled = false;
                }
                else
                {
                    txtPolicialSubEscalafon.Visible = false;
                    txtPolicialSubEscalafon.Enabled = false;
                    lblSubEscalafon.Visible = false;
                    cbCombatiente.Visible = true;
                    cbCombatiente.Enabled = true;
                }
            }
        }

        private void updateListOfTiposEventoHistorialCombo()
        {
            List<TipOsEventOHistOrIal> tiposeventos = datosTipos.obtenerTiposEventoHistorial(false);
            listaTiposEventos = tiposeventos;
            cmbTipoEventoHistorial.Items.Clear();
            cmbTipoEventoHistorial.ValueMember = "Value";
            cmbTipoEventoHistorial.DisplayMember = "Display";
            cmbTipoEventoHistorial.BeginUpdate();
            foreach (TipOsEventOHistOrIal tipo in tiposeventos)
            {
                ComboBoxValue cbval = new ComboBoxValue(tipo.Nombre, tipo.IDTipoEventoHistorial);
                cmbTipoEventoHistorial.Items.Add(cbval);
            }
            cmbTipoEventoHistorial.EndUpdate();
        }

        private void btnAddTipoEvento_Click(object sender, EventArgs e)
        {
            ABMTipoEventoHistorial abmtiposeventos = ABMTipoEventoHistorial.getVentana();
            abmtiposeventos.ShowDialog(this);
            updateListOfTiposEventoHistorialCombo();
        }

        private void cmbTiposCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idtipocargo;
            try
            {
                if (cmbTiposCargos.SelectedItem != null)
                {
                    idtipocargo = (int)cmbTiposCargos.SelectedValue;
                    //idtipocargo = ((ComboBoxValue)cmbTiposCargos.SelectedItem).Value;
                    foreach (TipOscarGoS cargo in cargos)
                    {
                        if (cargo.IDCargo == idtipocargo)
                            lblTipoFacturacion.Text = cargo.TipoFacturacion.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                int? numemp;
                if (mtNumeroEmpleado.Text != "")
                    numemp = datos.obtenerProximoIdEmpleadoActivo(int.Parse(mtNumeroEmpleado.Text));
                else
                    numemp = datos.obtenerProximoIdEmpleadoActivo(-1);

                if (numemp != null)
                {
                    mtNumeroEmpleado.Text = numemp.ToString();
                    mtNumeroEmpleado.Focus();

                    SendKeys.Send("{ENTER}");
                }
                else
                    MessageBox.Show("No existe un empleado posterior a este.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtNumeroEmpleado.Text != "")
                {
                    int? numemp = datos.obtenerPrevioIdEmpleadoActivo(int.Parse(mtNumeroEmpleado.Text));
                    if (numemp != null)
                    {
                        mtNumeroEmpleado.Text = numemp.ToString();
                        mtNumeroEmpleado.Focus();

                        SendKeys.Send("{ENTER}");
                    }
                    else
                        MessageBox.Show("No existe un empleado anterior a este.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ABMEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }



        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            BuscarEmpleados busquedaEmps = new BuscarEmpleados();
            DialogResult res = busquedaEmps.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                try
                {
                    mtNumeroEmpleado.Text = busquedaEmps.idEmpleadoSeleccionado.ToString();
                    mtNumeroEmpleado.Focus();
                    SendKeys.Send("{ENTER}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre.Text = TranfaTitulo(txtNombre.Text);
        }

        private string TranfaTitulo(string ori)
        {
            if (ori.Length > 1)
            {
                string dest = ori.Trim();
                int esp = dest.LastIndexOf(" ");
                string aux = (esp + 2 < dest.Length) ? dest.Substring(esp + 2).ToLower() : "?";
                if (esp == -1)
                    return dest.Substring(0, 1).ToUpper() + dest.Substring(1).ToLower();
                else
                    return dest.Substring(0, 1).ToUpper() + dest.Substring(1, esp).ToLower() + dest.Substring(esp + 1, 1).ToUpper() + aux;
            }
            else
                return ori;
        }

        private string TranfCI(string ori)
        {
            if (ori.Length == 8)
            {
                string aux = ori.Insert(1, ".");
                aux = aux.Insert(5, ".");
                aux = aux.Insert(9, "-");
                return aux;
            }
            else
                return ori;
        }

        //private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbTipoDocumento.Text == "C.I.")
        //        mtNumeroDocumento.Mask = "00000000";
        //    else
        //        mtNumeroDocumento.Mask = null;

        //    //mtNumeroDocumento.Refresh();
        //}


        #region **** VALIDAR FECHAS ****

        private bool ValidarFecha(string fecha)
        {
            DateTime dt;
            DateTimeStyles dts = new DateTimeStyles();

            if (fecha == fechaMask)
                return true;
            else
                return DateTime.TryParseExact(fecha, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo, dts, out dt);
        }


        private void dtpFechaNacimiento_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaNacimiento.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaNacimiento, "No es una fecha válida");
            }
        }

        private void dtpFechaIngreso_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaIngreso.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaIngreso, "No es una fecha válida");
            }
        }

        private void dtpFechaVencimientoCarneSalud_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaVencimientoCarneSalud.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaVencimientoCarneSalud, "No es una fecha válida");
            }
        }

        private void dtpPsicologo_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpPsicologo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpPsicologo, "No es una fecha válida");
            }
        }

        private void dtpFechaIngresoRenaemse_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaIngresoRenaemse.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaIngresoRenaemse, "No es una fecha válida");
            }
        }

        private void dtpFechaAltaBPS_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaAltaBPS.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaAltaBPS, "No es una fecha válida");
            }
        }

        private void dtpFechaBajaBPS_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaBajaBPS.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaBajaBPS, "No es una fecha válida");
            }
        }

        private void dtpFechaEmisionCAJ_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaEmisionCAJ.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaEmisionCAJ, "No es una fecha válida");
            }
        }

        private void dtpFechaEntregaCAJ_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaEntregaCAJ.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaEntregaCAJ, "No es una fecha válida");
            }
        }

        //private void dtpFechaAltaMTSS_Validating(object sender, CancelEventArgs e)
        //{
        //    if (!ValidarFecha(dtpFechaAltaMTSS.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider1.SetError(dtpFechaAltaMTSS, "No es una fecha válida");
        //    }
        //}

        //private void dtpFechaBajaMTSS_Validating(object sender, CancelEventArgs e)
        //{
        //    if (!ValidarFecha(dtpFechaBajaMTSS.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider1.SetError(dtpFechaBajaMTSS, "No es una fecha válida");
        //    }
        //}

        private void dtpFechaEgresoEmpresa_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(mtFechaPagoEfectuado.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtFechaPagoEfectuado, "No es una fecha válida");
            }
        }

        private void dtpFechaIngresoPolicialMilitar_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaIngresoPolicialMilitar.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaIngresoPolicialMilitar, "No es una fecha válida");
            }
        }

        private void dtpFechaEgresoPolicialMilitar_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaEgresoPolicialMilitar.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaEgresoPolicialMilitar, "No es una fecha válida");
            }
        }

        private void dtpFechaBaja_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaBaja.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaBaja, "No es una fecha válida");
            }
        }

        private void mtFechaPrevistaPago_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(mtFechaPrevistaPago.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtFechaPrevistaPago, "No es una fecha válida");
            }
        }
        private void mtFechaPagoEfectuado_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(mtFechaPagoEfectuado.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtFechaPagoEfectuado, "No es una fecha válida");
            }
        }

        private void dtpFechaInicioHistorial_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaInicioHistorial.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaInicioHistorial, "No es una fecha válida");
            }
        }

        private void dtpFechaFinHistorial_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaFinHistorial.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaFinHistorial, "No es una fecha válida");
            }
        }

        private void dtpFechaEntregaCelular_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaEntregaCelular.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaEntregaCelular, "No es una fecha válida");
            }
        }

        private void dtpFechaEntregaCelular_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaEntregaCelular, "");
        }

        private void dtpFechaFinHistorial_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaFinHistorial, "");
        }

        private void dtpFechaInicioHistorial_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaInicioHistorial, "");
        }

        private void dtpFechaIngresoRenaemse_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaIngresoRenaemse, "");
        }

        private void dtpFechaAltaBPS_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaAltaBPS, "");
        }

        private void dtpFechaBajaBPS_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaBajaBPS, "");
        }

        private void dtpFechaEmisionCAJ_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaEmisionCAJ, "");
        }

        private void dtpFechaEntregaCAJ_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaEntregaCAJ, "");
        }

        //private void dtpFechaAltaMTSS_Validated(object sender, EventArgs e)
        //{
        //    errorProvider1.SetError(dtpFechaAltaMTSS, "");
        //}

        //private void dtpFechaBajaMTSS_Validated(object sender, EventArgs e)
        //{
        //    errorProvider1.SetError(dtpFechaBajaMTSS, "");
        //}

        //private void dtpFechaEgresoEmpresa_Validated(object sender, EventArgs e)
        //{
        //    errorProvider1.SetError(mtFechaPagoEfectuado, "");
        //}

        private void dtpFechaBaja_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaBaja, "");
            cbBajadoBPS.Checked  = true;
            dtpFechaBajaBPS.Text  = dtpFechaBaja.Text;
        }

        private void dtpFechaEgresoPolicialMilitar_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaEgresoPolicialMilitar, "");
        }

        private void dtpFechaIngresoPolicialMilitar_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaIngresoPolicialMilitar, "");
        }

        private void dtpFechaVencimientoCarneSalud_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaVencimientoCarneSalud, "");
        }

        private void dtpPsicologo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpPsicologo, "");
        }

        private void dtpFechaNacimiento_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaNacimiento, "");
            if (dtpFechaNacimiento.Text != fechaMask)
                lblEdad.Text = calcularEdad(DateTime.ParseExact(dtpFechaNacimiento.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo)).ToString();
        }

        private void dtpFechaIngreso_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaIngreso, "");
            dtpFechaAltaBPS.Text = dtpFechaIngreso.Text;
        }

        private void mtFechaPagoEfectuado_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(mtFechaPagoEfectuado, "");
            
        }

        private void mtFechaPrevistaPago_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(mtFechaPrevistaPago, "");
        }

        #endregion

        private void ABMEmpleados_Shown(object sender, EventArgs e)
        {
            //mtNumeroEmpleado.Focus();
            mtNumeroDocumento.Focus();
        }

        private void ImprimirTSB_ButtonClick(object sender, EventArgs e)
        {
            ImprimirTSB.ShowDropDown();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathdoc = Path.Combine(dirbase, dirRelativaDocs);
            object fileName = Path.Combine(pathdoc, "Contrato.doc");

            object mark;
            object readOnly = true;


            Word._Application oWord;
            oWord = new Word.ApplicationClass();
            Word._Document oDoc;
            // oWord.DocumentBeforeSave += new Microsoft.Office.Interop.Word.ApplicationEvents4_DocumentBeforeSaveEventHandler(oWord_DocumentBeforeSave);
            // oWord.DocumentBeforeClose += new Microsoft.Office.Interop.Word.ApplicationEvents4_DocumentBeforeCloseEventHandler(oWord_DocumentBeforeClose);
            // oWord.Options.SavePropertiesPrompt = false;
            //  oWord.Options.SaveNormalPrompt = false;
            //  oWord.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            //  oWord.ScreenUpdating = false;
            oWord.Visible = true;
            try
            {
                oDoc = oWord.Documents.Open(ref fileName,
                                        ref missing, ref readOnly, ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);//, ref missing);


                //oDoc = oWord.Documents.Add(ref fileName, ref missing, ref missing, ref missing);
                mark = "diaHoy";
                Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.Day.ToString();

                mark = "mesHoy";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.ToString("MMMM");

                mark = "anoHoy";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.Year.ToString();

                mark = "nombre";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = txtNombre.Text + " " + TranfaTitulo(txtApellido.Text);

                mark = "estadocivil";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = cmbEstadoCivil.Text.ToLower();

                mark = "ci";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = TranfCI(mtNumeroDocumento.Text);

                mark = "domicilio";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = txtDireccion.Text;

                mark = "cargo";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = cmbTiposCargos.Text;

                mark = "dia";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.Day.ToString();

                mark = "mes";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.ToString("MMMM");

                mark = "ano";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.Year.ToString();

                mark = "sueldo";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = txtValorHora.Text;

                #region imprimir
                //string fileNameSave;
                /*
                saveFileEmpleados.Filter = "Microsoft Office Word Document (*.doc)|*.doc";
                DialogResult res = saveFileEmpleados.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    //fileNameSave = txtNombre.Text + " " + txtApellido.Text + "-" + mtNumeroDocumento.Text + "-Contrato.doc";
                    object FileName = saveFileEmpleados.FileName;
                    object FileFormat = Word.WdSaveFormat.wdFormatDocument;
                    object LockComments = false;
                    object AddToRecentFiles = true;
                    object ReadOnlyRecommended = false;
                    object EmbedTrueTypeFonts = false;
                    object SaveNativePictureFormat = true;
                    object SaveFormsData = true;
                    object SaveAsAOCELetter = false;
                    object Encoding = missing;
                    object InsertLineBreaks = false;
                    object AllowSubstitutions = false;
                    object LineEnding = Word.WdLineEndingType.wdCRLF;
                    object AddBiDiMarks = false;
                    try
                    {
                       // oDoc.Save();
                      //  oDoc.SaveAs(ref FileName, ref FileFormat, ref LockComments,
                      //      ref missing, ref AddToRecentFiles, ref missing,
                      //      ref ReadOnlyRecommended, ref EmbedTrueTypeFonts,
                      //      ref SaveNativePictureFormat, ref SaveFormsData,
                      //      ref SaveAsAOCELetter, ref Encoding, ref InsertLineBreaks,
                      //      ref AllowSubstitutions, ref LineEnding, ref AddBiDiMarks);
                        Object saveChanges = Type.Missing;
                        Object originalFormat = Type.Missing;
                        Object routeDocument = Type.Missing;
                    
                        oWord.Documents.Close(ref saveChanges, ref originalFormat, ref routeDocument);
                    }
                    catch (Exception ioe)
                    {
                        MessageBox.Show(this, ioe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //finally
                    //{
                    //    //object saveOptions = Microsoft.Office.Interop.Word.WdSaveOptions.wdSaveChanges;
                    //    ////object routeDocument = Microsoft.Office.Interop.Word.WdRoutingSlipDelivery.wdAllAtOnce;
                    //    ////oWord.Quit(ref saveOptions, ref FileFormat, ref missing);
                    //    //object routing = false;
                    //    //object saveFormat = Microsoft.Office.Interop.Word.WdOriginalFormat.wdWordDocument;
                    //    Object saveChanges = Type.Missing;
                    //    Object originalFormat = Type.Missing;
                    //    Object routeDocument = Type.Missing;

                    //    oWord.Documents.Close(ref saveChanges, ref originalFormat, ref routeDocument);
                    //    //oDoc.Close(ref saveOptions, ref saveFormat ,ref routing);

                    //}
                }
                */
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el documento para el funcionario.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void movistarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathdoc = Path.Combine(dirbase, dirRelativaDocs);
            object fileName = Path.Combine(pathdoc, "Movistar.doc");
            object mark;
            object readOnly = true;

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            try
            {
                oDoc = oWord.Documents.Open(ref fileName,
                            ref missing, ref readOnly, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing);//, ref missing);

                mark = "diaHoy";
                Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.Day.ToString();

                mark = "mesHoy";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.ToString("MMMM");

                mark = "anoHoy";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.Year.ToString();

                mark = "nombre";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = txtNombre.Text + " " + TranfaTitulo(txtApellido.Text);

                mark = "ci";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = TranfCI(mtNumeroDocumento.Text);

                mark = "domicilio";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = txtDireccion.Text;

                mark = "dHoy";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.Day.ToString();

                mark = "mHoy";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.ToString("MMMM");

                mark = "aHoy";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = DateTime.Today.Year.ToString();

                mark = "numCel";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = txtCelularConvenio.Text;
            }
            catch (Exception ex)
            {
                //oWord.C
                MessageBox.Show("Error al cargar el documento para el funcionario.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void diplomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathdoc = Path.Combine(dirbase, dirRelativaDocs);
            object fileName = Path.Combine(pathdoc, "Diploma.doc");
            object mark;
            object readOnly = true;

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            try
            {
                oDoc = oWord.Documents.Open(ref fileName,
                            ref missing, ref readOnly, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing);//, ref missing);

                mark = "nombre";
                Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = txtNombre.Text + " " + TranfaTitulo(txtApellido.Text);

                mark = "ci";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = TranfCI(mtNumeroDocumento.Text);

                mark = "arma";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                if (cbCapacitadoPorteArma.Checked)
                    wrdRng.Text = "con";
                else
                    wrdRng.Text = "sin";

                if (dtpFechaIngreso.Text != fechaMask)
                {
                    DateTime FI = DateTime.ParseExact(dtpFechaIngreso.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                    mark = "fechaIni";
                    wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                    wrdRng.Text = FI.AddDays(-2).Day.ToString();

                    mark = "fechaFin";
                    wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                    wrdRng.Text = FI.AddDays(-1).Day.ToString();


                    mark = "mes";
                    wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                    wrdRng.Text = FI.ToString("MMMM");

                    mark = "ano";
                    wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                    wrdRng.Text = FI.Year.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el documento para el funcionario.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void renaemseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathdoc = Path.Combine(dirbase, dirRelativaDocs);
            string fileName = Path.Combine(pathdoc, "Renaemse.xls");
            object readOnly = true;

            Excel.Application ExApp;
            Excel._Workbook oWBook;
            Excel._Worksheet oSheet;
            //Excel.Range oRng;
            try
            {
                //Start Excel and get Application object.
                ExApp = new Excel.Application();
                ExApp.Visible = true;
                //Get a new workbook.
                //oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oWBook = ExApp.Workbooks.Open(fileName, missing, readOnly, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                oSheet = (Excel._Worksheet)oWBook.ActiveSheet;

                // Nombre
                oSheet.Cells[16, 2] = TranfaTitulo(txtApellido.Text) + " " + txtNombre.Text;

                // C.I.
                oSheet.Cells[18, 2] = "C.I. " + TranfCI(mtNumeroDocumento.Text);

                // Estado Civil
                oSheet.Cells[18, 9] = cmbEstadoCivil.Text;

                // Fecha de Nacimiento
                oSheet.Cells[20, 4] = dtpFechaNacimiento.Text;

                // Edad
                oSheet.Cells[20, 9] = lblEdad.Text;

                // Dirección
                oSheet.Cells[23, 2] = txtDireccion.Text;

                //Intersección
                oSheet.Cells[23, 7] = txtEntreCalles.Text;

                // Nivel Educacional
                if (cmbNivelEducativo.Text == "Primario")
                    oSheet.Cells[26, 3] = "X";
                else if (cmbNivelEducativo.Text == "Secundario")
                    oSheet.Cells[26, 5] = "X";
                else
                    oSheet.Cells[26, 7] = "X";


                // Antecedentes Policiales o Militares
                if (cbAntecedentePolicialoMilitar.Checked)
                {
                    int fila;
                    if (cmbPolicialMilitar.Text == "Policia")
                    {
                        fila = 31;
                        oSheet.Cells[fila, 10] = txtPolicialSubEscalafon.Text;
                    }
                    else
                    {
                        fila = 32;
                        if (cbCombatiente.Checked)
                            oSheet.Cells[fila, 9] = "Combatiente:               X";
                    }

                    if (dtpFechaIngresoPolicialMilitar.Text != fechaMask)
                        oSheet.Cells[fila, 6] = dtpFechaIngresoPolicialMilitar.Text;

                    if (dtpFechaEgresoPolicialMilitar.Text != fechaMask)
                        oSheet.Cells[fila, 8] = dtpFechaEgresoPolicialMilitar.Text;

                    try
                    {
                        if ((dtpFechaIngresoPolicialMilitar.Text != fechaMask) && (dtpFechaEgresoPolicialMilitar.Text != fechaMask))
                        {
                            DateTime fi = DateTime.ParseExact(dtpFechaIngresoPolicialMilitar.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                            DateTime ff = DateTime.ParseExact(dtpFechaEgresoPolicialMilitar.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                            oSheet.Cells[fila, 3] = calcularAnos(fi, ff).ToString();
                        }
                    }
                    catch (Exception ex) { }
                }

                // Nro CAJ
                oSheet.Cells[34, 6] = txtNumeroCAJ.Text;

                // Fecha Emisión CAJ
                oSheet.Cells[35, 3] = dtpFechaEmisionCAJ.Text;

                // Fecha Entrega CAJ
                oSheet.Cells[35, 7] = dtpFechaEntregaCAJ.Text;

                // Fecha Prueba de Capacitación
                if (dtpFechaIngreso.Text != fechaMask)
                {
                    DateTime aux = DateTime.ParseExact(dtpFechaIngreso.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                    oSheet.Cells[37, 6] = aux.AddDays(-2).ToString();
                }

                // Con o Sin Arma
                int col;
                if (cbCapacitadoPorteArma.Checked)
                    col = 3;
                else
                    col = 7;
                oSheet.Cells[39, col] = "X";

                // Fecha Test Sicológico
                oSheet.Cells[40, 6] = dtpPsicologo.Text;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);
                MessageBox.Show(errorMessage, "Error");
            }

        }

        private void formularioDGIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathdoc = Path.Combine(dirbase, dirRelativaDocs);
            string pdftemplate = Path.Combine(pathdoc, "formulario 3100 DGI.pdf");
            
            //string nomEmpresa = "Trust";
            try
            {
                PdfReader pdfReader = new PdfReader(pdftemplate);

                //saveFileEmpleados.Filter = "Acrobat Reader (*.pdf)|*.pdf";
                //saveFileEmpleados.FileName = 
                //DialogResult OKSave =  saveFileEmpleados.ShowDialog(this);
                //if (OKSave == DialogResult.OK)
                //{
                string newFile = mtNumeroEmpleado.Text + "-" + txtNombre.Text + " " + txtApellido.Text + "-FormularioDGI.pdf";
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;


                //R1.1Ap - Primer Apellido
                //R1.2Ap - Segundo Apellido
                //R1.1Nom - Primer Nombre
                //R1.2Nom - Segundo Nombre
                //R1.NDoc - Numero Documento
                //R1.Año - 
                //R1.Mes - 
                //R1.Nom - Nombre o Denominacion
                //R1.TDoc.0 - NroDocumento en la primera Parte
                //R1.Pais - Pais del Documento

                DateTime hoy = DateTime.Today;

                pdfFormFields.SetField("R1.1Ap", txtApellido.Text.Split(' ').ElementAt(0));
                if (txtApellido.Text.Split(' ').Count() > 1)
                    pdfFormFields.SetField("R1.2Ap", txtApellido.Text.Split(' ').ElementAt(1));
                pdfFormFields.SetField("R1.1Nom", txtNombre.Text.Split(' ').ElementAt(0));
                if (txtNombre.Text.Split(' ').Count() > 1)
                    pdfFormFields.SetField("R1.2Nom", txtNombre.Text.Split(' ').ElementAt(1));
                pdfFormFields.SetField("R1.TDoc.0", "C.I");
                pdfFormFields.SetField("R1.Pais", "Uruguay");
                pdfFormFields.SetField("R1.NDoc", mtNumeroDocumento.Text);
                //pdfFormFields.SetField("R1.Mes", hoy.Month.ToString());
                //pdfFormFields.SetField("R1.Año", hoy.Year.ToString());
                //pdfFormFields.SetField("R1.Nom", nomEmpresa);

                pdfFormFields.SetField("R6.Suscr", txtNombre.Text.Split(' ').ElementAt(0) + " " + TranfaTitulo(txtApellido.Text.Split(' ').ElementAt(0)));
                pdfFormFields.SetField("R6.Calidad", "empleado");
                pdfFormFields.SetField("R6.CI", mtNumeroDocumento.Text);

                pdfStamper.Close();
                //DialogResult okOpen = MessageBox.Show("Documento creado correctamente. Desea abrirlo ahora?", "Abrir Formulario DGI 3100...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (okOpen == DialogResult.Yes)
                //{
                // try forcing the window to be full-screen maximized
                System.Diagnostics.ProcessStartInfo defapp = new System.Diagnostics.ProcessStartInfo();

                defapp.FileName = newFile;
                defapp.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
                System.Diagnostics.Process.Start(defapp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el documento para el funcionario.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            // }
        }

        private void PruebaBtn_Click(object sender, EventArgs e)
        {
            string pathdoc = Path.Combine(dirbase, dirRelativaDocs);
            string pdftemplate = Path.Combine(pathdoc, "formulario 3100 DGI.pdf");
            
            PdfReader pdfReader = new PdfReader(pdftemplate);
            string newFile = mtNumeroEmpleado.Text + "-" + txtNombre.Text + " " + txtApellido.Text + "-FormularioDGI.pdf";
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;

            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            try
            {
                oDoc = oWord.Documents.Add(ref missing, ref missing,
                    ref missing, ref missing);


                //Insert a paragraph at the end of the document.
                Word.Paragraph oPara2;
                object oRng = null;

                System.Collections.Hashtable h = pdfFormFields.Fields;

                foreach (System.Collections.DictionaryEntry d in h)
                {
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara2.Range.Text = d.Key.ToString();
                    oPara2.Format.SpaceAfter = 6;
                    oPara2.Range.InsertParagraphAfter();
                }

                pdfStamper.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el documento para el funcionario.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void carnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathdoc = Path.Combine(dirbase, dirRelativaDocs);
            object fileName = Path.Combine(pathdoc, "Carnet.doc");// @"C:\Documents and Settings\jcopello\Mis documentos\JPC\TrustSoftware\Codigo\ControlHoras\Docs\Contrato.doc";
            object mark;
            object readOnly = true;

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            try
            {
                oDoc = oWord.Documents.Open(ref fileName,
                            ref missing, ref readOnly, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing);//, ref missing);

                mark = "Apellido";
                Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = txtApellido.Text.Split(' ').ElementAt(0);

                mark = "Nombre";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = txtNombre.Text.Split(' ').ElementAt(0).ToUpper();

                mark = "CI";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = TranfCI(mtNumeroDocumento.Text);

                mark = "NroFunc";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                wrdRng.Text = mtNumeroEmpleado.Text;

                #region foto

                //*************   JUANCHI   *******************            
                mark = "Imagen";
                wrdRng = oDoc.Bookmarks.get_Item(ref mark).Range;
                //wrdRng.Select();
                //oWord.Selection.TypeParagraph();

                if (pbFoto.Image != null)
                {
                    System.Drawing.Image bi = ControladorUtilidades.imageResize(pbFoto.Image, 0.80);
                    
                    
                    Clipboard.SetDataObject(bi);
                    wrdRng.Paste();
                    
                    wrdRng.Select();
                    
                    oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }



                //*************   JUAN PABLO *******************
                //Object myFalse = false;
                //Object myTrue = true;
                //Object myEndOfDoc = "\\endofdoc";

                //// Set the position where the image will be placed
                //wrdRng = oDoc.Bookmarks.get_Item(ref myEndOfDoc).Range;
                //Object myImageRange = oDoc.Bookmarks.get_Item(ref myEndOfDoc).Range;

                //// Set the file of the picture
                //string imagePath = @"C:\Documents and Settings\jcopello\Mis documentos\Mis imágenes\14c.jpg";

                //// Add the picture to the document

                ////myRange.InlineShapes.AddPicture(imagePath, ref myFalse, ref myTrue, ref myImageRange);
                //wrdRng.InlineShapes.AddPicture(imagePath, ref myFalse, ref myTrue, ref myImageRange);          

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el documento para el funcionario.\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAntecedentes_SI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAntecedentes_SI.Checked)
                txtObservacionesAntecedentes.Enabled = true;
            else
                txtObservacionesAntecedentes.Enabled = false;
        }

        private void cmbPolicialMilitar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPolicialMilitar.Text == "Policia")
            {
                lblSubEscalafon.Visible = true;
                txtPolicialSubEscalafon.Visible = true;
                cbCombatiente.Visible = false;
            }
            else
            {
                lblSubEscalafon.Visible = false;
                txtPolicialSubEscalafon.Visible = false;
                cbCombatiente.Visible = true;
            }

        }

        private void tcEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcEmpleado.SelectedIndex == 0)
            {
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
            }
        }

       

        private void BtnReactivar_Click(object sender, EventArgs e)
        {
            //string nroViejo = lblEmpleadoCargado.Text.Split('-').ElementAt(0);
            int nroNuevo = datos.obtenerMaxIdEmpleado() + 1;
            DialogResult res = MessageBox.Show("Seguro que quiere reingresar el Empleado: " + txtNombre.Text + " " + txtApellido.Text + "?\nNúmero viejo: " + mtNumeroEmpleado.Text + "     Número nuevo: "  + nroNuevo.ToString(), "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    datos.cambiarNumeroEmpleado(int.Parse(mtNumeroEmpleado.Text), nroNuevo);
                    
                    mtNumeroEmpleado.Text = nroNuevo.ToString();
                    lblEstadoEmpleado.Text = "Activo";
                    lblEstadoEmpleado.ForeColor = Color.LimeGreen;
                    string fechaIngreso, fechaBaja, motivo;
                    fechaIngreso = dtpFechaIngreso.Text;
                    fechaBaja = dtpFechaBaja.Text;
                    motivo = txtMotivoBaja.Text;
                    txtObservaciones.Text = txtObservaciones.Text + "\r\n" + "INGRESÓ: " + fechaIngreso + "\r\nBAJA: " + fechaBaja + "    MOTIVO: " + motivo;
                    dtpFechaIngreso.Text = DateTime.Now.ToString();
                    dtpFechaAltaBPS.Text = DateTime.Now.ToString();
                    cbNoActivo.Checked = false;
                    dtpFechaBaja.Text = "";
                    txtMotivoBaja.Text = "";
                    cbBajadoBPS.Checked = false;

                    btnGuardar.Enabled = true;
                    btnGuardar.PerformClick();
                    //MessageBox.Show("El empleado a sido reingresado con exito.", "Modifacion con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //mtNumeroEmpleado.Text = nroNuevo.ToString();
                    //SendKeys.Send("{ENTER}");


                    /*
                    btnAgregar.Enabled = false;
                    btnGuardar.Enabled = true;
                    BtnReactivar.Visible = false;
                    btnExtrasAgregar.Enabled = true;
                    btnAgregarHistorial.Enabled = true;
                    ImprimirTSB.Enabled = true;
                     */
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error el cambiar el NumeroEmpleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void mtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtNumeroDocumento.MaskCompleted && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                // Busco si existe un empleado con esta cédula
                ListAnEGRa sujeto;
                EmPleadOs empleado;
                
                try
                {
                    limpiarForm3();
                    if (datos.existeEmpleadoListaNegra(mtNumeroDocumento.Text, out sujeto))
                    {
                        ListaNegra sear = new ListaNegra(sujeto);
                        DialogResult res = sear.ShowDialog(this);

                        if (res == DialogResult.OK)
                        {
                            //Dar de baja en Lista Negra
                            datos.BajaListaNegra(mtNumeroDocumento.Text);

                            //txtApellido.Text = sear.Apellidos;
                            //txtNombre.Text = sear.Nombres;
                            //txtObservaciones.Text ="LISTA NEGRA\r\nINGRESÓ: " + sear.FechaAlta + "    MOTIVO: " + sear.Motivo;

                            string obs = "LISTA NEGRA\r\nINGRESÓ: " + sujeto.FechaAlta.Value.ToString(@"dd/MM/yyyy") + "    MOTIVO: " + sujeto.MotivoRechazo;
                            string nro = (datos.obtenerMaxIdEmpleado() + 1).ToString();

                            datos.altaEmpleadoDesdeListaNegra(mtNumeroDocumento.Text, nro, sujeto.Apellidos, sujeto.Nombres, obs);

                            mtNumeroDocumento.Focus();
                            SendKeys.Send("{ENTER}");

                            
                            
                            //System.Threading.Thread.Sleep(3000);
                            
                            
                            
                            
                        }
                        else
                            btnCancelar.PerformClick();
                    }
                    else
                    {
                        if (datos.existeEmpleadoCI(mtNumeroDocumento.Text, out empleado))
                        {
                            //empleado = datos.obtenerEmpleado(int.Parse(mtNumeroEmpleado.Text));
                            if (empleado.Activo ==1)
                                habilitarPermisosEmpleado(true);
                            else
                                habilitarPermisosEmpleado(false);
                            cargarEmpleado(empleado);
                        }
                        mtNumeroEmpleado.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void habilitarPermisosEmpleado(bool activo)
        {
            if (activo)
            {
                lblEstadoEmpleado.Visible = true;
                lblEmpleadoCargado.Text = mtNumeroEmpleado.Text + " - " + txtNombre.Text + " " + txtApellido.Text;
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
                btnExtrasAgregar.Enabled = true;
                btnAgregarHistorial.Enabled = true;
                ImprimirTSB.Enabled = true;
            }
            else
            {
                lblEstadoEmpleado.Visible = true;
                lblEmpleadoCargado.Text = mtNumeroEmpleado.Text + " - " + txtNombre.Text + " " + txtApellido.Text;
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
                BtnReactivar.Visible = true;
                btnExtrasAgregar.Enabled = false;
                btnAgregarHistorial.Enabled = false;
                ImprimirTSB.Enabled = true;
            }
        }

        private void updateListOfDepartamentos()
        {
            Dictionary<int, string> docs = tipos.obtenerDepartamentos(false);
            CargarCombo(cmbDepartamento, docs);
        }

        private void updateListOfCiudades()
        {
            Dictionary<int, string> docs = tipos.obtenerCiudades(false);
            CargarCombo(cmbCiudades, docs);
        }

        private void updateListOfBarrios()
        {
            Dictionary<int, string> docs = tipos.obtenerBarrios(false);
            CargarCombo(cmbBarrios, docs);
        }

        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            ABMDepartamentos dptos = ABMDepartamentos.getVentana();
            dptos.ShowDialog(this);
            updateListOfDepartamentos();
        }

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            ABMCiudades dptos = ABMCiudades.getVentana();
            dptos.ShowDialog(this);
            updateListOfCiudades();
        }

        private void btnAgregarBarrio_Click(object sender, EventArgs e)
        {
            ABMBarrios dptos = ABMBarrios.getVentana();
            dptos.ShowDialog(this);
            updateListOfBarrios();
        }

        private void updateListOfMutualistas()
        {
            Dictionary<int, string> docs = tipos.obtenerMutualistas(false);
            CargarCombo(cmbMutualista, docs);
        }

        private void btnAgregarMutualista_Click(object sender, EventArgs e)
        {
            ABMMutualistas muts = ABMMutualistas.getVentana();
            muts.ShowDialog(this);
            updateListOfMutualistas();
        }

        private void updateListOfEmergenciaMedica()
        {
            Dictionary<int, string> docs = tipos.obtenerEmergenciaMedicas(false);
            CargarCombo(cmbEmergenciaMedica, docs);
        }

        private void btnAgregarEmergenciaMedica_Click(object sender, EventArgs e)
        {
            ABMEmergenciasMedica emrgs = ABMEmergenciasMedica.getVentana();
            emrgs.ShowDialog(this);
            updateListOfEmergenciaMedica();
        }

        private void updateListOfCargos()
        {
            Dictionary<int,string> listCargos = datosTipos.obtenerTiposCargos(true);
            
            cargos = datosTipos.obtenerTiposCargosList(true);
            CargarCombo(cmbTiposCargos, listCargos);

        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            ABMCargos abmcargos = ABMCargos.getVentana();
            abmcargos.ShowDialog(this);
            updateListOfCargos();
        }



        
     
    }
}


      