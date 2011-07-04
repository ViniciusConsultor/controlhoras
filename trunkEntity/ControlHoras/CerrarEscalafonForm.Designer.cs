namespace ControlHoras
{
    partial class CerrarEscalafonForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarEscalafon = new System.Windows.Forms.Button();
            this.panelCierre = new System.Windows.Forms.Panel();
            this.lblCerrando = new System.Windows.Forms.Label();
            this.CierrePicBox = new System.Windows.Forms.PictureBox();
            this.mtFechaHasta = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtFechaDesde = new ControlHoras.MaskedTextBoxKeyDown();
            this.panelCierre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CierrePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el rango de fechas que desea Cerrar el escalafon.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota: Recuerde que luego de cerrar una fecha no se podra generar nuevamente el es" +
                "calafon para esa fecha.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hasta";
            // 
            // btnCerrarEscalafon
            // 
            this.btnCerrarEscalafon.Location = new System.Drawing.Point(120, 82);
            this.btnCerrarEscalafon.Name = "btnCerrarEscalafon";
            this.btnCerrarEscalafon.Size = new System.Drawing.Size(109, 23);
            this.btnCerrarEscalafon.TabIndex = 6;
            this.btnCerrarEscalafon.Text = "Cerrar Escalafon";
            this.btnCerrarEscalafon.UseVisualStyleBackColor = true;
            this.btnCerrarEscalafon.Click += new System.EventHandler(this.btnCerrarEscalafon_Click);
            // 
            // panelCierre
            // 
            this.panelCierre.Controls.Add(this.lblCerrando);
            this.panelCierre.Controls.Add(this.CierrePicBox);
            this.panelCierre.Location = new System.Drawing.Point(11, 111);
            this.panelCierre.Name = "panelCierre";
            this.panelCierre.Size = new System.Drawing.Size(326, 49);
            this.panelCierre.TabIndex = 7;
            this.panelCierre.Visible = false;
            // 
            // lblCerrando
            // 
            this.lblCerrando.AutoSize = true;
            this.lblCerrando.Location = new System.Drawing.Point(36, 17);
            this.lblCerrando.Name = "lblCerrando";
            this.lblCerrando.Size = new System.Drawing.Size(59, 13);
            this.lblCerrando.TabIndex = 2;
            this.lblCerrando.Text = "Cerrando...";
            // 
            // CierrePicBox
            // 
            this.CierrePicBox.Image = global::ControlHoras.Imagenes.procesando_2;
            this.CierrePicBox.Location = new System.Drawing.Point(5, 4);
            this.CierrePicBox.Name = "CierrePicBox";
            this.CierrePicBox.Size = new System.Drawing.Size(25, 39);
            this.CierrePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CierrePicBox.TabIndex = 0;
            this.CierrePicBox.TabStop = false;
            // 
            // mtFechaHasta
            // 
            this.mtFechaHasta.Location = new System.Drawing.Point(229, 44);
            this.mtFechaHasta.Mask = "00/00/0000";
            this.mtFechaHasta.Name = "mtFechaHasta";
            this.mtFechaHasta.Size = new System.Drawing.Size(70, 20);
            this.mtFechaHasta.TabIndex = 3;
            // 
            // mtFechaDesde
            // 
            this.mtFechaDesde.Location = new System.Drawing.Point(93, 44);
            this.mtFechaDesde.Mask = "00/00/0000";
            this.mtFechaDesde.Name = "mtFechaDesde";
            this.mtFechaDesde.Size = new System.Drawing.Size(70, 20);
            this.mtFechaDesde.TabIndex = 2;
            // 
            // CerrarEscalafonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 217);
            this.Controls.Add(this.panelCierre);
            this.Controls.Add(this.btnCerrarEscalafon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtFechaHasta);
            this.Controls.Add(this.mtFechaDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CerrarEscalafonForm";
            this.Text = "CerrarEscalafonForm";
            this.Load += new System.EventHandler(this.CerrarEscalafonForm_Load);
            this.panelCierre.ResumeLayout(false);
            this.panelCierre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CierrePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaskedTextBoxKeyDown mtFechaDesde;
        private MaskedTextBoxKeyDown mtFechaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrarEscalafon;
        private System.Windows.Forms.Panel panelCierre;
        private System.Windows.Forms.Label lblCerrando;
        private System.Windows.Forms.PictureBox CierrePicBox;
    }
}