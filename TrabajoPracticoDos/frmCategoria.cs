using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoDos
{
    public partial class frmCategoria : Form
    {
        private List<Categoria> listaCategoria;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
        }

        private void cargarCategoria()
        {
            CategoriaNegocio negCategoria = new CategoriaNegocio();
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                dgvCategoria.DataSource = negocio.listarCategorias();
                dgvCategoria.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
