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
    }
}
