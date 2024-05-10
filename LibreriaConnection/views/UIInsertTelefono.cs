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
    public partial class UIInsertTelefono : Form
    {
        List<Cuentas> listaCuentas;
        string nombreCuenta;
        public UIInsertTelefono()
        {
            listaCuentas = new List<Cuentas>();
            InitializeComponent();
        }

        private void SelectCuenta(object sender, EventArgs e)
        {
            ControllerCuentas objCC = new ControllerCuentas();
            listaCuentas = objCC.SelectCuentas();
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                comboBox1.Items.Add(listaCuentas[i].Nombre1Cuenta);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroTelefonico = textBox1.Text;
            int idFKCuenta = 0;
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (nombreCuenta.Equals(listaCuentas[i].Nombre1Cuenta))
                {
                    idFKCuenta = listaCuentas[i].IdCuenta;
                }
            }

            Telefonos objTelefono = new Telefonos(numeroTelefonico, idFKCuenta);
            ControllerTelefono objController = new ControllerTelefono();
            bool result = objController.InsertTelefono(objTelefono);
            if (result)
            {
                MessageBox.Show("¡Telefono Insert Correct!");
            }
            else
            {
                MessageBox.Show("¡Cuidado Telefono Insert Incorrect!");   
            }

        }

        private void SelectItemCuenta(object sender, EventArgs e)
        {
            nombreCuenta = comboBox1.GetItemText(comboBox1.SelectedItem);

        }
    }
}
