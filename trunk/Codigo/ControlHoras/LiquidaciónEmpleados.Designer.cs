namespace ControlHoras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.MesDTP = new System.Windows.Forms.DateTimePicker();
            this.LiquidarBTN = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PosteriorBTN = new System.Windows.Forms.Button();
            this.AnteriorBTN = new System.Windows.Forms.Button();
            this.CargoLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpleadoLBL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.HsFerExtTB = new System.Windows.Forms.TextBox();
            this.HsFeriadoTB = new System.Windows.Forms.TextBox();
            this.HsExtraTB = new System.Windows.Forms.TextBox();
            this.HsComunesTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LiquidacionDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.210526F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Seleccione el mes a liquidar:";
            // 
            // MesDTP
            // 
            this.MesDTP.Location = new System.Drawing.Point(243, 33);
            this.MesDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MesDTP.Name = "MesDTP";
            this.MesDTP.Size = new System.Drawing.Size(200, 22);
            this.MesDTP.TabIndex = 28;
            // 
            // LiquidarBTN
            // 
            this.LiquidarBTN.Location = new System.Drawing.Point(633, 27);
            this.LiquidarBTN.Margin = new System.Windows.Forms.Padding(4);
            this.LiquidarBTN.Name = "LiquidarBTN";
            this.LiquidarBTN.Size = new System.Drawing.Size(100, 28);
            this.LiquidarBTN.TabIndex = 29;
            this.LiquidarBTN.Text = "Liquidar";
            this.LiquidarBTN.UseVisualStyleBackColor = true;
            this.LiquidarBTN.Click += new System.EventHandler(this.LiquidarBTN_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MesDTP);
            this.splitContainer1.Panel1.Controls.Add(this.LiquidarBTN);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(753, 604);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 30;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PosteriorBTN);
            this.splitContainer2.Panel1.Controls.Add(this.AnteriorBTN);
            this.splitContainer2.Panel1.Controls.Add(this.CargoLBL);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.EmpleadoLBL);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.HsFerExtTB);
            this.splitContainer2.Panel2.Controls.Add(this.HsFeriadoTB);
            this.splitContainer2.Panel2.Controls.Add(this.HsExtraTB);
            this.splitContainer2.Panel2.Controls.Add(this.HsComunesTB);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.LiquidacionDGV);
            this.splitContainer2.Size = new System.Drawing.Size(753, 497);
            this.splitContainer2.SplitterDistance = 76;
            this.splitContainer2.TabIndex = 0;
            // 
            // PosteriorBTN
            // 
            this.PosteriorBTN.AutoSize = true;
            this.PosteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PosteriorBTN.Location = new System.Drawing.Point(689, 18);
            this.PosteriorBTN.Margin = new System.Windows.Forms.Padding(4);
            this.PosteriorBTN.Name = "PosteriorBTN";
            this.PosteriorBTN.Size = new System.Drawing.Size(34, 27);
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
            this.AnteriorBTN.Location = new System.Drawing.Point(642, 18);
            this.AnteriorBTN.Margin = new System.Windows.Forms.Padding(4);
            this.AnteriorBTN.Name = "AnteriorBTN";
            this.AnteriorBTN.Size = new System.Drawing.Size(34, 27);
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
            this.CargoLBL.Location = new System.Drawing.Point(95, 40);
            this.CargoLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CargoLBL.Name = "CargoLBL";
            this.CargoLBL.Size = new System.Drawing.Size(93, 18);
            this.CargoLBL.TabIndex = 27;
            this.CargoLBL.Text = "Empleado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Puesto: ";
            // 
            // EmpleadoLBL
            // 
            this.EmpleadoLBL.AutoSize = true;
            this.EmpleadoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadoLBL.Location = new System.Drawing.Point(95, 22);
            this.EmpleadoLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpleadoLBL.Name = "EmpleadoLBL";
            this.EmpleadoLBL.Size = new System.Drawing.Size(93, 18);
            this.EmpleadoLBL.TabIndex = 25;
            this.EmpleadoLBL.Text = "Empleado: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Empleado: ";
            // 
            // HsFerExtTB
            // 
            this.HsFerExtTB.Location = new System.Drawing.Point(485, 376);
            this.HsFerExtTB.Name = "HsFerExtTB";
            this.HsFerExtTB.Size = new System.Drawing.Size(64, 22);
            this.HsFerExtTB.TabIndex = 9;
            this.HsFerExtTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HsFeriadoTB
            // 
            this.HsFeriadoTB.Location = new System.Drawing.Point(387, 376);
            this.HsFeriadoTB.Name = "HsFeriadoTB";
            this.HsFeriadoTB.Size = new System.Drawing.Size(64, 22);
            this.HsFeriadoTB.TabIndex = 8;
            this.HsFeriadoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HsExtraTB
            // 
            this.HsExtraTB.Location = new System.Drawing.Point(289, 376);
            this.HsExtraTB.Name = "HsExtraTB";
            this.HsExtraTB.Size = new System.Drawing.Size(64, 22);
            this.HsExtraTB.TabIndex = 7;
            this.HsExtraTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HsComunesTB
            // 
            this.HsComunesTB.Location = new System.Drawing.Point(191, 376);
            this.HsComunesTB.Name = "HsComunesTB";
            this.HsComunesTB.Size = new System.Drawing.Size(64, 22);
            this.HsComunesTB.TabIndex = 6;
            this.HsComunesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
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
            this.LiquidacionDGV.Location = new System.Drawing.Point(71, 2);
            this.LiquidacionDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LiquidacionDGV.Name = "LiquidacionDGV";
            this.LiquidacionDGV.RowTemplate.Height = 24;
            this.LiquidacionDGV.Size = new System.Drawing.Size(547, 355);
            this.LiquidacionDGV.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Día";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle5.Format = "00:00";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "Hs Comunes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle6.Format = "00:00";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Hs Extras";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle7.Format = "00:00";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.HeaderText = "Hs Feriado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle8.Format = "00:00";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "Hs FeriadoExt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.Width = 54;
            // 
            // Hs_Comunes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "00:00";
            dataGridViewCellStyle1.NullValue = "00:00";
            this.Hs_Comunes.DefaultCellStyle = dataGridViewCellStyle1;
            this.Hs_Comunes.HeaderText = "Hs Comunes";
            this.Hs_Comunes.Name = "Hs_Comunes";
            this.Hs_Comunes.Width = 113;
            // 
            // Hs_Extras
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "00:00";
            dataGridViewCellStyle2.NullValue = "00:00";
            this.Hs_Extras.DefaultCellStyle = dataGridViewCellStyle2;
            this.Hs_Extras.HeaderText = "Hs Extras";
            this.Hs_Extras.Name = "Hs_Extras";
            this.Hs_Extras.Width = 93;
            // 
            // Hs_Feriado
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "00:00";
            dataGridViewCellStyle3.NullValue = "00:00";
            this.Hs_Feriado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Hs_Feriado.HeaderText = "Hs Feriado";
            this.Hs_Feriado.Name = "Hs_Feriado";
            this.Hs_Feriado.Width = 102;
            // 
            // Hs_FeriadoEx
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "00:00";
            dataGridViewCellStyle4.NullValue = "00:00";
            this.Hs_FeriadoEx.DefaultCellStyle = dataGridViewCellStyle4;
            this.Hs_FeriadoEx.HeaderText = "Hs FeriadoExt";
            this.Hs_FeriadoEx.Name = "Hs_FeriadoEx";
            this.Hs_FeriadoEx.Width = 121;
            // 
            // LiquidaciónEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 604);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LiquidaciónEmpleados";
            this.Text = "Liquidación de Empleados";
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
    }
}