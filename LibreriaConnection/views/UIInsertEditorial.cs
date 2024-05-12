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
    public partial class UIInsertEditorial : Form
    {
        public UIInsertEditorial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreEditorial = textBox1.Text;

            Editoriales objEditorial = new Editoriales(nombreEditorial);
            ControllerEditorial objController = new ControllerEditorial();

            bool result = objController.InsertEditorial(objEditorial);
            if (result)
            {
                MessageBox.Show("¡Film Insert Correct!");
            }
            else
            {

                MessageBox.Show("¡Film Insert Incorrect!");
            }
        }
    }
}
