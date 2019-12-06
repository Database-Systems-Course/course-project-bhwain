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
    public partial class Homepage : Form
    {
        public string _textBox1 = "";
        string title = "";
        string publisher = "";
        List<Container> myList = new List<Container>();
        string genre = "";
        string _name = "";
        string _email = "";
        string _password = "";

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public Homepage(string name, string email, string password)
        {
            InitializeComponent();
            _textBox1 = "";
            _name = name;
            _email = email;
            _password = password;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
               
                {
                    //join here
                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                    //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                    conn.ConnectionString = cn;
                    conn.Open();

                    SqlCommand command = new SqlCommand("create table #game_search (Name varchar(20),Genre varchar(20), Developer varchar(20), Price varchar(20)) INSERT INTO #game_search(Name, Genre, Developer, Price) SElECT g.Title, f.Name, d.DeveloperName, g.Price from Game g, Genres f, Developers d where g.Genres_idGenres = f.idGenres and d.idDevelopers = g.Developers_idDevelopers Select * from #game_search", conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        List<string> MyList = new List<string>();
                        while (reader.Read())
                        {
                            int random = RandomNumber(0, 4);
                            Console.WriteLine(random);
                            if (random > 2)
                            {
                                MyList.Add(String.Format("Game Name: {0}, Game Price: {1}, Game Genre: {2}, Game Developer: {3}", reader["Name"], reader["Price"], reader["Genre"], reader["Developer"]));
                                title = String.Format("{0}", reader["Name"]);
                                publisher = String.Format("{0}", reader["Developer"]);
                                genre = String.Format("{0}", reader["Genre"]);
                                Container a = new Container(title, publisher, genre);
                                myList.Add(a);

                            }
                        }
                        listBox1.DataSource = MyList;
                        listBox1.Refresh();

                    }
                }
                conn.Close();


            }
        }
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SearchResultForm f7 = new SearchResultForm(_textBox1);
          
            f7.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage f1 = new Homepage(_name,_email,_password);
            f1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GameDetailForm f3 = new GameDetailForm("", "", "");
            f3.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GameDetailForm f3 = new GameDetailForm("", "", "");
            f3.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GameDetailForm f3 = new GameDetailForm("", "", "");
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Lines.Length == 1)
                _textBox1 = SearchBox.Lines[0];
            else
                _textBox1 = "";
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            CustomerForm f4 = new CustomerForm(_name,_email,_password);
            f4.ShowDialog();
        }

        private void NewGroup_Enter(object sender, EventArgs e)
        {

        }

        private void GameGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void ToolsGroup_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Container con = myList[index];
                title = con.con_title;
                publisher = con.con_publisher;
                genre = con.con_genre;

                GameDetailForm f1 = new GameDetailForm(title, publisher, genre);
                f1.ShowDialog();
            } 
        }
    }
}
