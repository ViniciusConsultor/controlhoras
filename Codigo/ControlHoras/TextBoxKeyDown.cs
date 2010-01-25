using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using System.Drawing;

namespace ControlHoras
{
    public partial class TextBoxKeyDown : TextBox
    {
        private Color EnterColor;
        private Color LeaveColor;

        public TextBoxKeyDown()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(TextBoxKeyDown_KeyDown);
            this.Enter += new EventHandler(TextBoxKeyDown_Enter);
            this.Leave +=new EventHandler(TextBoxKeyDown_Leave);
            try
            {
                EnterColor = ControladorConfiguracion.getColorEnterTextBoxPropertieValue();
                LeaveColor = ControladorConfiguracion.getColorLeaveTextBoxPropertieValue();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void TextBoxKeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxKeyDown_Enter(object sender, EventArgs e)
        {
            this.BackColor = EnterColor;
        }

        private void TextBoxKeyDown_Leave(object sender, EventArgs e)
        {
            this.BackColor = LeaveColor;
        }

    }
}
