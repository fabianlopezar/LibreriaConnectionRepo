using MySql.Data.MySqlClient;
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
        public MySqlConnection logManager;
        string server = "127.0.0.1";
        string database = "libreria";
        string user = "root";
        string password = "root";
        public UILogin()
        {
            InitializeComponent();
        }

        public MySqlConnection DataSource()
        {
            string connectionString = $"server={server};database={database};Uid={user};Pwd={password}";
            logManager = new MySqlConnection(connectionString);
            return logManager;
        }

        private void UILogin_Load(object sender, EventArgs e)
        {
            DataSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarAdministrador(txtCorreo.Text, txtContrasenia.Text))
            {
                MessageBox.Show("Bienvenido Administrador");
                ShowAdminInterface();
            }
            else if (ValidarCuenta(txtCorreo.Text, txtContrasenia.Text))
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
                logManager.Open();
                string consulta = "select * from administradores where correo=@correo and contraseniaAdministrador=@contraseniaA";
                MySqlCommand comando = new MySqlCommand(consulta, logManager);
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
                logManager.Close();
            }
        }
        private bool ValidarCuenta(string direccionCuenta, string contrasenia)
        {
            try
            {
                logManager.Open();
                string consulta = "select * from cuentas where direccionCuenta=@direccionCuenta and contraseniaCuenta=@contraseniaC";
                MySqlCommand comando = new MySqlCommand(consulta, logManager);
                comando.Parameters.AddWithValue("@direccionCuenta", direccionCuenta);
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
                logManager.Close();
            }
        }
        private void ShowAdminInterface()
        {
            PrincipalAdministrador adminForm = new PrincipalAdministrador(); //Vista de el administrador
            this.Hide();
            adminForm.Show();
        }
        private void ShowUserInterface()
        {
            UIInsertCategoria userForm = new UIInsertCategoria(); //Vista de el usuario
            this.Hide();
            userForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCorreo.Clear();
            txtContrasenia.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
