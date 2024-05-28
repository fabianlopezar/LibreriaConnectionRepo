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
        string rutaImage;
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
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutaImage = openFileDialog1.FileName;
                    //Console.WriteLine("Name file " + openFileDialog1.FileName);
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }

        private void UIInsertCuenta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre1Cuenta = textBox1.Text;
            string nombre2Cuenta = textBox2.Text;
            string apellido1Cuenta = textBox4.Text;
            string apellido2Cuenta = textBox3.Text;
            string direccionCuenta = textBox5.Text;
            string contraseniaCuenta = textBox6.Text;
            string foto = rutaImage;

            Cuentas objC = new Cuentas(nombre1Cuenta, nombre2Cuenta, apellido1Cuenta, apellido2Cuenta, direccionCuenta, foto, contraseniaCuenta);
            ControllerCuentas objCC = new ControllerCuentas();
            bool result = objCC.InserCuentaImage(objC);

            if (result)
            {
                MessageBox.Show("Costumer Insert Correct");
            }
            else
            {
                MessageBox.Show("Costumer Insert Incorrect");
            }
        }
    }
}
