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
    public partial class InfoForm : Form
    {
<<<<<<< HEAD
        string c_email = "";
        string c_Password = "";
        string name = "";
        public InfoForm(string a)
=======
<<<<<<< HEAD
        string c_email = "";
        string c_Password = "";
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
        public InfoForm()
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
        {
            InitializeComponent();
            c_email = EmailBox.Text;
            c_Password = ConfirmPasswordBox.Text;
<<<<<<< HEAD
            name = a;
=======

>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
        }
         
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
=======
<<<<<<< HEAD
            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

<<<<<<< HEAD
                SqlCommand command = new SqlCommand("UPDATE [Customers] SET Name ='" + FNameBox.Text + "',Password_2 = '" + PasswordBox.Text + "', Credit_card_number = '" + textBox1.Text + "', emailid = '" + EmailBox.Text + "' where idCustomers = (select idCustomers from Customers where convert(varchar(20), Name) = '" + name + "');", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("ADADA");
                }
                conn.Close();
                this.Hide();
            }
          
           

            CustomerForm f1 = new CustomerForm(FNameBox.Text, EmailBox.Text, PasswordBox.Text) ;
            f1.ShowDialog();
           
=======
                SqlCommand command = new SqlCommand("UPDATE [Customers] SET EmailID ='" + c_email + "',Password_2 = '" + c_Password + "' ;", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if more stuff needed
                }
            }
            //Homepage f1 = new Homepage();
            //f1.ShowDialog();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

=======
            Homepage f1 = new Homepage();
            f1.ShowDialog();
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
