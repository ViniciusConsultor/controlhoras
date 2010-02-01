namespace ControlHoras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.dgvHoras = new System.Windows.Forms.DataGridView();
            this.dgvHorasMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopiarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.lunesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.martesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miercolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juevesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viernesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sabadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DehsabilitarDia = new System.Windows.Forms.ToolStripMenuItem();
            this.Agregar = new System.Windows.Forms.Button();
            this.mtCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtServicio = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnPlanificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).BeginInit();
            this.dgvHorasMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(63, 53);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(362, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(63, 80);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(362, 20);
            this.txtServicio.TabIndex = 3;
            // 
            // dgvHoras
            // 
            this.dgvHoras.AllowUserToAddRows = false;
            this.dgvHoras.AllowUserToDeleteRows = false;
            this.dgvHoras.AllowUserToResizeColumns = false;
            this.dgvHoras.AllowUserToResizeRows = false;
            this.dgvHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoras.ContextMenuStrip = this.dgvHorasMenuStrip;
            this.dgvHoras.Location = new System.Drawing.Point(13, 158);
            this.dgvHoras.MultiSelect = false;
            this.dgvHoras.Name = "dgvHoras";
            this.dgvHoras.RowHeadersVisible = false;
            this.dgvHoras.RowHeadersWidth = 20;
            this.dgvHoras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.NullValue = null;
            this.dgvHoras.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgvHoras.Size = new System.Drawing.Size(576, 235);
            this.dgvHoras.TabIndex = 4;
            // 
            // dgvHorasMenuStrip
            // 
            this.dgvHorasMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopiarHorario,
            this.DehsabilitarDia});
            this.dgvHorasMenuStrip.Name = "dgvHorasMenuStrip";
            this.dgvHorasMenuStrip.Size = new System.Drawing.Size(179, 48);
            // 
            // CopiarHorario
            // 
            this.CopiarHorario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lunesToolStripMenuItem,
            this.martesToolStripMenuItem,
            this.miercolesToolStripMenuItem,
            this.juevesToolStripMenuItem,
            this.viernesToolStripMenuItem,
            this.sabadoToolStripMenuItem,
            this.domingoToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.CopiarHorario.Name = "CopiarHorario";
            this.CopiarHorario.Size = new System.Drawing.Size(178, 22);
            this.CopiarHorario.Text = "Copiar Horario a ...";
            // 
            // lunesToolStripMenuItem
            // 
            this.lunesToolStripMenuItem.Name = "lunesToolStripMenuItem";
            this.lunesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.lunesToolStripMenuItem.Text = "Lunes";
            // 
            // martesToolStripMenuItem
            // 
            this.martesToolStripMenuItem.Name = "martesToolStripMenuItem";
            this.martesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.martesToolStripMenuItem.Text = "Martes";
            this.martesToolStripMenuItem.Click += new System.EventHandler(this.martesToolStripMenuItem_Click);
            // 
            // miercolesToolStripMenuItem
            // 
            this.miercolesToolStripMenuItem.Name = "miercolesToolStripMenuItem";
            this.miercolesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.miercolesToolStripMenuItem.Text = "Miercoles";
            // 
            // juevesToolStripMenuItem
            // 
            this.juevesToolStripMenuItem.Name = "juevesToolStripMenuItem";
            this.juevesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.juevesToolStripMenuItem.Text = "Jueves";
            // 
            // viernesToolStripMenuItem
            // 
            this.viernesToolStripMenuItem.Name = "viernesToolStripMenuItem";
            this.viernesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.viernesToolStripMenuItem.Text = "Viernes";
            // 
            // sabadoToolStripMenuItem
            // 
            this.sabadoToolStripMenuItem.Name = "sabadoToolStripMenuItem";
            this.sabadoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sabadoToolStripMenuItem.Text = "Sabado";
            // 
            // domingoToolStripMenuItem
            // 
            this.domingoToolStripMenuItem.Name = "domingoToolStripMenuItem";
            this.domingoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.domingoToolStripMenuItem.Text = "Domingo";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            // 
            // DehsabilitarDia
            // 
            this.DehsabilitarDia.Name = "DehsabilitarDia";
            this.DehsabilitarDia.Size = new System.Drawing.Size(178, 22);
            this.DehsabilitarDia.Text = "Deshabilitar Dia";
            this.DehsabilitarDia.Click += new System.EventHandler(this.DehsabilitarDia_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(12, 129);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(59, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // mtCliente
            // 
            this.mtCliente.AllowPromptAsInput = false;
            this.mtCliente.Location = new System.Drawing.Point(13, 52);
            this.mtCliente.Mask = "0000";
            this.mtCliente.Name = "mtCliente";
            this.mtCliente.Size = new System.Drawing.Size(44, 20);
            this.mtCliente.TabIndex = 7;
            this.mtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtCliente_KeyDown);
           
            // 
            // mtServicio
            // 
            this.mtServicio.Location = new System.Drawing.Point(13, 79);
            this.mtServicio.Mask = "9990";
            this.mtServicio.Name = "mtServicio";
            this.mtServicio.Size = new System.Drawing.Size(44, 20);
            this.mtServicio.TabIndex = 8;
            this.mtServicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtServicio_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.btnPlanificar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(609, 36);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(45, 33);
            this.toolStripButton2.Text = "Boton1";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(50, 33);
            this.toolStripButton3.Text = "Guardar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 33);
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnPlanificar
            // 
            this.btnPlanificar.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanificar.Image")));
            this.btnPlanificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlanificar.Name = "btnPlanificar";
            this.btnPlanificar.Size = new System.Drawing.Size(54, 33);
            this.btnPlanificar.Text = "Planificar";
            this.btnPlanificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlanificar.Click += new System.EventHandler(this.btnPlanificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(78, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(58, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 405);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.mtServicio);
            this.Controls.Add(this.mtCliente);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dgvHoras);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Horas de Contrato";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).EndInit();
            this.dgvHorasMenuStrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.DataGridView dgvHoras;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.ContextMenuStrip dgvHorasMenuStrip;
        private System.Windows.Forms.MaskedTextBox mtCliente;
        private System.Windows.Forms.MaskedTextBox mtServicio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CopiarHorario;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem DehsabilitarDia;
        private System.Windows.Forms.ToolStripMenuItem lunesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem martesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miercolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juevesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viernesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sabadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domingoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolStripButton btnPlanificar;
    }
}

