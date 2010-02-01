namespace ControlHoras
{
    partial class Planificacion
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
            this.mtServicio = new System.Windows.Forms.MaskedTextBox();
            this.mtCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // mtServicio
            // 
            this.mtServicio.Location = new System.Drawing.Point(17, 38);
            this.mtServicio.Mask = "0000";
            this.mtServicio.Name = "mtServicio";
            this.mtServicio.Size = new System.Drawing.Size(44, 20);
            this.mtServicio.TabIndex = 12;
            // 
            // mtCliente
            // 
            this.mtCliente.AllowPromptAsInput = false;
            this.mtCliente.Location = new System.Drawing.Point(17, 11);
            this.mtCliente.Mask = "0000";
            this.mtCliente.Name = "mtCliente";
            this.mtCliente.Size = new System.Drawing.Size(44, 20);
            this.mtCliente.TabIndex = 11;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(67, 39);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(362, 20);
            this.txtServicio.TabIndex = 10;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(67, 12);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(362, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.AllowUserToResizeColumns = false;
            this.dgvPlan.AllowUserToResizeRows = false;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Location = new System.Drawing.Point(17, 103);
            this.dgvPlan.MultiSelect = false;
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowHeadersVisible = false;
            this.dgvPlan.RowHeadersWidth = 20;
            this.dgvPlan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.NullValue = null;
            this.dgvPlan.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgvPlan.Size = new System.Drawing.Size(546, 235);
            this.dgvPlan.TabIndex = 13;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 365);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // Planificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 365);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.mtServicio);
            this.Controls.Add(this.mtCliente);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.txtCliente);
            this.Name = "Planificacion";
            this.Text = "Planificacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtServicio;
        private System.Windows.Forms.MaskedTextBox mtCliente;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.Splitter splitter1;
    }
}