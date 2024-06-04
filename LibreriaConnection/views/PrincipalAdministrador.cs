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
    public partial class PrincipalAdministrador : Form
    {
        private bool isCollapsed = true;
        public PrincipalAdministrador()
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
            AbrirForm(new UIInsertLibro()); //libro insert
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new UIUpdateLibro()); //libro insert          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new UIUpdateCategorias());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelOpciones.Height += 10;

                if (panelOpciones.Size == panelOpciones.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelOpciones.Height -= 10;
                if (panelOpciones.Size == panelOpciones.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }

        }
        

        private void button14_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }       

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel2.Height += 10;

                if (panel2.Size == panel2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirForm(new UIInsertLibro());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForm(new UIInsertAutores());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AbrirForm(new UIUpdateLibro());
        }

        private void button16_Click(object sender, EventArgs e)
        {
           AbrirForm(new UIUpdateCategorias());
        }

        private void button17_Click(object sender, EventArgs e)
        {
           AbrirForm(new UIUpdateAutores());
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel3.Height += 10;

                if (panel3.Size == panel3.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           AbrirForm(new UIConsultarLibrosLector());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           AbrirForm(new ConsultaLibroPrestamo());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           AbrirForm(new ConsultaPrestamoPorFecha());

        }

        private void button5_Click(object sender, EventArgs e)
        {
           AbrirForm(new UIConsultarLibroCategoria());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //UIConsultarCantidadLibrosPrestados
           AbrirForm(new UIConsultarCantidadLibrosPrestados());
        }

        private void button10_Click(object sender, EventArgs e)
        {
           AbrirForm(new ConsultarValorMulta());

        }
    }
    

}
