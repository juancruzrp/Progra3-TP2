using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TrabajoPracticoDos
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;
                
                if (nuevo.Id != 0)
                {
                    negocio.modificar(nuevo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    
                    int idArticulo = negocio.agregar(nuevo);
                    negocio.agregarImagen(idArticulo, txtUrlImagen.Text);

                    MessageBox.Show("Agregado exitosamente");
                }
                
                Close();
            }
            catch (Exception ex)
            {   //hacer esta parte mas user friendly xd

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio(); 

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }


        private void cargarImagen(string imagen)
        {

            try
            {
                pbxArticulo.Load(imagen);

            }
            catch (Exception)
            {

                pbxArticulo.Load("https://png.pngtree.com/png-vector/20221125/ourmid/pngtree-illustration-of-a-flat-vector-icon-set-featuring-a-camera-symbol-and-a-placeholder-image-icon-vector-png-image_40968740.jpg");
            }
        }


    }
}
