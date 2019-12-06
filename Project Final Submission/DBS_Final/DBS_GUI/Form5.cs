﻿using System;
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

    public partial class DevForm : Form
    {
        string _email = "";
        string _password = "";
        string _name = "";

        public DevForm(string email, string password, string name, string developerid)
        {
            InitializeComponent();
            _email = email;
            _password = password;
            _name = name;

            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT DeveloperName FROM [Developers] WHERE CONVERT(VARCHAR, idDevelopers) = '" + developerid + "';", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
     
                    while (reader.Read())
                    {
 
                        NameBox.Text = String.Format("{0}", reader["DeveloperName"]);

                    }
  
                }
        
                conn.Close();
            }


            using (SqlConnection conn = new SqlConnection())
            {
                string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\123\\Downloads\\course-project-bhwain (2)\\course-project-bhwain\\course-project-bhwain\\course-project-bhwain\\Database\\Games.mdf;Integrated Security=True;Connect Timeout=30";
                //conn.ConnectionString = "Server= (LocalDB)/MSSQLLocalDB; Database= Games; Integrated Security=True;";
                conn.ConnectionString = cn;
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT Name, designation FROM [Employees] WHERE CONVERT(VARCHAR, Developers_idDevelopers) = '" + developerid + "';", conn);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> myEmployees = new List<string>();
                    while (reader.Read())
                    {
                        Console.WriteLine("Check2");
                        string myString = String.Format("{0}", reader["Name"]);
                        DirectorBox.Text = String.Format("{0}", reader["Designation"]);
                        myEmployees.Add(myString); 
                    }
                    TeamList.DataSource = myEmployees;
                    TeamList.Refresh();
               
                }
                SqlCommand c = new SqlCommand("SELECT Title FROM [Game] WHERE CONVERT(VARCHAR, Developers_idDevelopers) = '" + developerid + "';", conn);

                using (SqlDataReader reader = c.ExecuteReader())
                {
                    List<string> myTitles = new List<string>();
                    while (reader.Read())
                    {
                        Console.WriteLine("Check2");
                        string myString = String.Format("{0}", reader["Title"]);

                        myTitles.Add(myString);
                    }
                    TitlesList.DataSource = myTitles;
                    TitlesList.Refresh();

                }
                conn.Close();
            }
            
        }
        

    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f6 = new Form8();
            f6.ShowDialog();
        }

        private void TeamList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TitlesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
