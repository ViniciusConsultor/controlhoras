namespace ControlHoras
{
    partial class ABMTipoExtraLiquidacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvTipoExtrasLiquidacion = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdTipoExtra = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbLlevaHs = new System.Windows.Forms.CheckBox();
            this.idTipoExtraLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LlevaHs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoExtrasLiquidacion)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(70, 50);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // dgvTipoExtrasLiquidacion
            // 
            this.dgvTipoExtrasLiquidacion.AllowUserToAddRows = false;
            this.dgvTipoExtrasLiquidacion.AllowUserToDeleteRows = false;
            this.dgvTipoExtrasLiquidacion.AllowUserToResizeRows = false;
            this.dgvTipoExtrasLiquidacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoExtrasLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoExtrasLiquidacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoExtraLiquidacion,
            this.Nombre,
            this.Activa,
            this.LlevaHs});
            this.dgvTipoExtrasLiquidacion.Location = new System.Drawing.Point(12, 122);
            this.dgvTipoExtrasLiquidacion.MultiSelect = false;
            this.dgvTipoExtrasLiquidacion.Name = "dgvTipoExtrasLiquidacion";
            this.dgvTipoExtrasLiquidacion.ReadOnly = true;
            this.dgvTipoExtrasLiquidacion.RowHeadersVisible = false;
            this.dgvTipoExtrasLiquidacion.RowTemplate.Height = 24;
            this.dgvTipoExtrasLiquidacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoExtrasLiquidacion.Size = new System.Drawing.Size(261, 217);
            this.dgvTipoExtrasLiquidacion.TabIndex = 4;
            this.dgvTipoExtrasLiquidacion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTipoExtrasLiquidacion_MouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnGuardar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(285, 36);
            this.toolStrip1.TabIndex = 5;
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
            this.btnGuardar.Image = global::ControlHoras.Properties.Resources.filesave;
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
            this.btnCancelar.Image = global::ControlHoras.Properties.Resources.button_cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 33);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(171, 55);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(90, 17);
            this.cbEstado.TabIndex = 7;
            this.cbEstado.Text = "Deshabilitado";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLlevaHs);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.lblIdTipoExtra);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblIdTipoExtra
            // 
            this.lblIdTipoExtra.AutoSize = true;
            this.lblIdTipoExtra.Location = new System.Drawing.Point(225, 68);
            this.lblIdTipoExtra.Name = "lblIdTipoExtra";
            this.lblIdTipoExtra.Size = new System.Drawing.Size(0, 13);
            this.lblIdTipoExtra.TabIndex = 0;
            this.lblIdTipoExtra.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "idCiudad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 184;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 40F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Activa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // cmbLlevaHs
            // 
            this.cmbLlevaHs.AutoSize = true;
            this.cmbLlevaHs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbLlevaHs.Location = new System.Drawing.Point(6, 38);
            this.cmbLlevaHs.Name = "cmbLlevaHs";
            this.cmbLlevaHs.Size = new System.Drawing.Size(116, 17);
            this.cmbLlevaHs.TabIndex = 8;
            this.cmbLlevaHs.Text = "Lleva Valor de Hs?";
            this.cmbLlevaHs.UseVisualStyleBackColor = true;
            // 
            // idTipoExtraLiquidacion
            // 
            this.idTipoExtraLiquidacion.HeaderText = "idTipoExtraLiquidacion";
            this.idTipoExtraLiquidacion.Name = "idTipoExtraLiquidacion";
            this.idTipoExtraLiquidacion.ReadOnly = true;
            this.idTipoExtraLiquidacion.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Activa
            // 
            this.Activa.FillWeight = 40F;
            this.Activa.HeaderText = "Activa";
            this.Activa.Name = "Activa";
            this.Activa.ReadOnly = true;
            this.Activa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LlevaHs
            // 
            this.LlevaHs.HeaderText = "Lleva Hs";
            this.LlevaHs.Name = "LlevaHs";
            this.LlevaHs.ReadOnly = true;
            // 
            // ABMTipoExtraLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 351);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvTipoExtrasLiquidacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ABMTipoExtraLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABMTipoExtraLiquidacion";
            this.Load += new System.EventHandler(this.ABMTipoExtraLiquidacion_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ABMTipoExtraLiquidacion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoExtrasLiquidacion)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvTipoExtrasLiquidacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblIdTipoExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.CheckBox cmbLlevaHs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoExtraLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LlevaHs;
    }
}