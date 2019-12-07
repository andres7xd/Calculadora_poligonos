using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    public class Cuadrado : Figura
    {

       

        public int Lado
        {
            get => default(int);
            set
            {
            }
        }

        public override double CalcularArea()
        {
            return 2 * Lado;

        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;

        }
    }
}