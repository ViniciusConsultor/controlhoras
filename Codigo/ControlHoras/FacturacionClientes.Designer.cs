namespace ControlHoras
{
    partial class FacturacionClientes
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMesFacturacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tcClientesServicios = new ControlHoras.TreeClientesServicios();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(366, 217);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(356, 23);
            this.progressBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Facturación de Clientes: Se genera un archivo Excel por cada Cliente/Servicio que" +
                " contenga horas cubiertas durante el Mes de Facturación Seleccionado.";
            // 
            // dtpMesFacturacion
            // 
            this.dtpMesFacturacion.CustomFormat = "MMMMMyyyy";
            this.dtpMesFacturacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMesFacturacion.Location = new System.Drawing.Point(491, 70);
            this.dtpMesFacturacion.Name = "dtpMesFacturacion";
            this.dtpMesFacturacion.Size = new System.Drawing.Size(107, 20);
            this.dtpMesFacturacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mes de Facturación";
            // 
            // fbdFolder
            // 
            this.fbdFolder.Description = "Seleccione Carpeta donde se Exportaran los archivos";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(507, 257);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 6;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(433, 177);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Facturando:";
            // 
            // tcClientesServicios
            // 
            this.tcClientesServicios.Location = new System.Drawing.Point(12, 40);
            this.tcClientesServicios.Name = "tcClientesServicios";
            this.tcClientesServicios.Size = new System.Drawing.Size(333, 299);
            this.tcClientesServicios.TabIndex = 0;
            // 
            // FacturacionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpMesFacturacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tcClientesServicios);
            this.Name = "FacturacionClientes";
            this.Text = "FacturacionClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeClientesServicios tcClientesServicios;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMesFacturacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label3;
    }
}