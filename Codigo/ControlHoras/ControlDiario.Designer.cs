namespace ControlHoras
{
    partial class ControlDiario
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
            this.mtServicio = new System.Windows.Forms.MaskedTextBox();
            this.mtCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvHoras = new System.Windows.Forms.DataGridView();
            this.menuStripdgvHoras = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cambiarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cambiarHoraIngreso = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarHoraFin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtFecha = new System.Windows.Forms.MaskedTextBox();
            this.btnDiaSiguiente = new System.Windows.Forms.Button();
            this.btnDiaAnterior = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).BeginInit();
            this.menuStripdgvHoras.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtServicio
            // 
            this.mtServicio.BackColor = System.Drawing.SystemColors.Window;
            this.mtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtServicio.Location = new System.Drawing.Point(18, 61);
            this.mtServicio.Mask = "9990";
            this.mtServicio.Name = "mtServicio";
            this.mtServicio.Size = new System.Drawing.Size(44, 22);
            this.mtServicio.TabIndex = 2;
            this.mtServicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtServicio_KeyDown);
            this.mtServicio.Leave += new System.EventHandler(this.mtServicio_Leave);
            this.mtServicio.Enter += new System.EventHandler(this.mtServicio_Enter);
            // 
            // mtCliente
            // 
            this.mtCliente.AllowPromptAsInput = false;
            this.mtCliente.BackColor = System.Drawing.SystemColors.Window;
            this.mtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCliente.Location = new System.Drawing.Point(18, 34);
            this.mtCliente.Mask = "0000";
            this.mtCliente.Name = "mtCliente";
            this.mtCliente.Size = new System.Drawing.Size(44, 22);
            this.mtCliente.TabIndex = 1;
            this.mtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtCliente_KeyDown);
            this.mtCliente.Leave += new System.EventHandler(this.mtCliente_Leave);
            this.mtCliente.Enter += new System.EventHandler(this.mtCliente_Enter);
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(68, 62);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.ReadOnly = true;
            this.txtServicio.Size = new System.Drawing.Size(362, 22);
            this.txtServicio.TabIndex = 10;
            this.txtServicio.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(68, 35);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(362, 22);
            this.txtCliente.TabIndex = 12;
            this.txtCliente.TabStop = false;
            // 
            // dgvHoras
            // 
            this.dgvHoras.AllowUserToAddRows = false;
            this.dgvHoras.AllowUserToDeleteRows = false;
            this.dgvHoras.AllowUserToResizeColumns = false;
            this.dgvHoras.AllowUserToResizeRows = false;
            this.dgvHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoras.Location = new System.Drawing.Point(12, 126);
            this.dgvHoras.MultiSelect = false;
            this.dgvHoras.Name = "dgvHoras";
            this.dgvHoras.ReadOnly = true;
            this.dgvHoras.RowHeadersVisible = false;
            this.dgvHoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoras.Size = new System.Drawing.Size(563, 233);
            this.dgvHoras.TabIndex = 6;
            this.dgvHoras.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoras_CellMouseClick);
            this.dgvHoras.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoras_CellMouseDoubleClick);
            // 
            // menuStripdgvHoras
            // 
            this.menuStripdgvHoras.AllowMerge = false;
            this.menuStripdgvHoras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarFuncionario,
            this.toolStripSeparator2,
            this.cambiarHoraIngreso,
            this.cambiarHoraFin,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.cancelarSalidaToolStripMenuItem});
            this.menuStripdgvHoras.Name = "menuStripdgvHoras";
            this.menuStripdgvHoras.ShowImageMargin = false;
            this.menuStripdgvHoras.Size = new System.Drawing.Size(166, 126);
            // 
            // cambiarFuncionario
            // 
            this.cambiarFuncionario.Name = "cambiarFuncionario";
            this.cambiarFuncionario.Size = new System.Drawing.Size(165, 22);
            this.cambiarFuncionario.Text = "Cambiar Funcionario";
            this.cambiarFuncionario.Click += new System.EventHandler(this.cambiarFuncionario_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // cambiarHoraIngreso
            // 
            this.cambiarHoraIngreso.Name = "cambiarHoraIngreso";
            this.cambiarHoraIngreso.Size = new System.Drawing.Size(165, 22);
            this.cambiarHoraIngreso.Text = "Cambiar Hora Ingreso";
            this.cambiarHoraIngreso.Click += new System.EventHandler(this.cambiarHoraIngreso_Click);
            // 
            // cambiarHoraFin
            // 
            this.cambiarHoraFin.Name = "cambiarHoraFin";
            this.cambiarHoraFin.Size = new System.Drawing.Size(165, 22);
            this.cambiarHoraFin.Text = "Cambiar Hora Fin";
            this.cambiarHoraFin.Click += new System.EventHandler(this.cambiarHoraFin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem1.Text = "Cancelar Entrada";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cancelarSalidaToolStripMenuItem
            // 
            this.cancelarSalidaToolStripMenuItem.Name = "cancelarSalidaToolStripMenuItem";
            this.cancelarSalidaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cancelarSalidaToolStripMenuItem.Text = "Cancelar Salida";
            this.cancelarSalidaToolStripMenuItem.Click += new System.EventHandler(this.cancelarSalidaToolStripMenuItem_Click);
            // 
            // mtFecha
            // 
            this.mtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFecha.Location = new System.Drawing.Point(12, 100);
            this.mtFecha.Mask = "00/00/0000";
            this.mtFecha.Name = "mtFecha";
            this.mtFecha.Size = new System.Drawing.Size(70, 22);
            this.mtFecha.TabIndex = 3;
            this.mtFecha.ValidatingType = typeof(System.DateTime);
            this.mtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtFecha_KeyDown);
            this.mtFecha.Leave += new System.EventHandler(this.mtFecha_Leave);
            this.mtFecha.Enter += new System.EventHandler(this.mtFecha_Enter);
            // 
            // btnDiaSiguiente
            // 
            this.btnDiaSiguiente.Location = new System.Drawing.Point(122, 100);
            this.btnDiaSiguiente.Name = "btnDiaSiguiente";
            this.btnDiaSiguiente.Size = new System.Drawing.Size(28, 23);
            this.btnDiaSiguiente.TabIndex = 5;
            this.btnDiaSiguiente.Text = ">";
            this.btnDiaSiguiente.UseVisualStyleBackColor = true;
            this.btnDiaSiguiente.Click += new System.EventHandler(this.btnDiaSiguiente_Click);
            // 
            // btnDiaAnterior
            // 
            this.btnDiaAnterior.Location = new System.Drawing.Point(88, 100);
            this.btnDiaAnterior.Name = "btnDiaAnterior";
            this.btnDiaAnterior.Size = new System.Drawing.Size(28, 23);
            this.btnDiaAnterior.TabIndex = 4;
            this.btnDiaAnterior.Text = "<";
            this.btnDiaAnterior.UseVisualStyleBackColor = true;
            this.btnDiaAnterior.Click += new System.EventHandler(this.btnDiaAnterior_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(587, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ControlDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 377);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mtFecha);
            this.Controls.Add(this.btnDiaAnterior);
            this.Controls.Add(this.dgvHoras);
            this.Controls.Add(this.mtServicio);
            this.Controls.Add(this.mtCliente);
            this.Controls.Add(this.btnDiaSiguiente);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.txtCliente);
            this.Name = "ControlDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ControlDiario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).EndInit();
            this.menuStripdgvHoras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtServicio;
        private System.Windows.Forms.MaskedTextBox mtCliente;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvHoras;
        private System.Windows.Forms.ContextMenuStrip menuStripdgvHoras;
        private System.Windows.Forms.ToolStripMenuItem cambiarFuncionario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cambiarHoraIngreso;
        private System.Windows.Forms.ToolStripMenuItem cambiarHoraFin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MaskedTextBox mtFecha;
        private System.Windows.Forms.ToolStripMenuItem cancelarSalidaToolStripMenuItem;
        private System.Windows.Forms.Button btnDiaSiguiente;
        private System.Windows.Forms.Button btnDiaAnterior;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}