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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tcConsultas = new System.Windows.Forms.TabControl();
            this.tbPorTablas = new System.Windows.Forms.TabPage();
            this.gbPorTablasFiltros = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPorTablaNombre = new System.Windows.Forms.Label();
            this.cbPorTablasInactivos = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeleccionarTodos = new System.Windows.Forms.Button();
            this.listBoxCampos = new System.Windows.Forms.CheckedListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tbEmpleados = new System.Windows.Forms.TabPage();
            this.btnEmpleadosConsultar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientes = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblOrdenResultado = new System.Windows.Forms.Label();
            this.maskedTextBoxKeyDown5 = new ControlHoras.MaskedTextBoxKeyDown();
            this.maskedTextBoxKeyDown4 = new ControlHoras.MaskedTextBoxKeyDown();
            this.cmbTablas = new ControlHoras.ComboBoxKeyDown();
            this.maskedTextBoxKeyDown1 = new ControlHoras.MaskedTextBoxKeyDown();
            this.txtEmpleadosDescripcionConsulta = new ControlHoras.TextBoxKeyDown();
            this.cmbEmpleadosConsultas = new ControlHoras.ComboBoxKeyDown();
            this.mtEmpleadosDesde = new ControlHoras.MaskedTextBoxKeyDown();
            this.maskedTextBoxKeyDown3 = new ControlHoras.MaskedTextBoxKeyDown();
            this.maskedTextBoxKeyDown2 = new ControlHoras.MaskedTextBoxKeyDown();
            this.txtClientesDescripcionConsulta = new ControlHoras.TextBoxKeyDown();
            this.cmbClientesConsultas = new ControlHoras.ComboBoxKeyDown();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcConsultas.SuspendLayout();
            this.tbPorTablas.SuspendLayout();
            this.gbPorTablasFiltros.SuspendLayout();
            this.tbEmpleados.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(655, 36);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
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
            this.splitContainer1.Size = new System.Drawing.Size(655, 429);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 5;
            // 
            // tcConsultas
            // 
            this.tcConsultas.Controls.Add(this.tbPorTablas);
            this.tcConsultas.Controls.Add(this.tbEmpleados);
            this.tcConsultas.Controls.Add(this.tbClientes);
            this.tcConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcConsultas.Location = new System.Drawing.Point(0, 0);
            this.tcConsultas.Name = "tcConsultas";
            this.tcConsultas.SelectedIndex = 0;
            this.tcConsultas.Size = new System.Drawing.Size(655, 214);
            this.tcConsultas.TabIndex = 6;
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
            this.tbPorTablas.Location = new System.Drawing.Point(4, 22);
            this.tbPorTablas.Name = "tbPorTablas";
            this.tbPorTablas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPorTablas.Size = new System.Drawing.Size(647, 188);
            this.tbPorTablas.TabIndex = 0;
            this.tbPorTablas.Text = "Por Tablas";
            this.tbPorTablas.UseVisualStyleBackColor = true;
            // 
            // gbPorTablasFiltros
            // 
            this.gbPorTablasFiltros.Controls.Add(this.maskedTextBoxKeyDown5);
            this.gbPorTablasFiltros.Controls.Add(this.maskedTextBoxKeyDown4);
            this.gbPorTablasFiltros.Controls.Add(this.label8);
            this.gbPorTablasFiltros.Controls.Add(this.label7);
            this.gbPorTablasFiltros.Controls.Add(this.lblPorTablaNombre);
            this.gbPorTablasFiltros.Controls.Add(this.cbPorTablasInactivos);
            this.gbPorTablasFiltros.Location = new System.Drawing.Point(8, 148);
            this.gbPorTablasFiltros.Name = "gbPorTablasFiltros";
            this.gbPorTablasFiltros.Size = new System.Drawing.Size(539, 37);
            this.gbPorTablasFiltros.TabIndex = 11;
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
            // cbPorTablasInactivos
            // 
            this.cbPorTablasInactivos.AutoSize = true;
            this.cbPorTablasInactivos.Location = new System.Drawing.Point(412, 14);
            this.cbPorTablasInactivos.Name = "cbPorTablasInactivos";
            this.cbPorTablasInactivos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbPorTablasInactivos.Size = new System.Drawing.Size(100, 17);
            this.cbPorTablasInactivos.TabIndex = 17;
            this.cbPorTablasInactivos.Text = "Incluir Inactivos";
            this.cbPorTablasInactivos.UseVisualStyleBackColor = true;
            this.cbPorTablasInactivos.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Deseleccionar Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(553, 32);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(83, 35);
            this.btnSeleccionarTodos.TabIndex = 9;
            this.btnSeleccionarTodos.Text = "Seleccionar Todos";
            this.btnSeleccionarTodos.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // listBoxCampos
            // 
            this.listBoxCampos.CheckOnClick = true;
            this.listBoxCampos.FormattingEnabled = true;
            this.listBoxCampos.Location = new System.Drawing.Point(8, 32);
            this.listBoxCampos.MultiColumn = true;
            this.listBoxCampos.Name = "listBoxCampos";
            this.listBoxCampos.Size = new System.Drawing.Size(539, 94);
            this.listBoxCampos.TabIndex = 7;
            this.listBoxCampos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBoxCampos_ItemCheck);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(557, 148);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tbEmpleados
            // 
            this.tbEmpleados.Controls.Add(this.maskedTextBoxKeyDown1);
            this.tbEmpleados.Controls.Add(this.btnEmpleadosConsultar);
            this.tbEmpleados.Controls.Add(this.checkBox1);
            this.tbEmpleados.Controls.Add(this.label3);
            this.tbEmpleados.Controls.Add(this.label2);
            this.tbEmpleados.Controls.Add(this.label1);
            this.tbEmpleados.Controls.Add(this.txtEmpleadosDescripcionConsulta);
            this.tbEmpleados.Controls.Add(this.cmbEmpleadosConsultas);
            this.tbEmpleados.Controls.Add(this.mtEmpleadosDesde);
            this.tbEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tbEmpleados.Name = "tbEmpleados";
            this.tbEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmpleados.Size = new System.Drawing.Size(647, 188);
            this.tbEmpleados.TabIndex = 1;
            this.tbEmpleados.Text = "Empleados";
            this.tbEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnEmpleadosConsultar
            // 
            this.btnEmpleadosConsultar.Location = new System.Drawing.Point(52, 130);
            this.btnEmpleadosConsultar.Name = "btnEmpleadosConsultar";
            this.btnEmpleadosConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleadosConsultar.TabIndex = 8;
            this.btnEmpleadosConsultar.Text = "Consultar";
            this.btnEmpleadosConsultar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(455, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Incluir Inactivos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Empleado    Desde";
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
            this.tbClientes.Location = new System.Drawing.Point(4, 22);
            this.tbClientes.Name = "tbClientes";
            this.tbClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tbClientes.Size = new System.Drawing.Size(647, 188);
            this.tbClientes.TabIndex = 2;
            this.tbClientes.Text = "Clientes";
            this.tbClientes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero Cliente    Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Consultas";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(0, 0);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(655, 211);
            this.dgvResultados.TabIndex = 1;
            // 
            // lblOrdenResultado
            // 
            this.lblOrdenResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdenResultado.Location = new System.Drawing.Point(8, 129);
            this.lblOrdenResultado.Name = "lblOrdenResultado";
            this.lblOrdenResultado.Size = new System.Drawing.Size(538, 18);
            this.lblOrdenResultado.TabIndex = 12;
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
            // cmbTablas
            // 
            this.cmbTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(235, 4);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(174, 21);
            this.cmbTablas.TabIndex = 6;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // maskedTextBoxKeyDown1
            // 
            this.maskedTextBoxKeyDown1.Location = new System.Drawing.Point(492, 66);
            this.maskedTextBoxKeyDown1.Name = "maskedTextBoxKeyDown1";
            this.maskedTextBoxKeyDown1.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxKeyDown1.TabIndex = 9;
            // 
            // txtEmpleadosDescripcionConsulta
            // 
            this.txtEmpleadosDescripcionConsulta.Location = new System.Drawing.Point(206, 11);
            this.txtEmpleadosDescripcionConsulta.Multiline = true;
            this.txtEmpleadosDescripcionConsulta.Name = "txtEmpleadosDescripcionConsulta";
            this.txtEmpleadosDescripcionConsulta.Size = new System.Drawing.Size(430, 36);
            this.txtEmpleadosDescripcionConsulta.TabIndex = 6;
            // 
            // cmbEmpleadosConsultas
            // 
            this.cmbEmpleadosConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleadosConsultas.FormattingEnabled = true;
            this.cmbEmpleadosConsultas.Location = new System.Drawing.Point(22, 27);
            this.cmbEmpleadosConsultas.Name = "cmbEmpleadosConsultas";
            this.cmbEmpleadosConsultas.Size = new System.Drawing.Size(156, 21);
            this.cmbEmpleadosConsultas.TabIndex = 4;
            // 
            // mtEmpleadosDesde
            // 
            this.mtEmpleadosDesde.BackColor = System.Drawing.Color.White;
            this.mtEmpleadosDesde.Location = new System.Drawing.Point(364, 66);
            this.mtEmpleadosDesde.Name = "mtEmpleadosDesde";
            this.mtEmpleadosDesde.Size = new System.Drawing.Size(63, 20);
            this.mtEmpleadosDesde.TabIndex = 2;
            // 
            // maskedTextBoxKeyDown3
            // 
            this.maskedTextBoxKeyDown3.Location = new System.Drawing.Point(497, 65);
            this.maskedTextBoxKeyDown3.Name = "maskedTextBoxKeyDown3";
            this.maskedTextBoxKeyDown3.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxKeyDown3.TabIndex = 4;
            // 
            // maskedTextBoxKeyDown2
            // 
            this.maskedTextBoxKeyDown2.Location = new System.Drawing.Point(360, 65);
            this.maskedTextBoxKeyDown2.Name = "maskedTextBoxKeyDown2";
            this.maskedTextBoxKeyDown2.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxKeyDown2.TabIndex = 3;
            // 
            // txtClientesDescripcionConsulta
            // 
            this.txtClientesDescripcionConsulta.Location = new System.Drawing.Point(186, 12);
            this.txtClientesDescripcionConsulta.Multiline = true;
            this.txtClientesDescripcionConsulta.Name = "txtClientesDescripcionConsulta";
            this.txtClientesDescripcionConsulta.Size = new System.Drawing.Size(450, 37);
            this.txtClientesDescripcionConsulta.TabIndex = 2;
            // 
            // cmbClientesConsultas
            // 
            this.cmbClientesConsultas.BackColor = System.Drawing.Color.White;
            this.cmbClientesConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientesConsultas.FormattingEnabled = true;
            this.cmbClientesConsultas.Location = new System.Drawing.Point(8, 28);
            this.cmbClientesConsultas.Name = "cmbClientesConsultas";
            this.cmbClientesConsultas.Size = new System.Drawing.Size(157, 21);
            this.cmbClientesConsultas.TabIndex = 0;
            // 
            // ExportToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 465);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ExportToExcel";
            this.Text = "ExportToExcel";
            this.Load += new System.EventHandler(this.ExportToExcel_Load);
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
        private TextBoxKeyDown txtEmpleadosDescripcionConsulta;
        private System.Windows.Forms.CheckBox checkBox1;
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
    }
}