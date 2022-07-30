using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ejercicio_2
{
    class Operaciones
    {
        private decimal primerValor = 0;
        private decimal segundoValor = 0;
        private decimal resultado = 0;
        public Operaciones(decimal valor1,decimal valor2)
        {
            primerValor = valor1;
            segundoValor = valor2;
        }
        public void Sumar()
        {
            resultado = primerValor + segundoValor;
            Console.WriteLine(" El resultado es : " + resultado);
        }
        public void Restar()
        {
            resultado = primerValor - segundoValor;
            Console.WriteLine(" El resultado es : " + resultado);
        }
        public void Multiplicar()
        {
            resultado = primerValor * segundoValor;
            Console.WriteLine(" El resultado es : " + resultado);
        }
        public void Dividir()
        {
            if (segundoValor == 0)
            {
                Console.WriteLine("No se puede dividir por Cero ");
            }
            else
            {
                resultado = primerValor / segundoValor;
                Console.WriteLine(" El resultado es : " + resultado);
            }
        }
    }
}
