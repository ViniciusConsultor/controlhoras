namespace ControlHoras
{
    partial class GenerarDias
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PruTXT = new System.Windows.Forms.TextBox();
            this.FechaINI = new System.Windows.Forms.MaskedTextBox();
            this.FechaFIN = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(182, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PruTXT
            // 
            this.PruTXT.Location = new System.Drawing.Point(215, 28);
            this.PruTXT.Name = "PruTXT";
            this.PruTXT.Size = new System.Drawing.Size(28, 20);
            this.PruTXT.TabIndex = 8;
            this.PruTXT.Visible = false;
            // 
            // FechaINI
            // 
            this.FechaINI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaINI.Location = new System.Drawing.Point(64, 50);
            this.FechaINI.Mask = "00/00/0000";
            this.FechaINI.Name = "FechaINI";
            this.FechaINI.Size = new System.Drawing.Size(70, 22);
            this.FechaINI.TabIndex = 0;
            this.FechaINI.ValidatingType = typeof(System.DateTime);
            this.FechaINI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FechaINI_KeyDown);
            this.FechaINI.Leave += new System.EventHandler(this.FechaINI_Leave);
            this.FechaINI.Enter += new System.EventHandler(this.FechaINI_Enter);
            // 
            // FechaFIN
            // 
            this.FechaFIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFIN.Location = new System.Drawing.Point(64, 82);
            this.FechaFIN.Mask = "00/00/0000";
            this.FechaFIN.Name = "FechaFIN";
            this.FechaFIN.Size = new System.Drawing.Size(70, 22);
            this.FechaFIN.TabIndex = 1;
            this.FechaFIN.ValidatingType = typeof(System.DateTime);
            this.FechaFIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FechaFIN_KeyDown);
            this.FechaFIN.Leave += new System.EventHandler(this.FechaFIN_Leave);
            this.FechaFIN.Enter += new System.EventHandler(this.FechaFIN_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rango de Dias a Generar";
            // 
            // GenerarDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 127);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaFIN);
            this.Controls.Add(this.FechaINI);
            this.Controls.Add(this.PruTXT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenerarDias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar Dias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PruTXT;
        private System.Windows.Forms.MaskedTextBox FechaINI;
        private System.Windows.Forms.MaskedTextBox FechaFIN;
        private System.Windows.Forms.Label label3;
    }
}