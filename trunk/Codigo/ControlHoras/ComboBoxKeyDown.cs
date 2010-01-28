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
    public partial class ComboBoxKeyDown : ComboBox
    {
        private Color EnterColor;
        private Color LeaveColor;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }



        public ComboBoxKeyDown()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(ComboBoxKeyDown_KeyDown);
            this.Enter += new EventHandler(ComboBoxKeyDown_Enter);
            this.Leave +=new EventHandler(ComboBoxKeyDown_Leave);
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

        private void ComboBoxKeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ComboBoxKeyDown_Enter(object sender, EventArgs e)
        {
            this.BackColor = EnterColor;
        }

        private void ComboBoxKeyDown_Leave(object sender, EventArgs e)
        {
            this.BackColor = LeaveColor;
        }
    }
}
