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
    public partial class Form9 : Form
    {
        string ad_name = "";
        string ad_des = "";
        string ad_email = "";
        List<Container> myList = new List<Container>();
        public Form9()
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM [Admin];", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> MyList = new List<string>();
                    while (reader.Read())
                    {

                        MyList.Add(String.Format("Admin_Name: {0}, Admin_Designation: {1}, Admin_Email: {2}", reader["Name"], reader["Designation"], reader["Email"]));
                        ad_name = String.Format("{0}", reader["Name"]);
                        ad_des = String.Format("{0}", reader["Designation"]);
                        ad_email = String.Format("{0}", reader["Email"]);
                        Container a = new Container(ad_name, ad_des, ad_email);
                        myList.Add(a);
                    }
                    listBox1.DataSource = MyList;
                    listBox1.Refresh();

                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
