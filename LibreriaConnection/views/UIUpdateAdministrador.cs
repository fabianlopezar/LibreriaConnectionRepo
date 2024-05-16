using System;
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
    public partial class UIUpdateAdministrador : Form
    {
        string administradorOriginal;
        public UIUpdateAdministrador()
        {
            InitializeComponent();
        }

        private void SelectItem(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            administradorOriginal = comboBox1.GetItemText(comboBox1.SelectedItem);
        }// update min 04:00
    }
}
