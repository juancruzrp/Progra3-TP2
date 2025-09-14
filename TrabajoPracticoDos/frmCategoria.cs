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
                dgvCategoria.Columns["Id"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria();
            alta.ShowDialog();
            cargarCategoria();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar permanentemente esta categoria?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    negocio.eliminarFisico(seleccionada.Id);
                    cargarCategoria();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void bontonModificar(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria seleccionado;
                seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                frmAltaCategoria modificar = new frmAltaCategoria(seleccionado);
                modificar.ShowDialog();
                cargarCategoria();
            }

            else
            {
                MessageBox.Show("Seleccione una categoría para modificar.");
            }
        }
    }
}
