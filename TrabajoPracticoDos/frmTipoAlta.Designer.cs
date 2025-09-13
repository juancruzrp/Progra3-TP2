namespace TrabajoPracticoDos
{
    partial class frmTipoAlta
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
            this.btnAltaArticulo = new System.Windows.Forms.Button();
            this.btnAltaMarca = new System.Windows.Forms.Button();
            this.btnAltaCategoria = new System.Windows.Forms.Button();
            this.lblAlta = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaArticulo
            // 
            this.btnAltaArticulo.Location = new System.Drawing.Point(44, 121);
            this.btnAltaArticulo.Name = "btnAltaArticulo";
            this.btnAltaArticulo.Size = new System.Drawing.Size(79, 48);
            this.btnAltaArticulo.TabIndex = 0;
            this.btnAltaArticulo.Text = "Nuevo Articulo";
            this.btnAltaArticulo.UseVisualStyleBackColor = true;
            this.btnAltaArticulo.Click += new System.EventHandler(this.btnAltaArticulo_Click);
            // 
            // btnAltaMarca
            // 
            this.btnAltaMarca.Location = new System.Drawing.Point(187, 121);
            this.btnAltaMarca.Name = "btnAltaMarca";
            this.btnAltaMarca.Size = new System.Drawing.Size(75, 48);
            this.btnAltaMarca.TabIndex = 1;
            this.btnAltaMarca.Text = "Nueva Marca";
            this.btnAltaMarca.UseVisualStyleBackColor = true;
            this.btnAltaMarca.Click += new System.EventHandler(this.btnAltaMarca_Click);
            // 
            // btnAltaCategoria
            // 
            this.btnAltaCategoria.Location = new System.Drawing.Point(320, 121);
            this.btnAltaCategoria.Name = "btnAltaCategoria";
            this.btnAltaCategoria.Size = new System.Drawing.Size(77, 48);
            this.btnAltaCategoria.TabIndex = 2;
            this.btnAltaCategoria.Text = "Nueva Categoria";
            this.btnAltaCategoria.UseVisualStyleBackColor = true;
            this.btnAltaCategoria.Click += new System.EventHandler(this.btnAltaCategoria_Click);
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Location = new System.Drawing.Point(154, 55);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(129, 13);
            this.lblAlta.TabIndex = 3;
            this.lblAlta.Text = "Seleccione el tipo de alta:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(176, 210);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 56);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver al menu anterior";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmTipoAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 333);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblAlta);
            this.Controls.Add(this.btnAltaCategoria);
            this.Controls.Add(this.btnAltaMarca);
            this.Controls.Add(this.btnAltaArticulo);
            this.Name = "frmTipoAlta";
            this.Text = "frmTipoAlta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaArticulo;
        private System.Windows.Forms.Button btnAltaMarca;
        private System.Windows.Forms.Button btnAltaCategoria;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.Button btnVolver;
    }
}