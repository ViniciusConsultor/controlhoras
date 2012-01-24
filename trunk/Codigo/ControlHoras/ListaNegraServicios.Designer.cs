namespace ControlHoras
{
    partial class ListaNegraServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaNegraServicios));
            this.dgvBancos = new System.Windows.Forms.DataGridView();
            this.idBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdListaNegraServicios = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBuscarFuncionario = new System.Windows.Forms.ToolStripButton();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtNumeroEmpleado = new ControlHoras.MaskedTextBoxKeyDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBancos
            // 
            this.dgvBancos.AllowUserToAddRows = false;
            this.dgvBancos.AllowUserToDeleteRows = false;
            this.dgvBancos.AllowUserToResizeRows = false;
            this.dgvBancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBanco,
            this.Nombre,
            this.Activa});
            this.dgvBancos.Location = new System.Drawing.Point(12, 159);
            this.dgvBancos.MultiSelect = false;
            this.dgvBancos.Name = "dgvBancos";
            this.dgvBancos.ReadOnly = true;
            this.dgvBancos.RowHeadersVisible = false;
            this.dgvBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBancos.Size = new System.Drawing.Size(442, 217);
            this.dgvBancos.TabIndex = 4;
            this.dgvBancos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTiposMotivoCambioDiario_MouseDoubleClick);
            // 
            // idBanco
            // 
            this.idBanco.HeaderText = "idBanco";
            this.idBanco.Name = "idBanco";
            this.idBanco.ReadOnly = true;
            this.idBanco.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Activa
            // 
            this.Activa.FillWeight = 25F;
            this.Activa.HeaderText = "Activa";
            this.Activa.Name = "Activa";
            this.Activa.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnGuardar,
            this.btnCancelar,
            this.toolStripSeparator1,
            this.tsbBuscarFuncionario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 36);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.mtNumeroEmpleado);
            this.groupBox1.Controls.Add(this.lblIdListaNegraServicios);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblIdListaNegraServicios
            // 
            this.lblIdListaNegraServicios.AutoSize = true;
            this.lblIdListaNegraServicios.Location = new System.Drawing.Point(327, 97);
            this.lblIdListaNegraServicios.Name = "lblIdListaNegraServicios";
            this.lblIdListaNegraServicios.Size = new System.Drawing.Size(109, 13);
            this.lblIdListaNegraServicios.TabIndex = 0;
            this.lblIdListaNegraServicios.Text = "idListaNegraServicios";
            this.lblIdListaNegraServicios.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "idBanco";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // tsbBuscarFuncionario
            // 
            this.tsbBuscarFuncionario.Image = global::ControlHoras.Imagenes.UserSearch;
            this.tsbBuscarFuncionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarFuncionario.Name = "tsbBuscarFuncionario";
            this.tsbBuscarFuncionario.Size = new System.Drawing.Size(43, 33);
            this.tsbBuscarFuncionario.Text = "Buscar";
            this.tsbBuscarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuscarFuncionario.ToolTipText = "Buscar Funcionario";
            this.tsbBuscarFuncionario.Click += new System.EventHandler(this.tsbBuscarFuncionario_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(6, 16);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Numero";
            // 
            // mtNumeroEmpleado
            // 
            this.mtNumeroEmpleado.BackColor = System.Drawing.Color.White;
            this.mtNumeroEmpleado.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtNumeroEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtNumeroEmpleado.HidePromptOnLeave = true;
            this.mtNumeroEmpleado.Location = new System.Drawing.Point(67, 12);
            this.mtNumeroEmpleado.Mask = "0999";
            this.mtNumeroEmpleado.Name = "mtNumeroEmpleado";
            this.mtNumeroEmpleado.Size = new System.Drawing.Size(44, 21);
            this.mtNumeroEmpleado.TabIndex = 10;
            this.mtNumeroEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtNumeroEmpleado.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "C.I.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre y Apellido del Funcionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cedula";
            // 
            // ListaNegraServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 388);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBancos);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ListaNegraServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista Negra de Servicios";
            this.Load += new System.EventHandler(this.ListaNegraServicios_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListaNegraServicios_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBancos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblIdListaNegraServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBuscarFuncionario;
        private System.Windows.Forms.Label lblNumero;
        private MaskedTextBoxKeyDown mtNumeroEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}