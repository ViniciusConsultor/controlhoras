namespace ControlHoras
{
    partial class Escalafon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgEscalafon = new ControlHoras.DataGridTAB();
            this.NroEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraConfirmacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACargoDe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxKeyDown1 = new ControlHoras.TextBoxKeyDown();
            this.maskedTextBoxKeyDown1 = new ControlHoras.MaskedTextBoxKeyDown();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvHsPorCubrir = new System.Windows.Forms.DataGridView();
            this.HsACubrirLunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsACubrirMartes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsACubrirMiercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsACubrirJueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsACubrirViernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsACubrirSabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsACubrirDomingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEscalafon)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHsPorCubrir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEscalafon
            // 
            this.dgEscalafon.AllowUserToResizeColumns = false;
            this.dgEscalafon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEscalafon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEscalafon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgEscalafon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroEmpleado,
            this.Funcionario,
            this.CodigoPuesto,
            this.HoraConfirmacion,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sabado,
            this.Domingo,
            this.ACargoDe});
            this.dgEscalafon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEscalafon.Location = new System.Drawing.Point(0, 0);
            this.dgEscalafon.MultiSelect = false;
            this.dgEscalafon.Name = "dgEscalafon";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = "--------";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEscalafon.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgEscalafon.RowHeadersVisible = false;
            this.dgEscalafon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgEscalafon.Size = new System.Drawing.Size(1101, 267);
            this.dgEscalafon.TabIndex = 0;
            // 
            // NroEmpleado
            // 
            this.NroEmpleado.Frozen = true;
            this.NroEmpleado.HeaderText = "Nº Emp";
            this.NroEmpleado.Name = "NroEmpleado";
            this.NroEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NroEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Funcionario
            // 
            this.Funcionario.Frozen = true;
            this.Funcionario.HeaderText = "Funcionario";
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Funcionario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Funcionario.Width = 150;
            // 
            // CodigoPuesto
            // 
            this.CodigoPuesto.Frozen = true;
            this.CodigoPuesto.HeaderText = "Codigo Puesto";
            this.CodigoPuesto.Name = "CodigoPuesto";
            this.CodigoPuesto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoPuesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HoraConfirmacion
            // 
            this.HoraConfirmacion.Frozen = true;
            this.HoraConfirmacion.HeaderText = "Hora Confirma";
            this.HoraConfirmacion.Name = "HoraConfirmacion";
            this.HoraConfirmacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HoraConfirmacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HoraConfirmacion.Width = 60;
            // 
            // Lunes
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lunes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Lunes.Frozen = true;
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            this.Lunes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lunes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lunes.Width = 80;
            // 
            // Martes
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Martes.DefaultCellStyle = dataGridViewCellStyle3;
            this.Martes.Frozen = true;
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            this.Martes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Martes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Martes.Width = 80;
            // 
            // Miercoles
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Miercoles.DefaultCellStyle = dataGridViewCellStyle4;
            this.Miercoles.Frozen = true;
            this.Miercoles.HeaderText = "Miercoles";
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Miercoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Miercoles.Width = 80;
            // 
            // Jueves
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Jueves.DefaultCellStyle = dataGridViewCellStyle5;
            this.Jueves.Frozen = true;
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            this.Jueves.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Jueves.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Jueves.Width = 80;
            // 
            // Viernes
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Viernes.DefaultCellStyle = dataGridViewCellStyle6;
            this.Viernes.Frozen = true;
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            this.Viernes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Viernes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Viernes.Width = 80;
            // 
            // Sabado
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Sabado.DefaultCellStyle = dataGridViewCellStyle7;
            this.Sabado.Frozen = true;
            this.Sabado.HeaderText = "Sabado";
            this.Sabado.Name = "Sabado";
            this.Sabado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sabado.Width = 80;
            // 
            // Domingo
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Domingo.DefaultCellStyle = dataGridViewCellStyle8;
            this.Domingo.Frozen = true;
            this.Domingo.HeaderText = "Domingo";
            this.Domingo.Name = "Domingo";
            this.Domingo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Domingo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Domingo.Width = 80;
            // 
            // ACargoDe
            // 
            this.ACargoDe.HeaderText = "A Cargo De";
            this.ACargoDe.Items.AddRange(new object[] {
            "EMPRESA",
            "CLIENTE"});
            this.ACargoDe.MaxDropDownItems = 2;
            this.ACargoDe.Name = "ACargoDe";
            this.ACargoDe.ReadOnly = true;
            this.ACargoDe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ACargoDe.Width = 80;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxKeyDown1);
            this.splitContainer1.Panel1.Controls.Add(this.maskedTextBoxKeyDown1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 458);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBoxKeyDown1
            // 
            this.textBoxKeyDown1.Location = new System.Drawing.Point(104, 46);
            this.textBoxKeyDown1.Name = "textBoxKeyDown1";
            this.textBoxKeyDown1.Size = new System.Drawing.Size(264, 20);
            this.textBoxKeyDown1.TabIndex = 1;
            // 
            // maskedTextBoxKeyDown1
            // 
            this.maskedTextBoxKeyDown1.Location = new System.Drawing.Point(39, 46);
            this.maskedTextBoxKeyDown1.Name = "maskedTextBoxKeyDown1";
            this.maskedTextBoxKeyDown1.Size = new System.Drawing.Size(59, 20);
            this.maskedTextBoxKeyDown1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgEscalafon);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvHsPorCubrir);
            this.splitContainer2.Size = new System.Drawing.Size(1101, 354);
            this.splitContainer2.SplitterDistance = 267;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvHsPorCubrir
            // 
            this.dgvHsPorCubrir.AllowUserToAddRows = false;
            this.dgvHsPorCubrir.AllowUserToDeleteRows = false;
            this.dgvHsPorCubrir.AllowUserToResizeColumns = false;
            this.dgvHsPorCubrir.AllowUserToResizeRows = false;
            this.dgvHsPorCubrir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHsPorCubrir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHsPorCubrir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HsACubrirLunes,
            this.HsACubrirMartes,
            this.HsACubrirMiercoles,
            this.HsACubrirJueves,
            this.HsACubrirViernes,
            this.HsACubrirSabado,
            this.HsACubrirDomingo});
            this.dgvHsPorCubrir.Location = new System.Drawing.Point(301, 3);
            this.dgvHsPorCubrir.Name = "dgvHsPorCubrir";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Format = "HH:MM";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHsPorCubrir.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvHsPorCubrir.RowHeadersVisible = false;
            this.dgvHsPorCubrir.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHsPorCubrir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHsPorCubrir.Size = new System.Drawing.Size(705, 60);
            this.dgvHsPorCubrir.TabIndex = 1;
            // 
            // HsACubrirLunes
            // 
            this.HsACubrirLunes.HeaderText = "Hs Por Cubrir";
            this.HsACubrirLunes.Name = "HsACubrirLunes";
            // 
            // HsACubrirMartes
            // 
            this.HsACubrirMartes.HeaderText = "Hs Faltan Cubrir ";
            this.HsACubrirMartes.Name = "HsACubrirMartes";
            this.HsACubrirMartes.ReadOnly = true;
            // 
            // HsACubrirMiercoles
            // 
            this.HsACubrirMiercoles.HeaderText = "Hs Faltan Cubrir";
            this.HsACubrirMiercoles.Name = "HsACubrirMiercoles";
            this.HsACubrirMiercoles.ReadOnly = true;
            // 
            // HsACubrirJueves
            // 
            this.HsACubrirJueves.HeaderText = "Hs Faltan Cubrir";
            this.HsACubrirJueves.Name = "HsACubrirJueves";
            this.HsACubrirJueves.ReadOnly = true;
            // 
            // HsACubrirViernes
            // 
            this.HsACubrirViernes.HeaderText = "Hs Faltan Cubrir";
            this.HsACubrirViernes.Name = "HsACubrirViernes";
            this.HsACubrirViernes.ReadOnly = true;
            // 
            // HsACubrirSabado
            // 
            this.HsACubrirSabado.HeaderText = "Hs Faltan Cubrir";
            this.HsACubrirSabado.Name = "HsACubrirSabado";
            this.HsACubrirSabado.ReadOnly = true;
            // 
            // HsACubrirDomingo
            // 
            this.HsACubrirDomingo.HeaderText = "Hs Faltan Cubrir";
            this.HsACubrirDomingo.Name = "HsACubrirDomingo";
            this.HsACubrirDomingo.ReadOnly = true;
            // 
            // Escalafon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 458);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Escalafon";
            this.Text = "Escalafon";
            ((System.ComponentModel.ISupportInitialize)(this.dgEscalafon)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHsPorCubrir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridTAB dgEscalafon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvHsPorCubrir;
        private TextBoxKeyDown textBoxKeyDown1;
        private MaskedTextBoxKeyDown maskedTextBoxKeyDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsACubrirLunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsACubrirMartes;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsACubrirMiercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsACubrirJueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsACubrirViernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsACubrirSabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsACubrirDomingo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraConfirmacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ACargoDe;
    }
}