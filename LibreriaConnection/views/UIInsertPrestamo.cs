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
        List<Libros> listaLibros = null;
        string nombreCuenta;
        string nombreLibro;
        string fecha1;
        string fecha2;
        public UIInsertPrestamo()
        {
            InitializeComponent();
        }

        private void Consultar(object sender, EventArgs e)
        {
            ControllerCuentas controllerCuentas = new ControllerCuentas();
            ControllerLibro controllerLibro = new ControllerLibro();

            listaCuentas = controllerCuentas.SelectCuentas();
            listaLibros = controllerLibro.SelectLibros();

            for (int i = 0; i < listaCuentas.Count; i++)
            {
                comboBox1.Items.Add(listaCuentas[i].Nombre1Cuenta);
            }
            for (int i = 0; i < listaLibros.Count; i++)
            {
                comboBox2.Items.Add(listaLibros[i].Titulo);
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

            int idLibroPrestamo_Libro=0;

            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (nombreCuenta.Equals(listaCuentas[i].Nombre1Cuenta))
                {
                    idCuentaPrestamo = listaCuentas[i].IdCuenta;
                }
            }
            for (int i = 0; i < listaLibros.Count; i++)
            {
                if (nombreLibro.Equals(listaLibros[i].Titulo))
                {
                    idLibroPrestamo_Libro = listaLibros[i].IdLibro;
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

            int ultimoPrestamoID=0;
            List<Prestamos> listaPrestamosId = controllerPrestamo.ConsultarUltimoPrestamoId();
            if (listaPrestamosId.Count > 0)
            {
                Prestamos ultimoPrestamo = listaPrestamosId[listaPrestamosId.Count - 1];
                ultimoPrestamoID = ultimoPrestamo.IdPrestamo;
            }
            MessageBox.Show("Soy id Prestamo: "+ ultimoPrestamoID);

            int _idPrestamo = prestamo.IdPrestamo;
            MessageBox.Show("Soy id Prestamo_Libro: "+idLibroPrestamo_Libro);
            Libro_Prestamo libro_Prestamo = new Libro_Prestamo(ultimoPrestamoID, idLibroPrestamo_Libro);
            ControllerLibro_Prestamo controllerLibro_Prestamo = new ControllerLibro_Prestamo();



            bool result2 = controllerLibro_Prestamo.InsertPrestamo(libro_Prestamo);



            if (result2)
            {
                MessageBox.Show("Prestamo_Libro Insert Correct");
            }
            else
            {
                MessageBox.Show("Prestamo_Libro Insert Incorrect");
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

        private void LibroSelecionado(object sender, EventArgs e)
        {
            nombreLibro = comboBox2.GetItemText(comboBox2.SelectedItem);
        }
    }
}
