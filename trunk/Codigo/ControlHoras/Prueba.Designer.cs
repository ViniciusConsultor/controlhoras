namespace ControlHoras
{
    partial class Prueba
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxKeyDown3 = new ControlHoras.TextBoxKeyDown();
            this.textBoxKeyDown2 = new ControlHoras.TextBoxKeyDown();
            this.textBoxKeyDown1 = new ControlHoras.TextBoxKeyDown();
            this.maskedTextBoxColumn1 = new ControlHoras.MaskedTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Armado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Puesto,
            this.Armado,
            this.Cantidad});
            this.dgv.Location = new System.Drawing.Point(27, 43);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(823, 194);
            this.dgv.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Puesto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // textBoxKeyDown3
            // 
            this.textBoxKeyDown3.Location = new System.Drawing.Point(180, 408);
            this.textBoxKeyDown3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKeyDown3.Name = "textBoxKeyDown3";
            this.textBoxKeyDown3.Size = new System.Drawing.Size(289, 22);
            this.textBoxKeyDown3.TabIndex = 2;
            // 
            // textBoxKeyDown2
            // 
            this.textBoxKeyDown2.Location = new System.Drawing.Point(180, 364);
            this.textBoxKeyDown2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKeyDown2.Name = "textBoxKeyDown2";
            this.textBoxKeyDown2.Size = new System.Drawing.Size(289, 22);
            this.textBoxKeyDown2.TabIndex = 1;
            // 
            // textBoxKeyDown1
            // 
            this.textBoxKeyDown1.Location = new System.Drawing.Point(180, 332);
            this.textBoxKeyDown1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKeyDown1.Name = "textBoxKeyDown1";
            this.textBoxKeyDown1.Size = new System.Drawing.Size(289, 22);
            this.textBoxKeyDown1.TabIndex = 0;
            // 
            // maskedTextBoxColumn1
            // 
            this.maskedTextBoxColumn1.HeaderText = "Lunes";
            this.maskedTextBoxColumn1.IncludeLiterals = false;
            this.maskedTextBoxColumn1.IncludePrompt = false;
            this.maskedTextBoxColumn1.Mask = null;
            this.maskedTextBoxColumn1.Name = "maskedTextBoxColumn1";
            this.maskedTextBoxColumn1.PromptChar = '\0';
            this.maskedTextBoxColumn1.ValidatingType = null;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            // 
            // Armado
            // 
            this.Armado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Armado.HeaderText = "Armado";
            this.Armado.Name = "Armado";
            this.Armado.Width = 63;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 70;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 443);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.textBoxKeyDown3);
            this.Controls.Add(this.textBoxKeyDown2);
            this.Controls.Add(this.textBoxKeyDown1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prueba";
            this.Text = "Prueba";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxKeyDown textBoxKeyDown1;
        private TextBoxKeyDown textBoxKeyDown2;
        private TextBoxKeyDown textBoxKeyDown3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MaskedTextBoxColumn maskedTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Armado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;


    }
}