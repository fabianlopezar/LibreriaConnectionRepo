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
    public partial class UIUpdateAutores : Form
    {
        List<Autores> listaAutores;
        List<Ciudades> listaCiudades;
        string autorOriginal;
        string ciudadEscojida;
        public UIUpdateAutores()
        {
            InitializeComponent();
        }

        private void Selects(object sender, EventArgs e)
        {
            ControllerAutor objControllerAutor = new ControllerAutor();
            listaAutores = objControllerAutor.SelectAutores();
            ControllerCiudad objCC = new ControllerCiudad();
            listaCiudades = objCC.SelectCiudades();

            for (int i = 0; i < listaAutores.Count; i++)// Llena el ComboBox de nombres 1.
            {
                string autorNombre = listaAutores[i].Nombre1Autor;
                comboBox1.Items.Add(autorNombre);
            }

            for (int i = 0; i < listaCiudades.Count; i++)
            {
                comboBox2.Items.Add(listaCiudades[i].NombreCiudad);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre1 = textBox1.Text;
            string nombre2 = textBox2.Text;
            string apellido1 = textBox3.Text;
            string apellido2 = textBox4.Text;
            string direccion = textBox5.Text;
            string telefono = textBox6.Text;
            ControllerAutor objControllerAutor = new ControllerAutor();
            int idAutor = 0;
            int idCiudad = 0;
            for (int i = 0; i < listaAutores.Count; i++)
            {
                if (listaAutores[i].Nombre1Autor.Equals(autorOriginal))
                {
                    idAutor = listaAutores[i].IdAutor;
                }
            }
            for (int i = 0; i < listaAutores.Count; i++)
            {
                if (listaCiudades[i].NombreCiudad.Equals(ciudadEscojida))
                {
                    idCiudad = listaCiudades[i].IdCiudad;
                }
            }
            Autores objAutor = new Autores(idAutor, nombre1, nombre2, apellido1, apellido2, direccion, telefono,idCiudad);
            bool result = objControllerAutor.UpdateAutor(objAutor);
            if (result)
            {
                MessageBox.Show("¡Modificacion Correcta!");
            }
            else
            {
                MessageBox.Show("¡Modificacion Incorrecta!");

            }
        }

        private void SelectItem(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            autorOriginal = comboBox1.GetItemText(comboBox1.SelectedItem);
            MostrarAtributos();
        }
        private void SelectItemCiudad(object sender, EventArgs e)
        {
            ciudadEscojida = comboBox2.GetItemText(comboBox2.SelectedItem);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MostrarAtributos()
        {
            string autorEscojido = textBox1.Text;

            string nombre2 = "2";
            string apellido1 = "";
            string apellido2 = "";
            string direccion = "";
            string telefono = "";

            for (int i = 0; i < listaAutores.Count; i++)// Recorre la lista de autores.
            {
                if (autorEscojido.Equals(listaAutores[i].Nombre1Autor))// Si autorUpdate es igual al de la lista ejecute.
                {
                    nombre2 = listaAutores[i].Nombre2Autor;
                    apellido1 = listaAutores[i].Apellido1Autor;
                    apellido2 = listaAutores[i].Apellido2Autor;
                    direccion = listaAutores[i].DireccionAutor;
                    telefono = listaAutores[i].TelefonoAutor;

                }
            }

            textBox2.Text = nombre2;
            textBox3.Text = apellido1;
            textBox4.Text = apellido2;
            textBox5.Text = direccion;
            textBox6.Text = telefono;
            //Console.WriteLine("soy nombre 2: " + nombre2);

        }


    }
}
