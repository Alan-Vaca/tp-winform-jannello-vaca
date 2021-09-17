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
            reLoadTable();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            formAgregar form = new formAgregar();
            form.ShowDialog();
            reLoadTable();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarForm form = new eliminarForm();
            form.ShowDialog();
            reLoadTable();
        }

        private void reLoadTable()
        {
            dgvTabla.DataSource = negocio.listar("Where A.IdMarca = M.Id and A.IdCategoria = C.Id");
        }

        private void BtnSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
