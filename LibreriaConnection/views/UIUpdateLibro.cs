using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        
        string rutaImagen;
        string fecha = "";

        string imagenUpdate;
        
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
            CargarImagenDesdeBase64(rutaImagen);
            DateCargado();
        }
        public void MostrarAtributos()
        {
            string libroEscogido = textBox1.Text;
            string titulo = "";
            string codigoISBN = "";
            //imagen
            bool disponible = false;
            int cantidadEjemplares = 0;
    
            int idEditorial = 0;
            int idCategoria = 0;
            int idAdministrador = 0;

            for (int i = 0; i < listaLibros.Count; i++)
            {
                if (libroEscogido.Equals(listaLibros[i].Titulo))
                {                
                    titulo = listaLibros[i].Titulo;
                    rutaImagen = listaLibros[i].Imagen;
                    codigoISBN = listaLibros[i].CodigoISBN;
                    cantidadEjemplares = listaLibros[i].CantidadEjemplares;
                    fecha = listaLibros[i].FechaCreacion;
                    disponible = listaLibros[i].Disponible;
                    Console.WriteLine("Soy la imagen cargada: " + rutaImagen);
                    idEditorial = listaLibros[i].IdEditorialLibro;
                    idCategoria= listaLibros[i].IdCategoriaLibro;
                    idAdministrador= listaLibros[i].IdAdministradorLibro;
                }
            }

           
            textBox1.Text = titulo;
            textBox2.Text = codigoISBN;
            textBox3.Text = "" + cantidadEjemplares;
            checkBox1.Checked = disponible;
            comboBox1.Text = listaEditoriales.FirstOrDefault(e => e.IdEditorial == idEditorial)?.NombreEditorial;
            comboBox3.Text = listaCategorias.FirstOrDefault(c => c.IdCategoria == idCategoria)?.NombreCategoria;
            comboBox4.Text = listaAdministradores.FirstOrDefault(a => a.IdAdministrador == idAdministrador)?.Nombre1Administrador;
        }

        private void UpdateLibroBtn(object sender, EventArgs e)
        {
            ControllerLibro controllerLibro = new ControllerLibro();
            
            string title = textBox1.Text;            
            string _imagenUpdate=imagenUpdate;
            string codigoISBN = textBox2.Text;
            bool  disponible = checkBox1.Checked;
            int cantidadEjemplares = Int32.Parse(textBox3.Text);
            
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
            Console.WriteLine("Sou la imagen update: " + _imagenUpdate);
            #endregion        
            Libros objLibro = new Libros(idLibro,title, _imagenUpdate, codigoISBN, disponible, cantidadEjemplares, fecha, idEditorial, idCategoria, idAdministrador);
            
            bool result = controllerLibro.UpdateLibro(objLibro);
            if (result)
            {
                MessageBox.Show("Libro Update Correct");
            }
            else
            {
                MessageBox.Show("Libro Update Incorrect");
            }
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
            fecha = date.ToString("yyyy-MM-dd");
         
        }
        public void DateCargado()
        {            
            // Parsear el string en un objeto DateTime
            DateTime dateTime = DateTime.ParseExact(fecha, "yyyy-MM-dd HH:mm:ss", null);                       
            
            monthCalendar1.SelectionStart = dateTime.Date; 
        }
        public void CargarImagenDesdeBase64(string base64Imagen)
        {
            try
            {
                // Verificar que el string base64 no esté vacío
                if (!string.IsNullOrEmpty(base64Imagen))
                {
                    // Decodificar la imagen desde el string base64 a un array de bytes
                    byte[] imageBytes = Convert.FromBase64String(base64Imagen);

                    // Usar un MemoryStream para convertir el array de bytes en una imagen
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        // Asignar la imagen al PictureBox
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Mostrar un mensaje de error si el string base64 está vacío
                    MessageBox.Show("El string de imagen base64 está vacío.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                // Mostrar un mensaje de error si el string base64 no es válido
                MessageBox.Show("El string base64 no es válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error genérico si ocurre alguna otra excepción
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFifleDialog = new OpenFileDialog();
                openFifleDialog.Filter = "Image files | *.jpg";
                if (openFifleDialog.ShowDialog() == DialogResult.OK)
                {
                    imagenUpdate = openFifleDialog.FileName;
                    pictureBox1.Image = Image.FromFile(openFifleDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }
    }
}
