using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    public class Triangulo : Figura
    {

        

        public int Lado1
        {
            get => default(int);
            set
            {
            }
        }

        public int Lado2
        {
            get => default(int);
            set
            {
            }
        }

        public int Base
        {
            get => default(int);
            set
            {
            }
        }

        public int Altura
        {
            get => default(int);
            set
            {
            }
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Base;

        }
    }
}