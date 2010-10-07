namespace ControlHoras
{
    partial class CRErroresConsolidacionEscalafones
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
            this.crvErrores = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvErrores
            // 
            this.crvErrores.ActiveViewIndex = -1;
            this.crvErrores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvErrores.DisplayGroupTree = false;
            this.crvErrores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvErrores.Location = new System.Drawing.Point(0, 0);
            this.crvErrores.Name = "crvErrores";
            this.crvErrores.SelectionFormula = "";
            this.crvErrores.ShowCloseButton = false;
            this.crvErrores.ShowGroupTreeButton = false;
            this.crvErrores.ShowZoomButton = false;
            this.crvErrores.Size = new System.Drawing.Size(517, 401);
            this.crvErrores.TabIndex = 0;
            this.crvErrores.ViewTimeSelectionFormula = "";
            // 
            // CRErroresConsolidacionEscalafones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 401);
            this.Controls.Add(this.crvErrores);
            this.Name = "CRErroresConsolidacionEscalafones";
            this.Text = "CRErroresConsolidacionEscalafones";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvErrores;
    }
}