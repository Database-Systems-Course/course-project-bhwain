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
    /// Interaction logic for BSLogin.xaml
    /// </summary>
    public partial class BSLogin : Window
    {
        public BSLogin()
        {
            InitializeComponent();
        }

        private void BootlegSteam_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Steam_Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)/MSSQLLocalDB;AttachDbFilename=D:/course-project-bhwain/project_bhwain/project_bhwain/Games.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();
            string checkuser = "SELECT COUNT(*) FROM Users WHERE emailID ='" + Username.Text + "'" + "AND PASSWORD_2 = '" + Password.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                String ID = Username.Text;
                checkuser = "select id from users where emailID="+Username.Text+"";
                SqlCommand com1 = new SqlCommand(checkuser, conn);
                ID=com1.ExecuteScalar().ToString();

                project_bhwain.Store Str = new Store(ID);
                Str.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No such User exists");
            }
      
        }

        private void Sign_up_Click(object sender, RoutedEventArgs e)
        {
            Register Registration = new Register();
            Registration.Show();
            this.Close();
        }

        private void Cancel_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
