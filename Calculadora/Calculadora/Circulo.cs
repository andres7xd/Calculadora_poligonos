using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    public class Circulo : Figura
    {

        

        public int Radio
        {
            get => default(int);
            set
            {
            }
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio,2);
        }

        public override double CalcularPerimetro()
        {
            return 2*(Math.PI * Radio);
        }
    }
}