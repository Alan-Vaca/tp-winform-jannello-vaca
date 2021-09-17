using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Jannello_Vaca
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            allArticulosPanel.Visible = true;
        }

        private void articulosListButton_Click(object sender, EventArgs e)
        {
            allArticulosPanel.Visible = true;
        }

    }
}
