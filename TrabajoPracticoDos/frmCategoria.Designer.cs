namespace TrabajoPracticoDos
{
    partial class frmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoria.Location = new System.Drawing.Point(32, 42);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(334, 188);
            this.dgvCategoria.TabIndex = 0;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(29, 249);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(110, 40);
            this.btnAgregarCategoria.TabIndex = 1;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(244, 249);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(101, 40);
            this.btnEliminarCategoria.TabIndex = 2;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(145, 249);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(93, 40);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.bontonModificar);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 321);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.dgvCategoria);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Categorias";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnmodificar;
    }
}