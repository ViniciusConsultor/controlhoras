namespace ControlHoras
{
    partial class Prueba_2
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
            this.erroresTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // erroresTB
            // 
            this.erroresTB.AcceptsTab = true;
            this.erroresTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.erroresTB.Location = new System.Drawing.Point(12, 12);
            this.erroresTB.Name = "erroresTB";
            this.erroresTB.ReadOnly = true;
            this.erroresTB.Size = new System.Drawing.Size(794, 264);
            this.erroresTB.TabIndex = 0;
            this.erroresTB.Text = "";
            // 
            // Prueba_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 288);
            this.Controls.Add(this.erroresTB);
            this.Name = "Prueba_2";
            this.Text = "Errores al Consolidar Escalafones";
            this.Load += new System.EventHandler(this.Prueba_2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox erroresTB;

    }
}