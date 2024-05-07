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
    public partial class UIInsertCategoria : Form
    {
        public UIInsertCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreCategoria = textBox1.Text;
            string fechaCreacion = textBox2.Text;

            Categorias objC = new Categorias(nombreCategoria, fechaCreacion);
            ControllerCategorias objCC = new ControllerCategorias();

            bool restult = objCC.InsertCategoria(objC);
            if (restult)
            {
                MessageBox.Show("¡Categoria Insert Correct!");
            }
            else
            {
                MessageBox.Show("¡Categoria Insert Incorrect!");
            }
        }
    }
}
