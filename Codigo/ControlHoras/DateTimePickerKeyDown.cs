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
    public partial class DateTimePickerKeyDown : DateTimePicker
    {
        private Color EnterColor;
        private Color LeaveColor;

        public DateTimePickerKeyDown()
        {
            InitializeComponent();
            this.Enter +=new EventHandler(DateTimePickerKeyDown_Enter);
            this.Leave += new EventHandler(DateTimePickerKeyDown_Leave);
            this.KeyDown += new KeyEventHandler(DateTimePickerKeyDown_KeyDown);
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

        private void DateTimePickerKeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void DateTimePickerKeyDown_Enter(object sender, EventArgs e)
        {
            this.BackColor = EnterColor;
        }

        private void DateTimePickerKeyDown_Leave(object sender, EventArgs e)
        {
            this.BackColor = LeaveColor;
        }
    }
}
