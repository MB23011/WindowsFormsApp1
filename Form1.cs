using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            Double Resultado = 0.0;
            Double A = 0.0;
            Double B = 0.0;
            string Nombre = txtnom.Text;

            //Captura de Datos
            A = Convert.ToDouble(txtnumA1.Text);
            B = Convert.ToDouble(txtnumB.Text);
            

            //Condicionales
            if (btnsuma.Checked == true)
                Resultado = A + B;
            if (btnResta.Checked == true)
                Resultado = A - B;
            if (btnmultiplicar.Checked == true)
                Resultado = A * B;
            if (btndivision.Checked == true)
                Resultado = A / B;
           

            //Escribir Resultado
            txtresultado.Text = Resultado.ToString();
            txtnomUsu.Text = Nombre.ToString(); //txtnomUsu es la salidad de txtnom

            //MessageBox.Show("Usuario: " + Nombre + " "  + "Los datos ingresados son: " + A + " y " + B + " " + "Su resultado es: " + Resultado);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // txtnumA.Clear();
           txtnom.Clear(); //Limpia el txt Nombre
           txtnumB.Clear(); //Limpia el txt Numero A
           txtresultado.Clear(); //Limpia el txt Numero B

          // txtnumA1.Value = txtnumA1.Minimum; //Reduce el NumericUpDown a su valor mas minimo = 0
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra la aplicacion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //le di clic por accidente
        }
    }
}
