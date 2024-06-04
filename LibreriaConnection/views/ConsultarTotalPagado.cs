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
    public partial class ConsultarTotalPagado : Form
    {
        string fecha1;
        string fecha2;
        string nombreCuenta;
        List<Cuentas> listaCuentas = null;
        List<Multas> listaMultas = null;
        public ConsultarTotalPagado()
        {
            InitializeComponent();
        }

        private void FechaSelecinada1(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart;
            fecha1 = date.ToString("yyyy-MM-dd");
        }

        private void FechaSeleccionada2(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar2.SelectionStart;
            fecha2 = date.ToString("yyyy-MM-dd");
        }

        private void CuentaSelecionada(object sender, EventArgs e)
        {
            nombreCuenta = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void Consultar(object sender, EventArgs e)
        {
            ControllerCuentas controllerCuentas = new ControllerCuentas();
            listaCuentas = controllerCuentas.SelectCuentas();
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                comboBox1.Items.Add(listaCuentas[i].Nombre1Cuenta);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----------------------------
            int idCuenta = 0;
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (nombreCuenta.Equals(listaCuentas[i].Nombre1Cuenta))
                {
                    idCuenta = listaCuentas[i].IdCuenta;
                }
            }
            //-----------------------------
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();
            try
            {
             //   listaMultas = controllerPrestamo.ConsultarMultasPagadasEntreFechas(fecha1, fecha2, idCuenta);
                listaMultas = controllerPrestamo.ConsultaTotalPagado(fecha1, fecha2, idCuenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error UICosultarPrestamo PorFecha: {ex.Message}");
            }
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Total Pagado", typeof(double));

            foreach (var elem in listaMultas)
            {
                DataRow fila = tabla.NewRow();
                fila["Total Pagado"] = elem.ValorAPagar;
                tabla.Rows.Add(fila);
            }
            dataGridView2.DataSource = tabla;
        }
    }
}
