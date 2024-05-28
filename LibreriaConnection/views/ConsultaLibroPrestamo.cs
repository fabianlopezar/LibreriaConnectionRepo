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
    // -------------------- UI ------------------------
    public partial class ConsultaLibroPrestamo : Form
    {
        List<Libros> listaLibros;
        public ConsultaLibroPrestamo()
        {
            InitializeComponent();
        }

        private void LoadConsultaLibroPrestamoLector(object sender, EventArgs e)
        {
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();
            try
            {
                listaLibros = controllerPrestamo.ConsultaLibrosEnPrestamo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ConsultarLibroPrestamo : {ex.Message}");
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
