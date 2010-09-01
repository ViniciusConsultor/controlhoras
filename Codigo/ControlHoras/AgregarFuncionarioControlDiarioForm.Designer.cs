namespace ControlHoras
{
    partial class AgregarFuncionarioControlDiarioForm
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
            this.mtFuncionarioNuevo = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreFuncionarioNuevo = new System.Windows.Forms.TextBox();
            this.mtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mtHoraSalida = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNroServicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(222, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(102, 118);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mtFuncionarioNuevo
            // 
            this.mtFuncionarioNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.mtFuncionarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFuncionarioNuevo.Location = new System.Drawing.Point(28, 77);
            this.mtFuncionarioNuevo.Mask = "9990";
            this.mtFuncionarioNuevo.Name = "mtFuncionarioNuevo";
            this.mtFuncionarioNuevo.Size = new System.Drawing.Size(44, 22);
            this.mtFuncionarioNuevo.TabIndex = 0;
            this.mtFuncionarioNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtFuncionarioNuevo_KeyDown);
            // 
            // txtNombreFuncionarioNuevo
            // 
            this.txtNombreFuncionarioNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreFuncionarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFuncionarioNuevo.Location = new System.Drawing.Point(78, 77);
            this.txtNombreFuncionarioNuevo.Name = "txtNombreFuncionarioNuevo";
            this.txtNombreFuncionarioNuevo.ReadOnly = true;
            this.txtNombreFuncionarioNuevo.Size = new System.Drawing.Size(210, 22);
            this.txtNombreFuncionarioNuevo.TabIndex = 1;
            this.txtNombreFuncionarioNuevo.TabStop = false;
            // 
            // mtHoraEntrada
            // 
            this.mtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtHoraEntrada.Location = new System.Drawing.Point(294, 77);
            this.mtHoraEntrada.Mask = "00:00";
            this.mtHoraEntrada.Name = "mtHoraEntrada";
            this.mtHoraEntrada.Size = new System.Drawing.Size(37, 22);
            this.mtHoraEntrada.TabIndex = 2;
            // 
            // mtHoraSalida
            // 
            this.mtHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtHoraSalida.Location = new System.Drawing.Point(348, 77);
            this.mtHoraSalida.Mask = "00:00";
            this.mtHoraSalida.Name = "mtHoraSalida";
            this.mtHoraSalida.Size = new System.Drawing.Size(37, 22);
            this.mtHoraSalida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Agregar Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cliente";
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Location = new System.Drawing.Point(135, 37);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(35, 13);
            this.lblNroCliente.TabIndex = 29;
            this.lblNroCliente.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Servicio";
            // 
            // lblNroServicio
            // 
            this.lblNroServicio.AutoSize = true;
            this.lblNroServicio.Location = new System.Drawing.Point(303, 37);
            this.lblNroServicio.Name = "lblNroServicio";
            this.lblNroServicio.Size = new System.Drawing.Size(35, 13);
            this.lblNroServicio.TabIndex = 31;
            this.lblNroServicio.Text = "label4";
            // 
            // AgregarFuncionarioControlDiarioForm
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(411, 155);
            this.Controls.Add(this.lblNroServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtHoraSalida);
            this.Controls.Add(this.mtHoraEntrada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mtFuncionarioNuevo);
            this.Controls.Add(this.txtNombreFuncionarioNuevo);
            this.Name = "AgregarFuncionarioControlDiarioForm";
            this.Text = "AgregarFuncionarioControlDiarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox mtFuncionarioNuevo;
        private System.Windows.Forms.TextBox txtNombreFuncionarioNuevo;
        private System.Windows.Forms.MaskedTextBox mtHoraEntrada;
        private System.Windows.Forms.MaskedTextBox mtHoraSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNroServicio;
    }
}