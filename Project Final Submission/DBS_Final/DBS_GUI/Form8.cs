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
    public partial class Form8 : Form
    {
        string d_name = "";
        string n_genre = "";
        string n_title = "";
        string n_price = "";
        public Form8()
        {
            InitializeComponent();
            d_name = FNameBox.Text;
            n_genre = textBox2.Text;
            n_title = textBox1.Text;
            n_price = textBox3.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE [Customers] SET EmailID ='" + d_name + "' ;", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if more stuff needed
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                SqlCommand command = new SqlCommand("Insert into Game(RegisterationId, Genres_idGenres, Developers_idDevelopers, Titles, Price) values((Select (Max(RegisterationId)from Games) +1), (Select idGenres From Genres where Name ='" + n_genre + "', (Select idDevelopers from Developers where DeveloperName= '" + d_name + "'), '" + n_title + "', '" + n_price + "' ;", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if more stuff needed
                }
            }
        }
    }
}
