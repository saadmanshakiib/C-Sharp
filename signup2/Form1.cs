using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace signup2
{
    public partial class Form1 : Form
    {

        private string employeeName;
        private string employeeEmail;
        private string employeePassword;
        private string gender;
        private string designation;
        private string salary;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //lagbe na
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //lagbe na
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //female
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //name
            employeeName = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //email
            employeeEmail = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //password
            employeePassword = textBox3.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //lagbe na
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //lagbe na
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show
            if (string.IsNullOrEmpty(employeeName))
            {
                MessageBox.Show("Name cant be empty"); return;
            }
            if (string.IsNullOrEmpty(employeeEmail))
            {
                MessageBox.Show("Email cant be empty"); return;
            }
            if (string.IsNullOrEmpty(employeePassword))
            {
                MessageBox.Show("Password cant be empty"); return;
            }

            if (radioButton1.Checked) gender = "Male";
            else if (radioButton2.Checked) gender = "Female";
            else MessageBox.Show("Please Select Your Gender");

            if (comboBox1.SelectedIndex == 0)
            {
                designation = "Full Stack Developer";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                designation = "Frontend Developer";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                designation = "Backend Developer";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                designation = "AI-ML Engineer";
            }

            if (textBox4.Text.Length != 0)
            {
                salary = textBox4.Text;
            }
            else MessageBox.Show("Salary Cant be empty");

            MessageBox.Show(
                employeeName + " " + employeeEmail + " " + employeePassword
                + " " + gender + " " + designation
                );
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //designation

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //salary
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //lagbe na
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(employeeName)){
                MessageBox.Show("Name cant be empty"); return;
            }
            if (string.IsNullOrEmpty(employeeEmail))
            {
                MessageBox.Show("Email cant be empty"); return;
            }
            if (string.IsNullOrEmpty(employeePassword))
            {
                MessageBox.Show("Password cant be empty"); return;
            }

            if (radioButton1.Checked) gender = "Male";
            else if (radioButton2.Checked) gender = "Female";
            else MessageBox.Show("Please Select Your Gender");

            if (comboBox1.SelectedIndex == 0)
            {
                designation = "Full Stack Developer";
            }
            else if (comboBox1.SelectedIndex == 1) {
                designation = "Frontend Developer";
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                designation = "Backend Developer";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                designation = "AI-ML Engineer";
            }

            if (textBox4.Text.Length != 0)
            {
                salary = textBox4.Text;
            }
            else MessageBox.Show("Salary Cant be empty");

            

            SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N;Initial Catalog=test;Integrated Security=True;TrustServerCertificate=True");

connection.Open();
            string q = "INSERT INTO employee2 " +
               "(name, email, password, gender, designation, salary) VALUES ('"
               + employeeName + "','"
               + employeeEmail + "','"
               + employeePassword + "','"
               + gender + "','"
               + designation + "','"
               + salary + "')";

            SqlCommand cmd = new SqlCommand(q, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("ADDED"); return;
        }
    }
}
