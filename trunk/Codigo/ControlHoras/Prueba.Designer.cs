namespace ControlHoras
{
    partial class Prueba
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.HTB = new System.Windows.Forms.TextBox();
            this.mtbkd = new ControlHoras.MaskedTextBoxKeyDown();
            this.Hini1 = new ControlHoras.MaskedTextBoxKeyDown();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxColumn1 = new ControlHoras.MaskedTextBoxColumn();
            this.difbtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.res2TB = new System.Windows.Forms.TextBox();
            this.res3TB = new System.Windows.Forms.TextBox();
            this.Hfin1 = new ControlHoras.MaskedTextBoxKeyDown();
            this.Hini2 = new ControlHoras.MaskedTextBoxKeyDown();
            this.Hfin2 = new ControlHoras.MaskedTextBoxKeyDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HTB
            // 
            this.HTB.Location = new System.Drawing.Point(325, 153);
            this.HTB.Multiline = true;
            this.HTB.Name = "HTB";
            this.HTB.Size = new System.Drawing.Size(215, 92);
            this.HTB.TabIndex = 2;
            // 
            // mtbkd
            // 
            this.mtbkd.Location = new System.Drawing.Point(55, 12);
            this.mtbkd.Name = "mtbkd";
            this.mtbkd.Size = new System.Drawing.Size(100, 22);
            this.mtbkd.TabIndex = 0;
            // 
            // Hini1
            // 
            this.Hini1.Location = new System.Drawing.Point(55, 153);
            this.Hini1.Mask = "00:00";
            this.Hini1.Name = "Hini1";
            this.Hini1.Size = new System.Drawing.Size(100, 22);
            this.Hini1.TabIndex = 0;
            this.Hini1.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxKeyDown1_Validating);
            this.Hini1.Validated += new System.EventHandler(this.HoraTB_Validated);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Puesto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // maskedTextBoxColumn1
            // 
            this.maskedTextBoxColumn1.HeaderText = "Lunes";
            this.maskedTextBoxColumn1.IncludeLiterals = false;
            this.maskedTextBoxColumn1.IncludePrompt = false;
            this.maskedTextBoxColumn1.Mask = null;
            this.maskedTextBoxColumn1.Name = "maskedTextBoxColumn1";
            this.maskedTextBoxColumn1.PromptChar = '\0';
            this.maskedTextBoxColumn1.ValidatingType = null;
            // 
            // difbtn
            // 
            this.difbtn.Location = new System.Drawing.Point(55, 333);
            this.difbtn.Margin = new System.Windows.Forms.Padding(4);
            this.difbtn.Name = "difbtn";
            this.difbtn.Size = new System.Drawing.Size(100, 28);
            this.difbtn.TabIndex = 4;
            this.difbtn.Text = "button2";
            this.difbtn.UseVisualStyleBackColor = true;
            this.difbtn.Click += new System.EventHandler(this.difbtn_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(201, 339);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 9;
            // 
            // res2TB
            // 
            this.res2TB.Location = new System.Drawing.Point(469, 313);
            this.res2TB.Name = "res2TB";
            this.res2TB.Size = new System.Drawing.Size(100, 22);
            this.res2TB.TabIndex = 10;
            // 
            // res3TB
            // 
            this.res3TB.Location = new System.Drawing.Point(606, 313);
            this.res3TB.Name = "res3TB";
            this.res3TB.Size = new System.Drawing.Size(100, 22);
            this.res3TB.TabIndex = 11;
            // 
            // Hfin1
            // 
            this.Hfin1.Location = new System.Drawing.Point(55, 181);
            this.Hfin1.Mask = "00:00";
            this.Hfin1.Name = "Hfin1";
            this.Hfin1.Size = new System.Drawing.Size(100, 22);
            this.Hfin1.TabIndex = 1;
            // 
            // Hini2
            // 
            this.Hini2.Location = new System.Drawing.Point(55, 242);
            this.Hini2.Mask = "00:00";
            this.Hini2.Name = "Hini2";
            this.Hini2.Size = new System.Drawing.Size(100, 22);
            this.Hini2.TabIndex = 2;
            // 
            // Hfin2
            // 
            this.Hfin2.Location = new System.Drawing.Point(55, 284);
            this.Hfin2.Mask = "00:00";
            this.Hfin2.Name = "Hfin2";
            this.Hfin2.Size = new System.Drawing.Size(100, 22);
            this.Hfin2.TabIndex = 3;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 443);
            this.Controls.Add(this.Hfin2);
            this.Controls.Add(this.Hini2);
            this.Controls.Add(this.Hfin1);
            this.Controls.Add(this.res3TB);
            this.Controls.Add(this.res2TB);
            this.Controls.Add(this.result);
            this.Controls.Add(this.difbtn);
            this.Controls.Add(this.mtbkd);
            this.Controls.Add(this.HTB);
            this.Controls.Add(this.Hini1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prueba";
            this.Text = "Prueba";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MaskedTextBoxColumn maskedTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private MaskedTextBoxKeyDown Hini1;
        private System.Windows.Forms.TextBox HTB;
        private MaskedTextBoxKeyDown mtbkd;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button difbtn;
        private System.Windows.Forms.TextBox res2TB;
        private System.Windows.Forms.TextBox res3TB;
        private MaskedTextBoxKeyDown Hfin2;
        private MaskedTextBoxKeyDown Hini2;
        private MaskedTextBoxKeyDown Hfin1;


    }
}