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
            this.bcUC = new ControlHoras.BúsquedaCliente();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.VerBTN = new System.Windows.Forms.ToolStripButton();
            this.ServicioGB = new System.Windows.Forms.GroupBox();
            this.PosteriorBTN = new System.Windows.Forms.Button();
            this.TareasTB = new System.Windows.Forms.TextBox();
            this.AnteriorBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CelTrustTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CelTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ContactTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DirTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.NroMTB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardarBTN = new System.Windows.Forms.Button();
            this.ClienteGB.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ServicioGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClienteGB
            // 
            this.ClienteGB.AutoSize = true;
            this.ClienteGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
//            this.ClienteGB.Controls.Add(this.bcUC);
            this.ClienteGB.Enabled = false;
            this.ClienteGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteGB.Location = new System.Drawing.Point(12, 44);
            this.ClienteGB.Name = "ClienteGB";
            this.ClienteGB.Size = new System.Drawing.Size(438, 79);
            this.ClienteGB.TabIndex = 0;
            this.ClienteGB.TabStop = false;
            this.ClienteGB.Text = "Cliente";
            // 
            // bcUC
            // 
            this.bcUC.Location = new System.Drawing.Point(3, 16);
            this.bcUC.Margin = new System.Windows.Forms.Padding(2);
            this.bcUC.Name = "bcUC";
            this.bcUC.Size = new System.Drawing.Size(430, 45);
            this.bcUC.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNuevo,
            this.VerBTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(500, 36);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(42, 33);
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // VerBTN
            // 
            this.VerBTN.Image = ((System.Drawing.Image)(resources.GetObject("VerBTN.Image")));
            this.VerBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VerBTN.Name = "VerBTN";
            this.VerBTN.Size = new System.Drawing.Size(27, 33);
            this.VerBTN.Text = "Ver";
            this.VerBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VerBTN.Click += new System.EventHandler(this.VerBTN_Click);
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
            this.ServicioGB.Location = new System.Drawing.Point(15, 125);
            this.ServicioGB.Name = "ServicioGB";
            this.ServicioGB.Size = new System.Drawing.Size(435, 425);
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
            // TareasTB
            // 
            this.TareasTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TareasTB.Location = new System.Drawing.Point(65, 364);
            this.TareasTB.Multiline = true;
            this.TareasTB.Name = "TareasTB";
            this.TareasTB.Size = new System.Drawing.Size(362, 44);
            this.TareasTB.TabIndex = 8;
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
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tareas Asignadas:";
            // 
            // CelTrustTB
            // 
            this.CelTrustTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelTrustTB.Location = new System.Drawing.Point(330, 313);
            this.CelTrustTB.Name = "CelTrustTB";
            this.CelTrustTB.Size = new System.Drawing.Size(97, 22);
            this.CelTrustTB.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "CelularTrust:";
            // 
            // CelTB
            // 
            this.CelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelTB.Location = new System.Drawing.Point(65, 313);
            this.CelTB.Name = "CelTB";
            this.CelTB.Size = new System.Drawing.Size(97, 22);
            this.CelTB.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Celular:";
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(68, 258);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(362, 22);
            this.emailTB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "e-mail:";
            // 
            // ContactTB
            // 
            this.ContactTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactTB.Location = new System.Drawing.Point(68, 202);
            this.ContactTB.Name = "ContactTB";
            this.ContactTB.Size = new System.Drawing.Size(362, 22);
            this.ContactTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contacto:";
            // 
            // TelTB
            // 
            this.TelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelTB.Location = new System.Drawing.Point(65, 145);
            this.TelTB.Name = "TelTB";
            this.TelTB.Size = new System.Drawing.Size(362, 22);
            this.TelTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfonos:";
            // 
            // DirTB
            // 
            this.DirTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirTB.Location = new System.Drawing.Point(65, 92);
            this.DirTB.Name = "DirTB";
            this.DirTB.Size = new System.Drawing.Size(362, 22);
            this.DirTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // NombreTB
            // 
            this.NombreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTB.Location = new System.Drawing.Point(65, 39);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(362, 22);
            this.NombreTB.TabIndex = 1;
            // 
            // NroMTB
            // 
            this.NroMTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroMTB.Location = new System.Drawing.Point(5, 39);
            this.NroMTB.Mask = "9990";
            this.NroMTB.Name = "NroMTB";
            this.NroMTB.Size = new System.Drawing.Size(44, 22);
            this.NroMTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro:";
            // 
            // GuardarBTN
            // 
            this.GuardarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBTN.Location = new System.Drawing.Point(375, 556);
            this.GuardarBTN.Name = "GuardarBTN";
            this.GuardarBTN.Size = new System.Drawing.Size(75, 23);
            this.GuardarBTN.TabIndex = 3;
            this.GuardarBTN.Text = "Guardar";
            this.GuardarBTN.UseVisualStyleBackColor = true;
            this.GuardarBTN.Visible = false;
            this.GuardarBTN.Click += new System.EventHandler(this.GuardarBTN_Click);
            // 
            // ServicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 642);
            this.Controls.Add(this.GuardarBTN);
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
        private BúsquedaCliente bcUC;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox ServicioGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.MaskedTextBox NroMTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DirTB;
        private System.Windows.Forms.TextBox ContactTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CelTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CelTrustTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TareasTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton BtnNuevo;
        private System.Windows.Forms.Button GuardarBTN;
        private System.Windows.Forms.ToolStripButton VerBTN;
        private System.Windows.Forms.Button AnteriorBTN;
        private System.Windows.Forms.Button PosteriorBTN;
    }
}