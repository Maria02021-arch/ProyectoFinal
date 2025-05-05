using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectofinal
{
    public partial class FormProveedores : Form
    {
        string connectionString = "Server=DESKTOP-URM0EJC\\MSSQLSERVER01;Database=InventarioDB;Trusted_Connection=True;";

        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Proveedores", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProveedores.DataSource = dt;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtContacto.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Proveedores (Nombre, Contacto) VALUES (@Nombre, @Contacto)", con);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@Contacto", txtContacto.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            CargarProveedores();
            txtNombre.Clear();
            txtContacto.Clear();
            MessageBox.Show("Proveedor agregado correctamente.");
        }
    }
}
