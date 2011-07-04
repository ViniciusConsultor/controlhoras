
namespace ControlHoras
{
    partial class ABMClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnServicios = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNoActivo = new System.Windows.Forms.CheckBox();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotivoBaja = new ControlHoras.TextBoxKeyDown();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaBaja = new ControlHoras.MaskedTextBoxKeyDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelefonoCobro = new ControlHoras.TextBoxKeyDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreParaCobrar = new ControlHoras.TextBoxKeyDown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDiaHoraCobro = new ControlHoras.TextBoxKeyDown();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReferencia = new ControlHoras.TextBoxKeyDown();
            this.txtDireccionCobro = new ControlHoras.TextBoxKeyDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new ControlHoras.MaskedTextBoxKeyDown();
            this.txtFax = new ControlHoras.TextBoxKeyDown();
            this.txtTelefonos = new ControlHoras.TextBoxKeyDown();
            this.mtCliente = new ControlHoras.MaskedTextBoxKeyDown();
            this.txtEmail = new ControlHoras.TextBoxKeyDown();
            this.txtNombre = new ControlHoras.TextBoxKeyDown();
            this.txtDireccion = new ControlHoras.TextBoxKeyDown();
            this.txtNombreFantasia = new ControlHoras.TextBoxKeyDown();
            this.mtRUT = new ControlHoras.MaskedTextBoxKeyDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mtDiaInicioFacturacion = new System.Windows.Forms.MaskedTextBox();
            this.mtDiaFinFacturacion = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre *";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnGuardar,
            this.btnCancelar,
            this.toolStripSeparator1,
            this.btnBuscarCliente,
            this.toolStripSeparator2,
            this.btnServicios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(374, 36);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ControlHoras.Imagenes.document_new;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 33);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 33);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 33);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::ControlHoras.Imagenes.ClientsSearch42x42;
            this.btnBuscarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(79, 33);
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // btnServicios
            // 
            this.btnServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnServicios.Image")));
            this.btnServicios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(53, 33);
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RUT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre Fantasia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teléfonos *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fax";
            // 
            // cbNoActivo
            // 
            this.cbNoActivo.AutoSize = true;
            this.cbNoActivo.Location = new System.Drawing.Point(37, 22);
            this.cbNoActivo.Name = "cbNoActivo";
            this.cbNoActivo.Size = new System.Drawing.Size(73, 17);
            this.cbNoActivo.TabIndex = 0;
            this.cbNoActivo.Text = "No Activo";
            this.cbNoActivo.UseVisualStyleBackColor = true;
            this.cbNoActivo.CheckedChanged += new System.EventHandler(this.cbNoActivo_CheckedChanged);
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEstadoCliente.Location = new System.Drawing.Point(169, 49);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(140, 20);
            this.lblEstadoCliente.TabIndex = 15;
            this.lblEstadoCliente.Text = "lblEstadoCliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fecha Baja";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotivoBaja);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpFechaBaja);
            this.groupBox1.Controls.Add(this.cbNoActivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 83);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // txtMotivoBaja
            // 
            this.txtMotivoBaja.Enabled = false;
            this.txtMotivoBaja.Location = new System.Drawing.Point(52, 48);
            this.txtMotivoBaja.MaxLength = 255;
            this.txtMotivoBaja.Name = "txtMotivoBaja";
            this.txtMotivoBaja.Size = new System.Drawing.Size(288, 20);
            this.txtMotivoBaja.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Motivo *";
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Enabled = false;
            this.dtpFechaBaja.Location = new System.Drawing.Point(190, 19);
            this.dtpFechaBaja.Mask = "00/00/0000";
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(70, 20);
            this.dtpFechaBaja.TabIndex = 1;
            this.dtpFechaBaja.Validating += new System.ComponentModel.CancelEventHandler(this.dtpFechaBaja_Validating);
            this.dtpFechaBaja.Validated += new System.EventHandler(this.dtpFechaBaja_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Referencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Dirección de Cobro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTelefonoCobro);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtNombreParaCobrar);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtDiaHoraCobro);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtDireccionCobro);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 148);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cobranza";
            // 
            // txtTelefonoCobro
            // 
            this.txtTelefonoCobro.Location = new System.Drawing.Point(109, 122);
            this.txtTelefonoCobro.MaxLength = 150;
            this.txtTelefonoCobro.Name = "txtTelefonoCobro";
            this.txtTelefonoCobro.Size = new System.Drawing.Size(231, 20);
            this.txtTelefonoCobro.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Telefonos Cobro";
            // 
            // txtNombreParaCobrar
            // 
            this.txtNombreParaCobrar.Location = new System.Drawing.Point(109, 96);
            this.txtNombreParaCobrar.MaxLength = 100;
            this.txtNombreParaCobrar.Name = "txtNombreParaCobrar";
            this.txtNombreParaCobrar.Size = new System.Drawing.Size(231, 20);
            this.txtNombreParaCobrar.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Contacto Cobro";
            // 
            // txtDiaHoraCobro
            // 
            this.txtDiaHoraCobro.Location = new System.Drawing.Point(109, 70);
            this.txtDiaHoraCobro.MaxLength = 150;
            this.txtDiaHoraCobro.Name = "txtDiaHoraCobro";
            this.txtDiaHoraCobro.Size = new System.Drawing.Size(231, 20);
            this.txtDiaHoraCobro.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Dia/Hora Cobro";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(109, 45);
            this.txtReferencia.MaxLength = 100;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(231, 20);
            this.txtReferencia.TabIndex = 1;
            // 
            // txtDireccionCobro
            // 
            this.txtDireccionCobro.Location = new System.Drawing.Point(109, 19);
            this.txtDireccionCobro.MaxLength = 100;
            this.txtDireccionCobro.Name = "txtDireccionCobro";
            this.txtDireccionCobro.Size = new System.Drawing.Size(231, 20);
            this.txtDireccionCobro.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Fecha Ingreso";
            this.label10.Visible = false;
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(292, 130);
            this.dtpFechaAlta.Mask = "00/00/0000";
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(70, 20);
            this.dtpFechaAlta.TabIndex = 4;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(276, 211);
            this.txtFax.MaxLength = 50;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(86, 20);
            this.txtFax.TabIndex = 8;
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(72, 212);
            this.txtTelefonos.MaxLength = 50;
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(171, 20);
            this.txtTelefonos.TabIndex = 7;
            // 
            // mtCliente
            // 
            this.mtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCliente.Location = new System.Drawing.Point(72, 49);
            this.mtCliente.Mask = "9990";
            this.mtCliente.Name = "mtCliente";
            this.mtCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtCliente.Size = new System.Drawing.Size(42, 21);
            this.mtCliente.TabIndex = 0;
            this.mtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtCliente_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 156);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(72, 76);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(72, 182);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(290, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtNombreFantasia
            // 
            this.txtNombreFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreFantasia.Location = new System.Drawing.Point(108, 104);
            this.txtNombreFantasia.MaxLength = 100;
            this.txtNombreFantasia.Name = "txtNombreFantasia";
            this.txtNombreFantasia.Size = new System.Drawing.Size(253, 20);
            this.txtNombreFantasia.TabIndex = 2;
            // 
            // mtRUT
            // 
            this.mtRUT.Location = new System.Drawing.Point(72, 130);
            this.mtRUT.Mask = "00.000.000.0000";
            this.mtRUT.Name = "mtRUT";
            this.mtRUT.Size = new System.Drawing.Size(89, 20);
            this.mtRUT.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtDiaFinFacturacion);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.mtDiaInicioFacturacion);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(12, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 53);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Facturación";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Dia de Mes Inicio:";
            // 
            // mtDiaInicioFacturacion
            // 
            this.mtDiaInicioFacturacion.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtDiaInicioFacturacion.Location = new System.Drawing.Point(104, 22);
            this.mtDiaInicioFacturacion.Mask = "99";
            this.mtDiaInicioFacturacion.Name = "mtDiaInicioFacturacion";
            this.mtDiaInicioFacturacion.Size = new System.Drawing.Size(25, 20);
            this.mtDiaInicioFacturacion.TabIndex = 1;
            // 
            // mtDiaFinFacturacion
            // 
            this.mtDiaFinFacturacion.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtDiaFinFacturacion.Location = new System.Drawing.Point(266, 22);
            this.mtDiaFinFacturacion.Mask = "99";
            this.mtDiaFinFacturacion.Name = "mtDiaFinFacturacion";
            this.mtDiaFinFacturacion.Size = new System.Drawing.Size(25, 20);
            this.mtDiaFinFacturacion.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(168, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Dia de Mes Fin:";
            // 
            // ABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 545);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTelefonos);
            this.Controls.Add(this.mtCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEstadoCliente);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreFantasia);
            this.Controls.Add(this.mtRUT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.Name = "ABMClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABMClientes";
            this.Load += new System.EventHandler(this.ABMClientes_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ABMClientes_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private ControlHoras.TextBoxKeyDown txtNombre;
        private System.Windows.Forms.Label label5;
        private ControlHoras.TextBoxKeyDown txtNombreFantasia;
        private ControlHoras.MaskedTextBoxKeyDown mtRUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbNoActivo;
        private ControlHoras.TextBoxKeyDown txtDireccion;
        private ControlHoras.TextBoxKeyDown txtEmail;
        private System.Windows.Forms.Label lblEstadoCliente;
        private MaskedTextBoxKeyDown dtpFechaBaja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private ControlHoras.TextBoxKeyDown txtMotivoBaja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnServicios;
        private ControlHoras.MaskedTextBoxKeyDown mtCliente;
        private ControlHoras.TextBoxKeyDown txtTelefonos;
        private ControlHoras.TextBoxKeyDown txtFax;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private TextBoxKeyDown txtDiaHoraCobro;
        private System.Windows.Forms.Label label14;
        private TextBoxKeyDown txtReferencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private TextBoxKeyDown txtDireccionCobro;
        private TextBoxKeyDown txtTelefonoCobro;
        private System.Windows.Forms.Label label16;
        private TextBoxKeyDown txtNombreParaCobrar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label10;
        private MaskedTextBoxKeyDown dtpFechaAlta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mtDiaInicioFacturacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mtDiaFinFacturacion;
        private System.Windows.Forms.Label label18;
    }
}