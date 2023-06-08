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
    public partial class _2daPantalla : Form
    {
        public _2daPantalla()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3raPantalla pantalla3 = new _3raPantalla();

            // Mostrar el formulario 3raPantalla
            pantalla3.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 pantalla1 = new Form1();
            pantalla1.Show();
            this.Hide();
        }

    }
}
