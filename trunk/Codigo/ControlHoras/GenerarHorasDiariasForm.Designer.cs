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
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(180, 154);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
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
            this.RichTextBoxMensaje.TabIndex = 2;
            this.RichTextBoxMensaje.Text = resources.GetString("RichTextBoxMensaje.Text");
            // 
            // progressBarGeneracion
            // 
            this.progressBarGeneracion.Location = new System.Drawing.Point(13, 114);
            this.progressBarGeneracion.Name = "progressBarGeneracion";
            this.progressBarGeneracion.Size = new System.Drawing.Size(411, 23);
            this.progressBarGeneracion.TabIndex = 3;
            // 
            // lblProcesando
            // 
            this.lblProcesando.AutoSize = true;
            this.lblProcesando.Location = new System.Drawing.Point(13, 95);
            this.lblProcesando.Name = "lblProcesando";
            this.lblProcesando.Size = new System.Drawing.Size(102, 13);
            this.lblProcesando.TabIndex = 4;
            this.lblProcesando.Text = "Procesando Cliente:";
            this.lblProcesando.Visible = false;
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Location = new System.Drawing.Point(135, 95);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNroCliente.TabIndex = 5;
            this.lblNroCliente.Visible = false;
            // 
            // GenerarHorasDiariasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 189);
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

    }
}