using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ButtonTesting
{
    public partial class Form2 : Form
    {
        public Form2(String name)
        {
            InitializeComponent();
            NameOutput1.Text = name;
        }

        private void ReturnButton1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"]?.Show();
            this.Close();
        }

        
    }
}
