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
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoria;

        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
           txtCategoria.Text = categoria.Descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnAceptar_Click(sender, e, categoria);
        }

        private void btnAceptar_Click(object sender, EventArgs e, Categoria categoria)
        {
            Categoria nueva = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
                {
                if (categoria != null && categoria.Id != 0)
                {
                    categoria.Descripcion = txtCategoria.Text;
                    negocio.modificar(categoria);
                    MessageBox.Show("Modificado exitosamente");
                    Close();
                    return;
                }
                else {
                categoria = new Categoria();
                    nueva.Descripcion = txtCategoria.Text;
                negocio.agregar(nueva);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
