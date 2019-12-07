using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public abstract class Figura
    {
        public int NomFigura
        {
            get => default(int);
            set
            {
            }
        }

        public abstract double CalcularArea();


        public abstract double CalcularPerimetro();
        
    }
}