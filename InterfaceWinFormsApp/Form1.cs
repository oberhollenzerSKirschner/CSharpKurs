using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ItSchulung.CsharpKurs.InterfaceLibrary;
using ItSchulung.CsharpKurs.ClassLibrary;  
using InterfaceWinFormsApp.Prototype;

namespace InterfaceWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greed_button_Click(object sender, EventArgs e)
        {
            //IHuman human = new HumanPrototype();
            IHuman human = new Human();
            human.FirstName = firstNameTextBox.Text;
            human.LastName = lastNameTextBox.Text;
            //human.DateOfBirth = dateOfBirth_dateTimePicker.Value.Date;
            label3.Text = human.Greet();
        }
    }
}
