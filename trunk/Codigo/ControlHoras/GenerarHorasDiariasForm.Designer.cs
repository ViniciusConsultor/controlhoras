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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lbErrores = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtFechaHasta = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtFechaDesde = new ControlHoras.MaskedTextBoxKeyDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucTreeClientesServicios = new ControlHoras.TreeClientesServicios();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(188, 104);
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
            this.RichTextBoxMensaje.Size = new System.Drawing.Size(885, 46);
            this.RichTextBoxMensaje.TabIndex = 4;
            this.RichTextBoxMensaje.Text = resources.GetString("RichTextBoxMensaje.Text");
            // 
            // progressBarGeneracion
            // 
            this.progressBarGeneracion.Location = new System.Drawing.Point(26, 76);
            this.progressBarGeneracion.Name = "progressBarGeneracion";
            this.progressBarGeneracion.Size = new System.Drawing.Size(411, 23);
            this.progressBarGeneracion.TabIndex = 9;
            // 
            // lblProcesando
            // 
            this.lblProcesando.AutoSize = true;
            this.lblProcesando.Location = new System.Drawing.Point(251, 59);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 59);
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
            this.lbErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrores.FormattingEnabled = true;
            this.lbErrores.HorizontalScrollbar = true;
            this.lbErrores.ItemHeight = 15;
            this.lbErrores.Location = new System.Drawing.Point(26, 145);
            this.lbErrores.Name = "lbErrores";
            this.lbErrores.Size = new System.Drawing.Size(411, 184);
            this.lbErrores.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bitacora de Errores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBarGeneracion);
            this.groupBox1.Controls.Add(this.mtFechaHasta);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.mtFechaDesde);
            this.groupBox1.Controls.Add(this.lblProcesando);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbErrores);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.210526F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(437, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(460, 377);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2";
            // 
            // mtFechaHasta
            // 
            this.mtFechaHasta.Location = new System.Drawing.Point(290, 20);
            this.mtFechaHasta.Mask = "00/00/0000";
            this.mtFechaHasta.Name = "mtFechaHasta";
            this.mtFechaHasta.Size = new System.Drawing.Size(70, 20);
            this.mtFechaHasta.TabIndex = 14;
            // 
            // mtFechaDesde
            // 
            this.mtFechaDesde.Location = new System.Drawing.Point(116, 20);
            this.mtFechaDesde.Mask = "00/00/0000";
            this.mtFechaDesde.Name = "mtFechaDesde";
            this.mtFechaDesde.Size = new System.Drawing.Size(70, 20);
            this.mtFechaDesde.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucTreeClientesServicios);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.210526F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(409, 377);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1";
            // 
            // ucTreeClientesServicios
            // 
            this.ucTreeClientesServicios.Location = new System.Drawing.Point(2, 17);
            this.ucTreeClientesServicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucTreeClientesServicios.Name = "ucTreeClientesServicios";
            this.ucTreeClientesServicios.Size = new System.Drawing.Size(400, 353);
            this.ucTreeClientesServicios.TabIndex = 0;
            // 
            // GenerarHorasDiariasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.RichTextBoxMensaje);
            this.Name = "GenerarHorasDiariasForm";
            this.Text = "GenerarHorasDiariasForm";
            this.Load += new System.EventHandler(this.GenerarHorasDiariasForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox RichTextBoxMensaje;
        private System.Windows.Forms.ProgressBar progressBarGeneracion;
        private System.Windows.Forms.Label lblProcesando;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ListBox lbErrores;
        private System.Windows.Forms.Label label4;
        private MaskedTextBoxKeyDown mtFechaDesde;
        private MaskedTextBoxKeyDown mtFechaHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private TreeClientesServicios ucTreeClientesServicios;

    }
}