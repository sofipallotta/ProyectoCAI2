
namespace WinFormsPrototype
{
    partial class _3raPantalla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonAlojamiento = new System.Windows.Forms.RadioButton();
            this.radioButtonVuelo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.labelDestinoVuelo = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOrigenVuelo = new System.Windows.Forms.Label();
            this.textBoxSeleccionMenores = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSeleccionAdultos = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalReserva = new System.Windows.Forms.Label();
            this.TotalHotel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalHotel2 = new System.Windows.Forms.Label();
            this.TotalHotel3 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.totalAlojamientoMadrid = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBoxAlojamiento = new System.Windows.Forms.GroupBox();
            this.precioTotal = new System.Windows.Forms.Label();
            this.comboBoxOrigenVuelo = new System.Windows.Forms.ComboBox();
            this.comboBoxDestinoVuelo = new System.Windows.Forms.ComboBox();
            this.textBoxSeleccionInfante = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxAlojamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ventas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButtonAlojamiento
            // 
            this.radioButtonAlojamiento.AutoSize = true;
            this.radioButtonAlojamiento.Location = new System.Drawing.Point(119, 104);
            this.radioButtonAlojamiento.Name = "radioButtonAlojamiento";
            this.radioButtonAlojamiento.Size = new System.Drawing.Size(95, 19);
            this.radioButtonAlojamiento.TabIndex = 11;
            this.radioButtonAlojamiento.TabStop = true;
            this.radioButtonAlojamiento.Text = "Alojamientos";
            this.radioButtonAlojamiento.UseVisualStyleBackColor = true;
            this.radioButtonAlojamiento.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButtonVuelo
            // 
            this.radioButtonVuelo.AutoSize = true;
            this.radioButtonVuelo.Location = new System.Drawing.Point(311, 104);
            this.radioButtonVuelo.Name = "radioButtonVuelo";
            this.radioButtonVuelo.Size = new System.Drawing.Size(60, 19);
            this.radioButtonVuelo.TabIndex = 12;
            this.radioButtonVuelo.TabStop = true;
            this.radioButtonVuelo.Text = "Vuelos";
            this.radioButtonVuelo.UseVisualStyleBackColor = true;
            this.radioButtonVuelo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha inicio";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(112, 139);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(91, 23);
            this.dateTimePickerInicio.TabIndex = 21;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.DateTimePickerInicio_ValueChanged);
            // 
            // labelDestinoVuelo
            // 
            this.labelDestinoVuelo.AutoSize = true;
            this.labelDestinoVuelo.Location = new System.Drawing.Point(465, 145);
            this.labelDestinoVuelo.Name = "labelDestinoVuelo";
            this.labelDestinoVuelo.Size = new System.Drawing.Size(105, 15);
            this.labelDestinoVuelo.TabIndex = 24;
            this.labelDestinoVuelo.Text = "Seleccione destino";
            this.labelDestinoVuelo.Visible = false;
            // 
            // producto
            // 
            this.producto.AutoSize = true;
            this.producto.Location = new System.Drawing.Point(45, 78);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(115, 15);
            this.producto.TabIndex = 26;
            this.producto.Text = "Seleccione producto";
            this.producto.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Menores";
            this.label1.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // labelOrigenVuelo
            // 
            this.labelOrigenVuelo.AutoSize = true;
            this.labelOrigenVuelo.Location = new System.Drawing.Point(220, 145);
            this.labelOrigenVuelo.Name = "labelOrigenVuelo";
            this.labelOrigenVuelo.Size = new System.Drawing.Size(100, 15);
            this.labelOrigenVuelo.TabIndex = 31;
            this.labelOrigenVuelo.Text = "Seleccione origen";
            this.labelOrigenVuelo.Visible = false;
            // 
            // textBoxSeleccionMenores
            // 
            this.textBoxSeleccionMenores.Location = new System.Drawing.Point(272, 174);
            this.textBoxSeleccionMenores.Name = "textBoxSeleccionMenores";
            this.textBoxSeleccionMenores.Size = new System.Drawing.Size(35, 23);
            this.textBoxSeleccionMenores.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Adultos";
            // 
            // textBoxSeleccionAdultos
            // 
            this.textBoxSeleccionAdultos.Location = new System.Drawing.Point(113, 174);
            this.textBoxSeleccionAdultos.Name = "textBoxSeleccionAdultos";
            this.textBoxSeleccionAdultos.Size = new System.Drawing.Size(35, 23);
            this.textBoxSeleccionAdultos.TabIndex = 36;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(510, 174);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 37;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(196, 19);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Hotel Panamericano - 3 estrellas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(495, 328);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(189, 19);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "Hotel Cuesta Chica - 2 estrellas";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(151, 19);
            this.checkBox3.TabIndex = 33;
            this.checkBox3.Text = "Hotel Faena - 4 estrellas";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Precio";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // labelTotalReserva
            // 
            this.labelTotalReserva.Location = new System.Drawing.Point(485, 271);
            this.labelTotalReserva.Name = "labelTotalReserva";
            this.labelTotalReserva.Size = new System.Drawing.Size(100, 23);
            this.labelTotalReserva.TabIndex = 47;
            // 
            // TotalHotel1
            // 
            this.TotalHotel1.Location = new System.Drawing.Point(399, 260);
            this.TotalHotel1.Name = "TotalHotel1";
            this.TotalHotel1.Size = new System.Drawing.Size(100, 23);
            this.TotalHotel1.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Precio";
            // 
            // TotalHotel2
            // 
            this.TotalHotel2.AutoSize = true;
            this.TotalHotel2.Location = new System.Drawing.Point(590, 66);
            this.TotalHotel2.Name = "TotalHotel2";
            this.TotalHotel2.Size = new System.Drawing.Size(0, 15);
            this.TotalHotel2.TabIndex = 39;
            this.TotalHotel2.Click += new System.EventHandler(this.Label9_Click);
            // 
            // TotalHotel3
            // 
            this.TotalHotel3.AutoSize = true;
            this.TotalHotel3.Location = new System.Drawing.Point(590, 91);
            this.TotalHotel3.Name = "TotalHotel3";
            this.TotalHotel3.Size = new System.Drawing.Size(10, 15);
            this.TotalHotel3.TabIndex = 40;
            this.TotalHotel3.Text = " ";
            this.TotalHotel3.Click += new System.EventHandler(this.TotalHotel3_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(544, 298);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(178, 19);
            this.checkBox4.TabIndex = 41;
            this.checkBox4.Text = "Hotel Americano - 3 estrellas";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(447, 310);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(187, 19);
            this.checkBox5.TabIndex = 42;
            this.checkBox5.Text = "Hotel Rosa Magica - 2 estrellas";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(11, 87);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(170, 19);
            this.checkBox6.TabIndex = 43;
            this.checkBox6.Text = "Hotel Maryland - 4 estrellas";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Visible = false;
            // 
            // totalAlojamientoMadrid
            // 
            this.totalAlojamientoMadrid.AutoSize = true;
            this.totalAlojamientoMadrid.Location = new System.Drawing.Point(590, 137);
            this.totalAlojamientoMadrid.Name = "totalAlojamientoMadrid";
            this.totalAlojamientoMadrid.Size = new System.Drawing.Size(0, 15);
            this.totalAlojamientoMadrid.TabIndex = 44;
            this.totalAlojamientoMadrid.Click += new System.EventHandler(this.Label9_Click_1);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(33, 112);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(83, 19);
            this.checkBox7.TabIndex = 32;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.CheckBox7_CheckedChanged);
            // 
            // groupBoxAlojamiento
            // 
            this.groupBoxAlojamiento.Controls.Add(this.checkBox7);
            this.groupBoxAlojamiento.Controls.Add(this.totalAlojamientoMadrid);
            this.groupBoxAlojamiento.Controls.Add(this.checkBox6);
            this.groupBoxAlojamiento.Controls.Add(this.TotalHotel3);
            this.groupBoxAlojamiento.Controls.Add(this.TotalHotel2);
            this.groupBoxAlojamiento.Controls.Add(this.label8);
            this.groupBoxAlojamiento.Controls.Add(this.label7);
            this.groupBoxAlojamiento.Controls.Add(this.label6);
            this.groupBoxAlojamiento.Controls.Add(this.checkBox3);
            this.groupBoxAlojamiento.Controls.Add(this.checkBox1);
            this.groupBoxAlojamiento.Location = new System.Drawing.Point(605, 250);
            this.groupBoxAlojamiento.Name = "groupBoxAlojamiento";
            this.groupBoxAlojamiento.Size = new System.Drawing.Size(47, 79);
            this.groupBoxAlojamiento.TabIndex = 30;
            this.groupBoxAlojamiento.TabStop = false;
            this.groupBoxAlojamiento.Text = "Alojamientos";
            this.groupBoxAlojamiento.Visible = false;
            this.groupBoxAlojamiento.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // precioTotal
            // 
            this.precioTotal.AutoSize = true;
            this.precioTotal.Location = new System.Drawing.Point(689, 381);
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.Size = new System.Drawing.Size(44, 15);
            this.precioTotal.TabIndex = 38;
            this.precioTotal.Text = "label10";
            this.precioTotal.Click += new System.EventHandler(this.precioTotal_Click);
            // 
            // comboBoxOrigenVuelo
            // 
            this.comboBoxOrigenVuelo.FormattingEnabled = true;
            this.comboBoxOrigenVuelo.Location = new System.Drawing.Point(326, 139);
            this.comboBoxOrigenVuelo.Name = "comboBoxOrigenVuelo";
            this.comboBoxOrigenVuelo.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOrigenVuelo.TabIndex = 39;
            this.comboBoxOrigenVuelo.Visible = false;
            this.comboBoxOrigenVuelo.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            // 
            // comboBoxDestinoVuelo
            // 
            this.comboBoxDestinoVuelo.FormattingEnabled = true;
            this.comboBoxDestinoVuelo.Location = new System.Drawing.Point(576, 139);
            this.comboBoxDestinoVuelo.Name = "comboBoxDestinoVuelo";
            this.comboBoxDestinoVuelo.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDestinoVuelo.TabIndex = 40;
            this.comboBoxDestinoVuelo.Visible = false;
            // 
            // textBoxSeleccionInfante
            // 
            this.textBoxSeleccionInfante.Location = new System.Drawing.Point(424, 174);
            this.textBoxSeleccionInfante.Name = "textBoxSeleccionInfante";
            this.textBoxSeleccionInfante.Size = new System.Drawing.Size(35, 23);
            this.textBoxSeleccionInfante.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Infantes";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // _3raPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSeleccionInfante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxDestinoVuelo);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.comboBoxOrigenVuelo);
            this.Controls.Add(this.precioTotal);
            this.Controls.Add(this.labelTotalReserva);
            this.Controls.Add(this.TotalHotel1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxSeleccionAdultos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSeleccionMenores);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.labelOrigenVuelo);
            this.Controls.Add(this.groupBoxAlojamiento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.labelDestinoVuelo);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonVuelo);
            this.Controls.Add(this.radioButtonAlojamiento);
            this.Controls.Add(this.label2);
            this.Name = "_3raPantalla";
            this.Text = "_3raPantalla";
            this.Load += new System.EventHandler(this._3raPantalla_Load);
            this.groupBoxAlojamiento.ResumeLayout(false);
            this.groupBoxAlojamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonAlojamiento;
        private System.Windows.Forms.RadioButton radioButtonVuelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label labelDestinoVuelo;
        private System.Windows.Forms.Label producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOrigenVuelo;
        private System.Windows.Forms.TextBox textBoxSeleccionMenores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSeleccionAdultos;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotalReserva;
        private System.Windows.Forms.Label TotalHotel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TotalHotel2;
        private System.Windows.Forms.Label TotalHotel3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label totalAlojamientoMadrid;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.GroupBox groupBoxAlojamiento;
        private System.Windows.Forms.Label precioTotal;
        private System.Windows.Forms.ComboBox comboBoxOrigenVuelo;
        private System.Windows.Forms.ComboBox comboBoxDestinoVuelo;
        private System.Windows.Forms.TextBox textBoxSeleccionInfante;
        private System.Windows.Forms.Label label10;
    }
}