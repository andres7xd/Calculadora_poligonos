﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    public class Rectangulo : Figura
    {   


       

        public int Ancho
        {
            get => default(int);
            set
            {
            }
        }

        public int Largo
        {
            get => default(int);
            set
            {
            }
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