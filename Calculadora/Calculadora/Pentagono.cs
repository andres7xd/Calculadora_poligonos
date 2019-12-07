using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    public class Pentagono : Figura
    {
        public int Lado
        {
            get => default(int);
            set
            {
            }
        }

        public int Apotema
        {
            get => default(int);
            set
            {
            }
        }

        public override double CalcularArea()
        {
            return (CalcularPerimetro()*Apotema)/ 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado * 5;
        }
    }
}