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
            this.erroresTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // erroresTB
            // 
            this.erroresTB.Location = new System.Drawing.Point(31, 12);
            this.erroresTB.Multiline = true;
            this.erroresTB.Name = "erroresTB";
            this.erroresTB.Size = new System.Drawing.Size(760, 252);
            this.erroresTB.TabIndex = 0;
            // 
            // Prueba_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 288);
            this.Controls.Add(this.erroresTB);
            this.Name = "Prueba_2";
            this.Text = "Prueba_2";
            this.Load += new System.EventHandler(this.Prueba_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox erroresTB;
    }
}