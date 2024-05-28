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
    public partial class UIConsultarCantidadLibrosPrestados : Form
    {
        int numeroLibrosActuales = 0;
        int numeroLibrosVencidos = 0;
        public UIConsultarCantidadLibrosPrestados()
        {
            InitializeComponent();
        }

        private void UIConsultarCantidadLibrosPrestados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarLibrosActuales();
            ConsultarLibrosVencidos();
        }

        private void ConsultarLibrosActuales()
        {
            List<Libros> listaLibros = null;
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();

            try
            {
                listaLibros = controllerPrestamo.ConsultarCantidadLibrosPrestamosActuales();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error UIConsultarCantidadLibrosPrestados: {ex.Message}");
            }

            DataTable tabla = new DataTable();
            tabla.Columns.Add("title", typeof(string));

            foreach (var elem in listaLibros)
            {
                numeroLibrosActuales++;
                DataRow fila = tabla.NewRow();
                fila["title"] = elem.Titulo;
                tabla.Rows.Add(fila);
            }
            dataGridView1.DataSource = tabla;
            textBox1.Text = "" + numeroLibrosActuales;
        }
        private void ConsultarLibrosVencidos()
        {
            List<Libros> listaLibros = null;
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();
            try
            {
                listaLibros = controllerPrestamo.ConsultarCantidadLibrosPrestamosVencidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error UIConsultarCantidadLibrosPrestados: {ex.Message}");
            }
            DataTable tabla = new DataTable();
            tabla.Columns.Add("title", typeof(string));

            foreach (var elem in listaLibros)
            {
                numeroLibrosVencidos++;
                DataRow fila = tabla.NewRow();
                fila["title"] = elem.Titulo;
                tabla.Rows.Add(fila);
            }
            dataGridView2.DataSource = tabla;
            textBox2.Text = "" + numeroLibrosVencidos;
        }
    }
}
