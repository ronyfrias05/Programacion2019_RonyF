﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimiento
{
    public partial class Form1 : Form
    {
        public bool mouseActivado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            
            // Obtener el valor de la tecla
            var keyValue = e.KeyValue;

            var posicionX = label1.Location.X;
            var posicionY = label1.Location.Y;
            // MessageBox.Show(keyValue.ToString());

            // MessageBox.Show( posicionX.ToString() );
            // MessageBox.Show( posicionY.ToString() );

            // label1.Location = new System.Drawing.Point(0, 0);

            // Reseteo
            if (keyValue == 82)
            {
                // Centro relativo al padre
                // CentroX
                var anchoPadre = pictureBox1.Width;
                var anchoHijo = label1.Width;
                var margenX = pictureBox1.Location.X;

                var centroX = ((anchoPadre + anchoHijo) / 2) - margenX;

                // CentroY
                var alturaPadre = pictureBox1.Height;
                var alturaHijo = label1.Height;
                var margenY = pictureBox1.Location.Y;

                var centroY = ((alturaPadre + alturaHijo) / 2) - margenY;

                // Centro absoluto (al formulario)

                // CentroX
                anchoPadre = this.Width;
                anchoHijo = label1.Width;
                
                // CentroY
                alturaPadre = this.Height;
                alturaHijo = label1.Height;

                // Bordes
                var bordeX = 18;
                var bordeY = 47;

                centroX = (anchoPadre / 2) - (anchoHijo / 2) - bordeX;
                centroY = (alturaPadre / 2 ) - (alturaHijo / 2) - bordeY;

                // MessageBox.Show("Punto de inicio");
                label1.Location = new System.Drawing.Point(centroX, centroY);
            }

            // Raimbow color
            if (keyValue == 67)
            {
                // MessageBox.Show("Color cambiado");

                var random = new Random();

                // var numeroAleatorio = random.Next(0, 255);
                var red = random.Next(255);
                var green = random.Next(255);
                var blue = random.Next(255);
                
                // Listado de colores

                // Color[] colores = {Color.Blue, Color.Red, Color.Green, Color.Pink, Color.SaddleBrown};

                label1.BackColor = Color.FromArgb(red, green, blue);
                label2.ForeColor = Color.FromArgb(red, green, blue);
                label3.ForeColor = Color.FromArgb(red, green, blue);
                label4.ForeColor = Color.FromArgb(red, green, blue);
                label5.ForeColor = Color.FromArgb(red, green, blue);
                label6.ForeColor = Color.FromArgb(red, green, blue);
                label7.ForeColor = Color.FromArgb(red, green, blue);
                label8.ForeColor = Color.FromArgb(red, green, blue);
                lblFlag.ForeColor = Color.FromArgb(red, green, blue);
            }

            // Usando el mouse
            if (keyValue == 77)
            {              
                // Si esta activo
                if (mouseActivado)
                {
                    // MessageBox.Show("Este es el boton M");
                mouseActivado = false;

                lblFlag.Text = "Desactivado";
                }
                else
                {
                    // MessageBox.Show("Este es el boton M");
                    mouseActivado = true;

                    lblFlag.Text = "Activado";
                }
            }

            // MessageBox.Show(keyValue.ToString());

            // Disminuir el tamaño
            if (keyValue == 109)
            {
                if (label1.Width > 5)
                {
                    label1.Width -= 1;
                    label1.Height -= 1;
                }
            }

            // Aumentar tamaño al cubito
            if (keyValue == 107) 
            {

                if (label1.Width < 100) {
                    label1.Width += 1;
                    label1.Height += 1;
                }
            }
            
            if (mouseActivado == false)
            {

            // Izquierda
            if (keyValue == 37) {

                if (posicionX <= 12) {
                    return;
                }

                // MessageBox.Show("Flecha a la izquierda");
                label1.Location = new System.Drawing.Point(posicionX - 1, posicionY);
                label2.Text = label1.Location.ToString();
            }

            // Izquierda A
            if (keyValue == 65)
            {

                if (posicionX <= 12)
                {
                    return;
                }

                // MessageBox.Show("Flecha a la izquierda");
                label1.Location = new System.Drawing.Point(posicionX - 3, posicionY);
                label2.Text = label1.Location.ToString();
            }  

            // Derecha
            if (keyValue == 39) {

                if (posicionX >= 342)
                {
                    return;
                }
                
                // MessageBox.Show("Flecha a la derecha");
                label1.Location = new System.Drawing.Point(posicionX + 1, posicionY);
                label2.Text = label1.Location.ToString();
            }

            // Derecha D
            if (keyValue == 68)
            {

                if (posicionX >= 342)
                {
                    return;
                }

                // MessageBox.Show("Flecha a la derecha");
                label1.Location = new System.Drawing.Point(posicionX + 3, posicionY);
                label2.Text = label1.Location.ToString();
            }

            // Abajo
            if (keyValue == 40) {

                if (posicionY >= 419)
                {
                    return;
                }

                // MessageBox.Show("Flecha para abajo");
                label1.Location = new System.Drawing.Point(posicionX, posicionY + 1);
                label2.Text = label1.Location.ToString();
            }

            // Abajo S
            if (keyValue == 83)
            {

                if (posicionY >= 419)
                {
                    return;
                }

                // MessageBox.Show("Flecha para abajo");
                label1.Location = new System.Drawing.Point(posicionX, posicionY + 3);
                label2.Text = label1.Location.ToString();
            }

            // Arriba
            if (keyValue == 38) {

                if (posicionY <= 19)
                {
                    return;
                }

                // MessageBox.Show("Flecha para arriba");
                label1.Location = new System.Drawing.Point(posicionX, posicionY - 1);
                label2.Text = label1.Location.ToString();
            }

            // Arriba W
            if (keyValue == 87)
            {

                if (posicionY <= 19)
                {
                    return;
                }

                // MessageBox.Show("Flecha para arriba");
                label1.Location = new System.Drawing.Point(posicionX, posicionY - 3);
                label2.Text = label1.Location.ToString();
            }

            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("Te esta moviendo");

            if (mouseActivado) 
            {
                var locationX = e.Location.X;
                var locationY = e.Location.Y;

                label1.Location = new System.Drawing.Point(locationX, locationY);
            }

            //System.Diagnostics.Trace.WriteLine(location);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("Move");
            // System.Diagnostics.Trace.WriteLine("Yo te seguire");
        }

        private void lblFlag_Click(object sender, EventArgs e)
        {

        }
    }
}
