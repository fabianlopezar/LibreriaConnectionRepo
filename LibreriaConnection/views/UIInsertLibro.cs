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
    public partial class UIInsertLibro : Form// video 26:00
    {
        List<Editoriales> listaEditoriales;
        List<Categorias> listaCategorias;
        List<Administradores> listaAdministradores;
        string rutaImagen;
        string dateString;
        public UIInsertLibro()
        {
            InitializeComponent();
        }

        private void Selects(object sender, EventArgs e)
        {
            Console.WriteLine("deberia funcionar");
            ControllerEditorial controllerEditorial = new ControllerEditorial();
            listaEditoriales = controllerEditorial.SelectEditoriales();
            for (int i = 0; i < listaEditoriales.Count; i++)
            {
                comboBox1.Items.Add(listaEditoriales[i].IdEditorial);
            }

            ControllerCategorias controllerCategoria = new ControllerCategorias();
            listaCategorias = controllerCategoria.SelectCategorias();
            for (int i = 0; i < listaCategorias.Count; i++)
            {
                comboBox3.Items.Add(listaCategorias[i].IdCategoria);
            }

            ControllerAdministrador controllerAdministrador = new ControllerAdministrador();
            listaAdministradores = controllerAdministrador.SelectAdministradores();
            for (int i = 0; i < listaAdministradores.Count; i++)
            {
                comboBox4.Items.Add(listaAdministradores[i].IdAdministrador);
            }
        }

        private void InsertarBTN(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string imagen = rutaImagen;
            string codigoISBN = textBox2.Text;
            bool disponible = checkBox1.Checked;
            string cantidadEjemplares = textBox2.Text;
            string fechaCreacion = rutaImagen;
            int idEditorial;
            int idCategoria;
            int idAdministrador;
            



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
    }
}
