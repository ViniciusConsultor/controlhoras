using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace ControlHoras
{
    public partial class MaskedTextBoxKeyDown : MaskedTextBox
    {
        private Color EnterColor;
        private Color LeaveColor;

        public MaskedTextBoxKeyDown()
        {
            InitializeComponent();
            this.Enter +=new EventHandler(MaskedTextBoxKeyDown_Enter);
            this.Leave += new EventHandler(MaskedTextBoxKeyDown_Leave);
            this.KeyDown += new KeyEventHandler(MaskedTextBoxKeyDown_KeyDown);
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

        private void MaskedTextBoxKeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void MaskedTextBoxKeyDown_Enter(object sender, EventArgs e)
        {
            this.BackColor = EnterColor;
        }

        private void MaskedTextBoxKeyDown_Leave(object sender, EventArgs e)
        {
            this.BackColor = LeaveColor;
        }
    }
}
