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
    public partial class SearchResultForm : Form
    {
        string searched = "";
        string title = "";
        string publisher = "";
        string genre = "";
<<<<<<< HEAD
        List<Container> myList = new List<Container>();
=======
<<<<<<< HEAD
        List<Container> myList = new List<Container>();
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
        public SearchResultForm(string _textBox1)
        {
            InitializeComponent();
            searched = _textBox1;
            ResultList.Items.Clear();
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
           
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                if (searched != "" || searched == null)
                {
                    //join here
<<<<<<< HEAD
                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
=======
<<<<<<< HEAD
                    //string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                    ////conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                    //conn.ConnectionString = cn;
                    //conn.Open();

                    ////SqlCommand command = new SqlCommand("select g.Title, f.Name, d.DeveloperName, g.price into #game_search from Game g, Genres f, Developers d where CONVERT(VARCHAR, g.Genres_idGenres) = f.idGenres and CONVERT(VARCHAR, d.idDevelopers) = g.Developers_idDevelopers and CONVERT(VARCHAR, g.Title) = '" + searched + "';", conn);
                    //SqlCommand command = new SqlCommand("create table #game_search (id int, Name varchar(20), Genre varchar(20), Developer varchar(20), Price varchar(20)) INSERT INTO #game_search(Name, Genre, Developer, Price) SElECT g.Title, f.Name, d.DeveloperName, g.Price from Game g, Genres f, Developers d where g.Genres_idGenres = f.idGenres and d.idDevelopers = g.Developers_idDevelopers and Convert(VarChar(20), g.Title) = '" +searched + "'; select * from #game_search;", conn);

                    //Console.WriteLine("ASDAS");
                    //using (SqlDataReader reader = command.ExecuteReader())
                    //{
                    //    if (reader.Read())
                    //    {
                    //        List<string> MyList = new List<string>();
                           
                    //        MyList.Add(String.Format("Game Name: {0}, Game Price: {1}, Game Genre: {2}, Game Developer: {3}", reader["Name"], reader["Price"], reader["Genre"], reader["Developer"]));
                    //        Console.WriteLine("ASDAS");
                    //        ResultList.DataSource = MyList;
                    //        ResultList.Refresh();
                    //        title = String.Format("{0}", reader["Name"]);
                    //        publisher = String.Format("{0}", reader["Developer"]);
                    //        genre = String.Format("{0}", reader["Genre"]);
                    //        Container a = new Container(title, publisher, genre);
                    //        myList.Add(a);
=======
                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sj02806\\Downloads\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
                    //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                    conn.ConnectionString = cn;
                    conn.Open();

                    //SqlCommand command = new SqlCommand("select g.Title, f.Name, d.DeveloperName, g.price into #game_search from Game g, Genres f, Developers d where CONVERT(VARCHAR, g.Genres_idGenres) = f.idGenres and CONVERT(VARCHAR, d.idDevelopers) = g.Developers_idDevelopers and CONVERT(VARCHAR, g.Title) = '" + searched + "';", conn);
                    SqlCommand command = new SqlCommand("create table #game_search (id int, Name varchar(20), Genre varchar(20), Developer varchar(20), Price varchar(20)) INSERT INTO #game_search(Name, Genre, Developer, Price) SElECT g.Title, f.Name, d.DeveloperName, g.Price from Game g, Genres f, Developers d where g.Genres_idGenres = f.idGenres and d.idDevelopers = g.Developers_idDevelopers and Convert(VarChar(20), g.Title) = '" +searched + "'; select * from #game_search;", conn);

                    Console.WriteLine("ASDAS");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            List<string> MyList = new List<string>();
                           
                            MyList.Add(String.Format("Game Name: {0}, Game Price: {1}, Game Genre: {2}, Game Developer: {3}", reader["Name"], reader["Price"], reader["Genre"], reader["Developer"]));
                            Console.WriteLine("ASDAS");
                            ResultList.DataSource = MyList;
                            ResultList.Refresh();
<<<<<<< HEAD
                            title = String.Format("{0}", reader["Name"]);
                            publisher = String.Format("{0}", reader["Developer"]);
                            genre = String.Format("{0}", reader["Genre"]);
                            Container a = new Container(title, publisher, genre);
                            myList.Add(a);
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
                        }
                    }
                }
                else
                {
                    //join here
<<<<<<< HEAD
                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
=======
<<<<<<< HEAD
                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\si03013\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Project Final Submission\\DBS_Final\\DBS_GUI\\Games.mdf;Integrated Security=True;Connect Timeout=30";
=======
                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sj02806\\Downloads\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
                    //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                    conn.ConnectionString = cn;
                    conn.Open();

<<<<<<< HEAD
                    SqlCommand command = new SqlCommand("create table #game_search (Name varchar(20),Genre varchar(20), Developer varchar(20), Price varchar(20)) INSERT INTO #game_search(Name, Genre, Developer, Price) SElECT g.Title, f.Name, d.DeveloperName, g.Price from Game g, Genres f, Developers d where g.Genres_idGenres = f.idGenres and d.idDevelopers = g.Developers_idDevelopers Select * from #game_search", conn);
=======
<<<<<<< HEAD
                    SqlCommand command = new SqlCommand("create table #game_search (Name varchar(20),Genre varchar(20), Developer varchar(20), Price varchar(20)) INSERT INTO #game_search(Name, Genre, Developer, Price) SElECT g.Title, f.Name, d.DeveloperName, g.Price from Game g, Genres f, Developers d where g.Genres_idGenres = f.idGenres and d.idDevelopers = g.Developers_idDevelopers Select * from #game_search", conn);
=======
                    SqlCommand command = new SqlCommand("SELECT * FROM [Game];", conn);
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> MyList = new List<string>();
                        while (reader.Read())
                        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
                            Console.WriteLine("!@#!@!!@#" + String.Format("Game Name: {0}, Game Price: {1}, Game Genre: {2}, Game Developer: {3}", reader["Name"], reader["Price"], reader["Genre"], reader["Developer"]));
    
                            MyList.Add(String.Format("Game Name: {0}, Game Price: {1}, Game Genre: {2}, Game Developer: {3}", reader["Name"], reader["Price"], reader["Genre"], reader["Developer"]));
                            title = String.Format("{0}", reader["Name"]);
                            publisher = String.Format("{0}", reader["Developer"]);
                            genre = String.Format("{0}", reader["Genre"]);
                            Container a = new Container(title, publisher, genre);
                            myList.Add(a);
<<<<<<< HEAD
                        }
                        ResultList.DataSource = MyList;
                        ResultList.Refresh();
                        
=======
                        }
                        ResultList.DataSource = MyList;
                        ResultList.Refresh();
                        
=======
                            
                            MyList.Add(String.Format("Game Name: {0}, Game Price: {1}, Game Genre: {2}, Game Developer: {3}", reader["Title"], reader["Price"], reader["Genres_idGenres"], reader["Developers_idDevelopers"]));
 
                        }
                        ResultList.DataSource = MyList;
                        ResultList.Refresh();
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
                    }
                }
                searched = "";
                conn.Close();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Homepage p = new Homepage("","","");

=======
<<<<<<< HEAD
            Homepage p = new Homepage("","","");

=======
            Homepage p = new Homepage();
           
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void ResultList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ResultList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.ResultList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }
        }

        private void ResultList_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ResultList_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
<<<<<<< HEAD

            int index = this.ResultList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Container con = myList[index];
                title = con.con_title;
                publisher = con.con_publisher;
                genre = con.con_genre;

=======
<<<<<<< HEAD

            int index = this.ResultList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Container con = myList[index];
                title = con.con_title;
                publisher = con.con_publisher;
                genre = con.con_genre;

=======
 
            int index = this.ResultList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
>>>>>>> cfc300f427439963145d8568e4f842df0ad51d2b
                GameDetailForm f1 = new GameDetailForm(title, publisher, genre);

                this.Hide();
                f1.ShowDialog();
            }
<<<<<<< HEAD
        }

        private void ResultGroup_Enter(object sender, EventArgs e)
        {

=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
        }

        private void ResultGroup_Enter(object sender, EventArgs e)
        {

        }
    }
   

}
public class Container
{ 

    public string con_title = "";
    public string con_publisher = "";
    public string con_genre = "";
    public Container(string a, string b, string c)
    {
        con_title = a;
        con_publisher = b;
        con_genre = c;

    }

}