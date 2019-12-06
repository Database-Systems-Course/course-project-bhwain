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
        string pre_name = "";
        public Form8(string name)
        {
            InitializeComponent();
            d_name = FNameBox.Text;
            n_genre = textBox2.Text;
            n_title = textBox1.Text;
            n_price = textBox3.Text;
            pre_name = name;
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
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE [Developer] SET DeveloperName ='" + d_name + "' where DeveloperName ='"  + pre_name +  "' ;", conn);

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
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                SqlCommand command = new SqlCommand("Insert into Game(RegisterationId, Genres_idGenres, Developers_idDevelopers, Titles, Price) values((Select (Max(RegisterationId) from [Games]) +1), (Select idGenres From Genres where Name ='" + n_genre + "', (Select idDevelopers from Developers where DeveloperName= '" + d_name + "'), '" + n_title + "', '" + n_price + "' ;", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if more stuff needed
                }
            }
        }
    }
}
