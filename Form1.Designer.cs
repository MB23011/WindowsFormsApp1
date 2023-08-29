
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnumA = new System.Windows.Forms.TextBox();
            this.txtnumB = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.RadioButton();
            this.btnResta = new System.Windows.Forms.RadioButton();
            this.btnmultiplicar = new System.Windows.Forms.RadioButton();
            this.btndivision = new System.Windows.Forms.RadioButton();
            this.IngreDatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumA
            // 
            this.txtnumA.Location = new System.Drawing.Point(70, 103);
            this.txtnumA.Name = "txtnumA";
            this.txtnumA.Size = new System.Drawing.Size(100, 22);
            this.txtnumA.TabIndex = 0;
            // 
            // txtnumB
            // 
            this.txtnumB.Location = new System.Drawing.Point(70, 214);
            this.txtnumB.Name = "txtnumB";
            this.txtnumB.Size = new System.Drawing.Size(100, 22);
            this.txtnumB.TabIndex = 1;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(649, 361);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 22);
            this.txtresultado.TabIndex = 2;
            // 
            // btnsuma
            // 
            this.btnsuma.AutoSize = true;
            this.btnsuma.Location = new System.Drawing.Point(70, 303);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(65, 21);
            this.btnsuma.TabIndex = 3;
            this.btnsuma.TabStop = true;
            this.btnsuma.Text = "Suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.AutoSize = true;
            this.btnResta.Location = new System.Drawing.Point(70, 361);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(66, 21);
            this.btnResta.TabIndex = 4;
            this.btnResta.TabStop = true;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.AutoSize = true;
            this.btnmultiplicar.Location = new System.Drawing.Point(230, 303);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(113, 21);
            this.btnmultiplicar.TabIndex = 5;
            this.btnmultiplicar.TabStop = true;
            this.btnmultiplicar.Text = "Multiplicacion";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            // 
            // btndivision
            // 
            this.btndivision.AutoSize = true;
            this.btndivision.Location = new System.Drawing.Point(230, 361);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(78, 21);
            this.btndivision.TabIndex = 6;
            this.btndivision.TabStop = true;
            this.btndivision.Text = "Division";
            this.btndivision.UseVisualStyleBackColor = true;
            // 
            // IngreDatos
            // 
            this.IngreDatos.AutoSize = true;
            this.IngreDatos.Location = new System.Drawing.Point(80, 26);
            this.IngreDatos.Name = "IngreDatos";
            this.IngreDatos.Size = new System.Drawing.Size(116, 17);
            this.IngreDatos.TabIndex = 7;
            this.IngreDatos.Text = "Ingreso de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Operaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(614, 62);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(614, 117);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(614, 174);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 14;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IngreDatos);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnumB);
            this.Controls.Add(this.txtnumA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumA;
        private System.Windows.Forms.TextBox txtnumB;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.RadioButton btnsuma;
        private System.Windows.Forms.RadioButton btnResta;
        private System.Windows.Forms.RadioButton btnmultiplicar;
        private System.Windows.Forms.RadioButton btndivision;
        private System.Windows.Forms.Label IngreDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

