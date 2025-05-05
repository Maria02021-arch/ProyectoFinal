using System;
using System.Windows.Forms;

namespace proyectofinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorias formCategorias = new FormCategorias();
            formCategorias.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos productosForm = new FormProductos();
            productosForm.ShowDialog();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
