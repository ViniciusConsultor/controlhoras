namespace ControlHoras
{
    partial class ContratoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContratoForm));
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CancelarBTN = new System.Windows.Forms.ToolStripButton();
            this.GuardarBTN = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CostoCB = new System.Windows.Forms.ComboBox();
            this.MontoLBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClienteGB = new System.Windows.Forms.GroupBox();
            this.ServicioGB = new System.Windows.Forms.GroupBox();
            this.PosteriorBTN = new System.Windows.Forms.Button();
            this.AnteriorBTN = new System.Windows.Forms.Button();
            this.NroMTB = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FinCKB = new System.Windows.Forms.CheckBox();
            this.CargaHorariaCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.marcarNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PagaDescansoCKBX = new System.Windows.Forms.CheckBox();
            this.HorasExtrasCHK = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDespuesDeHs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreTB = new ControlHoras.TextBoxKeyDown();
            this.FFinMTB = new ControlHoras.MaskedTextBoxKeyDown();
            this.bcUC = new ControlHoras.BúsquedaCliente();
            this.FIniMTB = new ControlHoras.MaskedTextBoxKeyDown();
            this.ObsTB = new ControlHoras.TextBoxKeyDown();
            this.AjusteTB = new ControlHoras.TextBoxKeyDown();
            this.CargaHorariaDGV = new ControlHoras.DataGridTAB();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Armado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MontoTB = new ControlHoras.TextBoxKeyDown();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.ClienteGB.SuspendLayout();
            this.ServicioGB.SuspendLayout();
            this.CargaHorariaCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CargaHorariaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Inicio:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelarBTN,
            this.GuardarBTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(987, 36);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CancelarBTN.Image = ((System.Drawing.Image)(resources.GetObject("CancelarBTN.Image")));
            this.CancelarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(53, 33);
            this.CancelarBTN.Text = "Cancelar";
            this.CancelarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // GuardarBTN
            // 
            this.GuardarBTN.Enabled = false;
            this.GuardarBTN.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBTN.Image")));
            this.GuardarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarBTN.Name = "GuardarBTN";
            this.GuardarBTN.Size = new System.Drawing.Size(50, 33);
            this.GuardarBTN.Text = "Guardar";
            this.GuardarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarBTN.Click += new System.EventHandler(this.GuardarBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Carga Horaria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Costo ";
            // 
            // CostoCB
            // 
            this.CostoCB.FormattingEnabled = true;
            this.CostoCB.Items.AddRange(new object[] {
            "Variable",
            "Fijo"});
            this.CostoCB.Location = new System.Drawing.Point(81, 384);
            this.CostoCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CostoCB.Name = "CostoCB";
            this.CostoCB.Size = new System.Drawing.Size(80, 21);
            this.CostoCB.TabIndex = 6;
            this.CostoCB.SelectedValueChanged += new System.EventHandler(this.CostoCB_SelectedValueChanged);
            // 
            // MontoLBL
            // 
            this.MontoLBL.AutoSize = true;
            this.MontoLBL.Location = new System.Drawing.Point(40, 411);
            this.MontoLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MontoLBL.Name = "MontoLBL";
            this.MontoLBL.Size = new System.Drawing.Size(43, 13);
            this.MontoLBL.TabIndex = 12;
            this.MontoLBL.Text = "Monto: ";
            this.MontoLBL.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ajuste:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 411);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Observaciones:";
            // 
            // ClienteGB
            // 
            this.ClienteGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClienteGB.Controls.Add(this.bcUC);
            this.ClienteGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteGB.Location = new System.Drawing.Point(12, 41);
            this.ClienteGB.Name = "ClienteGB";
            this.ClienteGB.Size = new System.Drawing.Size(619, 60);
            this.ClienteGB.TabIndex = 0;
            this.ClienteGB.TabStop = false;
            this.ClienteGB.Text = "Cliente";
            // 
            // ServicioGB
            // 
            this.ServicioGB.Controls.Add(this.PosteriorBTN);
            this.ServicioGB.Controls.Add(this.AnteriorBTN);
            this.ServicioGB.Controls.Add(this.NombreTB);
            this.ServicioGB.Controls.Add(this.NroMTB);
            this.ServicioGB.Controls.Add(this.label9);
            this.ServicioGB.Enabled = false;
            this.ServicioGB.Location = new System.Drawing.Point(12, 107);
            this.ServicioGB.Name = "ServicioGB";
            this.ServicioGB.Size = new System.Drawing.Size(619, 50);
            this.ServicioGB.TabIndex = 1;
            this.ServicioGB.TabStop = false;
            this.ServicioGB.Text = "Servicio";
            // 
            // PosteriorBTN
            // 
            this.PosteriorBTN.AutoSize = true;
            this.PosteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PosteriorBTN.Location = new System.Drawing.Point(572, 16);
            this.PosteriorBTN.Name = "PosteriorBTN";
            this.PosteriorBTN.Size = new System.Drawing.Size(29, 23);
            this.PosteriorBTN.TabIndex = 1;
            this.PosteriorBTN.Text = ">>";
            this.PosteriorBTN.UseVisualStyleBackColor = true;
            this.PosteriorBTN.Visible = false;
            this.PosteriorBTN.Click += new System.EventHandler(this.PosteriorBTN_Click);
            // 
            // AnteriorBTN
            // 
            this.AnteriorBTN.AutoSize = true;
            this.AnteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnteriorBTN.Location = new System.Drawing.Point(541, 16);
            this.AnteriorBTN.Name = "AnteriorBTN";
            this.AnteriorBTN.Size = new System.Drawing.Size(29, 23);
            this.AnteriorBTN.TabIndex = 0;
            this.AnteriorBTN.Text = "<<";
            this.AnteriorBTN.UseVisualStyleBackColor = true;
            this.AnteriorBTN.Visible = false;
            this.AnteriorBTN.Click += new System.EventHandler(this.AnteriorBTN_Click);
            // 
            // NroMTB
            // 
            this.NroMTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroMTB.Location = new System.Drawing.Point(39, 16);
            this.NroMTB.Mask = "9990";
            this.NroMTB.Name = "NroMTB";
            this.NroMTB.Size = new System.Drawing.Size(44, 22);
            this.NroMTB.TabIndex = 6;
            this.NroMTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NroMTB_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nro:";
            // 
            // FinCKB
            // 
            this.FinCKB.AutoSize = true;
            this.FinCKB.Location = new System.Drawing.Point(803, 128);
            this.FinCKB.Name = "FinCKB";
            this.FinCKB.Size = new System.Drawing.Size(43, 17);
            this.FinCKB.TabIndex = 3;
            this.FinCKB.Text = "Fin:";
            this.FinCKB.UseVisualStyleBackColor = true;
            this.FinCKB.CheckedChanged += new System.EventHandler(this.FinCKB_CheckedChanged);
            // 
            // CargaHorariaCMS
            // 
            this.CargaHorariaCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripSeparator1,
            this.marcarNTToolStripMenuItem});
            this.CargaHorariaCMS.Name = "contextMenuStrip1";
            this.CargaHorariaCMS.Size = new System.Drawing.Size(142, 76);
            this.CargaHorariaCMS.Text = "Menú";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // marcarNTToolStripMenuItem
            // 
            this.marcarNTToolStripMenuItem.Name = "marcarNTToolStripMenuItem";
            this.marcarNTToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.marcarNTToolStripMenuItem.Text = "Marcar N/T ";
            this.marcarNTToolStripMenuItem.Click += new System.EventHandler(this.marcarNTToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PagaDescansoCKBX
            // 
            this.PagaDescansoCKBX.AutoSize = true;
            this.PagaDescansoCKBX.Location = new System.Drawing.Point(43, 437);
            this.PagaDescansoCKBX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PagaDescansoCKBX.Name = "PagaDescansoCKBX";
            this.PagaDescansoCKBX.Size = new System.Drawing.Size(105, 17);
            this.PagaDescansoCKBX.TabIndex = 19;
            this.PagaDescansoCKBX.Text = "1/2 H Descanso";
            this.PagaDescansoCKBX.UseVisualStyleBackColor = true;
            // 
            // HorasExtrasCHK
            // 
            this.HorasExtrasCHK.AutoSize = true;
            this.HorasExtrasCHK.Location = new System.Drawing.Point(31, 9);
            this.HorasExtrasCHK.Margin = new System.Windows.Forms.Padding(2);
            this.HorasExtrasCHK.Name = "HorasExtrasCHK";
            this.HorasExtrasCHK.Size = new System.Drawing.Size(86, 17);
            this.HorasExtrasCHK.TabIndex = 20;
            this.HorasExtrasCHK.Text = "Horas Extras";
            this.HorasExtrasCHK.UseVisualStyleBackColor = true;
            this.HorasExtrasCHK.CheckedChanged += new System.EventHandler(this.HorasExtrasCHK_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbDespuesDeHs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HorasExtrasCHK);
            this.panel1.Location = new System.Drawing.Point(180, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 57);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Extras despues de";
            // 
            // cmbDespuesDeHs
            // 
            this.cmbDespuesDeHs.Enabled = false;
            this.cmbDespuesDeHs.FormattingEnabled = true;
            this.cmbDespuesDeHs.Items.AddRange(new object[] {
            "8",
            "12"});
            this.cmbDespuesDeHs.Location = new System.Drawing.Point(101, 31);
            this.cmbDespuesDeHs.Name = "cmbDespuesDeHs";
            this.cmbDespuesDeHs.Size = new System.Drawing.Size(42, 21);
            this.cmbDespuesDeHs.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Hs";
            // 
            // NombreTB
            // 
            this.NombreTB.BackColor = System.Drawing.SystemColors.Window;
            this.NombreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTB.Location = new System.Drawing.Point(95, 16);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.ReadOnly = true;
            this.NombreTB.Size = new System.Drawing.Size(426, 22);
            this.NombreTB.TabIndex = 8;
            // 
            // FFinMTB
            // 
            this.FFinMTB.Enabled = false;
            this.FFinMTB.Location = new System.Drawing.Point(851, 126);
            this.FFinMTB.Margin = new System.Windows.Forms.Padding(2);
            this.FFinMTB.Mask = "00/00/0000";
            this.FFinMTB.Name = "FFinMTB";
            this.FFinMTB.Size = new System.Drawing.Size(76, 20);
            this.FFinMTB.TabIndex = 4;
            this.FFinMTB.Validating += new System.ComponentModel.CancelEventHandler(this.FFinMTB_Validating);
            this.FFinMTB.Validated += new System.EventHandler(this.FFinMTB_Validated);
            // 
            // bcUC
            // 
            this.bcUC.ClienteNRO = "";
            this.bcUC.Location = new System.Drawing.Point(39, 14);
            this.bcUC.Margin = new System.Windows.Forms.Padding(2);
            this.bcUC.Name = "bcUC";
            this.bcUC.Size = new System.Drawing.Size(480, 41);
            this.bcUC.TabIndex = 0;
            // 
            // FIniMTB
            // 
            this.FIniMTB.Location = new System.Drawing.Point(690, 126);
            this.FIniMTB.Margin = new System.Windows.Forms.Padding(2);
            this.FIniMTB.Mask = "00/00/0000";
            this.FIniMTB.Name = "FIniMTB";
            this.FIniMTB.Size = new System.Drawing.Size(76, 20);
            this.FIniMTB.TabIndex = 2;
            this.FIniMTB.Validating += new System.ComponentModel.CancelEventHandler(this.FIniMTB_Validating);
            this.FIniMTB.Validated += new System.EventHandler(this.FIniMTB_Validated);
            this.FIniMTB.Leave += new System.EventHandler(this.FIniMTB_Leave);
            // 
            // ObsTB
            // 
            this.ObsTB.Location = new System.Drawing.Point(443, 411);
            this.ObsTB.Margin = new System.Windows.Forms.Padding(2);
            this.ObsTB.MaxLength = 255;
            this.ObsTB.Multiline = true;
            this.ObsTB.Name = "ObsTB";
            this.ObsTB.Size = new System.Drawing.Size(525, 36);
            this.ObsTB.TabIndex = 10;
            // 
            // AjusteTB
            // 
            this.AjusteTB.Location = new System.Drawing.Point(443, 384);
            this.AjusteTB.Margin = new System.Windows.Forms.Padding(2);
            this.AjusteTB.MaxLength = 255;
            this.AjusteTB.Multiline = true;
            this.AjusteTB.Name = "AjusteTB";
            this.AjusteTB.Size = new System.Drawing.Size(525, 21);
            this.AjusteTB.TabIndex = 9;
            // 
            // CargaHorariaDGV
            // 
            this.CargaHorariaDGV.AllowUserToDeleteRows = false;
            this.CargaHorariaDGV.AllowUserToResizeColumns = false;
            this.CargaHorariaDGV.AllowUserToResizeRows = false;
            this.CargaHorariaDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.CargaHorariaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CargaHorariaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Puesto,
            this.Armado});
            this.CargaHorariaDGV.Location = new System.Drawing.Point(9, 179);
            this.CargaHorariaDGV.Margin = new System.Windows.Forms.Padding(2);
            this.CargaHorariaDGV.Name = "CargaHorariaDGV";
            this.CargaHorariaDGV.RowHeadersVisible = false;
            this.CargaHorariaDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CargaHorariaDGV.RowTemplate.Height = 24;
            this.CargaHorariaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CargaHorariaDGV.Size = new System.Drawing.Size(976, 195);
            this.CargaHorariaDGV.TabIndex = 5;
            this.CargaHorariaDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CargaHorariaDGV_CellMouseClick);
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Tarea";
            this.Puesto.Name = "Puesto";
            this.Puesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Armado
            // 
            this.Armado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Armado.FalseValue = "0";
            this.Armado.HeaderText = "Armado";
            this.Armado.IndeterminateValue = "0";
            this.Armado.Name = "Armado";
            this.Armado.TrueValue = "1";
            this.Armado.Width = 49;
            // 
            // MontoTB
            // 
            this.MontoTB.Location = new System.Drawing.Point(81, 407);
            this.MontoTB.Margin = new System.Windows.Forms.Padding(2);
            this.MontoTB.Name = "MontoTB";
            this.MontoTB.Size = new System.Drawing.Size(80, 20);
            this.MontoTB.TabIndex = 7;
            this.MontoTB.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Puesto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio X Hora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContratoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(987, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PagaDescansoCKBX);
            this.Controls.Add(this.ServicioGB);
            this.Controls.Add(this.FFinMTB);
            this.Controls.Add(this.ClienteGB);
            this.Controls.Add(this.FIniMTB);
            this.Controls.Add(this.CostoCB);
            this.Controls.Add(this.FinCKB);
            this.Controls.Add(this.ObsTB);
            this.Controls.Add(this.AjusteTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CargaHorariaDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MontoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MontoLBL);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContratoForm";
            this.Text = "ContratoForm";
            this.Load += new System.EventHandler(this.ContratoForm_Load);
            this.Shown += new System.EventHandler(this.ContratoForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ClienteGB.ResumeLayout(false);
            this.ServicioGB.ResumeLayout(false);
            this.ServicioGB.PerformLayout();
            this.CargaHorariaCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CargaHorariaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ControlHoras.DataGridTAB CargaHorariaDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CostoCB;
        private System.Windows.Forms.Label MontoLBL;
        private TextBoxKeyDown MontoTB;
        private System.Windows.Forms.Label label6;
        private TextBoxKeyDown AjusteTB;
        private TextBoxKeyDown ObsTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox ClienteGB;        
        private System.Windows.Forms.GroupBox ServicioGB;
        private System.Windows.Forms.Button PosteriorBTN;
        private System.Windows.Forms.Button AnteriorBTN;
        private TextBoxKeyDown NombreTB;
        private System.Windows.Forms.MaskedTextBox NroMTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox FinCKB;
        private System.Windows.Forms.ToolStripButton CancelarBTN;
        private System.Windows.Forms.ToolStripButton GuardarBTN;
        private System.Windows.Forms.ContextMenuStrip CargaHorariaCMS;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem marcarNTToolStripMenuItem;
        private MaskedTextBoxKeyDown FIniMTB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaskedTextBoxKeyDown FFinMTB;
        private BúsquedaCliente bcUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Armado;
        private System.Windows.Forms.CheckBox PagaDescansoCKBX;
        private System.Windows.Forms.CheckBox HorasExtrasCHK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDespuesDeHs;
    }
}