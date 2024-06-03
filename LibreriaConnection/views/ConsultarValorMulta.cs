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
    public partial class ConsultarValorMulta : Form
    {
        List<Cuentas> listaCuentas;
        List<Multas> listaMultas;
        string nombreCuenta;

        public ConsultarValorMulta()
        {
            InitializeComponent();
        }

        private void SelectCuenta(object sender, EventArgs e)
        {
            ControllerCuentas controllerCuentas = new ControllerCuentas();
            listaCuentas = controllerCuentas.SelectCuentas();
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                comboBox1.Items.Add(listaCuentas[i].Nombre1Cuenta);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreCuenta = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCuenta = 0;
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (nombreCuenta.Equals(listaCuentas[i].Nombre1Cuenta))
                {
                    idCuenta = listaCuentas[i].IdCuenta;
                }
            }
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();
            try
            {
                listaMultas = controllerPrestamo.ConsultarValorMulta(idCuenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
            DataTable tabla = new DataTable();
            tabla.Columns.Add("valor", typeof(double));

            foreach (var elem in listaMultas)
            {
                DataRow fila = tabla.NewRow();
                fila["valor"] = elem.ValorAPagar;
                tabla.Rows.Add(fila);
            }
            dataGridView2.DataSource = tabla;
        }
    }
}
