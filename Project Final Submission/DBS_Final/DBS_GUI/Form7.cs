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
        public SearchResultForm(string _textBox1)
        {
            InitializeComponent();
            searched = _textBox1;
            ResultList.Items.Clear();
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                if (searched != "" || searched == null)
                {
                    //join here
                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sj02806\\Downloads\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                    //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                    conn.ConnectionString = cn;
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM [Game] WHERE CONVERT(VARCHAR, Title) = '" + searched + "';", conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            List<string> MyList = new List<string>();
                            MyList.Add(String.Format("Game Name: {0}, Game Price: {1}, Game Genre: {2}, Game Developer: {3}", reader["Title"], reader["Price"], reader["Genres_idGenres"], reader["Developers_idDevelopers"]));

                            ResultList.DataSource = MyList;
                            ResultList.Refresh();
                        }
                    }
                }
                else
                {
                    //join here
                    string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sj02806\\Downloads\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                    //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                    conn.ConnectionString = cn;
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM [Game];", conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> MyList = new List<string>();
                        while (reader.Read())
                        {
                            
                            MyList.Add(String.Format("Game Name: {0}, Game Price: {1}, Game Genre: {2}, Game Developer: {3}", reader["Title"], reader["Price"], reader["Genres_idGenres"], reader["Developers_idDevelopers"]));
 
                        }
                        ResultList.DataSource = MyList;
                        ResultList.Refresh();
                    }
                }
                searched = "";
                conn.Close();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Homepage p = new Homepage();
           
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
 
            int index = this.ResultList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                GameDetailForm f1 = new GameDetailForm(title, publisher, genre);

                this.Hide();
                f1.ShowDialog();
            }
        }
    }
}
