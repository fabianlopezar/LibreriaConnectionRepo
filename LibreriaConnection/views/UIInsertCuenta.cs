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
        string rutaImagen;
        string fechaSelecionada;
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

        private void LoadImage(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFifleDialog = new OpenFileDialog();
                openFifleDialog.Filter = "Image files | *.jpg";
                if (openFifleDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = openFifleDialog.FileName;
                    pictureBox1.Image = Image.FromFile(openFifleDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void UIInsertCuenta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            private int idCuenta;
            private string nombre1Cuenta;
            private string nombre2Cuenta;
            private string apellido1Cuenta;
            private string apellido2Cuenta;
            private string direccionCuenta;
            private string foto;
            private string fechaNacimiento;
            private string contraseniaCuenta;*/
            
            string nombre1 = textBox1.Text;
            string nombre2 = textBox2.Text;
            string apellido1 = textBox4.Text;
            string apellido2 = textBox3.Text;
            string direccion = textBox5.Text;
            string contraseña = textBox6.Text;

            Cuentas cuenta = new Cuentas(nombre1,nombre2,apellido1,apellido2, direccion,rutaImagen,fechaSelecionada,contraseña);
            ControllerCuentas controllerCuenta = new ControllerCuentas();
            bool result = controllerCuenta.InsertCuentaImage(cuenta);
            if (result)
            {
                MessageBox.Show("Libro Insert Correct");
            }
            else
            {
                MessageBox.Show("Libro Insert Incorrect");
            }
        }

        private void FechaSeleccionada(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart;
            fechaSelecionada = date.ToString("yyyy-MM-dd");

        }
    }
}
