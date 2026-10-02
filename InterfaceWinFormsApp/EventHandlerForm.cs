using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfaceWinFormsApp
{
    public partial class EventHandlerForm : Form
    {
        public EventHandlerForm()
        {
            InitializeComponent();
        }

        private void EventHandlerForm_Load(object sender, EventArgs e)
        {
            EventHandlerWinformsApp parentForm = (EventHandlerWinformsApp)this.Owner;
        }
    }
}
