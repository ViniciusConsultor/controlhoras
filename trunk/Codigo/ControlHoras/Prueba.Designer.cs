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
            this.bc = new ControlHoras.BúsquedaCliente();
            this.SuspendLayout();
            // 
            // bc
            // 
            this.bc.Location = new System.Drawing.Point(103, 50);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(681, 67);
            this.bc.TabIndex = 0;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 167);
            this.Controls.Add(this.bc);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private BúsquedaCliente bc;

    }
}