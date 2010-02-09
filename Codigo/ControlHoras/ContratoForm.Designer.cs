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
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CancelarBTN = new System.Windows.Forms.ToolStripButton();
            this.GuardarBTN = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CostoCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HorasExtrasCHK = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClienteGB = new System.Windows.Forms.GroupBox();
            this.ServicioGB = new System.Windows.Forms.GroupBox();
            this.PosteriorBTN = new System.Windows.Forms.Button();
            this.AnteriorBTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NroMTB = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FinCKB = new System.Windows.Forms.CheckBox();
            this.CargaHorariaCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.marcarNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NombreTB = new ControlHoras.TextBoxKeyDown();
            this.bcUC = new ControlHoras.BúsquedaCliente();
            this.ObsTB = new ControlHoras.TextBoxKeyDown();
            this.AjusteTB = new ControlHoras.TextBoxKeyDown();
            this.MontoTB = new ControlHoras.TextBoxKeyDown();
            this.CargaHorariaDGV = new ControlHoras.DataGridTAB();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Armado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioXHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FfinDTP = new System.Windows.Forms.DateTimePicker();
            this.FIniMTB = new ControlHoras.MaskedTextBoxKeyDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.ClienteGB.SuspendLayout();
            this.ServicioGB.SuspendLayout();
            this.CargaHorariaCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CargaHorariaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
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
            this.toolStrip1.Size = new System.Drawing.Size(1267, 40);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CancelarBTN.Image = global::ControlHoras.Imagenes.button_cancel;
            this.CancelarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(64, 37);
            this.CancelarBTN.Text = "Cancelar";
            this.CancelarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // GuardarBTN
            // 
            this.GuardarBTN.Enabled = false;
            this.GuardarBTN.Image = global::ControlHoras.Imagenes.filesave;
            this.GuardarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarBTN.Name = "GuardarBTN";
            this.GuardarBTN.Size = new System.Drawing.Size(61, 37);
            this.GuardarBTN.Text = "Guardar";
            this.GuardarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarBTN.Click += new System.EventHandler(this.GuardarBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Carga Horaria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Costo ";
            // 
            // CostoCB
            // 
            this.CostoCB.FormattingEnabled = true;
            this.CostoCB.Items.AddRange(new object[] {
            "variable",
            "fijo"});
            this.CostoCB.Location = new System.Drawing.Point(67, 550);
            this.CostoCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CostoCB.Name = "CostoCB";
            this.CostoCB.Size = new System.Drawing.Size(121, 24);
            this.CostoCB.TabIndex = 5;
            this.CostoCB.SelectedValueChanged += new System.EventHandler(this.CostoCB_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1091, 645);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Monto: ";
            // 
            // HorasExtrasCHK
            // 
            this.HorasExtrasCHK.AutoSize = true;
            this.HorasExtrasCHK.Location = new System.Drawing.Point(272, 553);
            this.HorasExtrasCHK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HorasExtrasCHK.Name = "HorasExtrasCHK";
            this.HorasExtrasCHK.Size = new System.Drawing.Size(108, 21);
            this.HorasExtrasCHK.TabIndex = 6;
            this.HorasExtrasCHK.Text = "Horas Extras";
            this.HorasExtrasCHK.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ajuste:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 623);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Observaciones:";
            // 
            // ClienteGB
            // 
            this.ClienteGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClienteGB.Controls.Add(this.bcUC);
            this.ClienteGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteGB.Location = new System.Drawing.Point(16, 50);
            this.ClienteGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClienteGB.Name = "ClienteGB";
            this.ClienteGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClienteGB.Size = new System.Drawing.Size(712, 74);
            this.ClienteGB.TabIndex = 0;
            this.ClienteGB.TabStop = false;
            this.ClienteGB.Text = "Cliente";
            // 
            // ServicioGB
            // 
            this.ServicioGB.Controls.Add(this.PosteriorBTN);
            this.ServicioGB.Controls.Add(this.AnteriorBTN);
            this.ServicioGB.Controls.Add(this.label8);
            this.ServicioGB.Controls.Add(this.NombreTB);
            this.ServicioGB.Controls.Add(this.NroMTB);
            this.ServicioGB.Controls.Add(this.label9);
            this.ServicioGB.Enabled = false;
            this.ServicioGB.Location = new System.Drawing.Point(19, 132);
            this.ServicioGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServicioGB.Name = "ServicioGB";
            this.ServicioGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServicioGB.Size = new System.Drawing.Size(709, 102);
            this.ServicioGB.TabIndex = 20;
            this.ServicioGB.TabStop = false;
            this.ServicioGB.Text = "Servicio";
            // 
            // PosteriorBTN
            // 
            this.PosteriorBTN.AutoSize = true;
            this.PosteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PosteriorBTN.Location = new System.Drawing.Point(359, 64);
            this.PosteriorBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PosteriorBTN.Name = "PosteriorBTN";
            this.PosteriorBTN.Size = new System.Drawing.Size(34, 27);
            this.PosteriorBTN.TabIndex = 11;
            this.PosteriorBTN.Text = ">>";
            this.PosteriorBTN.UseVisualStyleBackColor = true;
            this.PosteriorBTN.Visible = false;
            this.PosteriorBTN.Click += new System.EventHandler(this.PosteriorBTN_Click);
            // 
            // AnteriorBTN
            // 
            this.AnteriorBTN.AutoSize = true;
            this.AnteriorBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnteriorBTN.Location = new System.Drawing.Point(312, 64);
            this.AnteriorBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnteriorBTN.Name = "AnteriorBTN";
            this.AnteriorBTN.Size = new System.Drawing.Size(34, 27);
            this.AnteriorBTN.TabIndex = 10;
            this.AnteriorBTN.Text = "<<";
            this.AnteriorBTN.UseVisualStyleBackColor = true;
            this.AnteriorBTN.Visible = false;
            this.AnteriorBTN.Click += new System.EventHandler(this.AnteriorBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre:";
            // 
            // NroMTB
            // 
            this.NroMTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NroMTB.Location = new System.Drawing.Point(52, 23);
            this.NroMTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NroMTB.Mask = "9990";
            this.NroMTB.Name = "NroMTB";
            this.NroMTB.Size = new System.Drawing.Size(57, 25);
            this.NroMTB.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nro:";
            // 
            // FinCKB
            // 
            this.FinCKB.AutoSize = true;
            this.FinCKB.Location = new System.Drawing.Point(559, 268);
            this.FinCKB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FinCKB.Name = "FinCKB";
            this.FinCKB.Size = new System.Drawing.Size(50, 21);
            this.FinCKB.TabIndex = 2;
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
            this.CargaHorariaCMS.Size = new System.Drawing.Size(162, 76);
            this.CargaHorariaCMS.Text = "Menú";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // marcarNTToolStripMenuItem
            // 
            this.marcarNTToolStripMenuItem.Name = "marcarNTToolStripMenuItem";
            this.marcarNTToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.marcarNTToolStripMenuItem.Text = "Marcar N/T ";
            this.marcarNTToolStripMenuItem.Click += new System.EventHandler(this.marcarNTToolStripMenuItem_Click);
            // 
            // NombreTB
            // 
            this.NombreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTB.Location = new System.Drawing.Point(212, 23);
            this.NombreTB.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(481, 25);
            this.NombreTB.TabIndex = 8;
            // 
            // bcUC
            // 
            this.bcUC.ClienteNRO = "";
            this.bcUC.Location = new System.Drawing.Point(4, 18);
            this.bcUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bcUC.Name = "bcUC";
            this.bcUC.Size = new System.Drawing.Size(707, 50);
            this.bcUC.TabIndex = 0;
            // 
            // ObsTB
            // 
            this.ObsTB.Location = new System.Drawing.Point(125, 623);
            this.ObsTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ObsTB.Multiline = true;
            this.ObsTB.Name = "ObsTB";
            this.ObsTB.Size = new System.Drawing.Size(699, 43);
            this.ObsTB.TabIndex = 8;
            // 
            // AjusteTB
            // 
            this.AjusteTB.Location = new System.Drawing.Point(509, 550);
            this.AjusteTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AjusteTB.Multiline = true;
            this.AjusteTB.Name = "AjusteTB";
            this.AjusteTB.Size = new System.Drawing.Size(315, 43);
            this.AjusteTB.TabIndex = 7;
            // 
            // MontoTB
            // 
            this.MontoTB.Location = new System.Drawing.Point(1151, 642);
            this.MontoTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MontoTB.Name = "MontoTB";
            this.MontoTB.ReadOnly = true;
            this.MontoTB.Size = new System.Drawing.Size(100, 22);
            this.MontoTB.TabIndex = 9;
            // 
            // CargaHorariaDGV
            // 
            this.CargaHorariaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CargaHorariaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Puesto,
            this.Armado,
            this.Cantidad,
            this.PrecioXHora});
            this.CargaHorariaDGV.Location = new System.Drawing.Point(15, 329);
            this.CargaHorariaDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CargaHorariaDGV.Name = "CargaHorariaDGV";
            this.CargaHorariaDGV.RowTemplate.Height = 24;
            this.CargaHorariaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CargaHorariaDGV.Size = new System.Drawing.Size(1237, 194);
            this.CargaHorariaDGV.TabIndex = 4;
            this.CargaHorariaDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CargaHorariaDGV_CellMouseClick);
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Armado
            // 
            this.Armado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Armado.HeaderText = "Armado";
            this.Armado.Name = "Armado";
            this.Armado.Width = 63;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 70;
            // 
            // PrecioXHora
            // 
            this.PrecioXHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecioXHora.HeaderText = "Precio X Hora";
            this.PrecioXHora.Name = "PrecioXHora";
            this.PrecioXHora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrecioXHora.Width = 102;
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
            // FfinDTP
            // 
            this.FfinDTP.Enabled = false;
            this.FfinDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FfinDTP.Location = new System.Drawing.Point(616, 265);
            this.FfinDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FfinDTP.Name = "FfinDTP";
            this.FfinDTP.Size = new System.Drawing.Size(115, 22);
            this.FfinDTP.TabIndex = 3;
            // 
            // FIniMTB
            // 
            this.FIniMTB.Location = new System.Drawing.Point(62, 265);
            this.FIniMTB.Mask = "00/00/0000";
            this.FIniMTB.Name = "FIniMTB";
            this.FIniMTB.Size = new System.Drawing.Size(100, 22);
            this.FIniMTB.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ContratoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 724);
            this.Controls.Add(this.FIniMTB);
            this.Controls.Add(this.FinCKB);
            this.Controls.Add(this.ServicioGB);
            this.Controls.Add(this.ClienteGB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ObsTB);
            this.Controls.Add(this.AjusteTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HorasExtrasCHK);
            this.Controls.Add(this.MontoTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CostoCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CargaHorariaDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FfinDTP);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ContratoForm";
            this.Text = "ContratoForm";
            this.Shown += new System.EventHandler(this.ContratoForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ClienteGB.ResumeLayout(false);
            this.ServicioGB.ResumeLayout(false);
            this.ServicioGB.PerformLayout();
            this.CargaHorariaCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CargaHorariaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private TextBoxKeyDown MontoTB;
        private System.Windows.Forms.CheckBox HorasExtrasCHK;
        private System.Windows.Forms.Label label6;
        private TextBoxKeyDown AjusteTB;
        private TextBoxKeyDown ObsTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Armado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioXHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox ClienteGB;
        private BúsquedaCliente bcUC;
        private System.Windows.Forms.GroupBox ServicioGB;
        private System.Windows.Forms.Button PosteriorBTN;
        private System.Windows.Forms.Button AnteriorBTN;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.DateTimePicker FfinDTP;
        private MaskedTextBoxKeyDown FIniMTB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}