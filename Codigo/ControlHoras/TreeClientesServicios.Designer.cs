﻿namespace ControlHoras
{
    partial class TreeClientesServicios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvClientesServicios = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDeseleccionarTodos = new System.Windows.Forms.Button();
            this.btnSeleccionarTodos = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvClientesServicios
            // 
            this.tvClientesServicios.CheckBoxes = true;
            this.tvClientesServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvClientesServicios.FullRowSelect = true;
            this.tvClientesServicios.Location = new System.Drawing.Point(0, 0);
            this.tvClientesServicios.Name = "tvClientesServicios";
            this.tvClientesServicios.Size = new System.Drawing.Size(333, 270);
            this.tvClientesServicios.TabIndex = 0;
            this.tvClientesServicios.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvClientesServicios_AfterCheck);
            this.tvClientesServicios.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvClientesServicios_NodeMouseClick);
            this.tvClientesServicios.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvClientesServicios_BeforeCheck);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvClientesServicios);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDeseleccionarTodos);
            this.splitContainer1.Panel2.Controls.Add(this.btnSeleccionarTodos);
            this.splitContainer1.Size = new System.Drawing.Size(333, 299);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnDeseleccionarTodos
            // 
            this.btnDeseleccionarTodos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDeseleccionarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionarTodos.Location = new System.Drawing.Point(175, 2);
            this.btnDeseleccionarTodos.Name = "btnDeseleccionarTodos";
            this.btnDeseleccionarTodos.Size = new System.Drawing.Size(117, 23);
            this.btnDeseleccionarTodos.TabIndex = 1;
            this.btnDeseleccionarTodos.Text = "Deseleccionar Todos";
            this.btnDeseleccionarTodos.UseVisualStyleBackColor = false;
            this.btnDeseleccionarTodos.Click += new System.EventHandler(this.btnDeseleccionarTodos_Click);
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSeleccionarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(41, 2);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(117, 23);
            this.btnSeleccionarTodos.TabIndex = 0;
            this.btnSeleccionarTodos.Text = "Seleccionar Todos";
            this.btnSeleccionarTodos.UseVisualStyleBackColor = false;
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // TreeClientesServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TreeClientesServicios";
            this.Size = new System.Drawing.Size(333, 299);
            this.Load += new System.EventHandler(this.TreeClientesServicios_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvClientesServicios;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDeseleccionarTodos;
        private System.Windows.Forms.Button btnSeleccionarTodos;
    }
}
