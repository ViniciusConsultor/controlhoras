namespace ControlHoras
{
    partial class GenerarHorasDiariasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarHorasDiariasForm));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.RichTextBoxMensaje = new System.Windows.Forms.RichTextBox();
            this.progressBarGeneracion = new System.Windows.Forms.ProgressBar();
            this.lblProcesando = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.mtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.mtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lbErrores = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(174, 188);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // RichTextBoxMensaje
            // 
            this.RichTextBoxMensaje.Location = new System.Drawing.Point(13, 12);
            this.RichTextBoxMensaje.Name = "RichTextBoxMensaje";
            this.RichTextBoxMensaje.ReadOnly = true;
            this.RichTextBoxMensaje.Size = new System.Drawing.Size(411, 63);
            this.RichTextBoxMensaje.TabIndex = 4;
            this.RichTextBoxMensaje.Text = resources.GetString("RichTextBoxMensaje.Text");
            // 
            // progressBarGeneracion
            // 
            this.progressBarGeneracion.Location = new System.Drawing.Point(12, 159);
            this.progressBarGeneracion.Name = "progressBarGeneracion";
            this.progressBarGeneracion.Size = new System.Drawing.Size(411, 23);
            this.progressBarGeneracion.TabIndex = 9;
            // 
            // lblProcesando
            // 
            this.lblProcesando.AutoSize = true;
            this.lblProcesando.Location = new System.Drawing.Point(237, 143);
            this.lblProcesando.Name = "lblProcesando";
            this.lblProcesando.Size = new System.Drawing.Size(102, 13);
            this.lblProcesando.TabIndex = 7;
            this.lblProcesando.Text = "Procesando Cliente:";
            this.lblProcesando.Visible = false;
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Location = new System.Drawing.Point(345, 143);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNroCliente.TabIndex = 8;
            this.lblNroCliente.Visible = false;
            // 
            // mtFechaDesde
            // 
            this.mtFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFechaDesde.Location = new System.Drawing.Point(98, 102);
            this.mtFechaDesde.Mask = "00/00/0000";
            this.mtFechaDesde.Name = "mtFechaDesde";
            this.mtFechaDesde.Size = new System.Drawing.Size(70, 22);
            this.mtFechaDesde.TabIndex = 0;
            this.mtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // mtFechaHasta
            // 
            this.mtFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFechaHasta.Location = new System.Drawing.Point(275, 102);
            this.mtFechaHasta.Mask = "00/00/0000";
            this.mtFechaHasta.Name = "mtFechaHasta";
            this.mtFechaHasta.Size = new System.Drawing.Size(70, 22);
            this.mtFechaHasta.TabIndex = 1;
            this.mtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Procesando Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(118, 143);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 6;
            // 
            // lbErrores
            // 
            this.lbErrores.FormattingEnabled = true;
            this.lbErrores.HorizontalScrollbar = true;
            this.lbErrores.Location = new System.Drawing.Point(12, 229);
            this.lbErrores.Name = "lbErrores";
            this.lbErrores.Size = new System.Drawing.Size(411, 147);
            this.lbErrores.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bitacora de Errores";
            // 
            // GenerarHorasDiariasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbErrores);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtFechaHasta);
            this.Controls.Add(this.mtFechaDesde);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.lblProcesando);
            this.Controls.Add(this.progressBarGeneracion);
            this.Controls.Add(this.RichTextBoxMensaje);
            this.Controls.Add(this.btnGenerar);
            this.Name = "GenerarHorasDiariasForm";
            this.Text = "GenerarHorasDiariasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox RichTextBoxMensaje;
        private System.Windows.Forms.ProgressBar progressBarGeneracion;
        private System.Windows.Forms.Label lblProcesando;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.MaskedTextBox mtFechaDesde;
        private System.Windows.Forms.MaskedTextBox mtFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ListBox lbErrores;
        private System.Windows.Forms.Label label4;

    }
}