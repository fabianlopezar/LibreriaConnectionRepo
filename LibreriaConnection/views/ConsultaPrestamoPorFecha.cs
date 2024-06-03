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
    public partial class ConsultaPrestamoPorFecha : Form
    {
        string fecha1;
        string fecha2;
        List<Libros> listaLibros = null;
        public ConsultaPrestamoPorFecha()
        {
            InitializeComponent();
        }

        private void Consulta(object sender, EventArgs e)
        {
           
        }

        private void FechaSelecionada1(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart;
            fecha1 = date.ToString("yyyy-MM-dd");
        }

        private void fechaSelecionada2(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar2.SelectionStart;
            fecha2 = date.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();
            try
            {
                listaLibros = controllerPrestamo.ConsultarLibrosPrestadoEntreFechas(fecha1, fecha2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error UICosultarPrestamo PorFecha: {ex.Message}");
            }
            DataTable tabla = new DataTable();
            tabla.Columns.Add("title", typeof(string));

            foreach (var elem in listaLibros)
            {
                DataRow fila = tabla.NewRow();
                fila["title"] = elem.Titulo;
                tabla.Rows.Add(fila);
            }
            dataGridView2.DataSource = tabla;
        }
    }
}
