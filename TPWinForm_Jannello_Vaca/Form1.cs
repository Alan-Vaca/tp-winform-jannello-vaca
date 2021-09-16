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
    }
}
