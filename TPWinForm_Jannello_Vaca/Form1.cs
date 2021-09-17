using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace TPWinForm_Jannello_Vaca
{
    public partial class AppForm : Form
    {
        ArticuloNegocio negocio = new ArticuloNegocio();

        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            dgvTabla.DataSource = negocio.listar("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void AppForm_Load(object sender, EventArgs e)
=======
        private void label3_Click(object sender, EventArgs e)
>>>>>>> 264399ed7c2c21f66078f83de634b86d1ed81095
        {
            allArticulosPanel.Visible = true;
        }

        private void articulosListButton_Click(object sender, EventArgs e)
        {
            allArticulosPanel.Visible = true;
        }

    }
}
