using System;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ingresar 5 números por consola, guardándolos en una variable escalar.
            //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.


            int numero;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            int acumulador = 0;
            int promedio;

            Console.WriteLine("Ingrese 5 numeros enteros validos");

            for(int i = 0; i < 5; i++)
            {
                string numeroString = Console.ReadLine();

                bool parse = int.TryParse(numeroString, out numero);
           
                if(parse)
                {
                    if(i == 0)
                    {
                        numeroMaximo = numero;
                        numeroMinimo = numero;
                    }
                    else
                    {
                        if(numero>=numeroMaximo)
                        {
                            numeroMaximo = numero;
                        }
                        else if(numero<=numeroMinimo)
                        {
                            numeroMinimo = numero;
                        }
                    }
                    acumulador = acumulador+numero;
                }
                else
                {
                    Console.WriteLine("error al ingresar un numero");
                }
            }
            
            promedio = acumulador / 5;

            Console.WriteLine($"El numero maximo ingresado es {numeroMaximo} el numero minimo es {numeroMinimo} y el promedio de los 5 numeros es {promedio}");
            
            Console.ReadKey();
        }
    }
}


//no corrige si ingresa una palabra o algo que no sea un numero, el promedio se hace igual. (mal)