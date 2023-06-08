using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace WinFormsPrototype
{
    public partial class _3raPantalla : Form
    {
        double acumulador = 0;
        public _3raPantalla()
        {
            InitializeComponent();
        }

        private FlowLayoutPanel flowLayoutPanel;



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _3raPantalla_Load(object sender, EventArgs e)
        {


        }

        private void Alojamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Alojamiento_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBoxAlojamiento.Visible = true;
            }
            else
            {
                groupBoxAlojamiento.Visible = false;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea agregar otro producto?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                // Navegar a la tercera pantalla en blanco (3raPantalla)
                _3raPantalla formaTerceraPantalla = new _3raPantalla();
                formaTerceraPantalla.Show();

                // Ocultar o cerrar el formulario actual si ya no lo necesitas
                this.Hide(); // O this.Close() si deseas cerrarlo
            }
            else if (respuesta == DialogResult.No)
            {
                // Navegar a la cuarta pantalla (4taPantalla)
                _4taPantalla formaCuartaPantalla = new _4taPantalla();
                formaCuartaPantalla.Show();

                // Ocultar o cerrar el formulario actual si ya no lo necesitas
                this.Hide(); // O this.Close() si deseas cerrarlo
            }
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TotalHotel3_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click_1(object sender, EventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            List<Vuelo> vuelos = Vuelo.TraerVuelo();

            int y = 210; // Posición vertical inicial
            System.Windows.Forms.CheckBox lastCheckedBox = null;
            

            foreach (Vuelo vuelo in vuelos)
            {
                if (vuelo.origen == textBoxOrigen.Text)
                {
                    System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                    // checkBox.Text = vuelo.nombreProducto + vuelo.idVuelo;
                    checkBox.Text = "Aerolinea: " + vuelo.nombreProducto + "ID: " + vuelo.idVuelo + " Precio: " + vuelo.precio;
                    checkBox.AutoSize = true;
                    checkBox.Location = new System.Drawing.Point(100, y);

                    checkBox.CheckedChanged += (sender, e) =>
                    {
                        if (checkBox.Checked)
                        {

                            if (lastCheckedBox != null && lastCheckedBox != checkBox)
                                lastCheckedBox.Checked = false;
                            // Establece el CheckBox actual como el último CheckBox seleccionado
                            lastCheckedBox = checkBox;
                            acumulador += vuelo.precio;
                        }
                        else
                        {
                            acumulador -= vuelo.precio;
                        }
                        precioTotal.Text = "Precio Total: " + acumulador.ToString("C");
                    };

                    this.Controls.Add(checkBox);
                    y += checkBox.Height + 10;
                }
                /*System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                // checkBox.Text = vuelo.nombreProducto + vuelo.idVuelo;
                checkBox.Text = "Aerolinea: " + vuelo.nombreProducto + "ID: " + vuelo.idVuelo + " Precio: " + vuelo.precio;
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(100, y);

                checkBox.CheckedChanged += (sender, e) =>
                {
                    if (checkBox.Checked)
                    {
                        
                        if (lastCheckedBox != null && lastCheckedBox != checkBox)
                            lastCheckedBox.Checked = false;
                        // Establece el CheckBox actual como el último CheckBox seleccionado
                        lastCheckedBox = checkBox;
                        acumulador += vuelo.precio;
                    }
                    else
                    {
                        acumulador -= vuelo.precio;
                    }
                    precioTotal.Text = "Precio Total: " + acumulador.ToString("C");
                };

                this.Controls.Add(checkBox);
                y += checkBox.Height + 10; */
            }
        }

        private void DateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<Vuelo> vuelos = Vuelo.TraerVuelo();

            int y = 210; // Posición vertical inicial
            System.Windows.Forms.CheckBox lastCheckedBox = null;


            foreach (Vuelo vuelo in vuelos)
            {

                if (vuelo.origen == textBoxOrigen.Text)
                {

                    System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                    // checkBox.Text = vuelo.nombreProducto + vuelo.idVuelo;
                    checkBox.Text = "Aerolinea: " + vuelo.nombreProducto + "ID: " + vuelo.idVuelo + " Precio: " + vuelo.precio;
                    checkBox.AutoSize = true;
                    checkBox.Location = new System.Drawing.Point(100, y);

                    checkBox.CheckedChanged += (sender, e) =>
                    {
                        if (checkBox.Checked)
                        {

                            if (lastCheckedBox != null && lastCheckedBox != checkBox)
                                lastCheckedBox.Checked = false;
                            // Establece el CheckBox actual como el último CheckBox seleccionado
                            lastCheckedBox = checkBox;
                            acumulador += vuelo.precio;
                        }
                        else
                        {
                            acumulador -= vuelo.precio;
                        }
                        precioTotal.Text = "Precio Total: " + acumulador.ToString("C");
                    };

                    this.Controls.Add(checkBox);
                    y += checkBox.Height + 10;
                }
            }

        }//falta que cuando se busque por segunda vez no se pise 

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {        

        }

        private void button3_Click(object sender, EventArgs e) //Falta agregar que si clickea guarde la opcion seleccionada y validar que tenga un producto seleccionado
        {
            DialogResult respuesta = MessageBox.Show("¿Desea agregar otro producto?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                // Navegar a la tercera pantalla en blanco (3raPantalla)
                _3raPantalla formaTerceraPantalla = new _3raPantalla();
                formaTerceraPantalla.Show();

                // Ocultar o cerrar el formulario actual si ya no lo necesitas
                this.Hide(); // O this.Close() si deseas cerrarlo
            }
            else if (respuesta == DialogResult.No)
            {
                // Navegar a la cuarta pantalla (4taPantalla)
                _4taPantalla formaCuartaPantalla = new _4taPantalla();
                formaCuartaPantalla.Show();

                // Ocultar o cerrar el formulario actual si ya no lo necesitas
                this.Hide(); // O this.Close() si deseas cerrarlo
            } 
        }

        private FlowLayoutPanel GetFlowLayoutPanel()
        {
            return flowLayoutPanel;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e, FlowLayoutPanel flowLayoutPanel)
        {

        }

        private void Vuelos_Enter(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void precioTotal_Click(object sender, EventArgs e)
        {
            precioTotal.Text = "Precio Total: " + acumulador.ToString("C");
        }
        private void precioTotal_TextChanged(object sender, EventArgs e)
        {
            precioTotal.Text = "Precio Total: " + acumulador.ToString("C");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
