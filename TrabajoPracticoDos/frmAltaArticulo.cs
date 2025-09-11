﻿using System;
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
                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;


                if (nuevo.Id != 0)
                {
                    negocio.modificar(nuevo);
                MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(nuevo);
                    MessageBox.Show("Agregado exitosamente");
                }
                negocio.agregar(nuevo);
                MessageBox.Show("Articulo agregado con exito.");
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
            ///CategoriaNegocio categoriaNegocio = new CategoriaNegocio(); 

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                ///cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
