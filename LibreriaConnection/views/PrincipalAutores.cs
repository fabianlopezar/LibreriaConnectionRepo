﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaConnection.views
{
    public partial class PrincipalAutores : Form
    {
        public PrincipalAutores()
        {
            InitializeComponent();
        }

        public void AbrirForm(Form form)
        {
            while (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            Form formHijo = form;
            form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(formHijo);
            formHijo.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new UIInsertAutores()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new UIUpdateAutores());          
        }
    }
}