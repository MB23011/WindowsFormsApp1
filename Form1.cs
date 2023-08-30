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

            //Escribir Resultado
            txtresultado.Text = Resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           txtnumA.Clear();
           txtnumB.Clear();
           txtresultado.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
