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
        string autorOriginal;
        public UIUpdateAutores()
        {
            InitializeComponent();
        }

        private void SelectAutor(object sender, EventArgs e)
        {
            ControllerAutor objControllerAutor = new ControllerAutor();
            listaAutores = objControllerAutor.SelectAutores();

            for (int i = 0; i < listaAutores.Count; i++)
            {
                string autorNombre = listaAutores[i].Nombre1Autor;
                comboBox1.Items.Add(autorNombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string autorUpdate = textBox1.Text;
            ControllerAutor objControllerAutor = new ControllerAutor();
            int idAutor = 0;
            for (int i = 0; i < listaAutores.Count; i++)
            {
                if (listaAutores[i].Nombre1Autor.Equals(autorOriginal))
                {
                    idAutor = listaAutores[i].IdAutor;
                }
            }
            Autores objAutor= new Autores(idAutor, autorUpdate);
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
