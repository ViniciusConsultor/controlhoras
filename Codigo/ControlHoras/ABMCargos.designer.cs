namespace ControlHoras
{
    partial class ABMCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMCargos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.IdTipoCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsComunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullTime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CobraHsExtras = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCobraExtras = new System.Windows.Forms.CheckBox();
            this.cbFulltime = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoFacturacion = new ControlHoras.ComboBoxKeyDown();
            this.mtHsComunes = new ControlHoras.MaskedTextBoxKeyDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new ControlHoras.TextBoxKeyDown();
            this.txtDescripcion = new ControlHoras.TextBoxKeyDown();
            this.lblIdTipoCargo = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // dgvCargos
            // 
            this.dgvCargos.AllowUserToAddRows = false;
            this.dgvCargos.AllowUserToDeleteRows = false;
            this.dgvCargos.AllowUserToResizeRows = false;
            this.dgvCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTipoCargo,
            this.Nombre,
            this.Descripcion,
            this.HsComunes,
            this.TipoFacturacion,
            this.FullTime,
            this.CobraHsExtras,
            this.Activo});
            this.dgvCargos.Location = new System.Drawing.Point(17, 249);
            this.dgvCargos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCargos.MultiSelect = false;
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.ReadOnly = true;
            this.dgvCargos.RowHeadersVisible = false;
            this.dgvCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargos.Size = new System.Drawing.Size(608, 276);
            this.dgvCargos.TabIndex = 4;
            this.dgvCargos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargos_CellContentDoubleClick);
            // 
            // IdTipoCargo
            // 
            this.IdTipoCargo.HeaderText = "IdTipoCargo";
            this.IdTipoCargo.Name = "IdTipoCargo";
            this.IdTipoCargo.ReadOnly = true;
            this.IdTipoCargo.Visible = false;
            this.IdTipoCargo.Width = 71;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 83;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 107;
            // 
            // HsComunes
            // 
            this.HsComunes.HeaderText = "Hs Comunes";
            this.HsComunes.Name = "HsComunes";
            this.HsComunes.ReadOnly = true;
            this.HsComunes.Width = 104;
            // 
            // TipoFacturacion
            // 
            this.TipoFacturacion.HeaderText = "Tipo Facturación";
            this.TipoFacturacion.Name = "TipoFacturacion";
            this.TipoFacturacion.ReadOnly = true;
            this.TipoFacturacion.Width = 127;
            // 
            // FullTime
            // 
            this.FullTime.HeaderText = "FullTime";
            this.FullTime.Name = "FullTime";
            this.FullTime.ReadOnly = true;
            this.FullTime.Width = 67;
            // 
            // CobraHsExtras
            // 
            this.CobraHsExtras.HeaderText = "Cobra Extras";
            this.CobraHsExtras.Name = "CobraHsExtras";
            this.CobraHsExtras.ReadOnly = true;
            this.CobraHsExtras.Width = 86;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 71;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnGuardar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 40);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ControlHoras.Imagenes.document_new;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 37);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(61, 37);
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
            this.btnCancelar.Size = new System.Drawing.Size(64, 37);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(101, 158);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(113, 21);
            this.cbEstado.TabIndex = 7;
            this.cbEstado.Text = "Deshabilitado";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCobraExtras);
            this.groupBox1.Controls.Add(this.cbFulltime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbTipoFacturacion);
            this.groupBox1.Controls.Add(this.mtHsComunes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblIdTipoCargo);
            this.groupBox1.Location = new System.Drawing.Point(17, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(608, 192);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cbCobraExtras
            // 
            this.cbCobraExtras.AutoSize = true;
            this.cbCobraExtras.Location = new System.Drawing.Point(328, 137);
            this.cbCobraExtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCobraExtras.Name = "cbCobraExtras";
            this.cbCobraExtras.Size = new System.Drawing.Size(137, 21);
            this.cbCobraExtras.TabIndex = 13;
            this.cbCobraExtras.Text = "Cobra Hs Extras?";
            this.cbCobraExtras.UseVisualStyleBackColor = true;
            // 
            // cbFulltime
            // 
            this.cbFulltime.AutoSize = true;
            this.cbFulltime.Location = new System.Drawing.Point(328, 108);
            this.cbFulltime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFulltime.Name = "cbFulltime";
            this.cbFulltime.Size = new System.Drawing.Size(88, 21);
            this.cbFulltime.TabIndex = 12;
            this.cbFulltime.Text = "FullTime?";
            this.cbFulltime.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo";
            // 
            // cmbTipoFacturacion
            // 
            this.cmbTipoFacturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFacturacion.FormattingEnabled = true;
            this.cmbTipoFacturacion.Items.AddRange(new object[] {
            "JORNALERO",
            "MENSUAL"});
            this.cmbTipoFacturacion.Location = new System.Drawing.Point(101, 117);
            this.cmbTipoFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoFacturacion.Name = "cmbTipoFacturacion";
            this.cmbTipoFacturacion.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoFacturacion.TabIndex = 10;
            // 
            // mtHsComunes
            // 
            this.mtHsComunes.Location = new System.Drawing.Point(143, 80);
            this.mtHsComunes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtHsComunes.Name = "mtHsComunes";
            this.mtHsComunes.Size = new System.Drawing.Size(37, 22);
            this.mtHsComunes.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cant. Hs Comunes";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 15);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(103, 47);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(367, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblIdTipoCargo
            // 
            this.lblIdTipoCargo.AutoSize = true;
            this.lblIdTipoCargo.Location = new System.Drawing.Point(300, 84);
            this.lblIdTipoCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTipoCargo.Name = "lblIdTipoCargo";
            this.lblIdTipoCargo.Size = new System.Drawing.Size(0, 17);
            this.lblIdTipoCargo.TabIndex = 0;
            this.lblIdTipoCargo.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdTipoCargo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hs Comunes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tipo Facturación";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 103;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 62;
            // 
            // ABMCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 539);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvCargos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ABMCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABMCargos";
            this.Load += new System.EventHandler(this.ABMCargos_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ABMCargos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ControlHoras.TextBoxKeyDown txtNombre;
        private ControlHoras.TextBoxKeyDown txtDescripcion;
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblIdTipoCargo;
        private MaskedTextBoxKeyDown mtHsComunes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbFulltime;
        private System.Windows.Forms.Label label5;
        private ControlHoras.ComboBoxKeyDown cmbTipoFacturacion;
        private System.Windows.Forms.CheckBox cbCobraExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsComunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFacturacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FullTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CobraHsExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}