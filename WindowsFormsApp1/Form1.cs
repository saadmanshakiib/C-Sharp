using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            if (email == "")
            {
                MessageBox.Show("Please field the email field");
            }
            else if (password == "")
            {
                MessageBox.Show("Please field the password field");

            }
            else
            {
                MessageBox.Show("Email : " + email + "Password : " + password);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     
    }
}
