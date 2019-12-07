namespace Calculadora
{
    partial class Fondo
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
            this.cuadrado_TabPage = new System.Windows.Forms.TabPage();
            this.circulo_TabPage = new System.Windows.Forms.TabPage();
            this.rectangulo_TabPage = new System.Windows.Forms.TabPage();
            this.pentagono_TabPage = new System.Windows.Forms.TabPage();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnCalcularPerimetro = new System.Windows.Forms.Button();
            this.tbc_calculadora.SuspendLayout();
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
            this.triangulo_TabPage.Location = new System.Drawing.Point(4, 22);
            this.triangulo_TabPage.Name = "triangulo_TabPage";
            this.triangulo_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.triangulo_TabPage.Size = new System.Drawing.Size(366, 200);
            this.triangulo_TabPage.TabIndex = 0;
            this.triangulo_TabPage.Text = "Triangulo";
            this.triangulo_TabPage.UseVisualStyleBackColor = true;
            // 
            // cuadrado_TabPage
            // 
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
            // Fondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(544, 447);
            this.Controls.Add(this.btnCalcularPerimetro);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.tbc_calculadora);
            this.Controls.Add(this.lblCalculadoraPoligonos);
            this.Name = "Fondo";
            this.Text = "Form1";
            this.tbc_calculadora.ResumeLayout(false);
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
    }
}

