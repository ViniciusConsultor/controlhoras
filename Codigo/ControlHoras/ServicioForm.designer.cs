namespace ControlHoras
{
    partial class ServicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicioForm));
            this.ClienteGB = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarBTN = new System.Windows.Forms.ToolStripButton();
            this.GuardarBTN = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContratoBTN = new System.Windows.Forms.ToolStripButton();
            this.CancelarBTN = new System.Windows.Forms.ToolStripButton();
            this.ServicioGB = new System.Windows.Forms.GroupBox();
            this.PosteriorBTN = new System.Windows.Forms.Button();
            this.AnteriorBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NroMTB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TareasTB = new ControlHoras.TextBoxKeyDown();
            this.CelTrustTB = new ControlHoras.TextBoxKeyDown();
            this.CelTB = new ControlHoras.TextBoxKeyDown();
            this.emailTB = new ControlHoras.TextBoxKeyDown();
            this.ContactTB = new ControlHoras.TextBoxKeyDown();
            this.TelTB = new ControlHoras.TextBoxKeyDown();
            this.DirTB = new ControlHoras.TextBoxKeyDown();
            this.NombreTB = new ControlHoras.TextBoxKeyDown();
            this.bcUC = new ControlHoras.BúsquedaCliente();
            this.ClienteGB.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ServicioGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClienteGB
            // 
            this.ClienteGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClienteGB.Controls.Add(this.bcUC);
            this.ClienteGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteGB.Location = new System.Drawing.Point(15, 36);
            this.ClienteGB.Name = "ClienteGB";
            this.ClienteGB.Size = new System.Drawing.Size(534, 60);
            this.ClienteGB.TabIndex = 0;
            this.ClienteGB.TabStop = false;
            this.ClienteGB.Text = "Cliente";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarBTN,
            this.GuardarBTN,
            this.toolStripSeparator1,
            this.ContratoBTN,
            this.CancelarBTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 36);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.Enabled = false;
            this.AgregarBTN.Image = global::ControlHoras.Imagenes.document_new;
            this.AgregarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(50, 33);
            this.AgregarBTN.Text = "Agregar";
            this.AgregarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarBTN.Click += new System.EventHandler(this.AgregarBTN_Click);
            // 
            // GuardarBTN
            // 
            this.GuardarBTN.Enabled = false;
            this.GuardarBTN.Image = global::ControlHoras.Imagenes.filesave;
            this.GuardarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarBTN.Name = "GuardarBTN";
            this.GuardarBTN.Size = new System.Drawing.Size(50, 33);
            this.GuardarBTN.Text = "Guardar";
            this.GuardarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarBTN.Click += new System.EventHandler(this.GuardarBTN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // ContratoBTN
            // 
            this.ContratoBTN.Enabled = false;
            this.ContratoBTN.Image = ((System.Drawing.Image)(resources.GetObject("ContratoBTN.Image")));
            this.ContratoBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ContratoBTN.Name = "ContratoBTN";
            this.ContratoBTN.Size = new System.Drawing.Size(54, 33);
            this.ContratoBTN.Text = "Contrato";
            this.ContratoBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CancelarBTN.Image = global::ControlHoras.Imagenes.button_cancel;
            this.CancelarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(53, 33);
            this.CancelarBTN.Text = "Cancelar";
            this.CancelarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // ServicioGB
            // 
            this.ServicioGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServicioGB.Controls.Add(this.PosteriorBTN);
            this.ServicioGB.Controls.Add(this.TareasTB);
            this.ServicioGB.Controls.Add(this.AnteriorBTN);
            this.ServicioGB.Controls.Add(this.label9);
            this.ServicioGB.Controls.Add(this.CelTrustTB);
            this.ServicioGB.Controls.Add(this.label8);
            this.ServicioGB.Controls.Add(this.CelTB);
            this.ServicioGB.Controls.Add(this.label7);
            this.ServicioGB.Controls.Add(this.emailTB);
            this.ServicioGB.Controls.Add(this.label6);
            this.ServicioGB.Controls.Add(this.ContactTB);
            this.ServicioGB.Controls.Add(this.label5);
            this.ServicioGB.Controls.Add(this.TelTB);
            this.ServicioGB.Controls.Add(this.label4);
            this.ServicioGB.Controls.Add(this.DirTB);
            this.ServicioGB.Controls.Add(this.label3);
            this.ServicioGB.Controls.Add(this.label2);
            this.ServicioGB.Controls.Add(this.NombreTB);
            this.ServicioGB.Controls.Add(this.NroMTB);
            this.ServicioGB.Controls.Add(this.label1);
            this.ServicioGB.Enabled = false;
            this.ServicioGB.Location = new System.Drawing.Point(15, 102);
            this.ServicioGB.Name = "ServicioGB";
            this.ServicioGB.Size = new System.Drawing.Size(534, 318);
            this.ServicioGB.TabIndex = 1;
            this.ServicioGB.TabStop = false;
            this.ServicioGB.Text = "Servicio";
            // 
            // PosteriorBTN
            // 
            this.PosteriorBTN.AutoSize = true;
            this.PosteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PosteriorBTN.Location = new System.Drawing.Point(222, 10);
            this.PosteriorBTN.Name = "PosteriorBTN";
            this.PosteriorBTN.Size = new System.Drawing.Size(29, 23);
            this.PosteriorBTN.TabIndex = 5;
            this.PosteriorBTN.Text = ">>";
            this.PosteriorBTN.UseVisualStyleBackColor = true;
            this.PosteriorBTN.Visible = false;
            this.PosteriorBTN.Click += new System.EventHandler(this.PosteriorBTN_Click);
            // 
            // AnteriorBTN
            // 
            this.AnteriorBTN.AutoSize = true;
            this.AnteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnteriorBTN.Location = new System.Drawing.Point(187, 10);
            this.AnteriorBTN.Name = "AnteriorBTN";
            this.AnteriorBTN.Size = new System.Drawing.Size(29, 23);
            this.AnteriorBTN.TabIndex = 4;
            this.AnteriorBTN.Text = "<<";
            this.AnteriorBTN.UseVisualStyleBackColor = true;
            this.AnteriorBTN.Visible = false;
            this.AnteriorBTN.Click += new System.EventHandler(this.AnteriorBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tareas Asignadas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(322, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "CelularTrust:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "e-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contacto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfonos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // NroMTB
            // 
            this.NroMTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroMTB.Location = new System.Drawing.Point(38, 37);
            this.NroMTB.Mask = "9990";
            this.NroMTB.Name = "NroMTB";
            this.NroMTB.Size = new System.Drawing.Size(44, 22);
            this.NroMTB.TabIndex = 0;
            this.NroMTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NroMTB_KeyDown);
            this.NroMTB.Leave += new System.EventHandler(this.NroMTB_Leave);
            this.NroMTB.Enter += new System.EventHandler(this.NroMTB_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro:";
            // 
            // TareasTB
            // 
            this.TareasTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TareasTB.Location = new System.Drawing.Point(161, 258);
            this.TareasTB.Multiline = true;
            this.TareasTB.Name = "TareasTB";
            this.TareasTB.Size = new System.Drawing.Size(362, 44);
            this.TareasTB.TabIndex = 8;
            // 
            // CelTrustTB
            // 
            this.CelTrustTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelTrustTB.Location = new System.Drawing.Point(394, 223);
            this.CelTrustTB.Name = "CelTrustTB";
            this.CelTrustTB.Size = new System.Drawing.Size(97, 22);
            this.CelTrustTB.TabIndex = 7;
            // 
            // CelTB
            // 
            this.CelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelTB.Location = new System.Drawing.Point(161, 222);
            this.CelTB.Name = "CelTB";
            this.CelTB.Size = new System.Drawing.Size(97, 22);
            this.CelTB.TabIndex = 6;
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(161, 185);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(362, 22);
            this.emailTB.TabIndex = 5;
            // 
            // ContactTB
            // 
            this.ContactTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactTB.Location = new System.Drawing.Point(161, 149);
            this.ContactTB.Name = "ContactTB";
            this.ContactTB.Size = new System.Drawing.Size(362, 22);
            this.ContactTB.TabIndex = 4;
            // 
            // TelTB
            // 
            this.TelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelTB.Location = new System.Drawing.Point(161, 112);
            this.TelTB.Name = "TelTB";
            this.TelTB.Size = new System.Drawing.Size(362, 22);
            this.TelTB.TabIndex = 3;
            // 
            // DirTB
            // 
            this.DirTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirTB.Location = new System.Drawing.Point(161, 76);
            this.DirTB.Name = "DirTB";
            this.DirTB.Size = new System.Drawing.Size(362, 22);
            this.DirTB.TabIndex = 2;
            // 
            // NombreTB
            // 
            this.NombreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTB.Location = new System.Drawing.Point(161, 39);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(362, 22);
            this.NombreTB.TabIndex = 1;
            // 
            // bcUC
            // 
            this.bcUC.ClienteNRO = "";
            this.bcUC.Location = new System.Drawing.Point(3, 15);
            this.bcUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bcUC.Name = "bcUC";
            this.bcUC.Size = new System.Drawing.Size(530, 41);
            this.bcUC.TabIndex = 0;
            // 
            // ServicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 490);
            this.Controls.Add(this.ServicioGB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ClienteGB);
            this.Name = "ServicioForm";
            this.Text = "ServicioForm";
            this.ClienteGB.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ServicioGB.ResumeLayout(false);
            this.ServicioGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClienteGB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox ServicioGB;
        private System.Windows.Forms.Label label1;
        private ControlHoras.TextBoxKeyDown NombreTB;
        private System.Windows.Forms.MaskedTextBox NroMTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ControlHoras.TextBoxKeyDown TelTB;
        private System.Windows.Forms.Label label4;
        private ControlHoras.TextBoxKeyDown DirTB;
        private ControlHoras.TextBoxKeyDown ContactTB;
        private System.Windows.Forms.Label label5;
        private ControlHoras.TextBoxKeyDown CelTB;
        private System.Windows.Forms.Label label7;
        private ControlHoras.TextBoxKeyDown emailTB;
        private System.Windows.Forms.Label label6;
        private ControlHoras.TextBoxKeyDown CelTrustTB;
        private System.Windows.Forms.Label label8;
        private ControlHoras.TextBoxKeyDown TareasTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AnteriorBTN;
        private System.Windows.Forms.Button PosteriorBTN;
        private BúsquedaCliente bcUC;
        private System.Windows.Forms.ToolStripButton AgregarBTN;
        private System.Windows.Forms.ToolStripButton GuardarBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ContratoBTN;
        private System.Windows.Forms.ToolStripButton CancelarBTN;
    }
}