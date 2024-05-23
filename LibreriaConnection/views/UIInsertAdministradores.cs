using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaConnection.models;
using LibreriaConnection.controller;

namespace LibreriaConnection.views
{
    public partial class UIInsertAdministradores : Form
    {
        public UIInsertAdministradores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre1Administrador = textBox1.Text;
            string nombre2Administrador = textBox2.Text;
            string apellido1Administrador = textBox4.Text;
            string apellido2Administrador = textBox3.Text;
            string correo = textBox5.Text;
            string contraseniaAdministrador = textBox6.Text;

            Administradores objAdministrador = new Administradores(nombre1Administrador,nombre2Administrador, apellido1Administrador,apellido2Administrador,correo, contraseniaAdministrador);
            ControllerAdministrador objController = new ControllerAdministrador();

            bool result = objController.InsertAdministrador(objAdministrador);
            if (result)
            {
                MessageBox.Show("¡Administrador Insert Correct!");
            }
            else
            {
                MessageBox.Show("¡Administrador Insert Incorrect!");

            }
        }

        private void UIInsertAdministradores_Load(object sender, EventArgs e)
        {

        }
    }
}
