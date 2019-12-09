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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            CustomerRadio.IsChecked = true;
            
        }

        private void CustomerRadio_Checked(object sender, RoutedEventArgs e)
        {
            DeveloperRadio.IsChecked = false;
            Developer.IsReadOnly = false;
        }

        private void DeveloperRadio_Checked(object sender, RoutedEventArgs e)
        {
            CustomerRadio.IsChecked = false;
            Developer.IsReadOnly = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            BSLogin log = new BSLogin();
            log.Show();
            this.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\zombi\\source\\repos\\project_bhwain\\project_bhwain\\Games.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();
            string x = "0";
            if (CustomerRadio.IsChecked == true)
            { }
            else { string devcount = "SELECT COUNT(*) FROM DEVELOPERS";
                SqlCommand com1 = new SqlCommand(devcount, conn);
                int DVCNT = Convert.ToInt32(com1.ExecuteScalar().ToString());
                x = DVCNT.ToString();
            }
            string checkuser = "insert into Users values("+Username.Text+","+Password.Text+","+Email.Text+","+x+")";
            SqlCommand com = new SqlCommand(checkuser, conn);
            com.ExecuteScalar(); 
            conn.Close();
            

        }
    }
}
