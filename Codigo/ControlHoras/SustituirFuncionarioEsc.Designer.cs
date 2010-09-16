namespace ControlHoras
{
    partial class SustituirFuncionarioEsc
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
            this.mtFuncionarioNuevo = new System.Windows.Forms.MaskedTextBox();
            this.mtFuncionarioActual = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreFuncionarioNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreFuncionarioActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtFuncionarioNuevo
            // 
            this.mtFuncionarioNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.mtFuncionarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFuncionarioNuevo.Location = new System.Drawing.Point(26, 89);
            this.mtFuncionarioNuevo.Mask = "9990";
            this.mtFuncionarioNuevo.Name = "mtFuncionarioNuevo";
            this.mtFuncionarioNuevo.Size = new System.Drawing.Size(44, 22);
            this.mtFuncionarioNuevo.TabIndex = 14;
            this.mtFuncionarioNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtFuncionarioNuevo_KeyDown);            
            // 
            // mtFuncionarioActual
            // 
            this.mtFuncionarioActual.AllowPromptAsInput = false;
            this.mtFuncionarioActual.BackColor = System.Drawing.Color.Bisque;
            this.mtFuncionarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFuncionarioActual.Location = new System.Drawing.Point(26, 35);
            this.mtFuncionarioActual.Mask = "0000";
            this.mtFuncionarioActual.Name = "mtFuncionarioActual";
            this.mtFuncionarioActual.Size = new System.Drawing.Size(44, 22);
            this.mtFuncionarioActual.TabIndex = 13;
            this.mtFuncionarioActual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtFuncionarioActual_KeyDown);
            // 
            // txtNombreFuncionarioNuevo
            // 
            this.txtNombreFuncionarioNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreFuncionarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFuncionarioNuevo.Location = new System.Drawing.Point(76, 90);
            this.txtNombreFuncionarioNuevo.Name = "txtNombreFuncionarioNuevo";
            this.txtNombreFuncionarioNuevo.ReadOnly = true;
            this.txtNombreFuncionarioNuevo.Size = new System.Drawing.Size(290, 22);
            this.txtNombreFuncionarioNuevo.TabIndex = 15;
            this.txtNombreFuncionarioNuevo.TabStop = false;
            // 
            // txtNombreFuncionarioActual
            // 
            this.txtNombreFuncionarioActual.BackColor = System.Drawing.Color.Bisque;
            this.txtNombreFuncionarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFuncionarioActual.Location = new System.Drawing.Point(76, 36);
            this.txtNombreFuncionarioActual.Name = "txtNombreFuncionarioActual";
            this.txtNombreFuncionarioActual.ReadOnly = true;
            this.txtNombreFuncionarioActual.Size = new System.Drawing.Size(290, 22);
            this.txtNombreFuncionarioActual.TabIndex = 16;
            this.txtNombreFuncionarioActual.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sustituir Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Por";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(88, 139);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(208, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // SustituirFuncionarioEsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 177);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtFuncionarioNuevo);
            this.Controls.Add(this.mtFuncionarioActual);
            this.Controls.Add(this.txtNombreFuncionarioNuevo);
            this.Controls.Add(this.txtNombreFuncionarioActual);
            this.Name = "SustituirFuncionarioEsc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sustituir Funcionario del Escalafón";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SustituirFuncionarioEsc_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtFuncionarioNuevo;
        private System.Windows.Forms.MaskedTextBox mtFuncionarioActual;
        private System.Windows.Forms.TextBox txtNombreFuncionarioNuevo;
        private System.Windows.Forms.TextBox txtNombreFuncionarioActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

    }
}