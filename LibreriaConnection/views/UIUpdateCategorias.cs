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
    
    public partial class UIUpdateCategorias : Form
    {
        List<Categorias> listaC;
        string categoriaOriginal;
        public UIUpdateCategorias()
        {
            InitializeComponent();
        }

        private void SelectCategorias(object sender, EventArgs e)
        {
            ControllerCategorias objcc = new ControllerCategorias();
            listaC = objcc.SelectCategorias();


            for (int i = 0; i < listaC.Count; i++)
            {
                string categoriasname = listaC[i].NombreCategoria;

                comboBox1.Items.Add(categoriasname);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoriaUpdate = textBox1.Text;
            ControllerCategorias objCC = new ControllerCategorias();
            int idC = 0;
            for (int i = 0; i < listaC.Count; i++)
            {
                if (listaC[i].NombreCategoria.Equals(categoriaOriginal))
                {
                    idC = listaC[i].IdCategoria;
                }
            }
            Categorias objCategorias= new Categorias(idC,categoriaUpdate);
            bool result = objCC.UpdateCategorias(objCategorias);
            if (result)
            {
                MessageBox.Show("Modificacion Correcta");
            }
            else
            {
                MessageBox.Show("Modificacion Incorrecta");
            }
        }

        private void SelectItemV(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            categoriaOriginal= comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }
}
