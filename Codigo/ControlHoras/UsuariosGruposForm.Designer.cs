namespace ControlHoras
{
    partial class UsuariosGruposForm
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
            this.TabUsuarios = new System.Windows.Forms.TabControl();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.Grupos = new System.Windows.Forms.TabPage();
            this.TabUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabUsuarios
            // 
            this.TabUsuarios.Controls.Add(this.Usuarios);
            this.TabUsuarios.Controls.Add(this.Grupos);
            this.TabUsuarios.Location = new System.Drawing.Point(1, 2);
            this.TabUsuarios.Name = "TabUsuarios";
            this.TabUsuarios.SelectedIndex = 0;
            this.TabUsuarios.Size = new System.Drawing.Size(520, 393);
            this.TabUsuarios.TabIndex = 0;
            // 
            // Usuarios
            // 
            this.Usuarios.Location = new System.Drawing.Point(4, 22);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(512, 367);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // Grupos
            // 
            this.Grupos.Location = new System.Drawing.Point(4, 22);
            this.Grupos.Name = "Grupos";
            this.Grupos.Padding = new System.Windows.Forms.Padding(3);
            this.Grupos.Size = new System.Drawing.Size(512, 367);
            this.Grupos.TabIndex = 1;
            this.Grupos.Text = "Grupos";
            this.Grupos.UseVisualStyleBackColor = true;
            // 
            // UsuariosGruposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 395);
            this.Controls.Add(this.TabUsuarios);
            this.Name = "UsuariosGruposForm";
            this.Text = "UsuariosGruposForm";
            this.TabUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabUsuarios;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.TabPage Grupos;
    }
}