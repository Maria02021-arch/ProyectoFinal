using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectofinal
{
    public partial class FormCategorias : Form
    {
        string connectionString = "Server=DESKTOP-URM0EJC\\MSSQLSERVER01;Database=InventarioDB;Trusted_Connection=True;";

        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Categorias", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCategorias.DataSource = dt;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre de categoría.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Categorias (Nombre) VALUES (@Nombre)", con);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            CargarCategorias();
            txtNombre.Clear();
            MessageBox.Show("Categoría agregada correctamente.");
        }
    }
}
