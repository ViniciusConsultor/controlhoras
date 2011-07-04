namespace ControlHoras
{
    partial class VerObservaciones
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
            this.HojaTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // HojaTB
            // 
            this.HojaTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HojaTB.Location = new System.Drawing.Point(0, 0);
            this.HojaTB.Name = "HojaTB";
            this.HojaTB.Size = new System.Drawing.Size(578, 77);
            this.HojaTB.TabIndex = 0;
            this.HojaTB.Text = "";
            // 
            // VerObservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 77);
            this.Controls.Add(this.HojaTB);
            this.Name = "VerObservaciones";
            this.Text = "Observaciones";
            this.Load += new System.EventHandler(this.VerObservaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HojaTB;
    }
}