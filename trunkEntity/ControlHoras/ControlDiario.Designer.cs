namespace ControlHoras
{
    partial class ControlDiario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDiario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.dgvHoras = new System.Windows.Forms.DataGridView();
            this.IdHorasGeneradasEscalafon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroEmpleado = new ControlHoras.MaskedTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new ControlHoras.MaskedTextBoxColumn();
            this.HoraSalida = new ControlHoras.MaskedTextBoxColumn();
            this.menuStripdgvHoras = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cambiarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cambiarHoraEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarHoraSalida = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBuscarCliente = new System.Windows.Forms.ToolStripButton();
            this.tsVerHorasFuncionario = new System.Windows.Forms.ToolStripButton();
            this.btnCerrarDia = new System.Windows.Forms.ToolStripButton();
            this.btnPermitirModificaciones = new System.Windows.Forms.ToolStripButton();
            this.maskedTextBoxColumn1 = new ControlHoras.MaskedTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxColumn2 = new ControlHoras.MaskedTextBoxColumn();
            this.maskedTextBoxColumn3 = new ControlHoras.MaskedTextBoxColumn();
            this.mtServicio = new ControlHoras.MaskedTextBoxKeyDown();
            this.ucCliente = new ControlHoras.BúsquedaCliente();
            this.PosteriorBTN = new System.Windows.Forms.Button();
            this.AnteriorBTN = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.mtFecha = new System.Windows.Forms.MaskedTextBox();
            this.btnDiaAnterior = new System.Windows.Forms.Button();
            this.btnDiaSiguiente = new System.Windows.Forms.Button();
            this.lblEstadoEscalafon = new System.Windows.Forms.Label();
            this.lblDiaCerrado = new System.Windows.Forms.Label();
            this.lblPermitirModificaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).BeginInit();
            this.menuStripdgvHoras.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.SystemColors.Window;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(62, 108);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.ReadOnly = true;
            this.txtServicio.Size = new System.Drawing.Size(362, 22);
            this.txtServicio.TabIndex = 1;
            this.txtServicio.TabStop = false;
            // 
            // dgvHoras
            // 
            this.dgvHoras.AllowUserToAddRows = false;
            this.dgvHoras.AllowUserToDeleteRows = false;
            this.dgvHoras.AllowUserToResizeColumns = false;
            this.dgvHoras.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHorasGeneradasEscalafon,
            this.NroEmpleado,
            this.Funcionario,
            this.HoraEntrada,
            this.HoraSalida});
            this.dgvHoras.ContextMenuStrip = this.menuStripdgvHoras;
            this.dgvHoras.Location = new System.Drawing.Point(12, 138);
            this.dgvHoras.MultiSelect = false;
            this.dgvHoras.Name = "dgvHoras";
            this.dgvHoras.ReadOnly = true;
            this.dgvHoras.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHoras.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvHoras.RowTemplate.Height = 24;
            this.dgvHoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoras.Size = new System.Drawing.Size(581, 239);
            this.dgvHoras.TabIndex = 3;
            this.dgvHoras.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoras_CellMouseDown);
            // 
            // IdHorasGeneradasEscalafon
            // 
            this.IdHorasGeneradasEscalafon.Frozen = true;
            this.IdHorasGeneradasEscalafon.HeaderText = "IdHorasGeneradasEscalafon";
            this.IdHorasGeneradasEscalafon.Name = "IdHorasGeneradasEscalafon";
            this.IdHorasGeneradasEscalafon.ReadOnly = true;
            this.IdHorasGeneradasEscalafon.Visible = false;
            // 
            // NroEmpleado
            // 
            dataGridViewCellStyle11.Format = "0000";
            this.NroEmpleado.DefaultCellStyle = dataGridViewCellStyle11;
            this.NroEmpleado.Frozen = true;
            this.NroEmpleado.HeaderText = "Nro Empleado";
            this.NroEmpleado.IncludeLiterals = false;
            this.NroEmpleado.IncludePrompt = false;
            this.NroEmpleado.Mask = null;
            this.NroEmpleado.Name = "NroEmpleado";
            this.NroEmpleado.PromptChar = '\0';
            this.NroEmpleado.ReadOnly = true;
            this.NroEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NroEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NroEmpleado.ValidatingType = null;
            this.NroEmpleado.Width = 104;
            // 
            // Funcionario
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Funcionario.DefaultCellStyle = dataGridViewCellStyle12;
            this.Funcionario.Frozen = true;
            this.Funcionario.HeaderText = "Funcionario";
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.ReadOnly = true;
            this.Funcionario.Width = 250;
            // 
            // HoraEntrada
            // 
            dataGridViewCellStyle13.Format = "00:00";
            dataGridViewCellStyle13.NullValue = null;
            this.HoraEntrada.DefaultCellStyle = dataGridViewCellStyle13;
            this.HoraEntrada.Frozen = true;
            this.HoraEntrada.HeaderText = "Hora Entrada";
            this.HoraEntrada.IncludeLiterals = false;
            this.HoraEntrada.IncludePrompt = false;
            this.HoraEntrada.Mask = null;
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.PromptChar = '\0';
            this.HoraEntrada.ReadOnly = true;
            this.HoraEntrada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoraEntrada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HoraEntrada.ValidatingType = null;
            // 
            // HoraSalida
            // 
            dataGridViewCellStyle14.Format = "00:00";
            this.HoraSalida.DefaultCellStyle = dataGridViewCellStyle14;
            this.HoraSalida.Frozen = true;
            this.HoraSalida.HeaderText = "Hora Salida";
            this.HoraSalida.IncludeLiterals = false;
            this.HoraSalida.IncludePrompt = false;
            this.HoraSalida.Mask = null;
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.PromptChar = '\0';
            this.HoraSalida.ReadOnly = true;
            this.HoraSalida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoraSalida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HoraSalida.ValidatingType = null;
            // 
            // menuStripdgvHoras
            // 
            this.menuStripdgvHoras.AllowMerge = false;
            this.menuStripdgvHoras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarFuncionario,
            this.toolStripSeparator2,
            this.cambiarHoraEntrada,
            this.cambiarHoraSalida,
            this.toolStripSeparator1,
            this.agregarFuncionario,
            this.quitarFuncionarioToolStripMenuItem});
            this.menuStripdgvHoras.Name = "menuStripdgvHoras";
            this.menuStripdgvHoras.ShowImageMargin = false;
            this.menuStripdgvHoras.Size = new System.Drawing.Size(167, 126);
            this.menuStripdgvHoras.Opening += new System.ComponentModel.CancelEventHandler(this.menuStripdgvHoras_Opening);
            // 
            // cambiarFuncionario
            // 
            this.cambiarFuncionario.Name = "cambiarFuncionario";
            this.cambiarFuncionario.Size = new System.Drawing.Size(166, 22);
            this.cambiarFuncionario.Text = "Cambiar Funcionario";
            this.cambiarFuncionario.Click += new System.EventHandler(this.cambiarFuncionario_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // cambiarHoraEntrada
            // 
            this.cambiarHoraEntrada.Name = "cambiarHoraEntrada";
            this.cambiarHoraEntrada.Size = new System.Drawing.Size(166, 22);
            this.cambiarHoraEntrada.Text = "Cambiar Hora Entrada";
            this.cambiarHoraEntrada.Click += new System.EventHandler(this.cambiarHoraEntrada_Click);
            // 
            // cambiarHoraSalida
            // 
            this.cambiarHoraSalida.Name = "cambiarHoraSalida";
            this.cambiarHoraSalida.Size = new System.Drawing.Size(166, 22);
            this.cambiarHoraSalida.Text = "Cambiar Hora Salida";
            this.cambiarHoraSalida.Click += new System.EventHandler(this.cambiarHoraSalida_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // agregarFuncionario
            // 
            this.agregarFuncionario.Name = "agregarFuncionario";
            this.agregarFuncionario.Size = new System.Drawing.Size(166, 22);
            this.agregarFuncionario.Text = "Agregar Funcionario";
            this.agregarFuncionario.Click += new System.EventHandler(this.agregarFuncionario_Click);
            // 
            // quitarFuncionarioToolStripMenuItem
            // 
            this.quitarFuncionarioToolStripMenuItem.Name = "quitarFuncionarioToolStripMenuItem";
            this.quitarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.quitarFuncionarioToolStripMenuItem.Text = "Quitar Funcionario";
            this.quitarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.quitarFuncionarioToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarCliente,
            this.tsVerHorasFuncionario,
            this.btnCerrarDia,
            this.btnPermitirModificaciones});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(605, 36);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::ControlHoras.Imagenes.ClientsSearch42x42;
            this.btnBuscarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(79, 33);
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // tsVerHorasFuncionario
            // 
            this.tsVerHorasFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("tsVerHorasFuncionario.Image")));
            this.tsVerHorasFuncionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVerHorasFuncionario.Name = "tsVerHorasFuncionario";
            this.tsVerHorasFuncionario.Size = new System.Drawing.Size(100, 33);
            this.tsVerHorasFuncionario.Text = "Ver Hs Funcionario";
            this.tsVerHorasFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsVerHorasFuncionario.Click += new System.EventHandler(this.tsVerHorasFuncionario_Click);
            // 
            // btnCerrarDia
            // 
            this.btnCerrarDia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrarDia.Enabled = false;
            this.btnCerrarDia.Image = global::ControlHoras.Imagenes.CerrarEscalafon_48x48;
            this.btnCerrarDia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarDia.Name = "btnCerrarDia";
            this.btnCerrarDia.Size = new System.Drawing.Size(60, 33);
            this.btnCerrarDia.Text = "Cerrar Dia";
            this.btnCerrarDia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarDia.Click += new System.EventHandler(this.tsCerrarDia_Click);
            // 
            // btnPermitirModificaciones
            // 
            this.btnPermitirModificaciones.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPermitirModificaciones.Enabled = false;
            this.btnPermitirModificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnPermitirModificaciones.Image")));
            this.btnPermitirModificaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPermitirModificaciones.Name = "btnPermitirModificaciones";
            this.btnPermitirModificaciones.Size = new System.Drawing.Size(119, 33);
            this.btnPermitirModificaciones.Text = "Permitir Modificaciones";
            this.btnPermitirModificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPermitirModificaciones.Click += new System.EventHandler(this.btnPermitirModificaciones_Click);
            // 
            // maskedTextBoxColumn1
            // 
            dataGridViewCellStyle1.Format = "0000";
            this.maskedTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.maskedTextBoxColumn1.Frozen = true;
            this.maskedTextBoxColumn1.HeaderText = "Nro Empleado";
            this.maskedTextBoxColumn1.IncludeLiterals = false;
            this.maskedTextBoxColumn1.IncludePrompt = false;
            this.maskedTextBoxColumn1.Mask = null;
            this.maskedTextBoxColumn1.Name = "maskedTextBoxColumn1";
            this.maskedTextBoxColumn1.PromptChar = '\0';
            this.maskedTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maskedTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.maskedTextBoxColumn1.ValidatingType = null;
            this.maskedTextBoxColumn1.Width = 104;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Funcionario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // maskedTextBoxColumn2
            // 
            dataGridViewCellStyle6.Format = "00:00";
            dataGridViewCellStyle6.NullValue = null;
            this.maskedTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.maskedTextBoxColumn2.Frozen = true;
            this.maskedTextBoxColumn2.HeaderText = "Hora Entrada";
            this.maskedTextBoxColumn2.IncludeLiterals = false;
            this.maskedTextBoxColumn2.IncludePrompt = false;
            this.maskedTextBoxColumn2.Mask = null;
            this.maskedTextBoxColumn2.Name = "maskedTextBoxColumn2";
            this.maskedTextBoxColumn2.PromptChar = '\0';
            this.maskedTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maskedTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.maskedTextBoxColumn2.ValidatingType = null;
            // 
            // maskedTextBoxColumn3
            // 
            dataGridViewCellStyle16.Format = "00:00";
            this.maskedTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle16;
            this.maskedTextBoxColumn3.Frozen = true;
            this.maskedTextBoxColumn3.HeaderText = "Hora Salida";
            this.maskedTextBoxColumn3.IncludeLiterals = false;
            this.maskedTextBoxColumn3.IncludePrompt = false;
            this.maskedTextBoxColumn3.Mask = null;
            this.maskedTextBoxColumn3.Name = "maskedTextBoxColumn3";
            this.maskedTextBoxColumn3.PromptChar = '\0';
            this.maskedTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maskedTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.maskedTextBoxColumn3.ValidatingType = null;
            // 
            // mtServicio
            // 
            this.mtServicio.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtServicio.Location = new System.Drawing.Point(12, 108);
            this.mtServicio.Mask = "9990";
            this.mtServicio.Name = "mtServicio";
            this.mtServicio.Size = new System.Drawing.Size(44, 22);
            this.mtServicio.TabIndex = 2;
            this.mtServicio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtServicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtServicio_KeyDown);
            // 
            // ucCliente
            // 
            this.ucCliente.ClienteNRO = "";
            this.ucCliente.Location = new System.Drawing.Point(12, 65);
            this.ucCliente.Margin = new System.Windows.Forms.Padding(2);
            this.ucCliente.Name = "ucCliente";
            this.ucCliente.Size = new System.Drawing.Size(418, 40);
            this.ucCliente.TabIndex = 1;
            // 
            // PosteriorBTN
            // 
            this.PosteriorBTN.AutoSize = true;
            this.PosteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PosteriorBTN.Location = new System.Drawing.Point(468, 108);
            this.PosteriorBTN.Name = "PosteriorBTN";
            this.PosteriorBTN.Size = new System.Drawing.Size(29, 23);
            this.PosteriorBTN.TabIndex = 14;
            this.PosteriorBTN.Text = ">>";
            this.PosteriorBTN.UseVisualStyleBackColor = true;
            this.PosteriorBTN.Visible = false;
            this.PosteriorBTN.Click += new System.EventHandler(this.PosteriorBTN_Click);
            // 
            // AnteriorBTN
            // 
            this.AnteriorBTN.AutoSize = true;
            this.AnteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnteriorBTN.Location = new System.Drawing.Point(433, 108);
            this.AnteriorBTN.Name = "AnteriorBTN";
            this.AnteriorBTN.Size = new System.Drawing.Size(29, 23);
            this.AnteriorBTN.TabIndex = 13;
            this.AnteriorBTN.Text = "<<";
            this.AnteriorBTN.UseVisualStyleBackColor = true;
            this.AnteriorBTN.Visible = false;
            this.AnteriorBTN.Click += new System.EventHandler(this.AnteriorBTN_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(168, 49);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(0, 16);
            this.lblDia.TabIndex = 18;
            // 
            // mtFecha
            // 
            this.mtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFecha.Location = new System.Drawing.Point(12, 44);
            this.mtFecha.Mask = "00/00/0000";
            this.mtFecha.Name = "mtFecha";
            this.mtFecha.Size = new System.Drawing.Size(70, 22);
            this.mtFecha.TabIndex = 0;
            this.mtFecha.ValidatingType = typeof(System.DateTime);
            this.mtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtFecha_KeyDown);
            // 
            // btnDiaAnterior
            // 
            this.btnDiaAnterior.Location = new System.Drawing.Point(88, 44);
            this.btnDiaAnterior.Name = "btnDiaAnterior";
            this.btnDiaAnterior.Size = new System.Drawing.Size(28, 24);
            this.btnDiaAnterior.TabIndex = 16;
            this.btnDiaAnterior.Text = "<";
            this.btnDiaAnterior.UseVisualStyleBackColor = true;
            this.btnDiaAnterior.Click += new System.EventHandler(this.btnDiaAnterior_Click);
            // 
            // btnDiaSiguiente
            // 
            this.btnDiaSiguiente.Location = new System.Drawing.Point(122, 44);
            this.btnDiaSiguiente.Name = "btnDiaSiguiente";
            this.btnDiaSiguiente.Size = new System.Drawing.Size(28, 24);
            this.btnDiaSiguiente.TabIndex = 17;
            this.btnDiaSiguiente.Text = ">";
            this.btnDiaSiguiente.UseVisualStyleBackColor = true;
            this.btnDiaSiguiente.Click += new System.EventHandler(this.btnDiaSiguiente_Click);
            // 
            // lblEstadoEscalafon
            // 
            this.lblEstadoEscalafon.AutoSize = true;
            this.lblEstadoEscalafon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoEscalafon.ForeColor = System.Drawing.Color.Red;
            this.lblEstadoEscalafon.Location = new System.Drawing.Point(299, 48);
            this.lblEstadoEscalafon.Name = "lblEstadoEscalafon";
            this.lblEstadoEscalafon.Size = new System.Drawing.Size(254, 16);
            this.lblEstadoEscalafon.TabIndex = 19;
            this.lblEstadoEscalafon.Text = "No esta cerrado el escalafón de este día.";
            this.lblEstadoEscalafon.Visible = false;
            // 
            // lblDiaCerrado
            // 
            this.lblDiaCerrado.AutoSize = true;
            this.lblDiaCerrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaCerrado.Location = new System.Drawing.Point(435, 47);
            this.lblDiaCerrado.Name = "lblDiaCerrado";
            this.lblDiaCerrado.Size = new System.Drawing.Size(84, 16);
            this.lblDiaCerrado.TabIndex = 20;
            this.lblDiaCerrado.Text = "Dia Cerrado.";
            this.lblDiaCerrado.Visible = false;
            // 
            // lblPermitirModificaciones
            // 
            this.lblPermitirModificaciones.AutoSize = true;
            this.lblPermitirModificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermitirModificaciones.ForeColor = System.Drawing.Color.Green;
            this.lblPermitirModificaciones.Location = new System.Drawing.Point(435, 74);
            this.lblPermitirModificaciones.Name = "lblPermitirModificaciones";
            this.lblPermitirModificaciones.Size = new System.Drawing.Size(169, 16);
            this.lblPermitirModificaciones.TabIndex = 21;
            this.lblPermitirModificaciones.Text = "Modificaciones Permitidas.";
            this.lblPermitirModificaciones.Visible = false;
            // 
            // ControlDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 389);
            this.Controls.Add(this.lblPermitirModificaciones);
            this.Controls.Add(this.lblDiaCerrado);
            this.Controls.Add(this.lblEstadoEscalafon);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.mtFecha);
            this.Controls.Add(this.btnDiaAnterior);
            this.Controls.Add(this.btnDiaSiguiente);
            this.Controls.Add(this.PosteriorBTN);
            this.Controls.Add(this.AnteriorBTN);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mtServicio);
            this.Controls.Add(this.ucCliente);
            this.Controls.Add(this.dgvHoras);
            this.Controls.Add(this.txtServicio);
            this.Name = "ControlDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ControlDiario";
            this.Load += new System.EventHandler(this.ControlDiario_Load);
            this.Shown += new System.EventHandler(this.ControlDiario_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlDiario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).EndInit();
            this.menuStripdgvHoras.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.DataGridView dgvHoras;
        private System.Windows.Forms.ContextMenuStrip menuStripdgvHoras;
        private System.Windows.Forms.ToolStripMenuItem cambiarFuncionario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cambiarHoraEntrada;
        private System.Windows.Forms.ToolStripMenuItem cambiarHoraSalida;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private MaskedTextBoxKeyDown mtServicio;
        private BúsquedaCliente ucCliente;
        private MaskedTextBoxColumn maskedTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MaskedTextBoxColumn maskedTextBoxColumn2;
        private MaskedTextBoxColumn maskedTextBoxColumn3;
        private System.Windows.Forms.ToolStripMenuItem agregarFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHorasGeneradasEscalafon;
        private MaskedTextBoxColumn NroEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private MaskedTextBoxColumn HoraEntrada;
        private MaskedTextBoxColumn HoraSalida;
        private System.Windows.Forms.ToolStripButton btnBuscarCliente;
        private System.Windows.Forms.Button PosteriorBTN;
        private System.Windows.Forms.Button AnteriorBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsVerHorasFuncionario;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.MaskedTextBox mtFecha;
        private System.Windows.Forms.Button btnDiaAnterior;
        private System.Windows.Forms.Button btnDiaSiguiente;
        private System.Windows.Forms.Label lblEstadoEscalafon;
        private System.Windows.Forms.ToolStripButton btnCerrarDia;
        private System.Windows.Forms.ToolStripButton btnPermitirModificaciones;
        private System.Windows.Forms.Label lblDiaCerrado;
        private System.Windows.Forms.Label lblPermitirModificaciones;
    }
}