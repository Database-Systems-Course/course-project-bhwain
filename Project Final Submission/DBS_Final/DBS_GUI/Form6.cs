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
        string c_email = "";
        string c_Password = "";
        string name = "";
        public InfoForm(string a)
        {
            InitializeComponent();
            c_email = EmailBox.Text;
            c_Password = ConfirmPasswordBox.Text;
            name = a;
        }
         
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

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
