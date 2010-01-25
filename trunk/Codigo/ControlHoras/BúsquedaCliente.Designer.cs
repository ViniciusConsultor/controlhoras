namespace ControlHoras
{
    partial class BúsquedaCliente
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClienteMT = new System.Windows.Forms.MaskedTextBox();
            this.ClienteTB = new System.Windows.Forms.TextBox();
            this.NroLBL = new System.Windows.Forms.Label();
            this.NombreLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClienteMT
            // 
            this.ClienteMT.BackColor = System.Drawing.SystemColors.Window;
            this.ClienteMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteMT.Location = new System.Drawing.Point(47, 12);
            this.ClienteMT.Margin = new System.Windows.Forms.Padding(4);
            this.ClienteMT.Mask = "9990";
            this.ClienteMT.Name = "ClienteMT";
            this.ClienteMT.Size = new System.Drawing.Size(57, 25);
            this.ClienteMT.TabIndex = 3;
            this.ClienteMT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClienteMT_KeyDown);
            this.ClienteMT.Leave += new System.EventHandler(this.ClienteMT_Leave);
            this.ClienteMT.Enter += new System.EventHandler(this.ClienteMT_Enter);
            // 
            // ClienteTB
            // 
            this.ClienteTB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClienteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteTB.Location = new System.Drawing.Point(211, 12);
            this.ClienteTB.Margin = new System.Windows.Forms.Padding(4);
            this.ClienteTB.Name = "ClienteTB";
            this.ClienteTB.ReadOnly = true;
            this.ClienteTB.Size = new System.Drawing.Size(481, 25);
            this.ClienteTB.TabIndex = 11;
            this.ClienteTB.TabStop = false;
            // 
            // NroLBL
            // 
            this.NroLBL.AutoSize = true;
            this.NroLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroLBL.Location = new System.Drawing.Point(4, 17);
            this.NroLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NroLBL.Name = "NroLBL";
            this.NroLBL.Size = new System.Drawing.Size(35, 17);
            this.NroLBL.TabIndex = 12;
            this.NroLBL.Text = "Nro:";
            // 
            // NombreLB
            // 
            this.NombreLB.AutoSize = true;
            this.NombreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLB.Location = new System.Drawing.Point(141, 17);
            this.NombreLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreLB.Name = "NombreLB";
            this.NombreLB.Size = new System.Drawing.Size(62, 17);
            this.NombreLB.TabIndex = 13;
            this.NombreLB.Text = "Nombre:";
            // 
            // BúsquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NombreLB);
            this.Controls.Add(this.NroLBL);
            this.Controls.Add(this.ClienteTB);
            this.Controls.Add(this.ClienteMT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BúsquedaCliente";
            this.Size = new System.Drawing.Size(700, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ClienteMT;
        private System.Windows.Forms.TextBox ClienteTB;
        private System.Windows.Forms.Label NroLBL;
        private System.Windows.Forms.Label NombreLB;
    }
}
