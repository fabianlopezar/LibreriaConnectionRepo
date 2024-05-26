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
        List<Cuentas> listaCuentas;
        string nombreCuenta;
        public UIConsultarLibrosLector()
        {
            InitializeComponent();
        }

        private void UIConsultarLibrosLector_Load(object sender, EventArgs e)
        {            
            #region ListaCuentas          
            ControllerCuentas controllerCuenta = new ControllerCuentas();
            listaCuentas = controllerCuenta.SelectCuentas();

            for (int j = 0; j < listaCuentas.Count; j++)
            {
                comboBox1.Items.Add(listaCuentas[j].Nombre1Cuenta);
            }
            #endregion
           
           
        }

        private void SelectCuenta(object sender, EventArgs e)
        {
            nombreCuenta = comboBox1.GetItemText(comboBox1.SelectedItem);
            int idCuenta = 0;
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (nombreCuenta.Equals(listaCuentas[i].Nombre1Cuenta))
                {
                    idCuenta = listaCuentas[i].IdCuenta;
                }
            }

            #region Consulta
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();
            try
            {
                listaLibros = controllerPrestamo.ConsultaLibroPrestamoCuenta(idCuenta);
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
            #endregion
        }
    }
}
