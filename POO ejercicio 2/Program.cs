using System;

namespace POO_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Sumar = "1";
            const string Restar = "2";
            const string Multiplicar = "3";
            const string Dividir = "4";
            const string Salir = "S";
            string Opciones = "";
            decimal Valor1 ;
            decimal Valor2 ;
           
            do
            {
                Console.WriteLine("¿Qué operacón desea hacer?");
                Console.WriteLine(Sumar + " -Sumar");
                Console.WriteLine(Restar + " -Restar");
                Console.WriteLine(Multiplicar + " -Multiplicar");
                Console.WriteLine(Dividir + " -Dividir");
                Console.WriteLine(Salir + " -Salir");

                Opciones = ServValidac.PedirStrNoVac("Ingrese una opción");
                switch (Opciones)
                {
                    case Sumar:
                        Valor1 = ServValidac.PedirLong("Ingrese el Primer valor ", 1, 100);
                        Valor2 = ServValidac.PedirLong("Ingrese el Segundo valor ", 1, 100);
                        Operaciones miOperaciones = new Operaciones(Valor1, Valor2);
                        miOperaciones.Sumar();
                       
                        break;
                    case Restar:
                        Valor1 = ServValidac.PedirLong("Ingrese el Primer valor ", 1, 100);
                        Valor2 = ServValidac.PedirLong("Ingrese el Segundo valor ", 1, 100);
                        Operaciones miOperacionesR = new Operaciones(Valor1, Valor2);
                        miOperacionesR.Restar();

                        break;
                    case Multiplicar:
                        Valor1 = ServValidac.PedirLong("Ingrese el Primer valor ", 1, 100);
                        Valor2 = ServValidac.PedirLong("Ingrese el Segundo valor ", 1, 100);
                        Operaciones miOperacionesM = new Operaciones(Valor1, Valor2);
                        miOperacionesM.Multiplicar();
                        break;
                    case Dividir:
                        Valor1 = ServValidac.PedirLong("Ingrese el Primer valor ", 1, 100);
                        Valor2 = ServValidac.PedirLong("Ingrese el Segundo valor ", 1, 100);
                        Operaciones miOperacionesD = new Operaciones(Valor1, Valor2);
                        miOperacionesD.Dividir();

                        break;
                }
            } while (Opciones != Salir);

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();

        }
    }
}
