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
    public partial class UIUpdateLibro : Form
    {
        //editorial categoria administrador
        List<Libros> listaLibros;
        List<Editoriales> listaEditoriales;
        List<Categorias> listaCategorias;
        List<Administradores> listaAdministradores;

        string libroOriginal;
        string editorialSeleccionado;
        string categoriaSeleccionado;
        string administradorSeleccionado;
        string fechaSeleccionada;

        public UIUpdateLibro()
        {
            InitializeComponent();
        }

        private void LoadSelects(object sender, EventArgs e)
        {
            #region Variables
            ControllerEditorial controllerEditorial = new ControllerEditorial();
            ControllerCategorias controllerCategoria = new ControllerCategorias();
            ControllerAdministrador controllerAdministrador = new ControllerAdministrador();
            ControllerLibro controllerLibro = new ControllerLibro();

            listaEditoriales = controllerEditorial.SelectEditoriales();
            listaCategorias = controllerCategoria.SelectCategorias();
            listaAdministradores = controllerAdministrador.SelectAdministradores();
            listaLibros = controllerLibro.SelectLibros();
            #endregion

            #region Bucles For
            for (int i = 0; i < listaEditoriales.Count; i++)
            {
                string editorialNombre = listaEditoriales[i].NombreEditorial;
                comboBox1.Items.Add(editorialNombre);
            }
            for (int i = 0; i < listaCategorias.Count; i++)
            {
                string categoriaNombre = listaCategorias[i].NombreCategoria;
                comboBox3.Items.Add(categoriaNombre);
            }
            for (int i = 0; i < listaAdministradores.Count; i++)
            {
                string administradorNombre = listaAdministradores[i].Nombre1Administrador;
                comboBox4.Items.Add(administradorNombre);
            }
            for (int i = 0; i < listaLibros.Count; i++)
            {
                string libroNombre = listaLibros[i].Titulo;
                comboBox2.Items.Add(libroNombre);
            }
            #endregion
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LibroEscogido(object sender, EventArgs e)
        {
            textBox1.Text = comboBox2.GetItemText(comboBox2.SelectedItem);
            libroOriginal = comboBox2.GetItemText(comboBox2.SelectedItem);
            MostrarAtributos();
        }
        public void MostrarAtributos()
        {
            string libroEscogido = textBox1.Text;
            string titulo = "";
            string codigoISBN = "";
            int cantidadEjemplares = 0;
            string imagen = "";
            string fecha = "";

            for (int i = 0; i < listaLibros.Count; i++)
            {
                if (libroEscogido.Equals(listaLibros[i].Titulo))
                {
                    Console.WriteLine("Soy codigo: " + listaLibros[i].CodigoISBN);
                    titulo = listaLibros[i].Titulo;
                    codigoISBN = listaLibros[i].CodigoISBN;
                    cantidadEjemplares = listaLibros[i].CantidadEjemplares;
                    imagen = listaLibros[i].Imagen;
                    fecha = listaLibros[i].FechaCreacion;
                }
            }
            textBox1.Text = titulo;
            textBox2.Text = codigoISBN;
            textBox3.Text = "" + cantidadEjemplares;

        }

        private void UpdateLibroBtn(object sender, EventArgs e)
        {
            ControllerLibro controllerLibro = new ControllerLibro();
            string title = textBox1.Text;
            string codigoIsbn = textBox2.Text;
            int cantidadEjemplares = Int32.Parse(textBox2.Text);

            int idLibro = 0;
            int idEditorial = 0;
            int idCategoria = 0;
            int idAdministrador = 0;
            #region Bucles For 
            for (int i = 0; i < listaEditoriales.Count; i++)
            {
                if (editorialSeleccionado.Equals(listaEditoriales[i].NombreEditorial))
                {
                    idEditorial = listaEditoriales[i].IdEditorial;
                }
            }
            for (int i = 0; i < listaCategorias.Count; i++)
            {
                if (categoriaSeleccionado.Equals(listaCategorias[i].NombreCategoria))
                {
                    idCategoria = listaCategorias[i].IdCategoria;
                }
            }
            for (int i = 0; i < listaAdministradores.Count; i++)
            {
                if (administradorSeleccionado.Equals(listaAdministradores[i].Nombre1Administrador))
                {
                    idAdministrador = listaAdministradores[i].IdAdministrador;
                }
            }

            for (int i = 0; i < listaLibros.Count; i++)
            {
                if (listaLibros[i].Titulo.Equals(libroOriginal))
                {
                    idLibro = listaLibros[i].IdLibro;
                }
            }
            #endregion



        }

        private void EditorialSeleccionado(object sender, EventArgs e)
        {
            editorialSeleccionado = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void CategoriaSeleccionada(object sender, EventArgs e)
        {
            categoriaSeleccionado = comboBox3.GetItemText(comboBox3.SelectedItem);
        }

        private void AdministradorSeleccionado(object sender, EventArgs e)
        {
            administradorSeleccionado = comboBox4.GetItemText(comboBox4.SelectedItem);
        }

        private void DateSeleccionado(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart;
            fechaSeleccionada = date.ToString("yyyy-MM-dd");
        }
    }
}
