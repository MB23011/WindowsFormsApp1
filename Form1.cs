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
            A = Convert.ToDouble(txtnumA.Text);
         
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
            else
                MessageBox.Show("Seleccione una opcion para realizar la operacion ", "Error" ,
                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Escribir Resultado
            txtresultado.Text = Resultado.ToString();
            txtnomUsu.Text = Nombre.ToString(); //txtnomUsu es la salidad de txtnom

           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
           txtnom.Clear(); //Limpia el txt nom
           txtnumA.Clear(); //Limpia el txt Nombre A
           txtnumB.Clear(); //Limpia el txt Numero B
           txtresultado.Clear(); //Limpia el txt Resultado
           txtnomUsu.Clear(); //Limpia el txt NomUsu
           
          
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra la aplicacion
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            //le di clic por accidente
        }

        private void txtnumA_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese Solo Numeros Mayores a 0", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }

        }
    }
}
