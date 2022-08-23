using System;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ngresar un número y mostrar el cuadrado y el cubo del mismo.
            //Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            //Utilizar el método Pow de la clase Math para calcular las potencias.



            Console.WriteLine("Ingrese un numero mayor a 0");

            bool comprobacionDelNumeroIngresado = false;
            double numeroIngresado;

           string numeroIngresadoString = Console.ReadLine();

            comprobacionDelNumeroIngresado = double.TryParse(numeroIngresadoString, out numeroIngresado);

            if(comprobacionDelNumeroIngresado && numeroIngresado>0)
            {
              double resultadoCuadrado =  Math.Pow(numeroIngresado, 2); //raiz cuadrada(2) del numero ingresado
              double resultadoCubo= Math.Pow(numeroIngresado, 3); //raiz cubica(3) del numero ingresado
                Console.WriteLine($"La raiz cuadrada del numero ingresado es: {resultadoCuadrado} y la raiz al cubo es: {resultadoCubo}");
            } 
            else
            {
                Console.WriteLine("Error al ingresar el dato, este tiene que ser un numero y ser mayor a 0, intente nuevamente");
            }
        }
    }
}
