﻿namespace ControlHoras
{
    partial class LiquidaciónEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.MesDTP = new System.Windows.Forms.DateTimePicker();
            this.LiquidarBTN = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.MesTB = new System.Windows.Forms.Label();
            this.PosteriorBTN = new System.Windows.Forms.Button();
            this.AnteriorBTN = new System.Windows.Forms.Button();
            this.CargoLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpleadoLBL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ExcelBTN = new System.Windows.Forms.Button();
            this.HsFerExtTB = new System.Windows.Forms.TextBox();
            this.HsFeriadoTB = new System.Windows.Forms.TextBox();
            this.HsExtraTB = new System.Windows.Forms.TextBox();
            this.HsComunesTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LiquidacionDGV = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExportarTodos = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtNumeroEmpleado = new ControlHoras.MaskedTextBoxKeyDown();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hs_Comunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hs_Extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hs_Feriado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hs_FeriadoEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiquidacionDGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.210526F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Seleccione el mes a liquidar:";
            // 
            // MesDTP
            // 
            this.MesDTP.Location = new System.Drawing.Point(189, 40);
            this.MesDTP.Margin = new System.Windows.Forms.Padding(2);
            this.MesDTP.Name = "MesDTP";
            this.MesDTP.ShowUpDown = true;
            this.MesDTP.Size = new System.Drawing.Size(116, 20);
            this.MesDTP.TabIndex = 28;
            // 
            // LiquidarBTN
            // 
            this.LiquidarBTN.Location = new System.Drawing.Point(348, 39);
            this.LiquidarBTN.Name = "LiquidarBTN";
            this.LiquidarBTN.Size = new System.Drawing.Size(75, 23);
            this.LiquidarBTN.TabIndex = 29;
            this.LiquidarBTN.Text = "Liquidar";
            this.LiquidarBTN.UseVisualStyleBackColor = true;
            this.LiquidarBTN.Click += new System.EventHandler(this.LiquidarBTN_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.MesDTP);
            this.splitContainer1.Panel1.Controls.Add(this.LiquidarBTN);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(565, 548);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 30;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.mtNumeroEmpleado);
            this.splitContainer2.Panel1.Controls.Add(this.MesTB);
            this.splitContainer2.Panel1.Controls.Add(this.PosteriorBTN);
            this.splitContainer2.Panel1.Controls.Add(this.AnteriorBTN);
            this.splitContainer2.Panel1.Controls.Add(this.CargoLBL);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.EmpleadoLBL);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ExcelBTN);
            this.splitContainer2.Panel2.Controls.Add(this.HsFerExtTB);
            this.splitContainer2.Panel2.Controls.Add(this.HsFeriadoTB);
            this.splitContainer2.Panel2.Controls.Add(this.HsExtraTB);
            this.splitContainer2.Panel2.Controls.Add(this.HsComunesTB);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.LiquidacionDGV);
            this.splitContainer2.Size = new System.Drawing.Size(563, 470);
            this.splitContainer2.SplitterDistance = 79;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nro:";
            // 
            // MesTB
            // 
            this.MesTB.AutoSize = true;
            this.MesTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesTB.Location = new System.Drawing.Point(235, 8);
            this.MesTB.Name = "MesTB";
            this.MesTB.Size = new System.Drawing.Size(93, 18);
            this.MesTB.TabIndex = 30;
            this.MesTB.Text = "Empleado: ";
            // 
            // PosteriorBTN
            // 
            this.PosteriorBTN.AutoSize = true;
            this.PosteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PosteriorBTN.Location = new System.Drawing.Point(517, 52);
            this.PosteriorBTN.Name = "PosteriorBTN";
            this.PosteriorBTN.Size = new System.Drawing.Size(29, 23);
            this.PosteriorBTN.TabIndex = 29;
            this.PosteriorBTN.Text = ">>";
            this.PosteriorBTN.UseVisualStyleBackColor = true;
            this.PosteriorBTN.Visible = false;
            this.PosteriorBTN.Click += new System.EventHandler(this.PosteriorBTN_Click);
            // 
            // AnteriorBTN
            // 
            this.AnteriorBTN.AutoSize = true;
            this.AnteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnteriorBTN.Location = new System.Drawing.Point(482, 52);
            this.AnteriorBTN.Name = "AnteriorBTN";
            this.AnteriorBTN.Size = new System.Drawing.Size(29, 23);
            this.AnteriorBTN.TabIndex = 28;
            this.AnteriorBTN.Text = "<<";
            this.AnteriorBTN.UseVisualStyleBackColor = true;
            this.AnteriorBTN.Visible = false;
            this.AnteriorBTN.Click += new System.EventHandler(this.AnteriorBTN_Click);
            // 
            // CargoLBL
            // 
            this.CargoLBL.AutoSize = true;
            this.CargoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoLBL.Location = new System.Drawing.Point(79, 57);
            this.CargoLBL.Name = "CargoLBL";
            this.CargoLBL.Size = new System.Drawing.Size(80, 15);
            this.CargoLBL.TabIndex = 27;
            this.CargoLBL.Text = "Empleado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Puesto: ";
            // 
            // EmpleadoLBL
            // 
            this.EmpleadoLBL.AutoSize = true;
            this.EmpleadoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadoLBL.Location = new System.Drawing.Point(79, 43);
            this.EmpleadoLBL.Name = "EmpleadoLBL";
            this.EmpleadoLBL.Size = new System.Drawing.Size(80, 15);
            this.EmpleadoLBL.TabIndex = 25;
            this.EmpleadoLBL.Text = "Empleado: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Empleado: ";
            // 
            // ExcelBTN
            // 
            this.ExcelBTN.Location = new System.Drawing.Point(471, 352);
            this.ExcelBTN.Name = "ExcelBTN";
            this.ExcelBTN.Size = new System.Drawing.Size(75, 23);
            this.ExcelBTN.TabIndex = 30;
            this.ExcelBTN.Text = "Excel";
            this.ExcelBTN.UseVisualStyleBackColor = true;
            this.ExcelBTN.Click += new System.EventHandler(this.ExcelBTN_Click);
            // 
            // HsFerExtTB
            // 
            this.HsFerExtTB.Location = new System.Drawing.Point(382, 355);
            this.HsFerExtTB.Margin = new System.Windows.Forms.Padding(2);
            this.HsFerExtTB.Name = "HsFerExtTB";
            this.HsFerExtTB.Size = new System.Drawing.Size(49, 20);
            this.HsFerExtTB.TabIndex = 9;
            this.HsFerExtTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HsFeriadoTB
            // 
            this.HsFeriadoTB.Location = new System.Drawing.Point(292, 355);
            this.HsFeriadoTB.Margin = new System.Windows.Forms.Padding(2);
            this.HsFeriadoTB.Name = "HsFeriadoTB";
            this.HsFeriadoTB.Size = new System.Drawing.Size(49, 20);
            this.HsFeriadoTB.TabIndex = 8;
            this.HsFeriadoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HsExtraTB
            // 
            this.HsExtraTB.Location = new System.Drawing.Point(209, 355);
            this.HsExtraTB.Margin = new System.Windows.Forms.Padding(2);
            this.HsExtraTB.Name = "HsExtraTB";
            this.HsExtraTB.Size = new System.Drawing.Size(49, 20);
            this.HsExtraTB.TabIndex = 7;
            this.HsExtraTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HsComunesTB
            // 
            this.HsComunesTB.Location = new System.Drawing.Point(126, 355);
            this.HsComunesTB.Margin = new System.Windows.Forms.Padding(2);
            this.HsComunesTB.Name = "HsComunesTB";
            this.HsComunesTB.Size = new System.Drawing.Size(49, 20);
            this.HsComunesTB.TabIndex = 6;
            this.HsComunesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Totales:";
            // 
            // LiquidacionDGV
            // 
            this.LiquidacionDGV.AllowUserToAddRows = false;
            this.LiquidacionDGV.AllowUserToDeleteRows = false;
            this.LiquidacionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.LiquidacionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LiquidacionDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.Hs_Comunes,
            this.Hs_Extras,
            this.Hs_Feriado,
            this.Hs_FeriadoEx});
            this.LiquidacionDGV.Location = new System.Drawing.Point(52, 2);
            this.LiquidacionDGV.Margin = new System.Windows.Forms.Padding(2);
            this.LiquidacionDGV.Name = "LiquidacionDGV";
            this.LiquidacionDGV.RowHeadersVisible = false;
            this.LiquidacionDGV.RowTemplate.Height = 24;
            this.LiquidacionDGV.Size = new System.Drawing.Size(421, 345);
            this.LiquidacionDGV.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportarTodos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 36);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExportarTodos
            // 
            this.btnExportarTodos.Enabled = false;
            this.btnExportarTodos.Image = global::ControlHoras.Imagenes.application_vnd_ms_excel;
            this.btnExportarTodos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarTodos.Name = "btnExportarTodos";
            this.btnExportarTodos.Size = new System.Drawing.Size(85, 33);
            this.btnExportarTodos.Text = "Exportar Todos";
            this.btnExportarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportarTodos.Click += new System.EventHandler(this.btnExportTodos_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Día";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle9.Format = "00:00";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "Hs Comunes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 92;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle10.Format = "00:00";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "Hs Extras";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle11.Format = "00:00";
            dataGridViewCellStyle11.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn4.HeaderText = "Hs Feriado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 83;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle12.Format = "00:00";
            dataGridViewCellStyle12.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn5.HeaderText = "Hs FeriadoExt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 98;
            // 
            // mtNumeroEmpleado
            // 
            this.mtNumeroEmpleado.BackColor = System.Drawing.Color.White;
            this.mtNumeroEmpleado.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtNumeroEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtNumeroEmpleado.HidePromptOnLeave = true;
            this.mtNumeroEmpleado.Location = new System.Drawing.Point(429, 54);
            this.mtNumeroEmpleado.Mask = "0999";
            this.mtNumeroEmpleado.Name = "mtNumeroEmpleado";
            this.mtNumeroEmpleado.Size = new System.Drawing.Size(44, 21);
            this.mtNumeroEmpleado.TabIndex = 31;
            this.mtNumeroEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtNumeroEmpleado.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtNumeroEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtNumeroEmpleado_KeyDown);
            this.mtNumeroEmpleado.Click += new System.EventHandler(this.mtNumeroEmpleado_Click);
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.Width = 50;
            // 
            // Hs_Comunes
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "00:00";
            dataGridViewCellStyle13.NullValue = "00:00";
            this.Hs_Comunes.DefaultCellStyle = dataGridViewCellStyle13;
            this.Hs_Comunes.HeaderText = "Hs Comunes";
            this.Hs_Comunes.Name = "Hs_Comunes";
            this.Hs_Comunes.Width = 92;
            // 
            // Hs_Extras
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "00:00";
            dataGridViewCellStyle14.NullValue = "00:00";
            this.Hs_Extras.DefaultCellStyle = dataGridViewCellStyle14;
            this.Hs_Extras.HeaderText = "Hs Extras";
            this.Hs_Extras.Name = "Hs_Extras";
            this.Hs_Extras.Width = 77;
            // 
            // Hs_Feriado
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "00:00";
            dataGridViewCellStyle15.NullValue = "00:00";
            this.Hs_Feriado.DefaultCellStyle = dataGridViewCellStyle15;
            this.Hs_Feriado.HeaderText = "Hs Feriado";
            this.Hs_Feriado.Name = "Hs_Feriado";
            this.Hs_Feriado.Width = 83;
            // 
            // Hs_FeriadoEx
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "00:00";
            dataGridViewCellStyle16.NullValue = "00:00";
            this.Hs_FeriadoEx.DefaultCellStyle = dataGridViewCellStyle16;
            this.Hs_FeriadoEx.HeaderText = "Hs FeriadoExt";
            this.Hs_FeriadoEx.Name = "Hs_FeriadoEx";
            this.Hs_FeriadoEx.Width = 98;
            // 
            // LiquidaciónEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 548);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LiquidaciónEmpleados";
            this.Text = "Liquidación de Empleados";
            this.Enter += new System.EventHandler(this.LiquidaciónEmpleados_Enter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LiquidacionDGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker MesDTP;
        private System.Windows.Forms.Button LiquidarBTN;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label EmpleadoLBL;
        private System.Windows.Forms.Label CargoLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LiquidacionDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button PosteriorBTN;
        private System.Windows.Forms.Button AnteriorBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HsFerExtTB;
        private System.Windows.Forms.TextBox HsFeriadoTB;
        private System.Windows.Forms.TextBox HsExtraTB;
        private System.Windows.Forms.TextBox HsComunesTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hs_Comunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hs_Extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hs_Feriado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hs_FeriadoEx;
        private System.Windows.Forms.Label MesTB;
        private System.Windows.Forms.Button ExcelBTN;
        private System.Windows.Forms.Label label4;
        private MaskedTextBoxKeyDown mtNumeroEmpleado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripButton btnExportarTodos;
    }
}