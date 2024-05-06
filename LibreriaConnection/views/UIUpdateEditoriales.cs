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
    public partial class UIUpdateEditoriales : Form
    {
        List<Editoriales> listaEditoriales;
        string editorialOriginal;
        public UIUpdateEditoriales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string editorialUpdate = textBox1.Text;
            ControllerEditorial obj = new ControllerEditorial();
            int _idEditorial = 0;
            for (int i = 0; i < listaEditoriales.Count; i++)
            {
                if (listaEditoriales[i].NombreEditorial.Equals(editorialOriginal)){
                    _idEditorial = listaEditoriales[i].IdEditorial;
                }
            }
            Editoriales objEditorial = new Editoriales(_idEditorial, editorialUpdate);
            bool result = obj.UpdateEditoriales(objEditorial);
            if (result)
            {
                MessageBox.Show("Modificacion Correcta");
            }
            else
            {
                MessageBox.Show("Modificacion Incorrecta");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectEditoriales(object sender, EventArgs e)
        {
            ControllerEditorial obj = new ControllerEditorial();
            listaEditoriales = obj.SelectEditoriales();
            for (int i = 0; i < listaEditoriales.Count; i++)
            {
                string _nombreEditorial = listaEditoriales[i].NombreEditorial;
                comboBox1.Items.Add(_nombreEditorial);
            }
        }

        private void SelectItem(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            editorialOriginal = comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }
}
