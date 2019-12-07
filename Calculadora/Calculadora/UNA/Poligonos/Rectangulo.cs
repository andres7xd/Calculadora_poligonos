using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Rectangulo : Figura
    {   


       

        public double Ancho
        {
            get;
            set;
            
        }

        public double Largo
        {
            get;
            set;
        }

        public override double CalcularArea()
        {

            return  Largo * Ancho;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Largo + 2 * Ancho;
        }
    }
}