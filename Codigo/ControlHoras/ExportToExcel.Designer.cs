﻿namespace ControlHoras
{
    partial class ExportToExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.saveExcelFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panelNroEmpleadoDesdeHasta = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFechaDesdeHasta = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelEmpleado = new System.Windows.Forms.Panel();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.lblmtFecha = new System.Windows.Forms.Label();
            this.panelServicio = new System.Windows.Forms.Panel();
            this.lblServicio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcConsultas = new System.Windows.Forms.TabControl();
            this.tbPorTablas = new System.Windows.Forms.TabPage();
            this.tbEmpleados = new System.Windows.Forms.TabPage();
            this.btnEmpleadosConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClientes = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPorTablas = new System.Windows.Forms.Panel();
            this.lblOrdenResultado = new System.Windows.Forms.Label();
            this.gbPorTablasFiltros = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPorTablaNombre = new System.Windows.Forms.Label();
            this.btnDeseleccionarTodos = new System.Windows.Forms.Button();
            this.btnSeleccionarTodos = new System.Windows.Forms.Button();
            this.listBoxCampos = new System.Windows.Forms.CheckedListBox();
            this.cbPorTablasInactivos = new System.Windows.Forms.CheckBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxKeyDown1 = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtEmpleadosDesde = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtFechaHasta = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtFechaDesde = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtNumeroEmpleado = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtFecha = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtNroServicio = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtNroCliente = new ControlHoras.MaskedTextBoxKeyDown();
            this.cmbTablas = new ControlHoras.ComboBoxKeyDown();
            this.txtConsultasEmpleadosDescripcion = new ControlHoras.TextBoxKeyDown();
            this.cmbEmpleadosConsultas = new ControlHoras.ComboBoxKeyDown();
            this.txtClientesDescripcionConsulta = new ControlHoras.TextBoxKeyDown();
            this.cmbClientesConsultas = new ControlHoras.ComboBoxKeyDown();
            this.maskedTextBoxKeyDown5 = new ControlHoras.MaskedTextBoxKeyDown();
            this.maskedTextBoxKeyDown4 = new ControlHoras.MaskedTextBoxKeyDown();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panelNroEmpleadoDesdeHasta.SuspendLayout();
            this.panelFechaDesdeHasta.SuspendLayout();
            this.panelEmpleado.SuspendLayout();
            this.panelFecha.SuspendLayout();
            this.panelServicio.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.tcConsultas.SuspendLayout();
            this.tbPorTablas.SuspendLayout();
            this.tbEmpleados.SuspendLayout();
            this.tbClientes.SuspendLayout();
            this.panelPorTablas.SuspendLayout();
            this.gbPorTablasFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportToExcel,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(656, 36);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Enabled = false;
            this.btnExportToExcel.Image = global::ControlHoras.Imagenes.application_vnd_ms_excel;
            this.btnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(81, 33);
            this.btnExportToExcel.Text = "Exportar Excel";
            this.btnExportToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancelar.Image = global::ControlHoras.Imagenes.button_cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 33);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // saveExcelFileDialog
            // 
            this.saveExcelFileDialog.DefaultExt = "xls";
            this.saveExcelFileDialog.Filter = "Archivos de Microsoft Office Excel(*.xls)|*.xls";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelFiltros);
            this.splitContainer1.Panel1.Controls.Add(this.tcConsultas);
            this.splitContainer1.Panel1.Controls.Add(this.panelPorTablas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvResultados);
            this.splitContainer1.Size = new System.Drawing.Size(656, 532);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 5;
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.btnConsultar);
            this.panelFiltros.Controls.Add(this.panelNroEmpleadoDesdeHasta);
            this.panelFiltros.Controls.Add(this.panelFechaDesdeHasta);
            this.panelFiltros.Controls.Add(this.panelEmpleado);
            this.panelFiltros.Controls.Add(this.panelFecha);
            this.panelFiltros.Controls.Add(this.panelServicio);
            this.panelFiltros.Controls.Add(this.panelCliente);
            this.panelFiltros.Location = new System.Drawing.Point(7, 89);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(631, 179);
            this.panelFiltros.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(244, 153);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panelNroEmpleadoDesdeHasta
            // 
            this.panelNroEmpleadoDesdeHasta.Controls.Add(this.maskedTextBoxKeyDown1);
            this.panelNroEmpleadoDesdeHasta.Controls.Add(this.mtEmpleadosDesde);
            this.panelNroEmpleadoDesdeHasta.Controls.Add(this.label10);
            this.panelNroEmpleadoDesdeHasta.Controls.Add(this.label1);
            this.panelNroEmpleadoDesdeHasta.Controls.Add(this.label2);
            this.panelNroEmpleadoDesdeHasta.Location = new System.Drawing.Point(341, 38);
            this.panelNroEmpleadoDesdeHasta.Name = "panelNroEmpleadoDesdeHasta";
            this.panelNroEmpleadoDesdeHasta.Size = new System.Drawing.Size(287, 35);
            this.panelNroEmpleadoDesdeHasta.TabIndex = 11;
            this.panelNroEmpleadoDesdeHasta.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Desde";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Empleado";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // panelFechaDesdeHasta
            // 
            this.panelFechaDesdeHasta.Controls.Add(this.mtFechaHasta);
            this.panelFechaDesdeHasta.Controls.Add(this.label13);
            this.panelFechaDesdeHasta.Controls.Add(this.mtFechaDesde);
            this.panelFechaDesdeHasta.Controls.Add(this.label12);
            this.panelFechaDesdeHasta.Location = new System.Drawing.Point(297, 2);
            this.panelFechaDesdeHasta.Name = "panelFechaDesdeHasta";
            this.panelFechaDesdeHasta.Size = new System.Drawing.Size(332, 30);
            this.panelFechaDesdeHasta.TabIndex = 2;
            this.panelFechaDesdeHasta.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Fecha Hasta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fecha Desde";
            // 
            // panelEmpleado
            // 
            this.panelEmpleado.Controls.Add(this.lblEmpleado);
            this.panelEmpleado.Controls.Add(this.mtNumeroEmpleado);
            this.panelEmpleado.Controls.Add(this.label11);
            this.panelEmpleado.Location = new System.Drawing.Point(4, 34);
            this.panelEmpleado.Name = "panelEmpleado";
            this.panelEmpleado.Size = new System.Drawing.Size(332, 30);
            this.panelEmpleado.TabIndex = 6;
            this.panelEmpleado.Visible = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(131, 8);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(0, 13);
            this.lblEmpleado.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "NroEmpleado";
            // 
            // panelFecha
            // 
            this.panelFecha.Controls.Add(this.mtFecha);
            this.panelFecha.Controls.Add(this.lblmtFecha);
            this.panelFecha.Location = new System.Drawing.Point(3, 3);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(183, 30);
            this.panelFecha.TabIndex = 1;
            this.panelFecha.Visible = false;
            // 
            // lblmtFecha
            // 
            this.lblmtFecha.AutoSize = true;
            this.lblmtFecha.Location = new System.Drawing.Point(17, 8);
            this.lblmtFecha.Name = "lblmtFecha";
            this.lblmtFecha.Size = new System.Drawing.Size(37, 13);
            this.lblmtFecha.TabIndex = 0;
            this.lblmtFecha.Text = "Fecha";
            this.lblmtFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelServicio
            // 
            this.panelServicio.Controls.Add(this.lblServicio);
            this.panelServicio.Controls.Add(this.mtNroServicio);
            this.panelServicio.Controls.Add(this.label5);
            this.panelServicio.Location = new System.Drawing.Point(5, 97);
            this.panelServicio.Name = "panelServicio";
            this.panelServicio.Size = new System.Drawing.Size(331, 30);
            this.panelServicio.TabIndex = 3;
            this.panelServicio.Visible = false;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(129, 9);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(0, 13);
            this.lblServicio.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Servicio";
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.lblCliente);
            this.panelCliente.Controls.Add(this.mtNroCliente);
            this.panelCliente.Controls.Add(this.label6);
            this.panelCliente.Location = new System.Drawing.Point(4, 65);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(332, 30);
            this.panelCliente.TabIndex = 2;
            this.panelCliente.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(130, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cliente";
            // 
            // tcConsultas
            // 
            this.tcConsultas.Controls.Add(this.tbPorTablas);
            this.tcConsultas.Controls.Add(this.tbEmpleados);
            this.tcConsultas.Controls.Add(this.tbClientes);
            this.tcConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcConsultas.Location = new System.Drawing.Point(0, 0);
            this.tcConsultas.Name = "tcConsultas";
            this.tcConsultas.SelectedIndex = 0;
            this.tcConsultas.Size = new System.Drawing.Size(656, 88);
            this.tcConsultas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcConsultas.TabIndex = 0;
            this.tcConsultas.SelectedIndexChanged += new System.EventHandler(this.tcConsultas_TabIndexChanged);
            // 
            // tbPorTablas
            // 
            this.tbPorTablas.Controls.Add(this.cmbTablas);
            this.tbPorTablas.Location = new System.Drawing.Point(4, 22);
            this.tbPorTablas.Name = "tbPorTablas";
            this.tbPorTablas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPorTablas.Size = new System.Drawing.Size(648, 62);
            this.tbPorTablas.TabIndex = 0;
            this.tbPorTablas.Text = "Por Tablas";
            this.tbPorTablas.UseVisualStyleBackColor = true;
            // 
            // tbEmpleados
            // 
            this.tbEmpleados.Controls.Add(this.btnEmpleadosConsultar);
            this.tbEmpleados.Controls.Add(this.label3);
            this.tbEmpleados.Controls.Add(this.txtConsultasEmpleadosDescripcion);
            this.tbEmpleados.Controls.Add(this.cmbEmpleadosConsultas);
            this.tbEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tbEmpleados.Name = "tbEmpleados";
            this.tbEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmpleados.Size = new System.Drawing.Size(648, 62);
            this.tbEmpleados.TabIndex = 1;
            this.tbEmpleados.Text = "Empleados";
            this.tbEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnEmpleadosConsultar
            // 
            this.btnEmpleadosConsultar.Location = new System.Drawing.Point(283, 179);
            this.btnEmpleadosConsultar.Name = "btnEmpleadosConsultar";
            this.btnEmpleadosConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleadosConsultar.TabIndex = 8;
            this.btnEmpleadosConsultar.Text = "Consultar";
            this.btnEmpleadosConsultar.UseVisualStyleBackColor = true;
            this.btnEmpleadosConsultar.Click += new System.EventHandler(this.btnEmpleadosConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consultas Empleados";
            // 
            // tbClientes
            // 
            this.tbClientes.Controls.Add(this.label4);
            this.tbClientes.Controls.Add(this.txtClientesDescripcionConsulta);
            this.tbClientes.Controls.Add(this.cmbClientesConsultas);
            this.tbClientes.Location = new System.Drawing.Point(4, 22);
            this.tbClientes.Name = "tbClientes";
            this.tbClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tbClientes.Size = new System.Drawing.Size(648, 62);
            this.tbClientes.TabIndex = 2;
            this.tbClientes.Text = "Clientes";
            this.tbClientes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Consultas Clientes";
            // 
            // panelPorTablas
            // 
            this.panelPorTablas.Controls.Add(this.lblOrdenResultado);
            this.panelPorTablas.Controls.Add(this.gbPorTablasFiltros);
            this.panelPorTablas.Controls.Add(this.btnDeseleccionarTodos);
            this.panelPorTablas.Controls.Add(this.btnSeleccionarTodos);
            this.panelPorTablas.Controls.Add(this.listBoxCampos);
            this.panelPorTablas.Controls.Add(this.cbPorTablasInactivos);
            this.panelPorTablas.Controls.Add(this.btnCargar);
            this.panelPorTablas.Location = new System.Drawing.Point(4, 90);
            this.panelPorTablas.Name = "panelPorTablas";
            this.panelPorTablas.Size = new System.Drawing.Size(640, 185);
            this.panelPorTablas.TabIndex = 8;
            // 
            // lblOrdenResultado
            // 
            this.lblOrdenResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdenResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenResultado.Location = new System.Drawing.Point(8, 124);
            this.lblOrdenResultado.Name = "lblOrdenResultado";
            this.lblOrdenResultado.Size = new System.Drawing.Size(539, 25);
            this.lblOrdenResultado.TabIndex = 18;
            // 
            // gbPorTablasFiltros
            // 
            this.gbPorTablasFiltros.Controls.Add(this.maskedTextBoxKeyDown5);
            this.gbPorTablasFiltros.Controls.Add(this.maskedTextBoxKeyDown4);
            this.gbPorTablasFiltros.Controls.Add(this.label8);
            this.gbPorTablasFiltros.Controls.Add(this.label7);
            this.gbPorTablasFiltros.Controls.Add(this.lblPorTablaNombre);
            this.gbPorTablasFiltros.Location = new System.Drawing.Point(7, 143);
            this.gbPorTablasFiltros.Name = "gbPorTablasFiltros";
            this.gbPorTablasFiltros.Size = new System.Drawing.Size(430, 35);
            this.gbPorTablasFiltros.TabIndex = 17;
            this.gbPorTablasFiltros.TabStop = false;
            this.gbPorTablasFiltros.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Desde";
            // 
            // lblPorTablaNombre
            // 
            this.lblPorTablaNombre.AutoSize = true;
            this.lblPorTablaNombre.Location = new System.Drawing.Point(16, 16);
            this.lblPorTablaNombre.Name = "lblPorTablaNombre";
            this.lblPorTablaNombre.Size = new System.Drawing.Size(130, 13);
            this.lblPorTablaNombre.TabIndex = 18;
            this.lblPorTablaNombre.Text = "lblQueCambiaSegunTabla";
            // 
            // btnDeseleccionarTodos
            // 
            this.btnDeseleccionarTodos.Location = new System.Drawing.Point(553, 48);
            this.btnDeseleccionarTodos.Name = "btnDeseleccionarTodos";
            this.btnDeseleccionarTodos.Size = new System.Drawing.Size(83, 35);
            this.btnDeseleccionarTodos.TabIndex = 16;
            this.btnDeseleccionarTodos.Text = "Deseleccionar Todos";
            this.btnDeseleccionarTodos.UseVisualStyleBackColor = true;
            this.btnDeseleccionarTodos.Click += new System.EventHandler(this.btnDeseleccionarTodos_Click);
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(553, 7);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(83, 35);
            this.btnSeleccionarTodos.TabIndex = 15;
            this.btnSeleccionarTodos.Text = "Seleccionar Todos";
            this.btnSeleccionarTodos.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // listBoxCampos
            // 
            this.listBoxCampos.CheckOnClick = true;
            this.listBoxCampos.FormattingEnabled = true;
            this.listBoxCampos.Location = new System.Drawing.Point(8, 7);
            this.listBoxCampos.MultiColumn = true;
            this.listBoxCampos.Name = "listBoxCampos";
            this.listBoxCampos.Size = new System.Drawing.Size(539, 109);
            this.listBoxCampos.TabIndex = 13;
            this.listBoxCampos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBoxCampos_ItemCheck);
            // 
            // cbPorTablasInactivos
            // 
            this.cbPorTablasInactivos.AutoSize = true;
            this.cbPorTablasInactivos.Location = new System.Drawing.Point(447, 157);
            this.cbPorTablasInactivos.Name = "cbPorTablasInactivos";
            this.cbPorTablasInactivos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbPorTablasInactivos.Size = new System.Drawing.Size(100, 17);
            this.cbPorTablasInactivos.TabIndex = 17;
            this.cbPorTablasInactivos.Text = "Incluir Inactivos";
            this.cbPorTablasInactivos.UseVisualStyleBackColor = true;
            this.cbPorTablasInactivos.Visible = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(557, 153);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 14;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(0, 0);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.Size = new System.Drawing.Size(656, 255);
            this.dgvResultados.TabIndex = 1;
            // 
            // maskedTextBoxKeyDown1
            // 
            this.maskedTextBoxKeyDown1.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxKeyDown1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxKeyDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxKeyDown1.HidePromptOnLeave = true;
            this.maskedTextBoxKeyDown1.Location = new System.Drawing.Point(230, 4);
            this.maskedTextBoxKeyDown1.Mask = "0999";
            this.maskedTextBoxKeyDown1.Name = "maskedTextBoxKeyDown1";
            this.maskedTextBoxKeyDown1.Size = new System.Drawing.Size(44, 21);
            this.maskedTextBoxKeyDown1.TabIndex = 14;
            this.maskedTextBoxKeyDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBoxKeyDown1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtEmpleadosDesde
            // 
            this.mtEmpleadosDesde.BackColor = System.Drawing.Color.White;
            this.mtEmpleadosDesde.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtEmpleadosDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtEmpleadosDesde.HidePromptOnLeave = true;
            this.mtEmpleadosDesde.Location = new System.Drawing.Point(134, 4);
            this.mtEmpleadosDesde.Mask = "0999";
            this.mtEmpleadosDesde.Name = "mtEmpleadosDesde";
            this.mtEmpleadosDesde.Size = new System.Drawing.Size(44, 21);
            this.mtEmpleadosDesde.TabIndex = 13;
            this.mtEmpleadosDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtEmpleadosDesde.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtFechaHasta
            // 
            this.mtFechaHasta.Location = new System.Drawing.Point(244, 5);
            this.mtFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.mtFechaHasta.Mask = "00/00/0000";
            this.mtFechaHasta.Name = "mtFechaHasta";
            this.mtFechaHasta.Size = new System.Drawing.Size(76, 20);
            this.mtFechaHasta.TabIndex = 2;
            // 
            // mtFechaDesde
            // 
            this.mtFechaDesde.Location = new System.Drawing.Point(80, 5);
            this.mtFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.mtFechaDesde.Mask = "00/00/0000";
            this.mtFechaDesde.Name = "mtFechaDesde";
            this.mtFechaDesde.Size = new System.Drawing.Size(76, 20);
            this.mtFechaDesde.TabIndex = 0;
            this.mtFechaDesde.Validating += new System.ComponentModel.CancelEventHandler(this.mtConsultasEmpleadoFecha_Validating);
            // 
            // mtNumeroEmpleado
            // 
            this.mtNumeroEmpleado.BackColor = System.Drawing.Color.White;
            this.mtNumeroEmpleado.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtNumeroEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtNumeroEmpleado.HidePromptOnLeave = true;
            this.mtNumeroEmpleado.Location = new System.Drawing.Point(81, 4);
            this.mtNumeroEmpleado.Mask = "0999";
            this.mtNumeroEmpleado.Name = "mtNumeroEmpleado";
            this.mtNumeroEmpleado.Size = new System.Drawing.Size(44, 21);
            this.mtNumeroEmpleado.TabIndex = 2;
            this.mtNumeroEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtNumeroEmpleado.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtNumeroEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtNumeroEmpleado_KeyDown);
            // 
            // mtFecha
            // 
            this.mtFecha.Location = new System.Drawing.Point(95, 5);
            this.mtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.mtFecha.Mask = "00/00/0000";
            this.mtFecha.Name = "mtFecha";
            this.mtFecha.Size = new System.Drawing.Size(76, 20);
            this.mtFecha.TabIndex = 0;
            this.mtFecha.Validating += new System.ComponentModel.CancelEventHandler(this.mtConsultasEmpleadoFecha_Validating);
            // 
            // mtNroServicio
            // 
            this.mtNroServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtNroServicio.Location = new System.Drawing.Point(78, 4);
            this.mtNroServicio.Mask = "9990";
            this.mtNroServicio.Name = "mtNroServicio";
            this.mtNroServicio.Size = new System.Drawing.Size(44, 22);
            this.mtNroServicio.TabIndex = 5;
            this.mtNroServicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtNroServicio_KeyDown);
            // 
            // mtNroCliente
            // 
            this.mtNroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtNroCliente.Location = new System.Drawing.Point(79, 4);
            this.mtNroCliente.Mask = "9990";
            this.mtNroCliente.Name = "mtNroCliente";
            this.mtNroCliente.Size = new System.Drawing.Size(44, 22);
            this.mtNroCliente.TabIndex = 4;
            this.mtNroCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtNroCliente_KeyDown);
            // 
            // cmbTablas
            // 
            this.cmbTablas.BackColor = System.Drawing.Color.White;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(235, 4);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(174, 21);
            this.cmbTablas.TabIndex = 6;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // txtConsultasEmpleadosDescripcion
            // 
            this.txtConsultasEmpleadosDescripcion.Location = new System.Drawing.Point(298, 8);
            this.txtConsultasEmpleadosDescripcion.Multiline = true;
            this.txtConsultasEmpleadosDescripcion.Name = "txtConsultasEmpleadosDescripcion";
            this.txtConsultasEmpleadosDescripcion.Size = new System.Drawing.Size(341, 48);
            this.txtConsultasEmpleadosDescripcion.TabIndex = 6;
            // 
            // cmbEmpleadosConsultas
            // 
            this.cmbEmpleadosConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbEmpleadosConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleadosConsultas.FormattingEnabled = true;
            this.cmbEmpleadosConsultas.Location = new System.Drawing.Point(8, 27);
            this.cmbEmpleadosConsultas.Name = "cmbEmpleadosConsultas";
            this.cmbEmpleadosConsultas.Size = new System.Drawing.Size(284, 21);
            this.cmbEmpleadosConsultas.TabIndex = 4;
            this.cmbEmpleadosConsultas.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleadosConsultas_SelectedIndexChanged);
            // 
            // txtClientesDescripcionConsulta
            // 
            this.txtClientesDescripcionConsulta.Location = new System.Drawing.Point(290, 7);
            this.txtClientesDescripcionConsulta.Multiline = true;
            this.txtClientesDescripcionConsulta.Name = "txtClientesDescripcionConsulta";
            this.txtClientesDescripcionConsulta.ReadOnly = true;
            this.txtClientesDescripcionConsulta.Size = new System.Drawing.Size(350, 48);
            this.txtClientesDescripcionConsulta.TabIndex = 2;
            // 
            // cmbClientesConsultas
            // 
            this.cmbClientesConsultas.BackColor = System.Drawing.Color.White;
            this.cmbClientesConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientesConsultas.FormattingEnabled = true;
            this.cmbClientesConsultas.Location = new System.Drawing.Point(8, 28);
            this.cmbClientesConsultas.Name = "cmbClientesConsultas";
            this.cmbClientesConsultas.Size = new System.Drawing.Size(272, 21);
            this.cmbClientesConsultas.TabIndex = 0;
            this.cmbClientesConsultas.SelectedIndexChanged += new System.EventHandler(this.cmbClientesConsultas_SelectedIndexChanged);
            // 
            // maskedTextBoxKeyDown5
            // 
            this.maskedTextBoxKeyDown5.Location = new System.Drawing.Point(314, 12);
            this.maskedTextBoxKeyDown5.Name = "maskedTextBoxKeyDown5";
            this.maskedTextBoxKeyDown5.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBoxKeyDown5.TabIndex = 22;
            // 
            // maskedTextBoxKeyDown4
            // 
            this.maskedTextBoxKeyDown4.Location = new System.Drawing.Point(198, 12);
            this.maskedTextBoxKeyDown4.Name = "maskedTextBoxKeyDown4";
            this.maskedTextBoxKeyDown4.Size = new System.Drawing.Size(62, 20);
            this.maskedTextBoxKeyDown4.TabIndex = 21;
            // 
            // ExportToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(656, 568);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ExportToExcel";
            this.Text = "ExportToExcel";
            this.Load += new System.EventHandler(this.ExportToExcel_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExportToExcel_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportToExcel_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelNroEmpleadoDesdeHasta.ResumeLayout(false);
            this.panelNroEmpleadoDesdeHasta.PerformLayout();
            this.panelFechaDesdeHasta.ResumeLayout(false);
            this.panelFechaDesdeHasta.PerformLayout();
            this.panelEmpleado.ResumeLayout(false);
            this.panelEmpleado.PerformLayout();
            this.panelFecha.ResumeLayout(false);
            this.panelFecha.PerformLayout();
            this.panelServicio.ResumeLayout(false);
            this.panelServicio.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.tcConsultas.ResumeLayout(false);
            this.tbPorTablas.ResumeLayout(false);
            this.tbEmpleados.ResumeLayout(false);
            this.tbEmpleados.PerformLayout();
            this.tbClientes.ResumeLayout(false);
            this.tbClientes.PerformLayout();
            this.panelPorTablas.ResumeLayout(false);
            this.panelPorTablas.PerformLayout();
            this.gbPorTablasFiltros.ResumeLayout(false);
            this.gbPorTablasFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExportToExcel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TabControl tcConsultas;
        private System.Windows.Forms.TabPage tbPorTablas;
        private System.Windows.Forms.TabPage tbEmpleados;
        private ComboBoxKeyDown cmbTablas;
        private System.Windows.Forms.Label label3;
        private ComboBoxKeyDown cmbEmpleadosConsultas;
        private TextBoxKeyDown txtConsultasEmpleadosDescripcion;
        private System.Windows.Forms.Button btnEmpleadosConsultar;
        private System.Windows.Forms.TabPage tbClientes;
        private TextBoxKeyDown txtClientesDescripcionConsulta;
        private System.Windows.Forms.Label label4;
        private ComboBoxKeyDown cmbClientesConsultas;
        private System.Windows.Forms.SaveFileDialog saveExcelFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panelFecha;
        private MaskedTextBoxKeyDown mtFecha;
        private System.Windows.Forms.Label lblmtFecha;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaskedTextBoxKeyDown mtNroServicio;
        private System.Windows.Forms.Panel panelServicio;
        private MaskedTextBoxKeyDown mtNroCliente;
        private System.Windows.Forms.Panel panelEmpleado;
        private System.Windows.Forms.Label label11;
        private MaskedTextBoxKeyDown mtNumeroEmpleado;
        private System.Windows.Forms.Panel panelFechaDesdeHasta;
        private MaskedTextBoxKeyDown mtFechaDesde;
        private System.Windows.Forms.Label label12;
        private MaskedTextBoxKeyDown mtFechaHasta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Panel panelNroEmpleadoDesdeHasta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPorTablas;
        private System.Windows.Forms.Label lblOrdenResultado;
        private System.Windows.Forms.GroupBox gbPorTablasFiltros;
        private MaskedTextBoxKeyDown maskedTextBoxKeyDown5;
        private MaskedTextBoxKeyDown maskedTextBoxKeyDown4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPorTablaNombre;
        private System.Windows.Forms.CheckBox cbPorTablasInactivos;
        private System.Windows.Forms.Button btnDeseleccionarTodos;
        private System.Windows.Forms.Button btnSeleccionarTodos;
        private System.Windows.Forms.CheckedListBox listBoxCampos;
        private System.Windows.Forms.Button btnCargar;
        private MaskedTextBoxKeyDown maskedTextBoxKeyDown1;
        private MaskedTextBoxKeyDown mtEmpleadosDesde;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblCliente;
    }
}