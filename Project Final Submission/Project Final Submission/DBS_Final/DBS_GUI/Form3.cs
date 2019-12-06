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

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PublisherBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
