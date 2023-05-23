using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ///asdasdasdsa
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string usuario = textBoxUsuario.Text;
                string contraseña = textBoxContraseña.Text;

                // Verificar si el usuario y la contraseña son válidos
                if (usuario == "JuanRoman" && contraseña == "1234")
                {
                    // Inicio de sesión exitoso
                    MessageBox.Show("Inicio de sesión exitoso");

                    // Mostrar el siguiente formulario
                    _2daPantalla pantalla2 = new _2daPantalla();
                    pantalla2.Show();

                    // Ocultar el formulario actual
                    this.Hide();
                }
                else
                {
                    // Inicio de sesión fallido
                    MessageBox.Show("Inicio de sesión fallido. Intente nuevamente.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
