﻿namespace ControlHoras
{
    partial class Search_Clientes
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
            this.label7 = new System.Windows.Forms.Label();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OKBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ingrese nombre o parte de él:";
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(157, 10);
            this.NombreTB.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(136, 20);
            this.NombreTB.TabIndex = 0;
            this.NombreTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NombreTB_KeyDown);
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.AllowUserToAddRows = false;
            this.ClientesDGV.AllowUserToDeleteRows = false;
            this.ClientesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Nro});
            this.ClientesDGV.Location = new System.Drawing.Point(8, 44);
            this.ClientesDGV.Margin = new System.Windows.Forms.Padding(2);
            this.ClientesDGV.MultiSelect = false;
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.ReadOnly = true;
            this.ClientesDGV.RowTemplate.Height = 24;
            this.ClientesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesDGV.Size = new System.Drawing.Size(284, 150);
            this.ClientesDGV.TabIndex = 21;
            this.ClientesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDGV_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Nro
            // 
            this.Nro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nro.HeaderText = "Número";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Width = 69;
            // 
            // OKBTN
            // 
            this.OKBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBTN.Enabled = false;
            this.OKBTN.Location = new System.Drawing.Point(236, 216);
            this.OKBTN.Margin = new System.Windows.Forms.Padding(2);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(56, 19);
            this.OKBTN.TabIndex = 22;
            this.OKBTN.Text = "Aceptar";
            this.OKBTN.UseVisualStyleBackColor = true;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Location = new System.Drawing.Point(9, 216);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(56, 19);
            this.CancelBTN.TabIndex = 23;
            this.CancelBTN.Text = "Cancelar";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Número";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Search_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 245);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.ClientesDGV);
            this.Controls.Add(this.NombreTB);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Búsqueda de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.DataGridView ClientesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button OKBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
    }
}