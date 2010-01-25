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
            this.textBoxKeyDown1 = new ControlHoras.TextBoxKeyDown();
            this.textBoxKeyDown2 = new ControlHoras.TextBoxKeyDown();
            this.textBoxKeyDown3 = new ControlHoras.TextBoxKeyDown();
            this.SuspendLayout();
            // 
            // textBoxKeyDown1
            // 
            this.textBoxKeyDown1.Location = new System.Drawing.Point(133, 13);
            this.textBoxKeyDown1.Name = "textBoxKeyDown1";
            this.textBoxKeyDown1.Size = new System.Drawing.Size(218, 20);
            this.textBoxKeyDown1.TabIndex = 0;
            // 
            // textBoxKeyDown2
            // 
            this.textBoxKeyDown2.Location = new System.Drawing.Point(133, 39);
            this.textBoxKeyDown2.Name = "textBoxKeyDown2";
            this.textBoxKeyDown2.Size = new System.Drawing.Size(218, 20);
            this.textBoxKeyDown2.TabIndex = 1;
            // 
            // textBoxKeyDown3
            // 
            this.textBoxKeyDown3.Location = new System.Drawing.Point(133, 75);
            this.textBoxKeyDown3.Name = "textBoxKeyDown3";
            this.textBoxKeyDown3.Size = new System.Drawing.Size(218, 20);
            this.textBoxKeyDown3.TabIndex = 2;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 136);
            this.Controls.Add(this.textBoxKeyDown3);
            this.Controls.Add(this.textBoxKeyDown2);
            this.Controls.Add(this.textBoxKeyDown1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxKeyDown textBoxKeyDown1;
        private TextBoxKeyDown textBoxKeyDown2;
        private TextBoxKeyDown textBoxKeyDown3;


    }
}