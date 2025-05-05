using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectofinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-URM0EJC\\MSSQLSERVER01;Database=InventarioDB;Trusted_Connection=True;";
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Contrasena = @contrasena";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contrasena", contrasena);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar(); // devuelve el número de coincidencias

                    if (count > 0)
                    {
                        //Usuario válido: abrir el sistema de inventario(Form2)
                        Form2 inventarioForm = new Form2();
                        inventarioForm.Show();
                        this.Hide(); // ocultar la pantalla de login
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }
    }
}
