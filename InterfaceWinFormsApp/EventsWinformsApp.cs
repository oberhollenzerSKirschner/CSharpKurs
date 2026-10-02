using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ItSchulung.CsharpKurs.ClassLibrary;

namespace InterfaceWinFormsApp
{
    public partial class EventsWinformsApp : Form
    {
        public EventsWinformsApp()
        {
            InitializeComponent();
            departmentsComboBox.DataSource = Enum.GetValues(typeof(Department));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee personal = new Employee();
            personal.FirstName = this.FirstNameTextBox.Text;
            personal.LastName = this.LastNameTextBox.Text;
            personal.Department = Enum.Parse<Department>(this.departmentsComboBox.SelectedValue.ToString());

            this.outputLabel.Text = $"Der Angestelle wurde angelegt: {personal.FirstName} {personal.LastName}, Department: {personal.Department}";

            EventHandlerForm childForm = new EventHandlerForm();
            childForm.Show(this);
            button1.Enabled = false;

        }

        private void departmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheEmployee != null)
            {
                TheEmployee.Department = Enum.Parse<Department>(departmentsComboBox.SelectedValue.ToString());
            }

        }
    }
    }
