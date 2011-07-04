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
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelGeneracion = new System.Windows.Forms.Panel();
            this.lblGenerando = new System.Windows.Forms.Label();
            this.generandoPicBox = new System.Windows.Forms.PictureBox();
            this.panelConsolidacion = new System.Windows.Forms.Panel();
            this.lblConsolidando = new System.Windows.Forms.Label();
            this.ConsolidandoPicBox = new System.Windows.Forms.PictureBox();
            this.mtFechaHasta = new ControlHoras.MaskedTextBoxKeyDown();
            this.mtFechaDesde = new ControlHoras.MaskedTextBoxKeyDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucTreeClientesServicios = new ControlHoras.TreeClientesServicios();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarEscalafon = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.panelGeneracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generandoPicBox)).BeginInit();
            this.panelConsolidacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsolidandoPicBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(347, 18);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // RichTextBoxMensaje
            // 
            this.RichTextBoxMensaje.Location = new System.Drawing.Point(13, 45);
            this.RichTextBoxMensaje.Name = "RichTextBoxMensaje";
            this.RichTextBoxMensaje.ReadOnly = true;
            this.RichTextBoxMensaje.Size = new System.Drawing.Size(885, 46);
            this.RichTextBoxMensaje.TabIndex = 4;
            this.RichTextBoxMensaje.Text = resources.GetString("RichTextBoxMensaje.Text");
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
            this.label1.Location = new System.Drawing.Point(198, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Desde";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(118, 143);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.panelGeneracion);
            this.groupBox1.Controls.Add(this.panelConsolidacion);
            this.groupBox1.Controls.Add(this.mtFechaHasta);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.mtFechaDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.210526F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(440, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(460, 377);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(66, 212);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(356, 23);
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // panelGeneracion
            // 
            this.panelGeneracion.Controls.Add(this.lblGenerando);
            this.panelGeneracion.Controls.Add(this.generandoPicBox);
            this.panelGeneracion.Location = new System.Drawing.Point(66, 157);
            this.panelGeneracion.Name = "panelGeneracion";
            this.panelGeneracion.Size = new System.Drawing.Size(356, 49);
            this.panelGeneracion.TabIndex = 4;
            this.panelGeneracion.Visible = false;
            // 
            // lblGenerando
            // 
            this.lblGenerando.AutoSize = true;
            this.lblGenerando.Location = new System.Drawing.Point(36, 17);
            this.lblGenerando.Name = "lblGenerando";
            this.lblGenerando.Size = new System.Drawing.Size(69, 13);
            this.lblGenerando.TabIndex = 2;
            this.lblGenerando.Text = "Generando...";
            // 
            // generandoPicBox
            // 
            this.generandoPicBox.Image = global::ControlHoras.Imagenes.procesando_2;
            this.generandoPicBox.Location = new System.Drawing.Point(5, 4);
            this.generandoPicBox.Name = "generandoPicBox";
            this.generandoPicBox.Size = new System.Drawing.Size(25, 39);
            this.generandoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.generandoPicBox.TabIndex = 0;
            this.generandoPicBox.TabStop = false;
            // 
            // panelConsolidacion
            // 
            this.panelConsolidacion.Controls.Add(this.lblConsolidando);
            this.panelConsolidacion.Controls.Add(this.ConsolidandoPicBox);
            this.panelConsolidacion.Location = new System.Drawing.Point(66, 102);
            this.panelConsolidacion.Name = "panelConsolidacion";
            this.panelConsolidacion.Size = new System.Drawing.Size(356, 49);
            this.panelConsolidacion.TabIndex = 3;
            this.panelConsolidacion.Visible = false;
            // 
            // lblConsolidando
            // 
            this.lblConsolidando.AutoSize = true;
            this.lblConsolidando.Location = new System.Drawing.Point(36, 17);
            this.lblConsolidando.Name = "lblConsolidando";
            this.lblConsolidando.Size = new System.Drawing.Size(80, 13);
            this.lblConsolidando.TabIndex = 2;
            this.lblConsolidando.Text = "Consolidando...";
            // 
            // ConsolidandoPicBox
            // 
            this.ConsolidandoPicBox.Image = global::ControlHoras.Imagenes.procesando_2;
            this.ConsolidandoPicBox.Location = new System.Drawing.Point(5, 4);
            this.ConsolidandoPicBox.Name = "ConsolidandoPicBox";
            this.ConsolidandoPicBox.Size = new System.Drawing.Size(25, 39);
            this.ConsolidandoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConsolidandoPicBox.TabIndex = 0;
            this.ConsolidandoPicBox.TabStop = false;
            // 
            // mtFechaHasta
            // 
            this.mtFechaHasta.Location = new System.Drawing.Point(240, 18);
            this.mtFechaHasta.Mask = "00/00/0000";
            this.mtFechaHasta.Name = "mtFechaHasta";
            this.mtFechaHasta.Size = new System.Drawing.Size(70, 20);
            this.mtFechaHasta.TabIndex = 14;
            // 
            // mtFechaDesde
            // 
            this.mtFechaDesde.Location = new System.Drawing.Point(66, 18);
            this.mtFechaDesde.Mask = "00/00/0000";
            this.mtFechaDesde.Name = "mtFechaDesde";
            this.mtFechaDesde.Size = new System.Drawing.Size(70, 20);
            this.mtFechaDesde.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucTreeClientesServicios);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.210526F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(409, 377);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1";
            // 
            // ucTreeClientesServicios
            // 
            this.ucTreeClientesServicios.Location = new System.Drawing.Point(2, 17);
            this.ucTreeClientesServicios.Margin = new System.Windows.Forms.Padding(4);
            this.ucTreeClientesServicios.Name = "ucTreeClientesServicios";
            this.ucTreeClientesServicios.Size = new System.Drawing.Size(400, 353);
            this.ucTreeClientesServicios.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarEscalafon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(907, 36);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCerrarEscalafon
            // 
            this.tsbCerrarEscalafon.Image = global::ControlHoras.Imagenes.CerrarEscalafon_48x48;
            this.tsbCerrarEscalafon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarEscalafon.Name = "tsbCerrarEscalafon";
            this.tsbCerrarEscalafon.Size = new System.Drawing.Size(91, 33);
            this.tsbCerrarEscalafon.Text = "Cerrar Escalafon";
            this.tsbCerrarEscalafon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrarEscalafon.Click += new System.EventHandler(this.tsbCerrarEscalafon_Click);
            // 
            // GenerarHorasDiariasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 480);
            this.Controls.Add(this.toolStrip1);
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
            this.panelGeneracion.ResumeLayout(false);
            this.panelGeneracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generandoPicBox)).EndInit();
            this.panelConsolidacion.ResumeLayout(false);
            this.panelConsolidacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsolidandoPicBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox RichTextBoxMensaje;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private MaskedTextBoxKeyDown mtFechaDesde;
        private MaskedTextBoxKeyDown mtFechaHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private TreeClientesServicios ucTreeClientesServicios;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelGeneracion;
        private System.Windows.Forms.Label lblGenerando;
        private System.Windows.Forms.PictureBox generandoPicBox;
        private System.Windows.Forms.Panel panelConsolidacion;
        private System.Windows.Forms.Label lblConsolidando;
        private System.Windows.Forms.PictureBox ConsolidandoPicBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCerrarEscalafon;

    }
}