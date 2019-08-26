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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(textUser.Text=="Juancho"&& textPassword.Text=="123tamarindo")
            {
                MessageBox.Show("Bienvenido Sr Don Juancho");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto no Valido");
                textUser.Text = "";
                textPassword.Text = "";
                textUser.Focus();
            }
        }
    }
}
