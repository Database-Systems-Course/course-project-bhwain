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
    public partial class Homepage : Form
    {
        public string _textBox1 = "";

        public Homepage()
        {
            InitializeComponent();
            _textBox1 = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
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
            Homepage f1 = new Homepage();
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
            CustomerForm f4 = new CustomerForm("","");
            f4.ShowDialog();
        }
    }
}
