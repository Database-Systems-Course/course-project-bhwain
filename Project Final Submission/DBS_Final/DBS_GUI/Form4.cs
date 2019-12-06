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
    public partial class CustomerForm : Form
    {
        string email = "";
        string password = "";
        string f_name = "";
        string l_name = "";
        string g_name = "";
        string g_p = "";
        string g_g = "";
        List<Container> myList = new List<Container>();

        public CustomerForm(string name, string email, string password)
        {
            InitializeComponent();
            FNameBox.Text = name;
            textBox1.Text = email;
            textBox2.Text = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoForm f6 = new InfoForm();
            f6.ShowDialog();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                SqlCommand command = new SqlCommand("select Title from Game where registration_id = (select w.game_registration_id from wishlist w where w.Customers_idCustomers = (select idCustomers from Customers where convert(varchar(20),Name) = '" + FNameBox.Text + "')) ;", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> MyList = new List<string>();
                    while (reader.Read())
                    {

                        MyList.Add(String.Format("{0}", reader["Title"]));
                        g_name = String.Format("{0}", reader["Title"]);
                        // g_p = String.Format("{0}", reader["Price"]);
                        //  g_g = String.Format("{0}", reader["Genre"]);
                        Container a = new Container(g_name, "", "");
                        myList.Add(a);
                    }
                    WishBox.DataSource = MyList;
                    WishBox.Refresh();
                }
            }
            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                SqlCommand command = new SqlCommand("select Title from Game where registration_id = (select o.game_registration_id from owns o where o.Customers_idCustomers = (select idCustomers from Customers where convert(varchar(20), Name) = '" + FNameBox.Text + "')) ; ", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> MyList = new List<string>();
                    while (reader.Read())
                    {

                        MyList.Add(String.Format("{0}", reader["Title"]));
                        g_name = String.Format("{0}", reader["Title"]);
                        // g_p = String.Format("{1}", reader["Price"]);
                        //  g_g = String.Format("{2}", reader["Genre"]);
                        Container a = new Container(g_name, "", "");
                        myList.Add(a);
                    }
                    PurchasedBox.DataSource = MyList;
                    PurchasedBox.Refresh();
                }
            }
        }

        private void FNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void WishBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PurchasedBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}