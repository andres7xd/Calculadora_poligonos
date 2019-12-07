using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Poligonos;

namespace Calculadora
{
    public partial class CalculadoraForm : Form
    {
        private Figura figuraSeleccionada;


        public CalculadoraForm()
        {
            InitializeComponent();
            figuraSeleccionada = new Triangulo();

        }



        private void tbc_calculadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbc_calculadora.SelectedIndex == 0)
            {
                figuraSeleccionada = new Triangulo();
            }

            if (tbc_calculadora.SelectedIndex == 1)
            {
                figuraSeleccionada = new Cuadrado();
            }

            if (tbc_calculadora.SelectedIndex == 2)
            {
                figuraSeleccionada = new Circulo();
            }

            if (tbc_calculadora.SelectedIndex == 3)
            {
                figuraSeleccionada = new Rectangulo();
            }

            if (tbc_calculadora.SelectedIndex == 4)
            {
                figuraSeleccionada = new Pentagono();
            }
        }

        private void txtBase_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSeleccionada;
            triangulo.Base = Convert.ToDouble(txtBase.Text);

        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSeleccionada;
            triangulo.Lado1 = Convert.ToDouble(txtLado1.Text);
        }

        private void txtLado2_TextChanged(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSeleccionada;
            triangulo.Lado2 = Convert.ToDouble(txtLado2.Text);
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSeleccionada;
            triangulo.Altura = Convert.ToDouble(txtAltura.Text);
        }



        private void txtLado_TextChanged(object sender, EventArgs e)
        {
            Cuadrado cuadrado = (Cuadrado)figuraSeleccionada;
            cuadrado.Lado = Convert.ToDouble(txtLado.Text);
        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {
            Circulo circulo = (Circulo)figuraSeleccionada;
            circulo.Radio = Convert.ToDouble(txtRadio.Text);
        }


        private void btnCalcularArea_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Convert.ToString("Segun los valores dados por la figura su area es: "+figuraSeleccionada.CalcularArea()));

        }

        private void txtBaserec_TextChanged(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)figuraSeleccionada;
            rectangulo.Ancho = Convert.ToDouble(txtBaserec.Text);
        }

        private void TxtAlturarec_TextChanged(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)figuraSeleccionada;
            rectangulo.Largo = Convert.ToDouble(TxtAlturarec.Text);
        }

        private void txtLadopent_TextChanged(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)figuraSeleccionada;
            pentagono.Lado = Convert.ToDouble(txtLadopent.Text);
        }

        private void txtApotema_TextChanged(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)figuraSeleccionada;
            pentagono.Apotema = Convert.ToDouble(txtApotema.Text);
        }

        private void btnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString("Segun los valores dados por la figura su perimetro es: " + figuraSeleccionada.CalcularPerimetro()));
        }
    }
}
