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

namespace DBS_GUI
{
    public partial class LoginForm : Form
    {
        string type = "";
        string register_email = "";
        string register_password = "";
        string login_email = "";
        string login_password = "";
        string login_name = "";
        string register_name = "";
        string register_id = "";
        string developerid = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                using (SqlConnection conn = new SqlConnection())
                {

                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sj02806\\Downloads\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                    //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                    conn.ConnectionString = cn;
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM [Customers] WHERE CONVERT(VARCHAR, EmailID) = '" + LogEmailBox.Text + "' and CONVERT(VARCHAR, Password_2) = '" + LogPasswordBox.Text + "';", conn);
                    Console.WriteLine("Check1");
                    Console.WriteLine(LogEmailBox.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine("Check2");
                            string myString = String.Format("{0}", reader["EmailID"]);
                            Console.WriteLine("::" + myString);
                            if (myString != null)
                            {
                                string message = "Successfully Logged in";
                                string caption = "Login";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result;

                                // Displays the MessageBox.
                                result = MessageBox.Show(message, caption, buttons);
                                if (result == System.Windows.Forms.DialogResult.Yes)
                                {
                                    // Closes the parent form.
                                    this.Close();
                                }

                                login_email = String.Format("{0}", reader["EmailID"]);
                                login_password = String.Format("{0}", reader["Password_2"]);
                                login_name = String.Format("{0}", reader["Name"]);
                                Console.WriteLine(myString);

                                Form f1 = new Homepage();
                                this.Hide();
                                f1.ShowDialog();
                               
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("Check3");
                            string message = "No such user exists";
                            string caption = "Login";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result;

                            // Displays the MessageBox.
                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                // Closes the parent form.
                                this.Close();
                            }
                        }
                    }

                    conn.Close();
                }

            }
            else if (radioButton2.Checked)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sj02806\\Downloads\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                    //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                    conn.ConnectionString = cn;
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM [Employees] WHERE CONVERT(VARCHAR, email) = '" + LogEmailBox.Text + "' and CONVERT(VARCHAR, Password_2) = '" + LogPasswordBox.Text + "';", conn);
                    Console.WriteLine("Check1");
                    Console.WriteLine(LogEmailBox.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine("Check2");
                            string myString = String.Format("{0}", reader["email"]);
                            Console.WriteLine("::" + myString);
                            if (myString != null)
                            {
                                string message = "Successfully Logged in";
                                string caption = "Login";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result;

                                // Displays the MessageBox.
                                result = MessageBox.Show(message, caption, buttons);
                                if (result == System.Windows.Forms.DialogResult.Yes)
                                {
                                    // Closes the parent form.
                                    this.Close();
                                }

                                login_email = String.Format("{0}", reader["email"]);
                                login_password = String.Format("{0}", reader["Password_2"]);
                                login_name = String.Format("{0}", reader["Name"]);
                                developerid = String.Format("{0}", reader["Developers_idDevelopers"]);
                                Console.WriteLine(myString);

                                Form f1 = new DevForm(login_email, login_password, login_name, developerid);
                                this.Hide();
                                f1.ShowDialog();

                            }

                        }
                        else
                        {
                            Console.WriteLine("Check3");
                            string message = "No such user exists";
                            string caption = "Login";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result;

                            // Displays the MessageBox.
                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                // Closes the parent form.
                                this.Close();
                            }
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LogEmailBox_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                type = "Customer";
            }
            else if (radioButton4.Checked == true)
            {
                type = "Developer";
            }

            if (type == "Customer")
            {
                register_email = LogEmailBox.Text;
                register_password = LogPasswordBox.Text;
                CustomerForm f4 = new CustomerForm(register_email, register_password);
                f4.ShowDialog();
            }
            else
            {
                register_email = LogEmailBox.Text;
                register_password = LogPasswordBox.Text;
                DevForm f5 = new DevForm(register_email, register_password, register_name, register_id);
                f5.ShowDialog();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginGroup_Enter(object sender, EventArgs e)
        {

        }

        private void LogPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
