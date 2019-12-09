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
    public partial class GameDetailForm : Form
    {
        public GameDetailForm(string title, string publisher, string genre)
        {
            InitializeComponent();
            TitleBox.Text = title;
            PublisherBox.Text = publisher;
            GenreBox.Text = genre;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GameDetailForm_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PublisherBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WishButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }
=======
            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                //SqlCommand command = new SqlCommand("select g.Title, f.Name, d.DeveloperName, g.price into #game_search from Game g, Genres f, Developers d where CONVERT(VARCHAR, g.Genres_idGenres) = f.idGenres and CONVERT(VARCHAR, d.idDevelopers) = g.Developers_idDevelopers and CONVERT(VARCHAR, g.Title) = '" + searched + "';", conn);
                SqlCommand command = new SqlCommand("insert into wishlist()");
                Console.WriteLine("ASDAS");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //
                    }
                }
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            //hi2
        }
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
    }
}
