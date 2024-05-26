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
    public partial class UIConsultarLibrosLector : Form
    {
        List<Libros> listaLibros;
        public UIConsultarLibrosLector()
        {
            InitializeComponent();
        }

        private void UIConsultarLibrosLector_Load(object sender, EventArgs e)
        {
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();
            try
            {
                listaLibros = controllerPrestamo.ConsultaLibroPrestamoCuenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error UIConsultarLibrosLector: {ex.Message}");
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
