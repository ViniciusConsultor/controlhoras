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
            this.CargaHorariaDGV = new ControlHoras.DataGridTAB();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Armado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CargaHorariaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CargaHorariaDGV
            // 
            this.CargaHorariaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CargaHorariaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Puesto,
            this.Armado});
            this.CargaHorariaDGV.Location = new System.Drawing.Point(24, 24);
            this.CargaHorariaDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CargaHorariaDGV.Name = "CargaHorariaDGV";
            this.CargaHorariaDGV.ReadOnly = true;
            this.CargaHorariaDGV.RowHeadersVisible = false;
            this.CargaHorariaDGV.RowTemplate.Height = 24;
            this.CargaHorariaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CargaHorariaDGV.Size = new System.Drawing.Size(925, 194);
            this.CargaHorariaDGV.TabIndex = 6;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Armado
            // 
            this.Armado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Armado.FalseValue = "0";
            this.Armado.HeaderText = "Armado";
            this.Armado.IndeterminateValue = "0";
            this.Armado.Name = "Armado";
            this.Armado.TrueValue = "1";
            this.Armado.Width = 63;
            // 
            // ShowContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 243);
            this.Controls.Add(this.CargaHorariaDGV);
            this.Name = "ShowContrato";
            this.Text = "ShowContrato";
            ((System.ComponentModel.ISupportInitialize)(this.CargaHorariaDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridTAB CargaHorariaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Armado;
    }
}