using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace WinFormsPrototype
{
    public partial class Form1 : Form
    {
        private Usuario user { get; set; }

        public Form1()
        {
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

        private void button1_Click(object sender, EventArgs e) //NO ESTA LISTO.PINCHAAAAAAA!!!
        {

            // Mostrar el siguiente formulario


            LimpiarMensajesError();

            string usuarioIngreso = textBoxUsuario.Text;
            string constraseñaIngreso = textBoxContraseña.Text;
            this.user = DB.TraerClientePorDato(usuarioIngreso);

            //Usuario usuarioValido = usuarios.FirstOrDefault(user => user.usuario == usuarioIngreso && user.contraseña == constraseñaIngreso);

            if (ValidarInicioSesion())
            {
                this.Hide();
                _2daPantalla pantalla2 = new _2daPantalla();
                pantalla2.Show();
            }
            else
            {
                usuarioErrorLbl.Show();
                contraseñaErrorLbl.Show();
            }

            //foreach (Usuario a in usuarios)
            //{
            //    if ()
            //    {
            //        MessageBox.Show("Usuario o contraseña incorrecta");

            //    }else
            //    {
            //        // Inicio de sesión exitoso
            //        MessageBox.Show("Inicio de sesión exitoso");

            //        // Mostrar el siguiente formulario
            //        _2daPantalla pantalla2 = new _2daPantalla();
            //        pantalla2.Show();

            //        // Ocultar el formulario actual
            //        this.Hide();

            //        // Si encontraste el usuario, puedes salir del bucle
            //        break;
            //    }
            //}
        }

        private bool ValidarInicioSesion()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(textBoxUsuario.Text))
            {
                usuarioErrorLbl.Text = "El usuario no puede estar vacio.";
                valido = false;
            }

            if (string.IsNullOrEmpty(textBoxContraseña.Text))
            {
                contraseñaErrorLbl.Text = "La contraseña no puede estar vacia.";
                valido = false;
            }

            if (!valido) { return valido; }

            if (this.user == null)
            {
                usuarioErrorLbl.Text = "El usuario no se encuentra registrado.";
                valido = false;
            }
            else
            {
                if (!string.Equals(textBoxContraseña.Text, this.user.contraseña, StringComparison.Ordinal))
                {
                    contraseñaErrorLbl.Text = "La contraseña es incorrecta.";
                    valido = false;
                }
            }

            return valido;
        }

        private void LimpiarMensajesError()
        {
            usuarioErrorLbl.Text = "";
            contraseñaErrorLbl.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
