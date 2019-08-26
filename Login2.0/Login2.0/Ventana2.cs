using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2._0
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if(checkBox1.Checked==true)
            {
                conteo++;
            }
            if (checkBox2.Checked==true)
            {
                conteo++;
            }
            if (radioButton1.Checked==true)
            {
                seleccion = "Tarjeta de Crédito";
            }
            else
            {
                seleccion = "Paypal";
            }
            MessageBox.Show("Has seleccionado" + conteo + 
            " Cursos y tu método de pago es " + seleccion);
        }
    }
}
