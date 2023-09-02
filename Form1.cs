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
            txtnom.Focus();
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
           else  if (btnResta.Checked == true)   //Modifique estructura de los condicionales 
                Resultado = A - B;
           else   if (btnmultiplicar.Checked == true)
                Resultado = A * B;
           else if (btndivision.Checked == true)
            {
                if(B==0){
                    MessageBox.Show("No se puede dividir entre 0", "Error Valor Invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnumB.Focus();
                }
                else
                {
                    Resultado = A / B;
                }
            }
                
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
            btndivision.Checked = false;//Limpiamos lo checkbox
            btnResta.Checked = false;//Limpiamos lo checkbox
            btnsuma.Checked = false;//Limpiamos lo checkbox
            btnmultiplicar.Checked = false;//Limpiamos lo checkbox

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra la aplicacion
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            btnCalcular.Enabled = false;
        }

        private void txtnumA_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese un número", "Error Valor Invalido",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }

        }


        private void validarCampoVacio() //Comprueba si los campos estan vacios :v
        {
            var vr = !string.IsNullOrEmpty(txtnumA.Text) && !string.IsNullOrEmpty(txtnumB.Text) && !string.IsNullOrEmpty(txtnom.Text);
            btnCalcular.Enabled = vr;
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            validarCampoVacio();
        }

        private void txtnumA_TextChanged(object sender, EventArgs e)
        {
            validarCampoVacio();
        }

        private void txtnumB_TextChanged(object sender, EventArgs e)
        {
            validarCampoVacio();
        }
    }
}
