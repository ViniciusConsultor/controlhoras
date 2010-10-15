namespace ControlHoras
{
    partial class ConsolidarEscalafonesForm
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
            this.btnConsolidar = new System.Windows.Forms.Button();
            this.pbConsolidacion = new System.Windows.Forms.ProgressBar();
            this.RichTextBoxMensaje = new System.Windows.Forms.RichTextBox();
            this.ucTreeClientesServicios = new ControlHoras.TreeClientesServicios();
            this.SuspendLayout();
            // 
            // btnConsolidar
            // 
            this.btnConsolidar.Location = new System.Drawing.Point(200, 442);
            this.btnConsolidar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsolidar.Name = "btnConsolidar";
            this.btnConsolidar.Size = new System.Drawing.Size(100, 28);
            this.btnConsolidar.TabIndex = 1;
            this.btnConsolidar.Text = "Consolidar";
            this.btnConsolidar.UseVisualStyleBackColor = true;
            this.btnConsolidar.Click += new System.EventHandler(this.btnConsolidar_Click);
            // 
            // pbConsolidacion
            // 
            this.pbConsolidacion.Location = new System.Drawing.Point(11, 481);
            this.pbConsolidacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbConsolidacion.Name = "pbConsolidacion";
            this.pbConsolidacion.Size = new System.Drawing.Size(479, 28);
            this.pbConsolidacion.TabIndex = 2;
            // 
            // RichTextBoxMensaje
            // 
            this.RichTextBoxMensaje.Location = new System.Drawing.Point(11, 15);
            this.RichTextBoxMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RichTextBoxMensaje.Name = "RichTextBoxMensaje";
            this.RichTextBoxMensaje.ReadOnly = true;
            this.RichTextBoxMensaje.Size = new System.Drawing.Size(477, 50);
            this.RichTextBoxMensaje.TabIndex = 5;
            this.RichTextBoxMensaje.Text = "Seleccione los Servicios y presione el boton Consolidar para comenzar con la Cons" +
                "olidacion";
            // 
            // ucTreeClientesServicios
            // 
            this.ucTreeClientesServicios.Location = new System.Drawing.Point(11, 73);
            this.ucTreeClientesServicios.Margin = new System.Windows.Forms.Padding(5);
            this.ucTreeClientesServicios.Name = "ucTreeClientesServicios";
            this.ucTreeClientesServicios.Size = new System.Drawing.Size(479, 362);
            this.ucTreeClientesServicios.TabIndex = 0;
            // 
            // ConsolidarEscalafonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 524);
            this.Controls.Add(this.RichTextBoxMensaje);
            this.Controls.Add(this.pbConsolidacion);
            this.Controls.Add(this.btnConsolidar);
            this.Controls.Add(this.ucTreeClientesServicios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsolidarEscalafonesForm";
            this.Text = "ConsolidarEscalafonesForm";
            this.Load += new System.EventHandler(this.ConsolidarEscalafonesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeClientesServicios ucTreeClientesServicios;
        private System.Windows.Forms.Button btnConsolidar;
        private System.Windows.Forms.ProgressBar pbConsolidacion;
        private System.Windows.Forms.RichTextBox RichTextBoxMensaje;
    }
}