namespace ControlHoras
{
    partial class VerEscalafonEmpleadoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerEscalafonEmpleadoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBuscarFuncionario = new System.Windows.Forms.ToolStripButton();
            this.mtFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreFuncionario = new System.Windows.Forms.TextBox();
            this.dgvEscalafonEmpleado = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ClienteServicio = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscalafonEmpleado)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarFuncionario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFuncionario.Image")));
            this.btnBuscarFuncionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(101, 33);
            this.btnBuscarFuncionario.Text = "Buscar Funcionario";
            this.btnBuscarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarFuncionario.ToolTipText = "Buscar Funcionario";
            // 
            // mtFuncionario
            // 
            this.mtFuncionario.BackColor = System.Drawing.SystemColors.Window;
            this.mtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFuncionario.Location = new System.Drawing.Point(13, 14);
            this.mtFuncionario.Mask = "9990";
            this.mtFuncionario.Name = "mtFuncionario";
            this.mtFuncionario.Size = new System.Drawing.Size(44, 22);
            this.mtFuncionario.TabIndex = 19;
            this.mtFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtFuncionario_KeyDown);
            // 
            // txtNombreFuncionario
            // 
            this.txtNombreFuncionario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFuncionario.Location = new System.Drawing.Point(63, 14);
            this.txtNombreFuncionario.Name = "txtNombreFuncionario";
            this.txtNombreFuncionario.ReadOnly = true;
            this.txtNombreFuncionario.Size = new System.Drawing.Size(290, 22);
            this.txtNombreFuncionario.TabIndex = 20;
            this.txtNombreFuncionario.TabStop = false;
            // 
            // dgvEscalafonEmpleado
            // 
            this.dgvEscalafonEmpleado.AllowUserToAddRows = false;
            this.dgvEscalafonEmpleado.AllowUserToDeleteRows = false;
            this.dgvEscalafonEmpleado.AllowUserToResizeColumns = false;
            this.dgvEscalafonEmpleado.AllowUserToResizeRows = false;
            this.dgvEscalafonEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEscalafonEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvEscalafonEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEscalafonEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEscalafonEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEscalafonEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteServicio,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sabado,
            this.Domingo});
            this.dgvEscalafonEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEscalafonEmpleado.Location = new System.Drawing.Point(0, 0);
            this.dgvEscalafonEmpleado.MultiSelect = false;
            this.dgvEscalafonEmpleado.Name = "dgvEscalafonEmpleado";
            this.dgvEscalafonEmpleado.ReadOnly = true;
            this.dgvEscalafonEmpleado.RowHeadersVisible = false;
            this.dgvEscalafonEmpleado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEscalafonEmpleado.Size = new System.Drawing.Size(800, 279);
            this.dgvEscalafonEmpleado.TabIndex = 21;
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
            this.splitContainer1.Panel1.Controls.Add(this.txtNombreFuncionario);
            this.splitContainer1.Panel1.Controls.Add(this.mtFuncionario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEscalafonEmpleado);
            this.splitContainer1.Size = new System.Drawing.Size(800, 335);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.TabIndex = 22;
            // 
            // ClienteServicio
            // 
            this.ClienteServicio.Frozen = true;
            this.ClienteServicio.HeaderText = "Cliente/Servicio";
            this.ClienteServicio.Name = "ClienteServicio";
            this.ClienteServicio.ReadOnly = true;
            // 
            // Lunes
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Lunes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Lunes.Frozen = true;
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            this.Lunes.ReadOnly = true;
            this.Lunes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Martes
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Martes.DefaultCellStyle = dataGridViewCellStyle3;
            this.Martes.Frozen = true;
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            this.Martes.ReadOnly = true;
            // 
            // Miercoles
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Miercoles.DefaultCellStyle = dataGridViewCellStyle4;
            this.Miercoles.Frozen = true;
            this.Miercoles.HeaderText = "Miercoles";
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.ReadOnly = true;
            // 
            // Jueves
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Jueves.DefaultCellStyle = dataGridViewCellStyle5;
            this.Jueves.Frozen = true;
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            this.Jueves.ReadOnly = true;
            // 
            // Viernes
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Viernes.DefaultCellStyle = dataGridViewCellStyle6;
            this.Viernes.Frozen = true;
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            this.Viernes.ReadOnly = true;
            // 
            // Sabado
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sabado.DefaultCellStyle = dataGridViewCellStyle7;
            this.Sabado.Frozen = true;
            this.Sabado.HeaderText = "Sabado";
            this.Sabado.Name = "Sabado";
            this.Sabado.ReadOnly = true;
            // 
            // Domingo
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Domingo.DefaultCellStyle = dataGridViewCellStyle8;
            this.Domingo.Frozen = true;
            this.Domingo.HeaderText = "Domingo";
            this.Domingo.Name = "Domingo";
            this.Domingo.ReadOnly = true;
            // 
            // VerEscalafonEmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VerEscalafonEmpleadoForm";
            this.Text = "VerEscalafonEmpleado";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscalafonEmpleado)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBuscarFuncionario;
        private System.Windows.Forms.MaskedTextBox mtFuncionario;
        private System.Windows.Forms.TextBox txtNombreFuncionario;
        private System.Windows.Forms.DataGridView dgvEscalafonEmpleado;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewLinkColumn ClienteServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
    }
}