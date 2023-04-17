using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_2_Julian_Monroy

{
    class operaciones
    {
        public double suma { get; set; }
        public double resta { get; set; }
        public double division { get; set; }
        public double multiplicacion { get; set; }
        public double raiz_cuadrada { get; set; }
        public double cuadrado { get; set; }
        public operaciones(double suma, double resta, double division, double multiplicacion)
        {
            this.suma = suma;
            this.resta = resta;
            this.division = division;
            this.multiplicacion = multiplicacion;
            this.cuadrado = cuadrado;
            this.raiz_cuadrada = raiz_cuadrada;
        }

    }
}
