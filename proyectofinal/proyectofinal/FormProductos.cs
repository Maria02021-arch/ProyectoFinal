using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectofinal
{
    public partial class FormProductos : Form
    {
        string connectionString = "Server=DESKTOP-URM0EJC\\MSSQLSERVER01;Database=InventarioDB;Trusted_Connection=True;";

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Productos", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Productos (Nombre, Descripcion, Cantidad, PrecioCompra, PrecioVenta) VALUES (@Nombre, @Descripcion, @Cantidad, @PrecioCompra, @PrecioVenta)", con);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                cmd.Parameters.AddWithValue("@PrecioCompra", decimal.Parse(txtCompra.Text));
                cmd.Parameters.AddWithValue("@PrecioVenta", decimal.Parse(txtVenta.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            CargarProductos();
            MessageBox.Show("Producto agregado correctamente");
        }
    }
}
