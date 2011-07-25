namespace ControlHoras
{
    partial class ServiciosFuncionariosSumarHsComunes
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFuncionarios = new System.Windows.Forms.CheckedListBox();
            this.cbSeleccionados = new System.Windows.Forms.CheckBox();
            this.btnClearFiltro = new System.Windows.Forms.Button();
            this.btnFiltrarFuncionarios = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tcClientesServicios = new ControlHoras.TreeClientesServicios();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(738, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciones los Servicios en los cuales se pagaran las Hs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione los Funcionarios a los cuales se les pagara Hs adicionales";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(410, 63);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(235, 20);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtro";
            // 
            // lbFuncionarios
            // 
            this.lbFuncionarios.CheckOnClick = true;
            this.lbFuncionarios.FormattingEnabled = true;
            this.lbFuncionarios.Location = new System.Drawing.Point(373, 108);
            this.lbFuncionarios.Name = "lbFuncionarios";
            this.lbFuncionarios.Size = new System.Drawing.Size(353, 289);
            this.lbFuncionarios.TabIndex = 8;
            this.lbFuncionarios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbFuncionarios_ItemCheck);
            // 
            // cbSeleccionados
            // 
            this.cbSeleccionados.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSeleccionados.AutoSize = true;
            this.cbSeleccionados.Location = new System.Drawing.Point(410, 84);
            this.cbSeleccionados.Name = "cbSeleccionados";
            this.cbSeleccionados.Size = new System.Drawing.Size(111, 23);
            this.cbSeleccionados.TabIndex = 11;
            this.cbSeleccionados.Text = "Solo Seleccionados";
            this.cbSeleccionados.UseVisualStyleBackColor = true;
            this.cbSeleccionados.CheckedChanged += new System.EventHandler(this.cbSeleccionados_CheckedChanged);
            // 
            // btnClearFiltro
            // 
            this.btnClearFiltro.Image = global::ControlHoras.Imagenes.check_error;
            this.btnClearFiltro.Location = new System.Drawing.Point(682, 62);
            this.btnClearFiltro.Name = "btnClearFiltro";
            this.btnClearFiltro.Size = new System.Drawing.Size(29, 22);
            this.btnClearFiltro.TabIndex = 10;
            this.btnClearFiltro.UseVisualStyleBackColor = true;
            this.btnClearFiltro.Click += new System.EventHandler(this.btnClearFiltro_Click);
            // 
            // btnFiltrarFuncionarios
            // 
            this.btnFiltrarFuncionarios.Image = global::ControlHoras.Imagenes.check_ok;
            this.btnFiltrarFuncionarios.Location = new System.Drawing.Point(651, 62);
            this.btnFiltrarFuncionarios.Name = "btnFiltrarFuncionarios";
            this.btnFiltrarFuncionarios.Size = new System.Drawing.Size(29, 22);
            this.btnFiltrarFuncionarios.TabIndex = 7;
            this.btnFiltrarFuncionarios.UseVisualStyleBackColor = true;
            this.btnFiltrarFuncionarios.Click += new System.EventHandler(this.btnFiltrarFuncionarios_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ControlHoras.Imagenes.filesave;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 33);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tcClientesServicios
            // 
            this.tcClientesServicios.Location = new System.Drawing.Point(12, 67);
            this.tcClientesServicios.Name = "tcClientesServicios";
            this.tcClientesServicios.Size = new System.Drawing.Size(333, 332);
            this.tcClientesServicios.TabIndex = 1;
            // 
            // ServiciosFuncionariosSumarHsComunes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 411);
            this.Controls.Add(this.cbSeleccionados);
            this.Controls.Add(this.btnClearFiltro);
            this.Controls.Add(this.lbFuncionarios);
            this.Controls.Add(this.btnFiltrarFuncionarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcClientesServicios);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ServiciosFuncionariosSumarHsComunes";
            this.Text = "ServiciosFuncionariosSumarHsComunes";
            this.Load += new System.EventHandler(this.ServiciosFuncionariosSumarHsComunes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private TreeClientesServicios tcClientesServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrarFuncionarios;
        private System.Windows.Forms.CheckedListBox lbFuncionarios;
        private System.Windows.Forms.Button btnClearFiltro;
        private System.Windows.Forms.CheckBox cbSeleccionados;
    }
}