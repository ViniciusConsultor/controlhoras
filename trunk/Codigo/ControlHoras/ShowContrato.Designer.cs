namespace ControlHoras
{
    partial class ShowContrato
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
            this.ClienteLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServicioLBL = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.CargaHorariaDGV = new ControlHoras.DataGridTAB();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Armado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CargaHorariaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClienteLBL
            // 
            this.ClienteLBL.AutoSize = true;
            this.ClienteLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLBL.Location = new System.Drawing.Point(83, 13);
            this.ClienteLBL.Name = "ClienteLBL";
            this.ClienteLBL.Size = new System.Drawing.Size(65, 18);
            this.ClienteLBL.TabIndex = 8;
            this.ClienteLBL.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Servicio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ServicioLBL
            // 
            this.ServicioLBL.AutoSize = true;
            this.ServicioLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicioLBL.Location = new System.Drawing.Point(83, 31);
            this.ServicioLBL.Name = "ServicioLBL";
            this.ServicioLBL.Size = new System.Drawing.Size(65, 18);
            this.ServicioLBL.TabIndex = 10;
            this.ServicioLBL.Text = "Cliente:";
            this.ServicioLBL.Click += new System.EventHandler(this.ServicioLBL_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Location = new System.Drawing.Point(863, 11);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 23);
            this.CloseBTN.TabIndex = 11;
            this.CloseBTN.Text = "Cerrar";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // CargaHorariaDGV
            // 
            this.CargaHorariaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CargaHorariaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Puesto,
            this.Armado});
            this.CargaHorariaDGV.Location = new System.Drawing.Point(11, 61);
            this.CargaHorariaDGV.Margin = new System.Windows.Forms.Padding(2);
            this.CargaHorariaDGV.Name = "CargaHorariaDGV";
            this.CargaHorariaDGV.ReadOnly = true;
            this.CargaHorariaDGV.RowHeadersVisible = false;
            this.CargaHorariaDGV.RowTemplate.Height = 24;
            this.CargaHorariaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CargaHorariaDGV.Size = new System.Drawing.Size(927, 135);
            this.CargaHorariaDGV.TabIndex = 6;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            this.Puesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Armado
            // 
            this.Armado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Armado.FalseValue = "0";
            this.Armado.HeaderText = "Armado";
            this.Armado.IndeterminateValue = "0";
            this.Armado.Name = "Armado";
            this.Armado.ReadOnly = true;
            this.Armado.TrueValue = "1";
            this.Armado.Width = 49;
            // 
            // ShowContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 207);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.ServicioLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClienteLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CargaHorariaDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowContrato";
            this.Text = "ShowContrato";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.CargaHorariaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridTAB CargaHorariaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Armado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClienteLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ServicioLBL;
        private System.Windows.Forms.Button CloseBTN;
    }
}