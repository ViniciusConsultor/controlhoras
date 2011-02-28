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
            this.label3 = new System.Windows.Forms.Label();
            this.MesDTP = new System.Windows.Forms.DateTimePicker();
            this.LiquidarBTN = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.EmpleadoLBL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CargoLBL = new System.Windows.Forms.Label();
            this.LiquidacionDGV = new System.Windows.Forms.DataGridView();
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
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Seleccione el mes a liquidar:";
            // 
            // MesDTP
            // 
            this.MesDTP.Location = new System.Drawing.Point(242, 33);
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
            this.splitContainer1.Size = new System.Drawing.Size(753, 529);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 30;
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
            this.splitContainer2.Panel1.Controls.Add(this.CargoLBL);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.EmpleadoLBL);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.LiquidacionDGV);
            this.splitContainer2.Size = new System.Drawing.Size(753, 433);
            this.splitContainer2.SplitterDistance = 85;
            this.splitContainer2.TabIndex = 0;
            // 
            // EmpleadoLBL
            // 
            this.EmpleadoLBL.AutoSize = true;
            this.EmpleadoLBL.Location = new System.Drawing.Point(105, 22);
            this.EmpleadoLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpleadoLBL.Name = "EmpleadoLBL";
            this.EmpleadoLBL.Size = new System.Drawing.Size(79, 17);
            this.EmpleadoLBL.TabIndex = 25;
            this.EmpleadoLBL.Text = "Empleado: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Empleado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Puesto: ";
            // 
            // CargoLBL
            // 
            this.CargoLBL.AutoSize = true;
            this.CargoLBL.Location = new System.Drawing.Point(566, 22);
            this.CargoLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CargoLBL.Name = "CargoLBL";
            this.CargoLBL.Size = new System.Drawing.Size(79, 17);
            this.CargoLBL.TabIndex = 27;
            this.CargoLBL.Text = "Empleado: ";
            // 
            // LiquidacionDGV
            // 
            this.LiquidacionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LiquidacionDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LiquidacionDGV.Location = new System.Drawing.Point(0, 0);
            this.LiquidacionDGV.Name = "LiquidacionDGV";
            this.LiquidacionDGV.RowTemplate.Height = 24;
            this.LiquidacionDGV.Size = new System.Drawing.Size(753, 344);
            this.LiquidacionDGV.TabIndex = 0;
            // 
            // LiquidaciónEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 529);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LiquidaciónEmpleados";
            this.Text = "Liquidación de Empleados";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
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
    }
}