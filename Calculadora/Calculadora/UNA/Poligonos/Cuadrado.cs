using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Cuadrado : Figura
    {

       

        public double Lado
        {
            get;
            set;
            
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