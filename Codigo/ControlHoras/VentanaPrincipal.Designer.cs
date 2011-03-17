namespace ControlHoras
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuBotones = new System.Windows.Forms.ToolStrip();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnEmpleados = new System.Windows.Forms.ToolStripButton();
            this.btnEscalafon = new System.Windows.Forms.ToolStripButton();
            this.btnControlDiario = new System.Windows.Forms.ToolStripButton();
            this.btnConsultas = new System.Windows.Forms.ToolStripButton();
            this.menuStripSuperior = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaNegraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.codiguerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emergenciasMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutualistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposMotivosCambioDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNumeroEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sustituirEnEscalafonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.generarHorasDiariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.liquidacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIdUsuarioLogueado = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdCargarArchivoImportacionConsultas = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBotones.SuspendLayout();
            this.menuStripSuperior.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBotones
            // 
            this.menuBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.btnEmpleados,
            this.btnEscalafon,
            this.btnControlDiario,
            this.btnConsultas});
            this.menuBotones.Location = new System.Drawing.Point(0, 24);
            this.menuBotones.Name = "menuBotones";
            this.menuBotones.Size = new System.Drawing.Size(400, 36);
            this.menuBotones.TabIndex = 0;
            this.menuBotones.Text = "toolStrip1";
            // 
            // btnClientes
            // 
            this.btnClientes.Enabled = false;
            this.btnClientes.Image = global::ControlHoras.Imagenes.client;
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(49, 33);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Enabled = false;
            this.btnEmpleados.Image = global::ControlHoras.Imagenes._1254703516_userconfig;
            this.btnEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(62, 33);
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpleados.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnEscalafon
            // 
            this.btnEscalafon.Enabled = false;
            this.btnEscalafon.Image = global::ControlHoras.Imagenes.Escalafon;
            this.btnEscalafon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEscalafon.Name = "btnEscalafon";
            this.btnEscalafon.Size = new System.Drawing.Size(57, 33);
            this.btnEscalafon.Text = "Escalafon";
            this.btnEscalafon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEscalafon.Click += new System.EventHandler(this.btnEscalafon_Click);
            // 
            // btnControlDiario
            // 
            this.btnControlDiario.Enabled = false;
            this.btnControlDiario.Image = global::ControlHoras.Imagenes.CheckIcon;
            this.btnControlDiario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnControlDiario.Name = "btnControlDiario";
            this.btnControlDiario.Size = new System.Drawing.Size(76, 33);
            this.btnControlDiario.Text = "Control Diario";
            this.btnControlDiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnControlDiario.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Enabled = false;
            this.btnConsultas.Image = global::ControlHoras.Imagenes.icon_query_reporting;
            this.btnConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(58, 33);
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultas.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // menuStripSuperior
            // 
            this.menuStripSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.menuStripSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuStripSuperior.Name = "menuStripSuperior";
            this.menuStripSuperior.Size = new System.Drawing.Size(400, 24);
            this.menuStripSuperior.TabIndex = 2;
            this.menuStripSuperior.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.listaNegraToolStripMenuItem,
            this.toolStripSeparator1,
            this.codiguerasToolStripMenuItem,
            this.cambiarNumeroEmpleadoToolStripMenuItem,
            this.toolStripSeparator3,
            this.usuariosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Enabled = false;
            this.clientesToolStripMenuItem.Image = global::ControlHoras.Imagenes.client;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Enabled = false;
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Enabled = false;
            this.empleadosToolStripMenuItem.Image = global::ControlHoras.Imagenes._1254703516_userconfig;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // listaNegraToolStripMenuItem
            // 
            this.listaNegraToolStripMenuItem.Enabled = false;
            this.listaNegraToolStripMenuItem.Image = global::ControlHoras.Imagenes.blacklist;
            this.listaNegraToolStripMenuItem.Name = "listaNegraToolStripMenuItem";
            this.listaNegraToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.listaNegraToolStripMenuItem.Text = "Lista Negra";
            this.listaNegraToolStripMenuItem.Click += new System.EventHandler(this.listaNegraToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // codiguerasToolStripMenuItem
            // 
            this.codiguerasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emergenciasMedicaToolStripMenuItem,
            this.mutualistasToolStripMenuItem,
            this.bancosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.ciudadesToolStripMenuItem,
            this.barriosToolStripMenuItem,
            this.tiposDeDocumentosToolStripMenuItem,
            this.tiposDeEventosToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.tiposMotivosCambioDiarioToolStripMenuItem,
            this.toolStripSeparator4,
            this.consultasToolStripMenuItem});
            this.codiguerasToolStripMenuItem.Enabled = false;
            this.codiguerasToolStripMenuItem.Name = "codiguerasToolStripMenuItem";
            this.codiguerasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.codiguerasToolStripMenuItem.Text = "Codigueras";
            // 
            // emergenciasMedicaToolStripMenuItem
            // 
            this.emergenciasMedicaToolStripMenuItem.Name = "emergenciasMedicaToolStripMenuItem";
            this.emergenciasMedicaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.emergenciasMedicaToolStripMenuItem.Text = "Emergencias Medica";
            this.emergenciasMedicaToolStripMenuItem.Click += new System.EventHandler(this.emergenciasMedicaToolStripMenuItem_Click);
            // 
            // mutualistasToolStripMenuItem
            // 
            this.mutualistasToolStripMenuItem.Name = "mutualistasToolStripMenuItem";
            this.mutualistasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.mutualistasToolStripMenuItem.Text = "Mutualistas";
            this.mutualistasToolStripMenuItem.Click += new System.EventHandler(this.mutualistasToolStripMenuItem_Click);
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.bancosToolStripMenuItem.Text = "Bancos";
            this.bancosToolStripMenuItem.Click += new System.EventHandler(this.bancosToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ciudadesToolStripMenuItem.Text = "Ciudades";
            this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
            // 
            // barriosToolStripMenuItem
            // 
            this.barriosToolStripMenuItem.Name = "barriosToolStripMenuItem";
            this.barriosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.barriosToolStripMenuItem.Text = "Barrios";
            this.barriosToolStripMenuItem.Click += new System.EventHandler(this.barriosToolStripMenuItem_Click);
            // 
            // tiposDeDocumentosToolStripMenuItem
            // 
            this.tiposDeDocumentosToolStripMenuItem.Name = "tiposDeDocumentosToolStripMenuItem";
            this.tiposDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.tiposDeDocumentosToolStripMenuItem.Text = "Tipos de Documentos";
            this.tiposDeDocumentosToolStripMenuItem.Visible = false;
            this.tiposDeDocumentosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDocumentosToolStripMenuItem_Click);
            // 
            // tiposDeEventosToolStripMenuItem
            // 
            this.tiposDeEventosToolStripMenuItem.Name = "tiposDeEventosToolStripMenuItem";
            this.tiposDeEventosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.tiposDeEventosToolStripMenuItem.Text = "Tipos de Eventos Historial";
            this.tiposDeEventosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeEventosToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // tiposMotivosCambioDiarioToolStripMenuItem
            // 
            this.tiposMotivosCambioDiarioToolStripMenuItem.Name = "tiposMotivosCambioDiarioToolStripMenuItem";
            this.tiposMotivosCambioDiarioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.tiposMotivosCambioDiarioToolStripMenuItem.Text = "Tipos Motivos Cambio Diario";
            this.tiposMotivosCambioDiarioToolStripMenuItem.Click += new System.EventHandler(this.tiposMotivosCambioDiarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(215, 6);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Visible = false;
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // cambiarNumeroEmpleadoToolStripMenuItem
            // 
            this.cambiarNumeroEmpleadoToolStripMenuItem.Enabled = false;
            this.cambiarNumeroEmpleadoToolStripMenuItem.Name = "cambiarNumeroEmpleadoToolStripMenuItem";
            this.cambiarNumeroEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cambiarNumeroEmpleadoToolStripMenuItem.Text = "Cambiar Número Empleado";
            this.cambiarNumeroEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.cambiarNúmeroEmpleadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Enabled = false;
            this.usuariosToolStripMenuItem.Image = global::ControlHoras.Imagenes.add_user;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sustituirEnEscalafonToolStripMenuItem,
            this.toolStripSeparator2,
            this.generarHorasDiariasToolStripMenuItem,
            this.toolStripSeparator5,
            this.liquidacionToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // sustituirEnEscalafonToolStripMenuItem
            // 
            this.sustituirEnEscalafonToolStripMenuItem.Enabled = false;
            this.sustituirEnEscalafonToolStripMenuItem.Name = "sustituirEnEscalafonToolStripMenuItem";
            this.sustituirEnEscalafonToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sustituirEnEscalafonToolStripMenuItem.Text = "Sustituir en Escalafon";
            this.sustituirEnEscalafonToolStripMenuItem.Click += new System.EventHandler(this.sustituirEnEscalafonToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // generarHorasDiariasToolStripMenuItem
            // 
            this.generarHorasDiariasToolStripMenuItem.Enabled = false;
            this.generarHorasDiariasToolStripMenuItem.Name = "generarHorasDiariasToolStripMenuItem";
            this.generarHorasDiariasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.generarHorasDiariasToolStripMenuItem.Text = "Generar Horas Diarias";
            this.generarHorasDiariasToolStripMenuItem.Click += new System.EventHandler(this.generarHorasDiariasToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
            // 
            // liquidacionToolStripMenuItem
            // 
            this.liquidacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.empleadosToolStripMenuItem1});
            this.liquidacionToolStripMenuItem.Enabled = false;
            this.liquidacionToolStripMenuItem.Name = "liquidacionToolStripMenuItem";
            this.liquidacionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.liquidacionToolStripMenuItem.Text = "Liquidación";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslUsuario,
            this.tsslIdUsuarioLogueado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 325);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(385, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Trust International";
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslIdUsuarioLogueado
            // 
            this.tsslIdUsuarioLogueado.Name = "tsslIdUsuarioLogueado";
            this.tsslIdUsuarioLogueado.Size = new System.Drawing.Size(0, 17);
            this.tsslIdUsuarioLogueado.Visible = false;
            // 
            // ofdCargarArchivoImportacionConsultas
            // 
            this.ofdCargarArchivoImportacionConsultas.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 347);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuBotones);
            this.Controls.Add(this.menuStripSuperior);
            this.MainMenuStrip = this.menuStripSuperior;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuBotones.ResumeLayout(false);
            this.menuBotones.PerformLayout();
            this.menuStripSuperior.ResumeLayout(false);
            this.menuStripSuperior.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuBotones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStripSuperior;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codiguerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emergenciasMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutualistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripButton btnEmpleados;
        private System.Windows.Forms.ToolStripMenuItem tiposDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnConsultas;
        private System.Windows.Forms.ToolStripMenuItem cambiarNumeroEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaNegraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnEscalafon;
        private System.Windows.Forms.ToolStripButton btnControlDiario;
        private System.Windows.Forms.ToolStripMenuItem tiposMotivosCambioDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarHorasDiariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sustituirEnEscalafonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel tsslIdUsuarioLogueado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdCargarArchivoImportacionConsultas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem liquidacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
    }
}