namespace ControlHoras
{
    partial class ControlDiarioAgregarFuncionario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mtFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreFuncionarioNuevo = new System.Windows.Forms.TextBox();
            this.mtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtHoraFin = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ACargoCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(693, 114);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(561, 114);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mtFuncionario
            // 
            this.mtFuncionario.BackColor = System.Drawing.SystemColors.Window;
            this.mtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFuncionario.Location = new System.Drawing.Point(15, 42);
            this.mtFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.mtFuncionario.Mask = "9990";
            this.mtFuncionario.Name = "mtFuncionario";
            this.mtFuncionario.Size = new System.Drawing.Size(57, 25);
            this.mtFuncionario.TabIndex = 0;
            this.mtFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtFuncionario_KeyDown);
            // 
            // txtNombreFuncionarioNuevo
            // 
            this.txtNombreFuncionarioNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreFuncionarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFuncionarioNuevo.Location = new System.Drawing.Point(81, 42);
            this.txtNombreFuncionarioNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreFuncionarioNuevo.Name = "txtNombreFuncionarioNuevo";
            this.txtNombreFuncionarioNuevo.ReadOnly = true;
            this.txtNombreFuncionarioNuevo.Size = new System.Drawing.Size(385, 25);
            this.txtNombreFuncionarioNuevo.TabIndex = 1;
            this.txtNombreFuncionarioNuevo.TabStop = false;
            // 
            // mtHoraInicio
            // 
            this.mtHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtHoraInicio.Location = new System.Drawing.Point(487, 42);
            this.mtHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.mtHoraInicio.Mask = "00:00";
            this.mtHoraInicio.Name = "mtHoraInicio";
            this.mtHoraInicio.Size = new System.Drawing.Size(48, 25);
            this.mtHoraInicio.TabIndex = 2;
            this.mtHoraInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtHoraInicio_KeyDown);
            // 
            // mtHoraFin
            // 
            this.mtHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtHoraFin.Location = new System.Drawing.Point(564, 42);
            this.mtHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.mtHoraFin.Mask = "00:00";
            this.mtHoraFin.Name = "mtHoraFin";
            this.mtHoraFin.Size = new System.Drawing.Size(48, 25);
            this.mtHoraFin.TabIndex = 3;
            this.mtHoraFin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtHoraFin_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hora Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hora Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Funcionario";
            // 
            // ACargoCB
            // 
            this.ACargoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACargoCB.FormattingEnabled = true;
            this.ACargoCB.Location = new System.Drawing.Point(672, 41);
            this.ACargoCB.Name = "ACargoCB";
            this.ACargoCB.Size = new System.Drawing.Size(121, 26);
            this.ACargoCB.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "A Cargo de";
            // 
            // ControlDiarioAgregarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(815, 175);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ACargoCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtHoraFin);
            this.Controls.Add(this.mtHoraInicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mtFuncionario);
            this.Controls.Add(this.txtNombreFuncionarioNuevo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlDiarioAgregarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ControlDiarioAgregarFuncionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlDiarioAgregarFuncionario_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox mtFuncionario;
        private System.Windows.Forms.TextBox txtNombreFuncionarioNuevo;
        private System.Windows.Forms.MaskedTextBox mtHoraInicio;
        private System.Windows.Forms.MaskedTextBox mtHoraFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ACargoCB;
        private System.Windows.Forms.Label label5;
    }
}