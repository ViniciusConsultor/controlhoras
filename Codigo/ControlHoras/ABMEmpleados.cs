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
using Utilidades;
using Datos;



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

            sistema = ControladorEmpleados.getInstance();
            datos = ControladorDatos.getInstance();
            datosTipos = DatosABMTipos.getInstance();
            tipos = ControladorABMTipos.getInstance();
            
        }

        private void ABMEmpleados_Load(object sender, EventArgs e)
        {
            #region CargaCombos
            
            // Combo TiposDocumentos
            try
            {
                Dictionary<int, string> docs = tipos.obtenerTipoDocumentos(false);
                cmbTipoDocumento.ValueMember = "Value";
                cmbTipoDocumento.DisplayMember = "Display";
                cmbTipoDocumento.BeginUpdate();
                foreach (int key in docs.Keys)
                {
                    ComboBoxValue cbval = new ComboBoxValue(docs[key], key);
                    cmbTipoDocumento.Items.Add(cbval);
                }
                cmbTipoDocumento.EndUpdate();
            }catch(Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            // Combo Bancos
            try
            {
                Dictionary<int, string> docs = tipos.obtenerBancos(false);
                cmbBanco.ValueMember = "Value";
                cmbBanco.DisplayMember = "Display";
                cmbBanco.BeginUpdate();
                foreach (int key in docs.Keys)
                {
                    ComboBoxValue cbval = new ComboBoxValue(docs[key], key);
                    cmbBanco.Items.Add(cbval);
                }
                cmbBanco.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Combo Departamentos
            try
            {
                Dictionary<int, string> docs = tipos.obtenerDepartamentos(false);
                cmbDepartamento.ValueMember = "Value";
                cmbDepartamento.DisplayMember = "Display";
                cmbDepartamento.BeginUpdate();
                foreach (int key in docs.Keys)
                {
                    ComboBoxValue cbval = new ComboBoxValue(docs[key], key);
                    cmbDepartamento.Items.Add(cbval);
                }
                cmbDepartamento.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Combo EmergenciaMedica
            try
            {
                Dictionary<int, string> docs = tipos.obtenerEmergenciaMedicas(false);
                cmbEmergenciaMedica.ValueMember = "Value";
                cmbEmergenciaMedica.DisplayMember = "Display";
                cmbEmergenciaMedica.BeginUpdate();
                foreach (int key in docs.Keys)
                {
                    ComboBoxValue cbval = new ComboBoxValue(docs[key], key);
                    cmbEmergenciaMedica.Items.Add(cbval);
                }
                cmbEmergenciaMedica.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Combo Mutualistas
            try
            {
                Dictionary<int, string> docs = tipos.obtenerMutualistas(false);
                cmbMutualista.ValueMember = "Value";
                cmbMutualista.DisplayMember = "Display";
                cmbMutualista.BeginUpdate();
                foreach (int key in docs.Keys)
                {
                    ComboBoxValue cbval = new ComboBoxValue(docs[key], key);
                    cmbMutualista.Items.Add(cbval);
                }
                cmbMutualista.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Combo TipoEventosHistorial
            try
            {
                List<TipOsEventOHistOrIal> tiposeventos = datosTipos.obtenerTiposEventoHistorial(false);
                listaTiposEventos = tiposeventos;
                cmbTipoEventoHistorial.ValueMember = "Value";
                cmbTipoEventoHistorial.DisplayMember = "Display";
                cmbTipoEventoHistorial.BeginUpdate();
                foreach (TipOsEventOHistOrIal tipo in tiposeventos )
                {
                    ComboBoxValue cbval = new ComboBoxValue(tipo.Nombre,tipo.IDTipoEventoHistorial );
                    cmbTipoEventoHistorial.Items.Add(cbval);
                }
                cmbTipoEventoHistorial.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cargar TiposCargos
            try
            {
                cargos = datosTipos.obtenerTiposCargos(true);
                cmbTiposCargos.ValueMember = "Value";
                cmbTiposCargos.DisplayMember = "Display";
                cmbTiposCargos.BeginUpdate();
                foreach (TipOscarGoS tipo in cargos)
                {
                    ComboBoxValue cbval = new ComboBoxValue(tipo.Nombre, (int)tipo.IDCargo);
                    cmbTiposCargos.Items.Add(cbval);
                }
                cmbTiposCargos.EndUpdate();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error Cargando las Cargos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
            
            btnCancelar.PerformClick();
            mtNumeroEmpleado.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            dgvExtrasLiquidacion.Rows.Clear();
            limpiarTabExtrasLiquidacion();
            dgvHistorialEmpleado.Rows.Clear();
            limpiarTabHistorial();
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnAgregarHistorial.Enabled = false;
            btnGuardarHistorial.Enabled = false;
            btnEliminarHistorial.Enabled = false;
            btnExtrasAgregar.Enabled = false;
            btnExtrasEliminar.Enabled = false;
            btnExtrasGuardar.Enabled = false;
            dtpFechaIngreso.Value = DateTime.Now;
            mtNumeroEmpleado.Focus();

        }


        private void limpiarForm()
        {
            foreach (TabPage tp in tcEmpleado.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    string tipoDelControl;
                    tipoDelControl = c.GetType().ToString();
                    if (tipoDelControl == "ControlHoras.TextBoxKeyDown" || tipoDelControl == "ControlHoras.MaskedTextBoxKeyDown")
                        c.Text = "";
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
                        }
                    }

                    else if (tipoDelControl == "System.Windows.Forms.PictureBox")
                    {
                        ((PictureBox) c).Image = null;
                    }

                    lblEmpleadoCargado.Text = "";
                    
                    
                }
            }
        }

        private void mtNumeroEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtNumeroEmpleado.Text != "" && e.KeyCode == Keys.Enter)
            { 
                // traigo el empleado y lleno los datos de los campos.
                EmPleadOs empleado;
                try
                {
                    if (sistema.existeEmpleado(int.Parse(mtNumeroEmpleado.Text)))
                    {
                        empleado = datos.obtenerEmpleado(int.Parse(mtNumeroEmpleado.Text));
                        cargarEmpleado(empleado);
                        lblEmpleadoCargado.Text = mtNumeroEmpleado.Text + " - " + txtNombre.Text + " " + txtApellido.Text;
                        btnAgregar.Enabled = false;
                        btnGuardar.Enabled = true;
                        btnExtrasAgregar.Enabled = true;
                        btnAgregarHistorial.Enabled = true;
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
            try
            {
                txtApellido.Text = empleado.Apellido;
            }
            catch (Exception e) { }
            try
            {
                cmbBanco.SelectedIndex = (int) empleado.IDBanco;
            }
            catch (Exception e) { }
            try
            {
                txtBarrio.Text = empleado.Barrio;
            }
            catch (Exception e) { }
            try
            {
                mtAcumulacionBPS.Text = empleado.BpsaCumulacionLaboral.ToString();
                
            }
            catch (Exception e) { }
            try
            {
                dtpFechaAltaBPS.Value = empleado.BpsfEchaAlta.Value;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaBajaBPS.Value = empleado.BpsfEchaBaja.Value;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaEmisionCAJ.Value = empleado.CajfEchaEmision.Value;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaEntregaCAJ.Value = empleado.CajfEchaEntrega.Value;
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
                txtCelularConvenio.Text  = empleado.CelularenConvenio;
            }
            catch (Exception e) { }
            try
            {
                txtCiudad.Text = empleado.Ciudad;
            }
            catch (Exception e) { }
            if (empleado.CombatienteMilitar ==1)
                cbCombatiente.Checked = true;
            else
                cbCombatiente.Checked = false;
            try
            {
                cmbDepartamento.SelectedIndex = (int)empleado.IDDepartamento;
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
                cmbEmergenciaMedica.SelectedIndex = (int) empleado.IDEmergenciaMedica;
            }
            catch (Exception e) { }
            try
            {
                txtEntreCalles.Text = empleado.EntreCalles;
            }
            catch (Exception e) { }
            try
            {
                cmbEstadoCivil.SelectedText = empleado.EstadoCivil;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaBaja.Value = empleado.FechaBaja.Value;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaEgresoPolicialMilitar.Value = empleado.FechaEgresoPolicialoMilitar.Value;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaIngreso.Value = empleado.FechaIngreso.Value;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaIngresoRenaemse.Value = empleado.RenaemsefEchaIngreso.Value;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaIngresoPolicialMilitar.Value = empleado.FechaIngresoPolicialoMilitar.Value ;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaNacimiento.Value = empleado.FechaNacimiento.Value;
            }
            catch (Exception e) { }
            try
            {
                dtpPsicologo.Value = empleado.FechaTestPsicologico.Value;
            }
            catch (Exception e) { }
            try
            {
                dtpFechaVencimientoCarneSalud.Value =  empleado.FechaVencimientoCarneDeSalud.Value;
            }
            catch (Exception e) { }
            try
            {
                Image img = ControladorUtilidades.convertByteArrayToImage(empleado.Foto);
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
                cmbMutualista.SelectedIndex = (int) empleado.IDMutualista;
            }
            catch (Exception e) { }
            try
            {
                txtNacionalidad.Text = empleado.Nacionalidad;
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
                txtNumeroCuenta.Text = empleado.NumeroCuenta;
            }
            catch (Exception e) { }
            try
            {
                mtNumeroDocumento.Text = empleado.NumeroDocumento;
            }
            catch (Exception e) { }
            try
            {
                mtNumeroEmpleado.Text = empleado.IDEmpleado.ToString();
            }
            catch (Exception e) { }
            try
            {
                empleado.Observaciones = empleado.Observaciones;
            }
            catch (Exception e) { }
            try
            {
                empleado.ObservacionesAntecedentes = empleado.ObservacionesAntecedentes;
            }
            catch (Exception e) { }
            if (empleado.EnServicioArmado == 0)
                cbEnServicioArmado.Checked = false;
            else
                cbEnServicioArmado.Checked = true;
            try
            {
                if (empleado.SexO == "M")
                    rbMasculino.Checked = true;
                else
                    rbFemenino.Checked = true;
            }
            catch (Exception e) { }
            try
            {
                txtPolicialSubEscalafon.Text = empleado.SubEscalafonPolicial;
            }
            catch (Exception e) { }
            try
            {
                txtSueldo.Text = empleado.SueldoActual.ToString();
            }
            catch (Exception e) { }
            try
            {
                txtTalleCamisa.Text = empleado.TalleCamisa;
            }
            catch (Exception e) { }
            try
            {
                txtTalleCampera.Text = empleado.TalleCampera;
            }
            catch (Exception e) { }
            try
            {
                txtTallePantalon.Text = empleado.TallePantalon;
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
                // Chequear porque el Selected index no deberia ser igual al IdTipoDocumento.
                cmbTipoDocumento.SelectedIndex = empleado.IDTipoDocumento;
            }
            catch (Exception e) { }
            lblEdad.Text = calcularEdad(dtpFechaNacimiento.Value).ToString();

            cargarHistorialEmpleado((int)empleado.IDEmpleado);
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
                    Image img = devolverImagen(ofdFoto.FileName.ToString());
                    Bitmap imgAchicada = new Bitmap(img, pbFoto.Width, pbFoto.Height);
                    pbFoto.Image = (Image)imgAchicada;
                }
                
            }
            catch (Exception ioe)
            {
                MessageBox.Show(this, ioe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private Image devolverImagen(string fileName)
        {
            Image result;
    	 
	        long size = (new FileInfo(fileName)).Length;
	        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[size];
            try {
            fs.Read(data, 0, (int)size);
	        } finally {
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
            return (mtNumeroEmpleado.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && cmbTipoDocumento.SelectedIndex > -1 && mtNumeroDocumento.Text != "");

        }

        private void agregarOModificarEmpleado(bool agregar)
        {
            DateTime dtpBaja = DateTime.MinValue.AddDays(1);


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
                    dtpBaja = dtpFechaBaja.Value;
                }
                bool combatiente = cbCombatiente.Enabled;
                bool antecedentesPolicialesOMilitares = cbAntecedentePolicialoMilitar.Enabled;
                int iddepartamento = ((ComboBoxValue)cmbDepartamento.SelectedItem).Value;
                int idtipodocumento = ((ComboBoxValue)cmbTipoDocumento.SelectedItem).Value;
                int idmutualista = -1;
                if (cmbMutualista.SelectedItem != null)
                    idmutualista = ((ComboBoxValue)cmbMutualista.SelectedItem).Value;
                int idbanco = -1;
                if (cmbBanco.SelectedItem != null)
                    idbanco = ((ComboBoxValue)cmbBanco.SelectedItem).Value;
                int idemergenciamovil = -1;
                if (cmbEmergenciaMedica.SelectedItem != null)
                    idemergenciamovil = ((ComboBoxValue)cmbEmergenciaMedica.SelectedItem).Value;
                string estadoCivil = cmbEstadoCivil.Text;
                int acumulacionLaboral = 0;
                float sueldo = 0;
                if (txtSueldo.Text != "")
                    sueldo = float.Parse(txtSueldo.Text);
                if (mtAcumulacionBPS.Text != "")
                    acumulacionLaboral = int.Parse(mtAcumulacionBPS.Text);
                int cantMenoresACargo = 0;
                if (mtCantidadHijos.Text != "")
                    cantMenoresACargo = int.Parse(mtCantidadHijos.Text);

                bool capacitadoPortarArma = cbCapacitadoPorteArma.Checked;
                bool enServicioArmado = cbEnServicioArmado.Checked;
                int edad = 0;
                if (lblEdad.Text != "")
                    edad = int.Parse(lblEdad.Text);
                bool antecedentesEmpleado= rbAntecedentes_SI.Checked;

                if (agregar)
                     
                    //sistema.altaEmpleado(int.Parse(mtNumeroEmpleado.Text), txtNombre.Text, txtApellido.Text, idtipodocumento, mtNumeroDocumento.Text, txtLugarNacimiento.Text, txtNacionalidad.Text, sexo, dtpPsicologo.Value, dtpFechaNacimiento.Value, dtpFechaIngreso.Value, txtTelefono.Text, txtCelular.Text, txtCelularConvenio.Text, txtEmail.Text, estadoCivil, cantHijos, foto, idbanco, txtNumeroCuenta.Text, sueldo, activo, dtpFechaBaja.Value, txtMotivoBaja.Text, iddepartamento, txtCiudad.Text, txtDireccion.Text, txtEntreCalles.Text, txtPuntoEncuentro.Text, txtNumAsuntoRenaemse.Text, dtpFechaIngresoRenaemse.Value, acumulacionLaboral, dtpFechaAltaBPS.Value, dtpFechaBajaBPS.Value, txtNumeroCAJ.Text, dtpFechaEmisionCAJ.Value, dtpFechaEntregaCAJ.Value, antecedentes, cmbPolicialMilitar.Text, dtpFechaIngresoPolicialMilitar.Value, dtpFechaEgresoPolicialMilitar.Value, txtPolicialSubEscalafon.Text, combatiente, txtTalleCamisa.Text, txtTallePantalon.Text, mtTalleZapatos.Text, txtTalleCampera.Text, dtpFechaVencimientoCarneSalud.Value, idmutualista, idemergenciamovil);
                    datos.altaEmpleado(int.Parse(mtNumeroEmpleado.Text), TranfaTitulo(txtNombre.Text), txtApellido.Text, idtipodocumento, mtNumeroDocumento.Text, txtLugarNacimiento.Text, txtNacionalidad.Text, sexo, dtpPsicologo.Value, dtpFechaNacimiento.Value, edad, dtpFechaIngreso.Value, txtTelefono.Text, txtCelular.Text, txtCelularConvenio.Text, txtEmail.Text, estadoCivil, cantMenoresACargo, foto, idbanco, txtNumeroCuenta.Text, sueldo, activo, dtpFechaBaja.Value, txtMotivoBaja.Text, iddepartamento, txtCiudad.Text, txtBarrio.Text, txtDireccion.Text, txtEntreCalles.Text, txtPuntoEncuentro.Text, txtNumAsuntoRenaemse.Text, dtpFechaIngresoRenaemse.Value, acumulacionLaboral, dtpFechaAltaBPS.Value, dtpFechaBajaBPS.Value, txtNumeroCAJ.Text, dtpFechaEmisionCAJ.Value, dtpFechaEntregaCAJ.Value, antecedentesEmpleado, txtObservacionesAntecedentes.Text, antecedentesPolicialesOMilitares, cmbPolicialMilitar.Text, dtpFechaIngresoPolicialMilitar.Value, dtpFechaEgresoPolicialMilitar.Value, txtPolicialSubEscalafon.Text, combatiente, txtTalleCamisa.Text, txtTallePantalon.Text, mtTalleZapatos.Text, txtTalleCampera.Text, dtpFechaVencimientoCarneSalud.Value, idmutualista, idemergenciamovil, capacitadoPortarArma, enServicioArmado, txtObservaciones.Text);
                    //datos.modificarEmpleado(idEmpleado, nombre,                         apellido, idTipoDocumento, documento, lugarNacimiento, nacionalidad, sexo, fechaPsicologo, fechaNacimiento, edad, fechaIngreso, telefono, celular, celularConvenio, email, estadoCivil, cantidadHijos, foto, idBanco, numeroCuenta, sueldo, activo, fechaBaja, motivoBaja, idDepartamento, ciudad, barrio, direccion, entreCalles, puntoEncuentro, numeroAsuntoRENAEMSE, fechaIngresoRENAEMSE, acumulacionLaboralBPS, fechaAltaBPS, fechaBajaBPS, numeroCAJ, fechaEmisionCAJ, fechaEntregaCAJ, antecedentesEmpleado, observacionesAntecedentesEmpleado, antecedentesPolicialesOMilitares, PolicialOMilitar, fechaIngresoAntecedete, fechaEgresoAntecedente, subEscalafon, combatiente, talleCamisa, tallePantalon, talleZapatos, talleCampera, vencimientoCarneSalud, idMutualista, idEmergenciaMedica,capacitadoPorteArma,enServicioArmado,observacionesEmpleado);
                else
                    datos.modificarEmpleado(int.Parse(mtNumeroEmpleado.Text), TranfaTitulo(txtNombre.Text), txtApellido.Text, idtipodocumento, mtNumeroDocumento.Text, txtLugarNacimiento.Text, txtNacionalidad.Text, sexo, dtpPsicologo.Value, dtpFechaNacimiento.Value, edad, dtpFechaIngreso.Value, txtTelefono.Text, txtCelular.Text, txtCelularConvenio.Text, txtEmail.Text, estadoCivil, cantMenoresACargo, foto, idbanco, txtNumeroCuenta.Text, sueldo, activo, dtpFechaBaja.Value, txtMotivoBaja.Text, iddepartamento, txtCiudad.Text, txtBarrio.Text, txtDireccion.Text, txtEntreCalles.Text, txtPuntoEncuentro.Text, txtNumAsuntoRenaemse.Text, dtpFechaIngresoRenaemse.Value, acumulacionLaboral, dtpFechaAltaBPS.Value, dtpFechaBajaBPS.Value, txtNumeroCAJ.Text, dtpFechaEmisionCAJ.Value, dtpFechaEntregaCAJ.Value, antecedentesEmpleado, txtObservacionesAntecedentes.Text, antecedentesPolicialesOMilitares, cmbPolicialMilitar.Text, dtpFechaIngresoPolicialMilitar.Value, dtpFechaEgresoPolicialMilitar.Value, txtPolicialSubEscalafon.Text, combatiente, txtTalleCamisa.Text, txtTallePantalon.Text, mtTalleZapatos.Text, txtTalleCampera.Text, dtpFechaVencimientoCarneSalud.Value, idmutualista, idemergenciamovil, capacitadoPortarArma, enServicioArmado, txtObservaciones.Text);
                btnCancelar.PerformClick();
            }
            catch (Exception ex)
            {
                throw ex;
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
                dtpFechaBaja.Value = DateTime.Today;
            }
            else
            {
                dtpFechaBaja.Enabled = false;
                txtMotivoBaja.Enabled = false;
            }
        }

        private void cbAntecedentePolicialoMilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAntecedentePolicialoMilitar.Checked)
            {
                cmbPolicialMilitar.Enabled = true;
                dtpFechaIngresoPolicialMilitar.Enabled = true;
                dtpFechaEgresoPolicialMilitar.Enabled = true;
                cmbPolicialMilitar.SelectedIndex = 0;
                txtPolicialSubEscalafon.Enabled = true;
                
            }
            else
            {
                cmbPolicialMilitar.Enabled = false;
                dtpFechaIngresoPolicialMilitar.Enabled = false;
                dtpFechaEgresoPolicialMilitar.Enabled = false;
                txtPolicialSubEscalafon.Enabled = false;
            }

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            
            lblEdad.Text = calcularEdad(dtpFechaNacimiento.Value).ToString();
        }

        private int calcularEdad(DateTime fecha)
        {
            int anio = (DateTime.Now.Year - dtpFechaNacimiento.Value.Year);
            if (DateTime.Now.Month < dtpFechaNacimiento.Value.Month)
                anio = anio - 1;
            else if (DateTime.Now.Month == dtpFechaNacimiento.Value.Month)
                if (DateTime.Now.Day < dtpFechaNacimiento.Value.Day)
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
            if (dtpFechaInicioHistorial.Value > dtpFechaFinHistorial.Value)
                MessageBox.Show("La Fecha Fin tiene que ser mayor que la Fecha Inicio.");
            else if (cmbTipoEventoHistorial.SelectedIndex >=0 && txtDescripcionHistorial.Text != "")
            {
                int n = -10;
                try
                {
                 
                    int idTipoEventoSelected = ((ComboBoxValue) cmbTipoEventoHistorial.Items[cmbTipoEventoHistorial.SelectedIndex]).Value;
                    int numEventoNuevo = datos.agregarEventoHistorialEmpleado(int.Parse(mtNumeroEmpleado.Text), dtpFechaInicioHistorial.Value, dtpFechaFinHistorial.Value, idTipoEventoSelected , txtDescripcionHistorial.Text);
                    // Una vez agregado el registro, insertamos una nueva fila en el datagrid
                    n = dgvHistorialEmpleado.Rows.Add();
                    dgvHistorialEmpleado.Rows[n].Cells["IdEventoHistorialEmpleado"].Value = numEventoNuevo.ToString();
                    dgvHistorialEmpleado.Rows[n].Cells["FechaInicio"].Value = dtpFechaInicioHistorial.Value.ToShortDateString();
                    dgvHistorialEmpleado.Rows[n].Cells["FechaFin"].Value = dtpFechaFinHistorial.Value.ToShortDateString();

                    dgvHistorialEmpleado.Rows[n].Cells["Descripcion"].Value = txtDescripcionHistorial.Text ;
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
                MessageBox.Show("Debe llenar todos los datos.","Faltan Datos",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void limpiarTabHistorial()
        {
            dtpFechaInicioHistorial.Value = DateTime.Today;
            dtpFechaFinHistorial.Value = DateTime.Today;
            //cmbTipoEventoHistorial.SelectedIndex = 0;
            txtDescripcionHistorial.Text = "";
            btnAddTipoEvento.Enabled = true;
            btnEliminarHistorial.Enabled = false;
            btnGuardarHistorial.Enabled = false;
        }

        private void btnGuardarHistorial_Click(object sender, EventArgs e)
        {
            int numFila = 0;
            while (dgvHistorialEmpleado.RowCount > numFila && lblIdEventoHistorialEmpleado.Text != dgvHistorialEmpleado.Rows[numFila].Cells["IdEventoHistorialEmpleado"].Value.ToString())
            {
                numFila++;
            }
            if (numFila != dgvHistorialEmpleado.RowCount)
            {

                if (dtpFechaInicioHistorial.Value > dtpFechaFinHistorial.Value)
                    MessageBox.Show("La Fecha Fin tiene que ser mayor que la Fecha Inicio.");
                else if (cmbTipoEventoHistorial.SelectedIndex >= 0 && txtDescripcionHistorial.Text != "")
                {
                    int idEvento = ((ComboBoxValue) cmbTipoEventoHistorial.SelectedItem).Value;
                    datos.modificarEventoHistorialEmpleado(int.Parse(lblIdEventoHistorialEmpleado.Text), int.Parse(mtNumeroEmpleado.Text), dtpFechaInicioHistorial.Value, dtpFechaFinHistorial.Value, idEvento, txtDescripcionHistorial.Text);
                    dgvHistorialEmpleado.Rows[numFila].Cells["IdEventoHistorialEmpleado"].Value = lblIdEventoHistorialEmpleado.Text;
                    dgvHistorialEmpleado.Rows[numFila].Cells["FechaInicio"].Value = dtpFechaInicioHistorial.Value.ToShortDateString();
                    dgvHistorialEmpleado.Rows[numFila].Cells["FechaFin"].Value = dtpFechaFinHistorial.Value.ToShortDateString();

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
            if (dtpFechaInicioHistorial.Value > dtpFechaFinHistorial.Value)
                MessageBox.Show("La Fecha Fin tiene que ser mayor que la Fecha Inicio.","Error Fechas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else if (cmbTipoEventoHistorial.SelectedIndex >=0 && txtDescripcionHistorial.Text != "")
            {
                DialogResult dr = MessageBox.Show("Seguro que desea eliminar el Evento del Empleado?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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
                MessageBox.Show("Debe llenar todos los datos.","Faltan Datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    
                    int index=-1;
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
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                lblIdEventoHistorialEmpleado.Text = dgvHistorialEmpleado.Rows[e.RowIndex].Cells["IdEventoHistorialEmpleado"].Value.ToString();
                dtpFechaInicioHistorial.Value = DateTime.Parse(dgvHistorialEmpleado.Rows[e.RowIndex].Cells["FechaInicio"].Value.ToString());
                dtpFechaFinHistorial.Value = DateTime.Parse(dgvHistorialEmpleado.Rows[e.RowIndex].Cells["FechaFin"].Value.ToString());
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
                btnEliminarHistorial.Enabled= true;
                     
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion


        #region ExtraLiquidacionEmpleado

        private void btnExtrasAgregar_Click(object sender, EventArgs e)
        {
            if (txtExtrasDescripcion.Text  != "" && mtExtrasValor.Text != "" && cmbExtrasSigno.SelectedIndex >=0 && mtExtrasCantCuotas.Text != "" )
            {
                try
                {
                    char signo = cmbExtrasSigno.Text.ToCharArray()[0];
                    bool signoPositivo = false;
                    if (signo == '+')
                        signoPositivo = true;
                    mtExtrasValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
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
                MessageBox.Show("Debe llenar todos los datos.","Faltan Datos",MessageBoxButtons.OK,MessageBoxIcon.Error);

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
            if (txtExtrasDescripcion.Text != "" && mtExtrasValor.Text != ""  && cmbExtrasSigno.SelectedIndex >= 0 && mtExtrasCantCuotas.Text != "")
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
                DialogResult dr = MessageBox.Show("Seguro que desea eliminar el Extra Liquidación?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                     try
                     {
                    datos.eliminarExtraLiquidacionEmpleado(int.Parse(mtNumeroEmpleado.Text), int.Parse(lblIdExtraLiquidacion.Text),dtpExtrasFecha.Value);
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
                    List<ExtrasLiquidAcIonEmPleadO> listaExtras = datos.obtenerExtrasLiquidacionEmpleado(int.Parse(mtNumeroEmpleado.Text), dtpExtrasFecha.Value);
                    // Vacio la grilla
                    dgvExtrasLiquidacion.Rows.Clear();


                    // llenado de la grilla con estos datos

                    foreach (ExtrasLiquidAcIonEmPleadO extra in listaExtras)
                    {
                        n = dgvExtrasLiquidacion.Rows.Add();
                        dgvExtrasLiquidacion.Rows[n].Cells["IdExtraLiquidacion"].Value = extra.IDExtrasLiquidacionEmpleado;
                        dgvExtrasLiquidacion.Rows[n].Cells["Fecha"].Value = extra.Fecha.ToShortDateString();
                        dgvExtrasLiquidacion.Rows[n].Cells["DescripcionEvento"].Value = extra.Descripcion;
                        if (extra.Signo == 1)
                            dgvExtrasLiquidacion.Rows[n].Cells["Signo"].Value = "+";
                        else
                            dgvExtrasLiquidacion.Rows[n].Cells["Signo"].Value = "-";
                        dgvExtrasLiquidacion.Rows[n].Cells["Valor"].Value = extra.Valor;
                        dgvExtrasLiquidacion.Rows[n].Cells["CuotaActual"].Value = extra.CuotaActual;
                        dgvExtrasLiquidacion.Rows[n].Cells["CantidadCuotas"].Value = extra.CantidadCuotas;
                        if (extra.Liquidado == 1)
                            dgvExtrasLiquidacion.Rows[n].Cells["Liquidado"].Value = "Si";
                        else
                            dgvExtrasLiquidacion.Rows[n].Cells["Liquidado"].Value = "No";

                    }
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
            dtpFechaBajaBPS.Enabled = cbBajadoBPS.Checked;
            dtpFechaBajaBPS.Value = DateTime.Today;
        }

        private void cbBajadoMTSS_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaBajaMTSS.Enabled = cbBajadoMTSS.Checked;
            dtpFechaBajaMTSS.Value = DateTime.Today;
        }

        private void cbEgresadoEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaEgresoEmpresa.Enabled = cbEgresadoEmpresa.Checked;
            dtpFechaEgresoEmpresa.Value = DateTime.Today;
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

        private void btnAddTipoEvento_Click(object sender, EventArgs e)
        {
            ABMTipoEventoHistorial abmtiposeventos = ABMTipoEventoHistorial.getVentana();
            abmtiposeventos.ShowDialog(this);
        }

        private void cmbTiposCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
           int idtipocargo;
            try
           {
               if (cmbTiposCargos.SelectedItem != null)
               {
                   idtipocargo = ((ComboBoxValue)cmbTiposCargos.SelectedItem).Value;
                   foreach(TipOscarGoS cargo in cargos)
                   {
                       if (cargo.IDCargo == idtipocargo)
                           lblTipoFacturacion.Text = cargo.TipoFacturacion.ToString();
                   }
               }
            }catch(Exception ex)
            {
                 MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtNumeroEmpleado.Text != "")
                {
                    int? numemp = datos.obtenerProximoIdEmpleadoActivo(int.Parse(mtNumeroEmpleado.Text));
                    if (numemp != null)
                    {
                        mtNumeroEmpleado.Text = numemp.ToString();
                        mtNumeroEmpleado.Focus();

                        SendKeys.Send("{ENTER}");
                    }
                    else
                        MessageBox.Show("No existe un empleado activo anterior a este.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                        MessageBox.Show("No existe un empleado activo anterior a este.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string dest = ori.Trim();
            int esp = dest.LastIndexOf(" ");
            string aux = (esp+2 < dest.Length)? dest.Substring(esp + 2).ToLower():"?";
            if (esp == -1)
                return dest.Substring(0, 1).ToUpper() + dest.Substring(1).ToLower();
            else
                return dest.Substring(0, 1).ToUpper() + dest.Substring(1, esp).ToLower() + dest.Substring(esp + 1, 1).ToUpper() + aux;
        }

    }
}


      