using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signup2
{
    public partial class employeeManagerInfo : Form
    {
        private string employeeName;
        private string employeeEmail;
        private string employeePassword;
        private string gender;
        private string designation;
        private string salary;
        public employeeManagerInfo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            try
            {
SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N;Initial Catalog=test;Integrated Security=True;TrustServerCertificate=True");

                connection.Open();

                var q = "SELECT * FROM employee2";
                SqlDataAdapter adp = new SqlDataAdapter(q, connection);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
               this.dgvemi.DataSource = dt;
                this.dgvemi.ClearSelection();
                this.dgvemi.Refresh();

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

        }

        private void employeeManagerInfo_Load(object sender, EventArgs e)
        {
            try
            {
SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N;Initial Catalog=test;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                var q = "SELECT * FROM employee2";
                SqlDataAdapter adp = new SqlDataAdapter(q, connection);

                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                this.dgvemi.ClearSelection();
                this.dgvemi.DataSource = dt;
                this.dgvemi.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvemi_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvemi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = this.dgvemi.Rows[e.RowIndex].Cells["id"].Value.ToString();
                idbox.Text = id;

                var name = this.dgvemi.Rows[e.RowIndex].Cells["name"].Value.ToString();
                textBox1.Text = name;

                var email = this.dgvemi.Rows[e.RowIndex].Cells["email"].Value.ToString();
                textBox2.Text = email;

                var password = this.dgvemi.Rows[e.RowIndex].Cells["password"].Value.ToString();
                textBox3.Text = password;

                var gender = this.dgvemi.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                if (gender == radioButton1.Text)
                {
                    radioButton1.Checked = true;
                }
                else if(radioButton2.Text == gender)radioButton2.Checked = true;

                var designation = this.dgvemi.Rows[e.RowIndex].Cells["designation"].Value.ToString();
                comboBox1.SelectedItem = designation;

                var salary = this.dgvemi.Rows[e.RowIndex].Cells["salary"].Value.ToString();
                textBox4.Text = email;
            }
            catch (Exception ex)
            {
MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeName = textBox1.Text;
            employeeEmail = textBox2.Text;
            employeePassword = textBox3.Text;


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
           
            MessageBox.Show("ADDED");
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox4.Text = null;
            comboBox1.SelectedItem = null;
            return;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //update
            employeeName = textBox1.Text;
            employeeEmail = textBox2.Text;
            employeePassword = textBox3.Text;


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

            //////
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N;Initial Catalog=test;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string q = "UPDATE employee2 SET " +
              "name = '" + textBox1.Text + "', " +
              "email = '" + textBox2.Text + "', " +
              "password = '" + textBox3.Text + "', " +
              "gender = '" + gender + "', " +
              "designation = '" + designation + "', " +
              "salary = '" + salary + "' " +
              "WHERE id = " + Convert.ToInt32(idbox.Text);



                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("UPDATED");
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBox4.Text = null;
                comboBox1.SelectedItem = null;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if(idbox.Text == "Auto Generated")
            {
                MessageBox.Show("Please select an employee to delete");
                return;
            }

            else
            {
                try
                {
                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N;Initial Catalog=test;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string q = "DELETE FROM employee2 " +
                               "WHERE id = " + Convert.ToInt32(idbox.Text);



                    SqlCommand cmd = new SqlCommand(q, connection);
                    cmd.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("DELETED");
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    textBox4.Text = null;
                    comboBox1.SelectedItem = null;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
