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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planificacion));
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PruebaTB = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.mtCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtServicio = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnOculto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.AllowUserToResizeColumns = false;
            this.dgvPlan.AllowUserToResizeRows = false;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Location = new System.Drawing.Point(23, 149);
            this.dgvPlan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPlan.MultiSelect = false;
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowHeadersVisible = false;
            this.dgvPlan.RowHeadersWidth = 20;
            this.dgvPlan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.NullValue = null;
            this.dgvPlan.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlan.RowTemplate.Height = 24;
            this.dgvPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgvPlan.Size = new System.Drawing.Size(873, 289);
            this.dgvPlan.TabIndex = 2;            
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 479);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // PruebaTB
            // 
            this.PruebaTB.BackColor = System.Drawing.Color.Lavender;
            this.PruebaTB.Location = new System.Drawing.Point(765, 69);
            this.PruebaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PruebaTB.Name = "PruebaTB";
            this.PruebaTB.Size = new System.Drawing.Size(100, 22);
            this.PruebaTB.TabIndex = 17;
            this.PruebaTB.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(91, 62);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(481, 25);
            this.txtCliente.TabIndex = 9;
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(91, 95);
            this.txtServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.ReadOnly = true;
            this.txtServicio.Size = new System.Drawing.Size(481, 25);
            this.txtServicio.TabIndex = 10;
            // 
            // mtCliente
            // 
            this.mtCliente.AllowPromptAsInput = false;
            this.mtCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCliente.Location = new System.Drawing.Point(24, 62);
            this.mtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtCliente.Mask = "0000";
            this.mtCliente.Name = "mtCliente";
            this.mtCliente.ReadOnly = true;
            this.mtCliente.Size = new System.Drawing.Size(57, 25);
            this.mtCliente.TabIndex = 0;
            // 
            // mtServicio
            // 
            this.mtServicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtServicio.Location = new System.Drawing.Point(24, 95);
            this.mtServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtServicio.Mask = "0000";
            this.mtServicio.Name = "mtServicio";
            this.mtServicio.ReadOnly = true;
            this.mtServicio.Size = new System.Drawing.Size(57, 25);
            this.mtServicio.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerar});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(911, 40);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(60, 37);
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnOculto
            // 
            this.btnOculto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOculto.Location = new System.Drawing.Point(765, 101);
            this.btnOculto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOculto.Name = "btnOculto";
            this.btnOculto.Size = new System.Drawing.Size(100, 28);
            this.btnOculto.TabIndex = 20;
            this.btnOculto.Text = "oculto";
            this.btnOculto.UseVisualStyleBackColor = true;
            this.btnOculto.Visible = false;
            // 
            // Planificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 479);
            this.Controls.Add(this.btnOculto);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PruebaTB);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.mtServicio);
            this.Controls.Add(this.mtCliente);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.txtCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Planificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Planificacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox PruebaTB;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.MaskedTextBox mtCliente;
        private System.Windows.Forms.MaskedTextBox mtServicio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.Button btnOculto;
    }
}