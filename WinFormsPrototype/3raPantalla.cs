using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsPrototype
{
    public partial class _3raPantalla : Form
    {
        int total = 0;
        int totalHotel1 = 0;
        int totalHotel2 = 0;
        int totalHotel3 = 0;
        public _3raPantalla()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Madrid")
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;

            }
            if (comboBox1.SelectedItem.ToString() == "Miami")
            {
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;
            }
            else
            {
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;

            }

        }


        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //hotel 1 madrid 
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;
            TimeSpan duracionReserva = fechaFin - fechaInicio;
            int cantidadNoches = Convert.ToInt32(duracionReserva.TotalDays);
            int precioPorPersona = 17530; // Precio por persona por noche
            int cantidadPersonas = Convert.ToInt32(comboBoxPersonas.SelectedItem);
            int totalReserva = precioPorPersona * cantidadPersonas * cantidadNoches;
            if (checkBox1.Checked)
            {
                // Incrementar el total
                totalHotel1 = totalReserva;
                total += totalReserva;
            }else
            {
                totalHotel1 -= totalReserva;
                total -= totalReserva;
            }

            TotalHotel1.Text = "Total: " + totalHotel1.ToString();
            totalAlojamientoMadrid.Text = "Total: " + total.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Hotel3 madrid 
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;
            TimeSpan duracionReserva = fechaFin - fechaInicio;
            int cantidadNoches = Convert.ToInt32(duracionReserva.TotalDays);
            int precioPorPersona = 26860; // Precio por persona por noche
            int cantidadPersonas = Convert.ToInt32(comboBoxPersonas.SelectedItem);
            int totalReserva = precioPorPersona * cantidadPersonas * cantidadNoches;


            if (checkBox3.Checked)
            {
                // Incrementar el total
                totalHotel3 = totalReserva;
                total += totalReserva;
            }
            else
            {
                totalHotel3 -= totalReserva;
                total -= totalReserva;
            }
            TotalHotel3.Text = "Total: " + totalHotel3.ToString();
            totalAlojamientoMadrid.Text = "Total: " + total.ToString();
        }

        private void TotalHotel3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Hotel2 madrid 
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;
            TimeSpan duracionReserva = fechaFin - fechaInicio;
            int cantidadNoches = Convert.ToInt32(duracionReserva.TotalDays);
            int precioPorPersona = 43500; // Precio por persona por noche
            int cantidadPersonas = Convert.ToInt32(comboBoxPersonas.SelectedItem);
            int totalReserva = precioPorPersona * cantidadPersonas * cantidadNoches;
           
            if (checkBox2.Checked)
            {
                // Incrementar el total
                totalHotel2 = totalReserva;
                total += totalReserva;
            }
            else
            {
                totalHotel2 -= totalReserva;
                total -= totalReserva;
            }
            TotalHotel2.Text = "Total: " + totalHotel2.ToString();
            totalAlojamientoMadrid.Text = "Total: " + total.ToString();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {


        }

        private void TotalHotel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
