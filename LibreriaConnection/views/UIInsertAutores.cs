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
    public partial class UIInsertAutores : Form
    {
     
        List<Ciudades> listaCiudades;
        string nombreCiudad;
        public UIInsertAutores()
        {
     
            listaCiudades = new List<Ciudades>();
            InitializeComponent();
        }

        private void Selects(object sender, InputLanguageChangingEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre1Autor = textBox1.Text;
            string nombre2Autor = textBox2.Text;
            string apellido1Autor = textBox4.Text;
            string apellido2Autor = textBox3.Text;
            string direccionAutor = textBox5.Text;
            string telefonoAutor = textBox7.Text;

            int idCiudadKF = 0;
            for (int i = 0; i < listaCiudades.Count; i++)
            {
                if (nombreCiudad.Equals(listaCiudades[i].NombreCiudad))
                {
                    idCiudadKF = listaCiudades[i].IdCiudad;
                }
            }

            Autores objAutor = new Autores(nombre1Autor, nombre2Autor, apellido1Autor, apellido2Autor, direccionAutor, telefonoAutor,idCiudadKF);
            ControllerAutor objControllerAutor = new ControllerAutor();

            bool result = objControllerAutor.InsertAutor(objAutor);
            if (result)
            {
                MessageBox.Show("¡Autor Insert Correct!");
            }
            else
            {
                MessageBox.Show("¡Autor Insert Incorrect!");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreCiudad = comboBox2.GetItemText(comboBox2.SelectedItem);
        }

        private void SelectCiudades(object sender, EventArgs e)
        {            
            ControllerCiudad objControllerCiudad = new ControllerCiudad();            
            listaCiudades = objControllerCiudad.SelectCiudades();

            for (int j = 0; j < listaCiudades.Count; j++)
            {
                comboBox2.Items.Add(listaCiudades[j].NombreCiudad);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
