using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace project_bhwain
{
    /// <summary>
    /// Interaction logic for Store.xaml
    /// </summary>
    public partial class Store : Window
    {
        public Store(String ID)
        {   
            List<items> it = new List<items>();
            InitializeComponent();

            /*//SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GamesConnectionString"].ConnectionString);
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\zombi\\source\\repos\\project_bhwain\\project_bhwain\\Games.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();
            string bring_trending_games = "SELECT Top 10 G.Title,G.Price,D.DeveloperName FROM Game G,Developers D WHERE (G.Developers_idDevelopers=idDevelopers )";
            SqlCommand SCMD = new SqlCommand(bring_trending_games,conn);
            SCMD.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(bring_trending_games,conn);
            DataTable Dtbl = new DataTable(); ;
            sda.Fill(Dtbl);
            dg.ItemsSource = Dtbl.DefaultView;
            sda.Update(Dtbl);
            conn.Close();
            //SqlCommand com = new SqlCommand(bring_trending_games, conn);
            //com.ExecuteScalar();
            conn.Close();

            it.Add(new items { Game_Name = "Asdf", Price = 69.69, Developer = "5318008" });
            dg.ItemsSource = it;
            */


        
        }
        class items
        {
            public string Game_Name { get; set; }
            public double Price { get; set; }
            public string Developer { get; set; }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            project_bhwain.GamesDataSet gamesDataSet = ((project_bhwain.GamesDataSet)(this.FindResource("gamesDataSet")));
            // Load data into the table Game. You can modify this code as needed.
            project_bhwain.GamesDataSetTableAdapters.GameTableAdapter gamesDataSetGameTableAdapter = new project_bhwain.GamesDataSetTableAdapters.GameTableAdapter();
            gamesDataSetGameTableAdapter.Fill(gamesDataSet.Game);
            System.Windows.Data.CollectionViewSource gameViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("gameViewSource")));
            gameViewSource.View.MoveCurrentToFirst();
            project_bhwain.GamesDataSet1 gamesDataSet1 = ((project_bhwain.GamesDataSet1)(this.FindResource("gamesDataSet1")));
            // Load data into the table Table. You can modify this code as needed.
            project_bhwain.GamesDataSet1TableAdapters.TableTableAdapter gamesDataSet1TableTableAdapter = new project_bhwain.GamesDataSet1TableAdapters.TableTableAdapter();
            gamesDataSet1TableTableAdapter.Fill(gamesDataSet1.Table);
            System.Windows.Data.CollectionViewSource tableViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tableViewSource")));
            tableViewSource.View.MoveCurrentToFirst();
            project_bhwain.GamesDataSet2 gamesDataSet2 = ((project_bhwain.GamesDataSet2)(this.FindResource("gamesDataSet2")));
            // Load data into the table frontpage. You can modify this code as needed.
            project_bhwain.GamesDataSet2TableAdapters.frontpageTableAdapter gamesDataSet2frontpageTableAdapter = new project_bhwain.GamesDataSet2TableAdapters.frontpageTableAdapter();
            gamesDataSet2frontpageTableAdapter.Fill(gamesDataSet2.frontpage);
            System.Windows.Data.CollectionViewSource frontpageViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("frontpageViewSource")));
            frontpageViewSource.View.MoveCurrentToFirst();
        }
    }
}
