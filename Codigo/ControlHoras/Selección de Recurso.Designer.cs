﻿namespace ControlHoras
{
    partial class Selección_de_Recurso
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
            this.mtFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.OKBTN = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.210526F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nro. de funcionario:";
            // 
            // mtFunc
            // 
            this.mtFunc.AllowPromptAsInput = false;
            this.mtFunc.Location = new System.Drawing.Point(40, 43);
            this.mtFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtFunc.Mask = "9990";
            this.mtFunc.Name = "mtFunc";
            this.mtFunc.Size = new System.Drawing.Size(48, 22);
            this.mtFunc.TabIndex = 0;
            // 
            // txtFunc
            // 
            this.txtFunc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFunc.Location = new System.Drawing.Point(97, 43);
            this.txtFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.ReadOnly = true;
            this.txtFunc.Size = new System.Drawing.Size(400, 22);
            this.txtFunc.TabIndex = 13;
            // 
            // OKBTN
            // 
            this.OKBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBTN.Location = new System.Drawing.Point(155, 89);
            this.OKBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(100, 28);
            this.OKBTN.TabIndex = 1;
            this.OKBTN.Text = "Aceptar";
            this.OKBTN.UseVisualStyleBackColor = true;            
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(285, 89);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Selección_de_Recurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(540, 143);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.mtFunc);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Selección_de_Recurso";
            this.Text = "Selección de Recurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtFunc;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Button OKBTN;
        private System.Windows.Forms.Button btnCancelar;
    }
}