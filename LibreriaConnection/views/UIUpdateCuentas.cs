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
    public partial class UIUpdateCuentas : Form
    {
        List<Cuentas> listaCuentas;
        string cuentaOriginal;
        public UIUpdateCuentas()
        {
            InitializeComponent();
        }

        private void SelectCuenta(object sender, EventArgs e)
        {
            ControllerCuentas objcc = new ControllerCuentas();
            listaCuentas = objcc.SelectCuentas();

            for (int i = 0; i < listaCuentas.Count; i++)
            {
                string _nombre1Cuenta = listaCuentas[i].Nombre1Cuenta;
                
                comboBox1.Items.Add(_nombre1Cuenta );

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cuentaUpdate = textBox1.Text;
            ControllerCuentas objCC = new ControllerCuentas();
            int idCuenta = 0;
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (listaCuentas[i].Nombre1Cuenta.Equals(cuentaOriginal))
                {
                    idCuenta = listaCuentas[i].IdCuenta;
                }
            }
            Cuentas objCuentas = new Cuentas(idCuenta, cuentaUpdate);
            bool result = objCC.UpdateCuentas(objCuentas);
            if (result)
            {
                MessageBox.Show("Modificacion Correcta");
            }
            else
            {
                MessageBox.Show("Modificacion Incorrecta");
            }
        }


        private void SelectItem(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            cuentaOriginal = comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }
}
