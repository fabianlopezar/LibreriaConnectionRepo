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
    public partial class UIConsultarLibroCategoria : Form
    {
        List<Libros> listaLibros=null;
        List<Categorias> listaCategorias;
        string categoria;
        public UIConsultarLibroCategoria()
        {
            InitializeComponent();
        }

        private void UIConsultarLibroCategoria_Load(object sender, EventArgs e)
        {
            ControllerCategorias controllerCategorias = new ControllerCategorias();
            listaCategorias = controllerCategorias.SelectCategorias();
            for (int i = 0; i < listaCategorias.Count; i++)
            {
                comboBox1.Items.Add(listaCategorias[i].NombreCategoria);
            }
        }

        private void CategoriaSeleccionada(object sender, EventArgs e)
        {
            categoria = comboBox1.GetItemText(comboBox1.SelectedItem);
            int idCategoria = 0;
            for (int i = 0; i < listaCategorias.Count; i++)
            {
                if (categoria.Equals(listaCategorias[i].NombreCategoria))
                {
                    idCategoria = listaCategorias[i].IdCategoria;
                }
            }

            ControllerLibro controllerLibro = new ControllerLibro();
            try
            {
                listaLibros = controllerLibro.ConsultarLibroCategoria(idCategoria);
                //Console.WriteLine(listaLibros[0].Titulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error UIConsultarLibrosCategoria: {ex.Message}");
            }
            
            DataTable tabla = new DataTable();
            tabla.Columns.Add("title", typeof(string));

            foreach (var elem in listaLibros)
            {
                DataRow fila = tabla.NewRow();
                fila["title"] = elem.Titulo;
                tabla.Rows.Add(fila);
            }
            dataGridView1.DataSource = tabla;
            
        }
    }
}
