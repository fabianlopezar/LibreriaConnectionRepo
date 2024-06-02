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
    public partial class UIInsertLibro : Form
    {
        List<Editoriales> listaEditoriales;
        List<Categorias> listaCategorias;
        List<Administradores> listaAdministradores;
        string rutaImagen;
        string dateString;

        string nombreEditorial;
        string nombreCategoria;
        string nombreAdministrador;

        public UIInsertLibro()
        {
            InitializeComponent();
        }

        private void Selects(object sender, EventArgs e)
        {
            ControllerEditorial controllerEditorial = new ControllerEditorial();
            listaEditoriales = controllerEditorial.SelectEditoriales();
            
            for (int i = 0; i < listaEditoriales.Count; i++)
            {
                comboBox1.Items.Add(listaEditoriales[i].NombreEditorial);
            }

            ControllerCategorias controllerCategoria = new ControllerCategorias();
            listaCategorias = controllerCategoria.SelectCategorias();
            for (int i = 0; i < listaCategorias.Count; i++)
            {
                comboBox3.Items.Add(listaCategorias[i].NombreCategoria);
            }

            ControllerAdministrador controllerAdministrador = new ControllerAdministrador();
            listaAdministradores = controllerAdministrador.SelectAdministradores();
            for (int i = 0; i < listaAdministradores.Count; i++)
            {
                comboBox4.Items.Add(listaAdministradores[i].Nombre1Administrador);
            }
        }

        private void InsertarBTN(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string imagen = rutaImagen;
            string codigoISBN = textBox2.Text;
            bool disponible = checkBox1.Checked;
            int cantidadEjemplares = Int32.Parse(textBox3.Text);
            string fechaCreacion = dateString;
            int idEditorial = 0;
            int idCategoria = 0;
            int idAdministrador = 0;


            #region Bucles For 
            for (int i = 0; i < listaEditoriales.Count; i++)
            {
                if (nombreEditorial.Equals(listaEditoriales[i].NombreEditorial))
                {
                    idEditorial = listaEditoriales[i].IdEditorial;
                }
            }
            for (int i = 0; i < listaCategorias.Count; i++)
            {
                if (nombreCategoria.Equals(listaCategorias[i].NombreCategoria))
                {
                    idCategoria = listaCategorias[i].IdCategoria;
                }
            }
            for (int i = 0; i < listaAdministradores.Count; i++)
            {
                if (nombreAdministrador.Equals(listaAdministradores[i].Nombre1Administrador))
                {
                    idAdministrador = listaAdministradores[i].IdAdministrador;
                }
            }
            #endregion
            Libros objLibro = new Libros(title, imagen, codigoISBN, disponible, cantidadEjemplares, fechaCreacion, idEditorial, idCategoria, idAdministrador);
            ControllerLibro controllerLibro = new ControllerLibro();
            bool result = controllerLibro.InsertLibroImage(objLibro);
            if (result)
            {
                MessageBox.Show("Libro Insert Correct");
            }
            else
            {
                MessageBox.Show("Libro Insert Incorrect");
            }

        }

        private void LoadImageBTN(object sender, EventArgs e)
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

        private void SelectDate(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart;
            dateString = date.ToString("yyyy-MM-dd");

        }

        private void EditorialSeleccionado(object sender, EventArgs e)
        {
            nombreEditorial = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void CategoriaSeleccionada(object sender, EventArgs e)
        {
            nombreCategoria = comboBox3.GetItemText(comboBox3.SelectedItem);
        }

        private void AdministradorSeleccionado(object sender, EventArgs e)
        {
            nombreAdministrador = comboBox4.GetItemText(comboBox4.SelectedItem);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /*
private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
{
nombreCiudad = comboBox2.GetItemText(comboBox2.SelectedItem);
}
*/
    }
}
