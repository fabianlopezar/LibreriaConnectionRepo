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
    public partial class UIInsertPrestamo : Form
    {
        List<Cuentas> listaCuentas = null;
        string nombreCuenta;
        string fecha1;
        string fecha2;
        public UIInsertPrestamo()
        {
            InitializeComponent();
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

        private void CuentaSelecionada(object sender, EventArgs e)
        {
            nombreCuenta = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPrestamo;
            string fechaPrestamo = fecha1;
            string fechaDevolucion = fecha2;
            bool estaVencido = checkBox1.Checked;
            int idCuentaPrestamo = 0;

            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (nombreCuenta.Equals(listaCuentas[i].Nombre1Cuenta))
                {
                    idCuentaPrestamo = listaCuentas[i].IdCuenta;
                }
            }
            Prestamos prestamo = new Prestamos(fechaPrestamo, fechaDevolucion, estaVencido, idCuentaPrestamo);
            ControllerPrestamo controllerPrestamo = new ControllerPrestamo();
            bool result = controllerPrestamo.InsertPrestamo(prestamo);
            if (result)
            {
                MessageBox.Show("Prestamo Insert Correct");
            }
            else
            {
                MessageBox.Show("Prestamo Insert Incorrect");
            }
        }

        private void FechaSelecionada1(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart;
            fecha1 = date.ToString("yyyy-MM-dd");
        }

        private void FechaSelecionada2(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar2.SelectionStart;
            fecha2 = date.ToString("yyyy-MM-dd");
        }
    }
}
