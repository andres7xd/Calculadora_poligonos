namespace Calculadora
{
    partial class calculadoraForm
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
            this.lblCalculadoraPoligonos = new System.Windows.Forms.Label();
            this.tbc_calculadora = new System.Windows.Forms.TabControl();
            this.triangulo_TabPage = new System.Windows.Forms.TabPage();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.cuadrado_TabPage = new System.Windows.Forms.TabPage();
            this.circulo_TabPage = new System.Windows.Forms.TabPage();
            this.rectangulo_TabPage = new System.Windows.Forms.TabPage();
            this.pentagono_TabPage = new System.Windows.Forms.TabPage();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnCalcularPerimetro = new System.Windows.Forms.Button();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.q = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblBaserec = new System.Windows.Forms.Label();
            this.txtBaserec = new System.Windows.Forms.TextBox();
            this.lblAlturarec = new System.Windows.Forms.Label();
            this.TxtAlturarec = new System.Windows.Forms.TextBox();
            this.lblLadopenta = new System.Windows.Forms.Label();
            this.lblApotema = new System.Windows.Forms.Label();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.txtLadopent = new System.Windows.Forms.TextBox();
            this.tbc_calculadora.SuspendLayout();
            this.triangulo_TabPage.SuspendLayout();
            this.cuadrado_TabPage.SuspendLayout();
            this.circulo_TabPage.SuspendLayout();
            this.rectangulo_TabPage.SuspendLayout();
            this.pentagono_TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculadoraPoligonos
            // 
            this.lblCalculadoraPoligonos.AutoSize = true;
            this.lblCalculadoraPoligonos.Location = new System.Drawing.Point(191, 50);
            this.lblCalculadoraPoligonos.Name = "lblCalculadoraPoligonos";
            this.lblCalculadoraPoligonos.Size = new System.Drawing.Size(127, 13);
            this.lblCalculadoraPoligonos.TabIndex = 0;
            this.lblCalculadoraPoligonos.Text = "Calculadora de Poligonos";
            this.lblCalculadoraPoligonos.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbc_calculadora
            // 
            this.tbc_calculadora.Controls.Add(this.triangulo_TabPage);
            this.tbc_calculadora.Controls.Add(this.cuadrado_TabPage);
            this.tbc_calculadora.Controls.Add(this.circulo_TabPage);
            this.tbc_calculadora.Controls.Add(this.rectangulo_TabPage);
            this.tbc_calculadora.Controls.Add(this.pentagono_TabPage);
            this.tbc_calculadora.Location = new System.Drawing.Point(82, 105);
            this.tbc_calculadora.Name = "tbc_calculadora";
            this.tbc_calculadora.SelectedIndex = 0;
            this.tbc_calculadora.Size = new System.Drawing.Size(374, 226);
            this.tbc_calculadora.TabIndex = 1;
            // 
            // triangulo_TabPage
            // 
            this.triangulo_TabPage.Controls.Add(this.txtAltura);
            this.triangulo_TabPage.Controls.Add(this.txtBase);
            this.triangulo_TabPage.Controls.Add(this.txtLado2);
            this.triangulo_TabPage.Controls.Add(this.txtLado1);
            this.triangulo_TabPage.Controls.Add(this.lblAltura);
            this.triangulo_TabPage.Controls.Add(this.lblBase);
            this.triangulo_TabPage.Controls.Add(this.lblLado2);
            this.triangulo_TabPage.Controls.Add(this.lblLado1);
            this.triangulo_TabPage.Location = new System.Drawing.Point(4, 22);
            this.triangulo_TabPage.Name = "triangulo_TabPage";
            this.triangulo_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.triangulo_TabPage.Size = new System.Drawing.Size(366, 200);
            this.triangulo_TabPage.TabIndex = 0;
            this.triangulo_TabPage.Text = "Triangulo";
            this.triangulo_TabPage.UseVisualStyleBackColor = true;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(25, 21);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(40, 13);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1";
            this.lblLado1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cuadrado_TabPage
            // 
            this.cuadrado_TabPage.Controls.Add(this.txtLado);
            this.cuadrado_TabPage.Controls.Add(this.label2);
            this.cuadrado_TabPage.Controls.Add(this.lblLado);
            this.cuadrado_TabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadrado_TabPage.Name = "cuadrado_TabPage";
            this.cuadrado_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadrado_TabPage.Size = new System.Drawing.Size(366, 200);
            this.cuadrado_TabPage.TabIndex = 1;
            this.cuadrado_TabPage.Text = "Cuadrado";
            this.cuadrado_TabPage.UseVisualStyleBackColor = true;
            // 
            // circulo_TabPage
            // 
            this.circulo_TabPage.Controls.Add(this.txtRadio);
            this.circulo_TabPage.Controls.Add(this.q);
            this.circulo_TabPage.Location = new System.Drawing.Point(4, 22);
            this.circulo_TabPage.Name = "circulo_TabPage";
            this.circulo_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.circulo_TabPage.Size = new System.Drawing.Size(366, 200);
            this.circulo_TabPage.TabIndex = 2;
            this.circulo_TabPage.Text = "Circulo";
            this.circulo_TabPage.UseVisualStyleBackColor = true;
            // 
            // rectangulo_TabPage
            // 
            this.rectangulo_TabPage.Controls.Add(this.TxtAlturarec);
            this.rectangulo_TabPage.Controls.Add(this.lblAlturarec);
            this.rectangulo_TabPage.Controls.Add(this.txtBaserec);
            this.rectangulo_TabPage.Controls.Add(this.lblBaserec);
            this.rectangulo_TabPage.Location = new System.Drawing.Point(4, 22);
            this.rectangulo_TabPage.Name = "rectangulo_TabPage";
            this.rectangulo_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rectangulo_TabPage.Size = new System.Drawing.Size(366, 200);
            this.rectangulo_TabPage.TabIndex = 3;
            this.rectangulo_TabPage.Text = "Rectangulo";
            this.rectangulo_TabPage.UseVisualStyleBackColor = true;
            // 
            // pentagono_TabPage
            // 
            this.pentagono_TabPage.Controls.Add(this.txtLadopent);
            this.pentagono_TabPage.Controls.Add(this.txtApotema);
            this.pentagono_TabPage.Controls.Add(this.lblApotema);
            this.pentagono_TabPage.Controls.Add(this.lblLadopenta);
            this.pentagono_TabPage.Location = new System.Drawing.Point(4, 22);
            this.pentagono_TabPage.Name = "pentagono_TabPage";
            this.pentagono_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pentagono_TabPage.Size = new System.Drawing.Size(366, 200);
            this.pentagono_TabPage.TabIndex = 4;
            this.pentagono_TabPage.Text = "Pentagono";
            this.pentagono_TabPage.UseVisualStyleBackColor = true;
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(200, 337);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(118, 23);
            this.btnCalcularArea.TabIndex = 2;
            this.btnCalcularArea.Text = "Calcular Area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            // 
            // btnCalcularPerimetro
            // 
            this.btnCalcularPerimetro.Location = new System.Drawing.Point(334, 337);
            this.btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            this.btnCalcularPerimetro.Size = new System.Drawing.Size(118, 23);
            this.btnCalcularPerimetro.TabIndex = 3;
            this.btnCalcularPerimetro.Text = "Calcular Perimetro";
            this.btnCalcularPerimetro.UseVisualStyleBackColor = true;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(25, 48);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(40, 13);
            this.lblLado2.TabIndex = 1;
            this.lblLado2.Text = "Lado 2";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(25, 83);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(25, 115);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(71, 18);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 4;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(71, 48);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 5;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(71, 76);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 6;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(71, 112);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 7;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(30, 29);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(31, 13);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Lado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(71, 26);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 2;
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Location = new System.Drawing.Point(23, 37);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(35, 13);
            this.q.TabIndex = 1;
            this.q.Text = "Radio";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(64, 34);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 3;
            this.txtRadio.TextChanged += new System.EventHandler(this.txtRadio_TextChanged);
            // 
            // lblBaserec
            // 
            this.lblBaserec.AutoSize = true;
            this.lblBaserec.Location = new System.Drawing.Point(19, 36);
            this.lblBaserec.Name = "lblBaserec";
            this.lblBaserec.Size = new System.Drawing.Size(31, 13);
            this.lblBaserec.TabIndex = 2;
            this.lblBaserec.Text = "Base";
            // 
            // txtBaserec
            // 
            this.txtBaserec.Location = new System.Drawing.Point(60, 33);
            this.txtBaserec.Name = "txtBaserec";
            this.txtBaserec.Size = new System.Drawing.Size(100, 20);
            this.txtBaserec.TabIndex = 4;
            // 
            // lblAlturarec
            // 
            this.lblAlturarec.AutoSize = true;
            this.lblAlturarec.Location = new System.Drawing.Point(19, 80);
            this.lblAlturarec.Name = "lblAlturarec";
            this.lblAlturarec.Size = new System.Drawing.Size(34, 13);
            this.lblAlturarec.TabIndex = 5;
            this.lblAlturarec.Text = "Altura";
            // 
            // TxtAlturarec
            // 
            this.TxtAlturarec.Location = new System.Drawing.Point(60, 77);
            this.TxtAlturarec.Name = "TxtAlturarec";
            this.TxtAlturarec.Size = new System.Drawing.Size(100, 20);
            this.TxtAlturarec.TabIndex = 6;
            // 
            // lblLadopenta
            // 
            this.lblLadopenta.AutoSize = true;
            this.lblLadopenta.Location = new System.Drawing.Point(27, 29);
            this.lblLadopenta.Name = "lblLadopenta";
            this.lblLadopenta.Size = new System.Drawing.Size(31, 13);
            this.lblLadopenta.TabIndex = 3;
            this.lblLadopenta.Text = "Lado";
            // 
            // lblApotema
            // 
            this.lblApotema.AutoSize = true;
            this.lblApotema.Location = new System.Drawing.Point(27, 58);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(49, 13);
            this.lblApotema.TabIndex = 4;
            this.lblApotema.Text = "Apotema";
            // 
            // txtApotema
            // 
            this.txtApotema.Location = new System.Drawing.Point(82, 55);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(100, 20);
            this.txtApotema.TabIndex = 5;
            // 
            // txtLadopent
            // 
            this.txtLadopent.Location = new System.Drawing.Point(82, 22);
            this.txtLadopent.Name = "txtLadopent";
            this.txtLadopent.Size = new System.Drawing.Size(100, 20);
            this.txtLadopent.TabIndex = 6;
            // 
            // calculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(544, 447);
            this.Controls.Add(this.btnCalcularPerimetro);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.tbc_calculadora);
            this.Controls.Add(this.lblCalculadoraPoligonos);
            this.Name = "calculadoraForm";
            this.Text = "Calculadora de Poligonos";
            this.Load += new System.EventHandler(this.Fondo_Load);
            this.tbc_calculadora.ResumeLayout(false);
            this.triangulo_TabPage.ResumeLayout(false);
            this.triangulo_TabPage.PerformLayout();
            this.cuadrado_TabPage.ResumeLayout(false);
            this.cuadrado_TabPage.PerformLayout();
            this.circulo_TabPage.ResumeLayout(false);
            this.circulo_TabPage.PerformLayout();
            this.rectangulo_TabPage.ResumeLayout(false);
            this.rectangulo_TabPage.PerformLayout();
            this.pentagono_TabPage.ResumeLayout(false);
            this.pentagono_TabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculadoraPoligonos;
        private System.Windows.Forms.TabControl tbc_calculadora;
        private System.Windows.Forms.TabPage triangulo_TabPage;
        private System.Windows.Forms.TabPage cuadrado_TabPage;
        private System.Windows.Forms.TabPage circulo_TabPage;
        private System.Windows.Forms.TabPage rectangulo_TabPage;
        private System.Windows.Forms.TabPage pentagono_TabPage;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Button btnCalcularPerimetro;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label q;
        private System.Windows.Forms.TextBox TxtAlturarec;
        private System.Windows.Forms.Label lblAlturarec;
        private System.Windows.Forms.TextBox txtBaserec;
        private System.Windows.Forms.Label lblBaserec;
        private System.Windows.Forms.TextBox txtLadopent;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.Label lblApotema;
        private System.Windows.Forms.Label lblLadopenta;
    }
}

