using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b

namespace DBS_GUI
{
    public partial class Form8 : Form
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
        string d_name = "";
        string n_genre = "";
        string n_title = "";
        string n_price = "";
<<<<<<< HEAD
        public Form8()
        {
            InitializeComponent();
            d_name = FNameBox.Text;
            n_genre = textBox2.Text;
            n_title = textBox1.Text;
            n_price = textBox3.Text;
=======
        string pre_name = "";
        public Form8(string name)
        {
            InitializeComponent();
            d_name = FNameBox.Text;
            n_genre = textBox2.Text;
            n_title = textBox1.Text;
            n_price = textBox3.Text;
            pre_name = name;
=======
        public Form8()
        {
            InitializeComponent();
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
<<<<<<< HEAD
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
=======
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

<<<<<<< HEAD
                SqlCommand command = new SqlCommand("UPDATE [Customers] SET EmailID ='" + d_name + "' ;", conn);
=======
                SqlCommand command = new SqlCommand("UPDATE [Developer] SET DeveloperName ='" + d_name + "' where DeveloperName ='"  + pre_name +  "' ;", conn);
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b

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
<<<<<<< HEAD
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
=======
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

<<<<<<< HEAD
                SqlCommand command = new SqlCommand("Insert into Game(RegisterationId, Genres_idGenres, Developers_idDevelopers, Titles, Price) values((Select (Max(RegisterationId)from Games) +1), (Select idGenres From Genres where Name ='" + n_genre + "', (Select idDevelopers from Developers where DeveloperName= '" + d_name + "'), '" + n_title + "', '" + n_price + "' ;", conn);
=======
                SqlCommand command = new SqlCommand("Insert into Game(RegisterationId, Genres_idGenres, Developers_idDevelopers, Titles, Price) values((Select (Max(RegisterationId) from [Games]) +1), (Select idGenres From Genres where Name ='" + n_genre + "', (Select idDevelopers from Developers where DeveloperName= '" + d_name + "'), '" + n_title + "', '" + n_price + "' ;", conn);
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if more stuff needed
                }
            }
        }
<<<<<<< HEAD
=======
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
    }
}
