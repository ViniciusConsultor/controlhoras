using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
//using System.Drawing.Imaging;
using System.IO;


namespace ControlHoras
{
    public partial class ABMEmpleados : Form
    {
        
        private IEmpleados sistema;
        private string LlenarCamposObligatorios = "Debe llenar todos los campos obligatorios.";

        public ABMEmpleados()
        {
            InitializeComponent();
            sistema = ControladorEmpleados.getInstance();
        }

        private void ABMEmpleados_Load(object sender, EventArgs e)
        {
            #region CargaCombos
            
            // Combo TiposDocumentos
            try
            {
                Dictionary<int, string> docs = sistema.obtenerTiposDocumento();
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
                Dictionary<int, string> docs = sistema.obtenerBancos();
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
                Dictionary<int, string> docs = sistema.obtenerDepartamentos();
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
                Dictionary<int, string> docs = sistema.obtenerEmergenciasMedica();
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
                Dictionary<int, string> docs = sistema.obtenerMutualistas();
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
            #endregion
            btnCancelar.PerformClick();
            mtNumeroEmpleado.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnAgregarHistorial.Enabled = true;
            btnGuardarHistorial.Enabled = false;
            btnEliminarHistorial.Enabled = false;
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
                                ((ComboBox)cgb).SelectedIndex = 0;
                            }
                        }
                    }

                    else if (tipoDelControl == "System.Windows.Forms.PictureBox")
                    {
                        ((PictureBox) c).Image = null;
                    }
                    
                    
                }
            }
        }

        private void mtNumeroEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtNumeroEmpleado.MaskCompleted && e.KeyCode == Keys.Enter)
            { 
                // traigo el empleado y lleno los datos de los campos.
                Empleado empleado;
                try
                {
                    if (sistema.existeEmpleado(int.Parse(mtNumeroEmpleado.Text)))
                    {
                        empleado = sistema.obtenerEmpleado(int.Parse(mtNumeroEmpleado.Text));
                        cargarEmpleado(empleado);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (mtNumeroEmpleado.Text == "")
            {    // Obtengo el ultimo numero de cliente + 1;
            }
        }

        private void cargarEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
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
                ofdFoto.ShowDialog(this);
                Image img = devolverImagen(ofdFoto.FileName.ToString());
                Bitmap imgAchicada = new Bitmap(img, pbFoto.Width, pbFoto.Height);
                pbFoto.Image = (Image) imgAchicada;
                
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

        private byte[] imagenToByte(Image img)
        {
            byte[] byteArray;
            try
            {
                MemoryStream ms = new MemoryStream();
                Image img2 = (Image)img.Clone();
                img2.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                img2.Dispose();
                byteArray = ms.ToArray();
                ms.Close();
                ms.Dispose();
                return byteArray;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkDatosObligatorios())
            {

                try
                {
                    //sistema.modificarEmpleado(int.Parse(mtNumeroEmpleado.Text),txtNombre.Text,txtApellido.Text,int.Parse(cmbDepartamento.ValueMember),mtNumeroDocumento.Text,txtLugarNacimiento.Text, txtNacionalidad.Text,sexo,dtpPsicologo.Value,dtpFechaNacimiento.Value,dtpFechaIngreso.Value,txtTelefono.Text,txtCelular.Text,txtCelularConvenio.Text,txtEmail.Text,cmbEstadoCivil.Text,int.Parse(mtCantidadHijos.Text),foto,int.Parse(cmbBanco.ValueMember),txtNumeroCuenta.Text,float.Parse(mtSueldo.Text),activo,dtpFechaBaja.Value,txtMotivoBaja.Text,int.Parse(cmbDepartamento.ValueMember),txtCiudad.Text,txtDireccion.Text,txtEntreCalles.Text,txtPuntoEncuentro.Text,txtNumAsuntoRenaemse.Text,dtpFechaIngresoRenaemse.Value,int.Parse(mtAcumulacionBPS.Text),dtpFechaAltaBPS.Value,dtpFechaBajaBPS.Value,txtNumeroCAJ.Text,dtpFechaEmisionCAJ.Value,dtpFechaEntregaCAJ.Value,antecedentes,cmbPolicialMilitar.Text,dtpFechaIngresoPolicialMilitar.Value,dtpFechaEgresoPolicialMilitar.Value,txtPolicialSubEscalafon.Text,combatiente,txtTalleCamisa.Text,txtTallePantalon.Text,mtTalleZapatos.Text,txtTalleCampera.Text,dtpFechaVencimientoCarneSalud.Value,int.Parse(cmbMutualista.ValueMember),int.Parse(cmbEmergenciaMedica.ValueMember));
                    btnCancelar.PerformClick();
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
            return (mtNumeroEmpleado.MaskCompleted && txtNombre.Text != "" && txtApellido.Text != "" && cmbTipoDocumento.SelectedIndex > -1 && mtNumeroDocumento.MaskCompleted);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Chequeo Campos Obligatorios
            if (checkDatosObligatorios())
            {
                
                DateTime dtpBaja = DateTime.MinValue.AddDays(1);
                

                try
                {
                    byte[] foto=null;
                    if (pbFoto.Image != null)
                        foto = imagenToByte(pbFoto.Image);
                            
                    char sexo = 'F';
                    if (rbMasculino.Checked)
                        sexo = 'M';
                    bool activo = ! cbNoActivo.Checked;
                    if (cbNoActivo.Checked)
                    {
                        dtpBaja = dtpFechaBaja.Value;
                    }
                    bool combatiente = cbCombatiente.Enabled;
                    bool antecedentes = cbAntecedentePolicialoMilitar.Enabled;
                    int iddepartamento = ((ComboBoxValue) cmbDepartamento.SelectedItem).Value;
                    int idtipodocumento = ((ComboBoxValue)cmbTipoDocumento.SelectedItem).Value;
                    int idmutualista = -1;
                    if (cmbMutualista.SelectedItem != null)
                        idmutualista = ((ComboBoxValue)cmbMutualista.SelectedItem).Value;
                    int idbanco = -1;
                    if (cmbBanco.SelectedItem != null)    
                        idbanco = ((ComboBoxValue)cmbBanco.SelectedItem).Value;
                    int idemergenciamovil = -1;
                    if(cmbEmergenciaMedica.SelectedItem != null)
                        idemergenciamovil = ((ComboBoxValue)cmbEmergenciaMedica.SelectedItem).Value;
                    string estadoCivil = cmbEstadoCivil.Text;
                    int acumulacionLaboral = 0;
                    float sueldo = 0;
                    if (mtSueldo.Text != "")
                        sueldo = float.Parse(mtSueldo.Text);
                    if (mtAcumulacionBPS.Text != "")
                        acumulacionLaboral = int.Parse(mtAcumulacionBPS.Text);
                    int cantHijos = 0;
                    if (mtCantidadHijos.Text != "")
                        cantHijos = int.Parse(mtCantidadHijos.Text);

                   
                    
                    sistema.altaEmpleado(int.Parse(mtNumeroEmpleado.Text),txtNombre.Text,txtApellido.Text,idtipodocumento,mtNumeroDocumento.Text,txtLugarNacimiento.Text, txtNacionalidad.Text,sexo,dtpPsicologo.Value,dtpFechaNacimiento.Value,dtpFechaIngreso.Value,txtTelefono.Text,txtCelular.Text,txtCelularConvenio.Text,txtEmail.Text,estadoCivil,cantHijos,foto,idbanco,txtNumeroCuenta.Text,sueldo,activo,dtpFechaBaja.Value,txtMotivoBaja.Text,iddepartamento,txtCiudad.Text,txtDireccion.Text,txtEntreCalles.Text,txtPuntoEncuentro.Text,txtNumAsuntoRenaemse.Text,dtpFechaIngresoRenaemse.Value,acumulacionLaboral,dtpFechaAltaBPS.Value,dtpFechaBajaBPS.Value,txtNumeroCAJ.Text,dtpFechaEmisionCAJ.Value,dtpFechaEntregaCAJ.Value,antecedentes,cmbPolicialMilitar.Text,dtpFechaIngresoPolicialMilitar.Value,dtpFechaEgresoPolicialMilitar.Value,txtPolicialSubEscalafon.Text,combatiente,txtTalleCamisa.Text,txtTallePantalon.Text,mtTalleZapatos.Text,txtTalleCampera.Text,dtpFechaVencimientoCarneSalud.Value,idmutualista,idemergenciamovil);
                    btnCancelar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void cmbPolicialMilitar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicialMilitar.Text == "Policia")
            {
                lblSubEscalafon.Visible = true;
                txtPolicialSubEscalafon.Visible = true;
                txtPolicialSubEscalafon.Enabled = true;
                cbCombatiente.Visible = false;
            }
            else if (cmbPolicialMilitar.Text == "Militar")
            {
                txtPolicialSubEscalafon.Visible = false;
                lblSubEscalafon.Visible = false;
                cbCombatiente.Visible = true;
                cbCombatiente.Enabled = true;
            }
        }



    }
}
