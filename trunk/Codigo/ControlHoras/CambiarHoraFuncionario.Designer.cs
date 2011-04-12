namespace ControlHoras
{
    partial class CambiarHoraFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtFuncionarioActual = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreFuncionarioActual = new System.Windows.Forms.TextBox();
            this.mtHoraActual = new System.Windows.Forms.MaskedTextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtHoraNueva = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaNueva = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cambiar Hora Funcionario";
            // 
            // mtFuncionarioActual
            // 
            this.mtFuncionarioActual.AllowPromptAsInput = false;
            this.mtFuncionarioActual.BackColor = System.Drawing.Color.Bisque;
            this.mtFuncionarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFuncionarioActual.Location = new System.Drawing.Point(26, 35);
            this.mtFuncionarioActual.Mask = "0000";
            this.mtFuncionarioActual.Name = "mtFuncionarioActual";
            this.mtFuncionarioActual.ReadOnly = true;
            this.mtFuncionarioActual.Size = new System.Drawing.Size(44, 22);
            this.mtFuncionarioActual.TabIndex = 18;
            // 
            // txtNombreFuncionarioActual
            // 
            this.txtNombreFuncionarioActual.BackColor = System.Drawing.Color.Bisque;
            this.txtNombreFuncionarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFuncionarioActual.Location = new System.Drawing.Point(78, 35);
            this.txtNombreFuncionarioActual.Name = "txtNombreFuncionarioActual";
            this.txtNombreFuncionarioActual.ReadOnly = true;
            this.txtNombreFuncionarioActual.Size = new System.Drawing.Size(248, 22);
            this.txtNombreFuncionarioActual.TabIndex = 19;
            this.txtNombreFuncionarioActual.TabStop = false;
            // 
            // mtHoraActual
            // 
            this.mtHoraActual.BackColor = System.Drawing.Color.Bisque;
            this.mtHoraActual.Location = new System.Drawing.Point(26, 97);
            this.mtHoraActual.Mask = "00/00/0000 90:00";
            this.mtHoraActual.Name = "mtHoraActual";
            this.mtHoraActual.ReadOnly = true;
            this.mtHoraActual.Size = new System.Drawing.Size(102, 20);
            this.mtHoraActual.TabIndex = 21;
            this.mtHoraActual.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 73);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(59, 16);
            this.lblHora.TabIndex = 22;
            this.lblHora.Text = "lblHora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Por";
            // 
            // mtHoraNueva
            // 
            this.mtHoraNueva.Location = new System.Drawing.Point(282, 97);
            this.mtHoraNueva.Mask = "00:00";
            this.mtHoraNueva.Name = "mtHoraNueva";
            this.mtHoraNueva.Size = new System.Drawing.Size(37, 20);
            this.mtHoraNueva.TabIndex = 0;
            this.mtHoraNueva.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtHoraNueva_KeyDown);
            this.mtHoraNueva.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtHoraNueva_MaskInputRejected);
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(74, 139);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(186, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaNueva
            // 
            this.dtpFechaNueva.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFechaNueva.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNueva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNueva.Location = new System.Drawing.Point(189, 97);
            this.dtpFechaNueva.Name = "dtpFechaNueva";
            this.dtpFechaNueva.ShowUpDown = true;
            this.dtpFechaNueva.Size = new System.Drawing.Size(87, 20);
            this.dtpFechaNueva.TabIndex = 27;
            // 
            // CambiarHoraFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(340, 174);
            this.Controls.Add(this.dtpFechaNueva);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mtHoraNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.mtHoraActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtFuncionarioActual);
            this.Controls.Add(this.txtNombreFuncionarioActual);
            this.Name = "CambiarHoraFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CambiarHoraFuncionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CambiarHoraFuncionario_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtFuncionarioActual;
        private System.Windows.Forms.TextBox txtNombreFuncionarioActual;
        private System.Windows.Forms.MaskedTextBox mtHoraActual;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtHoraNueva;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaNueva;
    }
}