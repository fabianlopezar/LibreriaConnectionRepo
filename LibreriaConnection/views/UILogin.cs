using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibreriaConnection.views
{
    public partial class UILogin : Form
    {
        public MySqlConnection connManager;
        string server = "127.0.0.1";
        string database = "libreria";
        string user = "root";
        string password = "maxwell55A@";

        public UILogin()
        {
            InitializeComponent();
        }

        public MySqlConnection DataSource()
        {
            string connectionString = $"server={server};database={database};Uid={user};Pwd={password}";
            connManager = new MySqlConnection(connectionString);
            return connManager;
        }

        private void UILogin_Load(object sender, EventArgs e)
        {
            DataSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarAdministrador(txtNombreOCorreo.Text, txtContrasenia.Text))
            {
                MessageBox.Show("Bienvenido Administrador");
                ShowAdminInterface();
            }
            else if (ValidarCuenta(txtNombreOCorreo.Text, txtContrasenia.Text))
            {
                MessageBox.Show("Bienvenido Usuario");
                ShowUserInterface();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
        private bool ValidarAdministrador(string correo, string contrasenia)
        {
            try
            {
                connManager.Open();
                string consulta = "select * from administradores where correo=@correo and contraseniaAdministrador=@contraseniaA";
                MySqlCommand comando = new MySqlCommand(consulta, connManager);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@contraseniaA", contrasenia);
                MySqlDataReader reader = comando.ExecuteReader();

                return reader.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connManager.Close();
            }
        }
        private bool ValidarCuenta(string nombreCuenta, string contrasenia)
        {
            try
            {
                connManager.Open();
                string consulta = "select * from cuentas where nombre1Cuenta=@nombreCuenta and contraseniaCuenta=@contraseniaC";
                MySqlCommand comando = new MySqlCommand(consulta, connManager);
                comando.Parameters.AddWithValue("@nombreCuenta", nombreCuenta);
                comando.Parameters.AddWithValue("@contraseniaC", contrasenia);
                MySqlDataReader reader = comando.ExecuteReader();

                return reader.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connManager.Close();
            }
        }
        private void ShowAdminInterface()
        {
           PrincipalAdministrador adminForm = new PrincipalAdministrador(); //Aquí va el UI de la vista que va a tener el administrador
            this.Hide();
            adminForm.Show();
        }

        private void ShowUserInterface()
        {
            //ConsultarValorMulta userForm = new ConsultarValorMulta(); //Aquí va el UI de la vista que va a tener el usuario, falta el prestamo
            PrincipalAutores userForm = new PrincipalAutores(); //Aquí va el UI de la vista que va a tener el usuario, falta el prestamo
            this.Hide();
            userForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombreOCorreo.Clear();
            txtContrasenia.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
