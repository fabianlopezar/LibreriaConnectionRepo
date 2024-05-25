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
    public partial class UIInsertCuenta : Form
    {
        public UIInsertCuenta()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UIInsertCuenta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre1 = textBox1.Text;
            string nombre2 = textBox2.Text;
            string apellido1 = textBox4.Text;
            string apellido2 = textBox3.Text;
            string direccion = textBox5.Text;
            string contraseña = textBox6.Text;

            Cuentas cuenta = new Cuentas();
            ControllerCuentas controllerCuenta = new ControllerCuentas();
        }
    }
}
