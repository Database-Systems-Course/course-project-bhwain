using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_GUI
{
    public partial class CustomerForm : Form
    {
        string email = "";
        string password = "";
        string f_name = "";
        string l_name = "";

        public CustomerForm(string email, string password)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoForm f6 = new InfoForm();
            f6.ShowDialog();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void FNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
