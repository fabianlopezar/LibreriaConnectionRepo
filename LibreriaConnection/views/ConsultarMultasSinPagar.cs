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
    public partial class ConsultarMultasSinPagar : Form
    {
        public ConsultarMultasSinPagar()
        {
            InitializeComponent();
        }

        private void ConsultarMultasSinPagar_Load(object sender, EventArgs e)
        {
            _ConsultarMultasSinPagar();
        }
        private void _ConsultarMultasSinPagar()
        {
            List<Multas> listaMultas= null;
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();

            try
            {
                listaMultas = controllerPrestamo.ConsultarMultaSinPagar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            DataTable tabla = new DataTable();
            tabla.Columns.Add("title", typeof(int));

            foreach (var elem in listaMultas)
            {                
                DataRow fila = tabla.NewRow();
                fila["title"] = elem.IdMultas;
                tabla.Rows.Add(fila);
            }
            dataGridView2.DataSource = tabla;
            
        }
    }
}
