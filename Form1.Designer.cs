
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.lael1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtnomUsu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnumB
            // 
            resources.ApplyResources(this.txtnumB, "txtnumB");
            this.txtnumB.Name = "txtnumB";
            this.txtnumB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumA_KeyPress);
            // 
            // txtresultado
            // 
            resources.ApplyResources(this.txtresultado, "txtresultado");
            this.txtresultado.Name = "txtresultado";
            // 
            // btnsuma
            // 
            resources.ApplyResources(this.btnsuma, "btnsuma");
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.TabStop = true;
            this.btnsuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            resources.ApplyResources(this.btnResta, "btnResta");
            this.btnResta.Name = "btnResta";
            this.btnResta.TabStop = true;
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicar
            // 
            resources.ApplyResources(this.btnmultiplicar, "btnmultiplicar");
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.TabStop = true;
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            // 
            // btndivision
            // 
            resources.ApplyResources(this.btndivision, "btndivision");
            this.btndivision.Name = "btndivision";
            this.btndivision.TabStop = true;
            this.btndivision.UseVisualStyleBackColor = true;
            // 
            // IngreDatos
            // 
            resources.ApplyResources(this.IngreDatos, "IngreDatos");
            this.IngreDatos.Name = "IngreDatos";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnCalcular
            // 
            resources.ApplyResources(this.btnCalcular, "btnCalcular");
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(this.btnLimpiar, "btnLimpiar");
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnsalir
            // 
            resources.ApplyResources(this.btnsalir, "btnsalir");
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lael1
            // 
            resources.ApplyResources(this.lael1, "lael1");
            this.lael1.Name = "lael1";
            // 
            // txtnom
            // 
            resources.ApplyResources(this.txtnom, "txtnom");
            this.txtnom.Name = "txtnom";
            // 
            // txtnomUsu
            // 
            resources.ApplyResources(this.txtnomUsu, "txtnomUsu");
            this.txtnomUsu.Name = "txtnomUsu";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtnumA
            // 
            resources.ApplyResources(this.txtnumA, "txtnumA");
            this.txtnumA.Name = "txtnumA";
            this.txtnumA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumA_KeyPress);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtnumA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomUsu);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lael1);
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
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lael1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtnomUsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumA;
    }
}

