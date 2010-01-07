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
            this.bc.Location = new System.Drawing.Point(77, 41);
            this.bc.Margin = new System.Windows.Forms.Padding(2);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(511, 54);
            this.bc.TabIndex = 0;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 136);
            this.Controls.Add(this.bc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private BúsquedaCliente bc;

    }
}