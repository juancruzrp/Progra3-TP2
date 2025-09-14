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
    public partial class frmMarca : Form
    {
        private DataGridView dgvMarcas;
        private Button btnAgregarMarca;
        private Button btnEliminarMarca;
        private Button button1;
        

        public frmMarca()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(30, 43);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(325, 190);
            this.dgvMarcas.TabIndex = 0;
            this.dgvMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellContentClick);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(30, 249);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(96, 38);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(265, 249);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(89, 38);
            this.btnEliminarMarca.TabIndex = 2;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMarca
            // 
            this.ClientSize = new System.Drawing.Size(437, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "frmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Marcas";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            cargarMarca();
        }

        private List<Marca> listaMarcas;

        public object dgvMarca { get; private set; }

        private void cargarMarca()
        {
            MarcaNegocio negMarc = new MarcaNegocio(); // tu clase que contiene listar()
            try
            {
              MarcaNegocio negocio = new MarcaNegocio();
                dgvMarcas.DataSource = negocio.listar();
                dgvMarcas.Columns["Id"].Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAltaMarca alta = new frmAltaMarca();
            alta.ShowDialog();
            cargarMarca();
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar permanentemente esta marca?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
    
                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminarFisico(seleccionada.Id);
                    cargarMarca();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAltaMarca modificar = new frmAltaMarca(seleccionado);
            modificar.ShowDialog();
            cargarMarca();
        }
    }
}
