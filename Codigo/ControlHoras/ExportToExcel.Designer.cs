namespace ControlHoras
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.saveExcelFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tcConsultas = new System.Windows.Forms.TabControl();
            this.tbPorTablas = new System.Windows.Forms.TabPage();
            this.lblOrdenResultado = new System.Windows.Forms.Label();
            this.gbPorTablasFiltros = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxKeyDown5 = new ControlHoras.MaskedTextBoxKeyDown();
            this.maskedTextBoxKeyDown4 = new ControlHoras.MaskedTextBoxKeyDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPorTablaNombre = new System.Windows.Forms.Label();
            this.cbPorTablasInactivos = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeleccionarTodos = new System.Windows.Forms.Button();
            this.listBoxCampos = new System.Windows.Forms.CheckedListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbTablas = new ControlHoras.ComboBoxKeyDown();
            this.tbEmpleados = new System.Windows.Forms.TabPage();
            this.panelConsultasEmpleadoFecha = new System.Windows.Forms.Panel();
            this.mtConsultasEmpleadoFecha = new ControlHoras.MaskedTextBoxKeyDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panelConsultasEmpleadosNumeroEmpleado = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxKeyDown1 = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtEmpleadosDesde = new ControlHoras.MaskedTextBoxKeyDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmpleadosConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsultasEmpleadosDescripcion = new ControlHoras.TextBoxKeyDown();
            this.cmbEmpleadosConsultas = new ControlHoras.ComboBoxKeyDown();
            this.tbClientes = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxKeyDown3 = new ControlHoras.MaskedTextBoxKeyDown();
            this.maskedTextBoxKeyDown2 = new ControlHoras.MaskedTextBoxKeyDown();
            this.txtClientesDescripcionConsulta = new ControlHoras.TextBoxKeyDown();
            this.cmbClientesConsultas = new ControlHoras.ComboBoxKeyDown();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcConsultas.SuspendLayout();
            this.tbPorTablas.SuspendLayout();
            this.gbPorTablasFiltros.SuspendLayout();
            this.tbEmpleados.SuspendLayout();
            this.panelConsultasEmpleadoFecha.SuspendLayout();
            this.panelConsultasEmpleadosNumeroEmpleado.SuspendLayout();
            this.tbClientes.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(873, 40);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Enabled = false;
            this.btnExportToExcel.Image = global::ControlHoras.Imagenes.application_vnd_ms_excel;
            this.btnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(102, 37);
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
            this.btnCancelar.Size = new System.Drawing.Size(64, 37);
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tcConsultas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvResultados);
            this.splitContainer1.Size = new System.Drawing.Size(873, 532);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // tcConsultas
            // 
            this.tcConsultas.Controls.Add(this.tbPorTablas);
            this.tcConsultas.Controls.Add(this.tbEmpleados);
            this.tcConsultas.Controls.Add(this.tbClientes);
            this.tcConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcConsultas.Location = new System.Drawing.Point(0, 0);
            this.tcConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.tcConsultas.Name = "tcConsultas";
            this.tcConsultas.SelectedIndex = 0;
            this.tcConsultas.Size = new System.Drawing.Size(873, 265);
            this.tcConsultas.TabIndex = 6;
            this.tcConsultas.TabIndexChanged += new System.EventHandler(this.tcConsultas_TabIndexChanged);
            // 
            // tbPorTablas
            // 
            this.tbPorTablas.Controls.Add(this.lblOrdenResultado);
            this.tbPorTablas.Controls.Add(this.gbPorTablasFiltros);
            this.tbPorTablas.Controls.Add(this.button1);
            this.tbPorTablas.Controls.Add(this.btnSeleccionarTodos);
            this.tbPorTablas.Controls.Add(this.listBoxCampos);
            this.tbPorTablas.Controls.Add(this.btnCargar);
            this.tbPorTablas.Controls.Add(this.cmbTablas);
            this.tbPorTablas.Location = new System.Drawing.Point(4, 25);
            this.tbPorTablas.Margin = new System.Windows.Forms.Padding(4);
            this.tbPorTablas.Name = "tbPorTablas";
            this.tbPorTablas.Padding = new System.Windows.Forms.Padding(4);
            this.tbPorTablas.Size = new System.Drawing.Size(865, 236);
            this.tbPorTablas.TabIndex = 0;
            this.tbPorTablas.Text = "Por Tablas";
            this.tbPorTablas.UseVisualStyleBackColor = true;
            // 
            // lblOrdenResultado
            // 
            this.lblOrdenResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdenResultado.Location = new System.Drawing.Point(11, 159);
            this.lblOrdenResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdenResultado.Name = "lblOrdenResultado";
            this.lblOrdenResultado.Size = new System.Drawing.Size(717, 22);
            this.lblOrdenResultado.TabIndex = 12;
            // 
            // gbPorTablasFiltros
            // 
            this.gbPorTablasFiltros.Controls.Add(this.maskedTextBoxKeyDown5);
            this.gbPorTablasFiltros.Controls.Add(this.maskedTextBoxKeyDown4);
            this.gbPorTablasFiltros.Controls.Add(this.label8);
            this.gbPorTablasFiltros.Controls.Add(this.label7);
            this.gbPorTablasFiltros.Controls.Add(this.lblPorTablaNombre);
            this.gbPorTablasFiltros.Controls.Add(this.cbPorTablasInactivos);
            this.gbPorTablasFiltros.Location = new System.Drawing.Point(11, 182);
            this.gbPorTablasFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.gbPorTablasFiltros.Name = "gbPorTablasFiltros";
            this.gbPorTablasFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.gbPorTablasFiltros.Size = new System.Drawing.Size(719, 46);
            this.gbPorTablasFiltros.TabIndex = 11;
            this.gbPorTablasFiltros.TabStop = false;
            this.gbPorTablasFiltros.Visible = false;
            // 
            // maskedTextBoxKeyDown5
            // 
            this.maskedTextBoxKeyDown5.Location = new System.Drawing.Point(419, 15);
            this.maskedTextBoxKeyDown5.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxKeyDown5.Name = "maskedTextBoxKeyDown5";
            this.maskedTextBoxKeyDown5.Size = new System.Drawing.Size(80, 22);
            this.maskedTextBoxKeyDown5.TabIndex = 22;
            // 
            // maskedTextBoxKeyDown4
            // 
            this.maskedTextBoxKeyDown4.Location = new System.Drawing.Point(264, 15);
            this.maskedTextBoxKeyDown4.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxKeyDown4.Name = "maskedTextBoxKeyDown4";
            this.maskedTextBoxKeyDown4.Size = new System.Drawing.Size(81, 22);
            this.maskedTextBoxKeyDown4.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Desde";
            // 
            // lblPorTablaNombre
            // 
            this.lblPorTablaNombre.AutoSize = true;
            this.lblPorTablaNombre.Location = new System.Drawing.Point(21, 20);
            this.lblPorTablaNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorTablaNombre.Name = "lblPorTablaNombre";
            this.lblPorTablaNombre.Size = new System.Drawing.Size(173, 17);
            this.lblPorTablaNombre.TabIndex = 18;
            this.lblPorTablaNombre.Text = "lblQueCambiaSegunTabla";
            // 
            // cbPorTablasInactivos
            // 
            this.cbPorTablasInactivos.AutoSize = true;
            this.cbPorTablasInactivos.Location = new System.Drawing.Point(549, 17);
            this.cbPorTablasInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.cbPorTablasInactivos.Name = "cbPorTablasInactivos";
            this.cbPorTablasInactivos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbPorTablasInactivos.Size = new System.Drawing.Size(123, 21);
            this.cbPorTablasInactivos.TabIndex = 17;
            this.cbPorTablasInactivos.Text = "Incluir Inactivos";
            this.cbPorTablasInactivos.UseVisualStyleBackColor = true;
            this.cbPorTablasInactivos.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Deseleccionar Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(737, 39);
            this.btnSeleccionarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(111, 43);
            this.btnSeleccionarTodos.TabIndex = 9;
            this.btnSeleccionarTodos.Text = "Seleccionar Todos";
            this.btnSeleccionarTodos.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // listBoxCampos
            // 
            this.listBoxCampos.CheckOnClick = true;
            this.listBoxCampos.FormattingEnabled = true;
            this.listBoxCampos.Location = new System.Drawing.Point(11, 39);
            this.listBoxCampos.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCampos.MultiColumn = true;
            this.listBoxCampos.Name = "listBoxCampos";
            this.listBoxCampos.Size = new System.Drawing.Size(717, 106);
            this.listBoxCampos.TabIndex = 7;
            this.listBoxCampos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBoxCampos_ItemCheck);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(743, 182);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 28);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cmbTablas
            // 
            this.cmbTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(313, 5);
            this.cmbTablas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(231, 24);
            this.cmbTablas.TabIndex = 6;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // tbEmpleados
            // 
            this.tbEmpleados.Controls.Add(this.panelConsultasEmpleadoFecha);
            this.tbEmpleados.Controls.Add(this.panelConsultasEmpleadosNumeroEmpleado);
            this.tbEmpleados.Controls.Add(this.btnEmpleadosConsultar);
            this.tbEmpleados.Controls.Add(this.label3);
            this.tbEmpleados.Controls.Add(this.txtConsultasEmpleadosDescripcion);
            this.tbEmpleados.Controls.Add(this.cmbEmpleadosConsultas);
            this.tbEmpleados.Location = new System.Drawing.Point(4, 25);
            this.tbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmpleados.Name = "tbEmpleados";
            this.tbEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.tbEmpleados.Size = new System.Drawing.Size(865, 236);
            this.tbEmpleados.TabIndex = 1;
            this.tbEmpleados.Text = "Empleados";
            this.tbEmpleados.UseVisualStyleBackColor = true;
            // 
            // panelConsultasEmpleadoFecha
            // 
            this.panelConsultasEmpleadoFecha.Controls.Add(this.mtConsultasEmpleadoFecha);
            this.panelConsultasEmpleadoFecha.Controls.Add(this.label9);
            this.panelConsultasEmpleadoFecha.Location = new System.Drawing.Point(425, 89);
            this.panelConsultasEmpleadoFecha.Margin = new System.Windows.Forms.Padding(4);
            this.panelConsultasEmpleadoFecha.Name = "panelConsultasEmpleadoFecha";
            this.panelConsultasEmpleadoFecha.Size = new System.Drawing.Size(333, 73);
            this.panelConsultasEmpleadoFecha.TabIndex = 11;
            this.panelConsultasEmpleadoFecha.Visible = false;
            // 
            // mtConsultasEmpleadoFecha
            // 
            this.mtConsultasEmpleadoFecha.Location = new System.Drawing.Point(165, 22);
            this.mtConsultasEmpleadoFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtConsultasEmpleadoFecha.Mask = "00/00/0000";
            this.mtConsultasEmpleadoFecha.Name = "mtConsultasEmpleadoFecha";
            this.mtConsultasEmpleadoFecha.Size = new System.Drawing.Size(100, 22);
            this.mtConsultasEmpleadoFecha.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fecha Pago Prevista";
            // 
            // panelConsultasEmpleadosNumeroEmpleado
            // 
            this.panelConsultasEmpleadosNumeroEmpleado.Controls.Add(this.label10);
            this.panelConsultasEmpleadosNumeroEmpleado.Controls.Add(this.label1);
            this.panelConsultasEmpleadosNumeroEmpleado.Controls.Add(this.maskedTextBoxKeyDown1);
            this.panelConsultasEmpleadosNumeroEmpleado.Controls.Add(this.mtEmpleadosDesde);
            this.panelConsultasEmpleadosNumeroEmpleado.Controls.Add(this.label2);
            this.panelConsultasEmpleadosNumeroEmpleado.Location = new System.Drawing.Point(425, 170);
            this.panelConsultasEmpleadosNumeroEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.panelConsultasEmpleadosNumeroEmpleado.Name = "panelConsultasEmpleadosNumeroEmpleado";
            this.panelConsultasEmpleadosNumeroEmpleado.Size = new System.Drawing.Size(426, 46);
            this.panelConsultasEmpleadosNumeroEmpleado.TabIndex = 10;
            this.panelConsultasEmpleadosNumeroEmpleado.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Desde";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Empleado";
            // 
            // maskedTextBoxKeyDown1
            // 
            this.maskedTextBoxKeyDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxKeyDown1.Location = new System.Drawing.Point(334, 12);
            this.maskedTextBoxKeyDown1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxKeyDown1.Name = "maskedTextBoxKeyDown1";
            this.maskedTextBoxKeyDown1.Size = new System.Drawing.Size(83, 22);
            this.maskedTextBoxKeyDown1.TabIndex = 9;
            // 
            // mtEmpleadosDesde
            // 
            this.mtEmpleadosDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtEmpleadosDesde.BackColor = System.Drawing.Color.White;
            this.mtEmpleadosDesde.Location = new System.Drawing.Point(192, 12);
            this.mtEmpleadosDesde.Margin = new System.Windows.Forms.Padding(4);
            this.mtEmpleadosDesde.Name = "mtEmpleadosDesde";
            this.mtEmpleadosDesde.Size = new System.Drawing.Size(83, 22);
            this.mtEmpleadosDesde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // btnEmpleadosConsultar
            // 
            this.btnEmpleadosConsultar.Location = new System.Drawing.Point(69, 160);
            this.btnEmpleadosConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleadosConsultar.Name = "btnEmpleadosConsultar";
            this.btnEmpleadosConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnEmpleadosConsultar.TabIndex = 8;
            this.btnEmpleadosConsultar.Text = "Consultar";
            this.btnEmpleadosConsultar.UseVisualStyleBackColor = true;
            this.btnEmpleadosConsultar.Click += new System.EventHandler(this.btnEmpleadosConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consultas";
            // 
            // txtConsultasEmpleadosDescripcion
            // 
            this.txtConsultasEmpleadosDescripcion.Location = new System.Drawing.Point(425, 14);
            this.txtConsultasEmpleadosDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultasEmpleadosDescripcion.Multiline = true;
            this.txtConsultasEmpleadosDescripcion.Name = "txtConsultasEmpleadosDescripcion";
            this.txtConsultasEmpleadosDescripcion.Size = new System.Drawing.Size(426, 67);
            this.txtConsultasEmpleadosDescripcion.TabIndex = 6;
            // 
            // cmbEmpleadosConsultas
            // 
            this.cmbEmpleadosConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbEmpleadosConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleadosConsultas.FormattingEnabled = true;
            this.cmbEmpleadosConsultas.Location = new System.Drawing.Point(11, 33);
            this.cmbEmpleadosConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmpleadosConsultas.Name = "cmbEmpleadosConsultas";
            this.cmbEmpleadosConsultas.Size = new System.Drawing.Size(378, 24);
            this.cmbEmpleadosConsultas.TabIndex = 4;
            this.cmbEmpleadosConsultas.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleadosConsultas_SelectedIndexChanged);
            // 
            // tbClientes
            // 
            this.tbClientes.Controls.Add(this.label6);
            this.tbClientes.Controls.Add(this.label5);
            this.tbClientes.Controls.Add(this.label4);
            this.tbClientes.Controls.Add(this.maskedTextBoxKeyDown3);
            this.tbClientes.Controls.Add(this.maskedTextBoxKeyDown2);
            this.tbClientes.Controls.Add(this.txtClientesDescripcionConsulta);
            this.tbClientes.Controls.Add(this.cmbClientesConsultas);
            this.tbClientes.Location = new System.Drawing.Point(4, 25);
            this.tbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tbClientes.Name = "tbClientes";
            this.tbClientes.Padding = new System.Windows.Forms.Padding(4);
            this.tbClientes.Size = new System.Drawing.Size(865, 236);
            this.tbClientes.TabIndex = 2;
            this.tbClientes.Text = "Clientes";
            this.tbClientes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero Cliente    Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Consultas";
            // 
            // maskedTextBoxKeyDown3
            // 
            this.maskedTextBoxKeyDown3.Location = new System.Drawing.Point(663, 80);
            this.maskedTextBoxKeyDown3.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxKeyDown3.Name = "maskedTextBoxKeyDown3";
            this.maskedTextBoxKeyDown3.Size = new System.Drawing.Size(83, 22);
            this.maskedTextBoxKeyDown3.TabIndex = 4;
            // 
            // maskedTextBoxKeyDown2
            // 
            this.maskedTextBoxKeyDown2.Location = new System.Drawing.Point(480, 80);
            this.maskedTextBoxKeyDown2.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxKeyDown2.Name = "maskedTextBoxKeyDown2";
            this.maskedTextBoxKeyDown2.Size = new System.Drawing.Size(83, 22);
            this.maskedTextBoxKeyDown2.TabIndex = 3;
            // 
            // txtClientesDescripcionConsulta
            // 
            this.txtClientesDescripcionConsulta.Location = new System.Drawing.Point(248, 15);
            this.txtClientesDescripcionConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientesDescripcionConsulta.Multiline = true;
            this.txtClientesDescripcionConsulta.Name = "txtClientesDescripcionConsulta";
            this.txtClientesDescripcionConsulta.Size = new System.Drawing.Size(599, 45);
            this.txtClientesDescripcionConsulta.TabIndex = 2;
            // 
            // cmbClientesConsultas
            // 
            this.cmbClientesConsultas.BackColor = System.Drawing.Color.White;
            this.cmbClientesConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientesConsultas.FormattingEnabled = true;
            this.cmbClientesConsultas.Location = new System.Drawing.Point(11, 34);
            this.cmbClientesConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClientesConsultas.Name = "cmbClientesConsultas";
            this.cmbClientesConsultas.Size = new System.Drawing.Size(208, 24);
            this.cmbClientesConsultas.TabIndex = 0;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(0, 0);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.Size = new System.Drawing.Size(873, 262);
            this.dgvResultados.TabIndex = 1;
            // 
            // ExportToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 572);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExportToExcel";
            this.Text = "ExportToExcel";
            this.Load += new System.EventHandler(this.ExportToExcel_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExportToExcel_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tcConsultas.ResumeLayout(false);
            this.tbPorTablas.ResumeLayout(false);
            this.gbPorTablasFiltros.ResumeLayout(false);
            this.gbPorTablasFiltros.PerformLayout();
            this.tbEmpleados.ResumeLayout(false);
            this.tbEmpleados.PerformLayout();
            this.panelConsultasEmpleadoFecha.ResumeLayout(false);
            this.panelConsultasEmpleadoFecha.PerformLayout();
            this.panelConsultasEmpleadosNumeroEmpleado.ResumeLayout(false);
            this.panelConsultasEmpleadosNumeroEmpleado.PerformLayout();
            this.tbClientes.ResumeLayout(false);
            this.tbClientes.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSeleccionarTodos;
        private System.Windows.Forms.CheckedListBox listBoxCampos;
        private System.Windows.Forms.Button btnCargar;
        private ComboBoxKeyDown cmbTablas;
        private System.Windows.Forms.Label label3;
        private ComboBoxKeyDown cmbEmpleadosConsultas;
        private MaskedTextBoxKeyDown mtEmpleadosDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBoxKeyDown txtConsultasEmpleadosDescripcion;
        private System.Windows.Forms.Button btnEmpleadosConsultar;
        private MaskedTextBoxKeyDown maskedTextBoxKeyDown1;
        private System.Windows.Forms.TabPage tbClientes;
        private TextBoxKeyDown txtClientesDescripcionConsulta;
        private System.Windows.Forms.Label label4;
        private ComboBoxKeyDown cmbClientesConsultas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MaskedTextBoxKeyDown maskedTextBoxKeyDown3;
        private MaskedTextBoxKeyDown maskedTextBoxKeyDown2;
        private System.Windows.Forms.GroupBox gbPorTablasFiltros;
        private MaskedTextBoxKeyDown maskedTextBoxKeyDown5;
        private MaskedTextBoxKeyDown maskedTextBoxKeyDown4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPorTablaNombre;
        private System.Windows.Forms.CheckBox cbPorTablasInactivos;
        private System.Windows.Forms.Label lblOrdenResultado;
        private System.Windows.Forms.SaveFileDialog saveExcelFileDialog;
        private System.Windows.Forms.Panel panelConsultasEmpleadosNumeroEmpleado;
        private System.Windows.Forms.Panel panelConsultasEmpleadoFecha;
        private System.Windows.Forms.Label label9;
        private MaskedTextBoxKeyDown mtConsultasEmpleadoFecha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
    }
}