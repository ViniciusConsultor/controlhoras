namespace ControlHoras
{
    partial class CambiarNumeroEmpleado
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtNumeroEmpleadoActual = new ControlHoras.MaskedTextBoxKeyDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mtNumeroEmpleadoNuevo = new ControlHoras.MaskedTextBoxKeyDown();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBuscarEmpleado = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(13, 59);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(77, 13);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Número Actual";
            // 
            // mtNumeroEmpleadoActual
            // 
            this.mtNumeroEmpleadoActual.BackColor = System.Drawing.Color.White;
            this.mtNumeroEmpleadoActual.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtNumeroEmpleadoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtNumeroEmpleadoActual.HidePromptOnLeave = true;
            this.mtNumeroEmpleadoActual.Location = new System.Drawing.Point(109, 54);
            this.mtNumeroEmpleadoActual.Mask = "0999";
            this.mtNumeroEmpleadoActual.Name = "mtNumeroEmpleadoActual";
            this.mtNumeroEmpleadoActual.Size = new System.Drawing.Size(44, 21);
            this.mtNumeroEmpleadoActual.TabIndex = 10;
            this.mtNumeroEmpleadoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtNumeroEmpleadoActual.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtNumeroEmpleadoActual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtNumeroEmpleadoActual_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Número Nuevo";
            // 
            // mtNumeroEmpleadoNuevo
            // 
            this.mtNumeroEmpleadoNuevo.BackColor = System.Drawing.Color.White;
            this.mtNumeroEmpleadoNuevo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtNumeroEmpleadoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtNumeroEmpleadoNuevo.HidePromptOnLeave = true;
            this.mtNumeroEmpleadoNuevo.Location = new System.Drawing.Point(109, 107);
            this.mtNumeroEmpleadoNuevo.Mask = "0999";
            this.mtNumeroEmpleadoNuevo.Name = "mtNumeroEmpleadoNuevo";
            this.mtNumeroEmpleadoNuevo.Size = new System.Drawing.Size(44, 21);
            this.mtNumeroEmpleadoNuevo.TabIndex = 12;
            this.mtNumeroEmpleadoNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtNumeroEmpleadoNuevo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(170, 54);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(249, 21);
            this.txtEmpleado.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cambiar Por:";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(97, 150);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 17;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(267, 150);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarEmpleado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(439, 36);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = global::ControlHoras.Imagenes.Search_Icon;
            this.btnBuscarEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(43, 33);
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // CambiarNumeroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 185);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtNumeroEmpleadoNuevo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.mtNumeroEmpleadoActual);
            this.Name = "CambiarNumeroEmpleado";
            this.Text = "Cambiar Número de Empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CambiarNumeroEmpleado_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private MaskedTextBoxKeyDown mtNumeroEmpleadoActual;
        private System.Windows.Forms.Label label1;
        private MaskedTextBoxKeyDown mtNumeroEmpleadoNuevo;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBuscarEmpleado;
    }
}