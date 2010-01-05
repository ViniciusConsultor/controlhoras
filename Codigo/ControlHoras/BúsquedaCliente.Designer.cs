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
            this.SuspendLayout();
            // 
            // ClienteMT
            // 
            this.ClienteMT.BackColor = System.Drawing.SystemColors.Window;
            this.ClienteMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteMT.Location = new System.Drawing.Point(21, 21);
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
            this.ClienteTB.Location = new System.Drawing.Point(100, 21);
            this.ClienteTB.Margin = new System.Windows.Forms.Padding(4);
            this.ClienteTB.Name = "ClienteTB";
            this.ClienteTB.ReadOnly = true;
            this.ClienteTB.Size = new System.Drawing.Size(481, 25);
            this.ClienteTB.TabIndex = 11;
            this.ClienteTB.TabStop = false;
            // 
            // BúsquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClienteTB);
            this.Controls.Add(this.ClienteMT);
            this.Name = "BúsquedaCliente";
            this.Size = new System.Drawing.Size(681, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ClienteMT;
        private System.Windows.Forms.TextBox ClienteTB;
    }
}
