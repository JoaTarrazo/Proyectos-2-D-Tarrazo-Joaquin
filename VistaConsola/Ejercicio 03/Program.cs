using System;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            //Validar que el dato ingresado por el usuario sea un número.
            //Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            //Si ingresa "salir", cerrar la consola.
            //Al finalizar, preguntar al usuario si desea volver a operar.
            //Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.
            //Utilizar sentencias de iteración, selectivas y el operador módulo (%).


            int numeroIngresadoInt;
            bool bandera = false;
            

            do
            {
                Console.WriteLine("Bienvenido, ingrese un numero entero mayor a 1");
                

                string datoIngresadoPorElUsuarioString = Console.ReadLine();

                bandera = int.TryParse(datoIngresadoPorElUsuarioString, out numeroIngresadoInt);

                if (bandera && numeroIngresadoInt >=2)
                {
                    for (int i = 2; i <= numeroIngresadoInt; i++) //empezamos por 2 que es el primer numero primo y sumamos de a 1 hasta dividir por el mismo numero
                    {
                        int cantidadDeDivisores = 0; //si tiene 3 o mas, significa que no es primo.

                        for (int e = 1; e <= i; e++) //se itera hasta que e alcance el valor de i (comienza en 2 e itera aumentando en 1 hasta llegar al mismo numero ingresado por el user)
                        {
                            if (i % e == 0)  //si la division del valor de i y e es 0, aumento la cantidad de divisores,
                            {
                                cantidadDeDivisores++;
                            }
                        }
                        if (cantidadDeDivisores < 3) //si tiene menos de 3 divisores (0, 1, 2) es un numero primo, lo muestro
                        {
                            Console.WriteLine(i); //muestro los numeros que tienen menos de 3 divisores.
                        }
                    }
                    bandera = true;

                    Console.WriteLine("Desea continuar operando? SI / NO");
                    string respuestaUsuarioContinuar = Console.ReadLine();

                    switch (respuestaUsuarioContinuar)
                    {
                        case "SI":
                            bandera = false;
                            break;

                        case "NO":
                            bandera= true;
                            Console.WriteLine("Cerrando la aplicacion...bye bye!");
                            break;

                        default:
                            Console.WriteLine("Error al ingresar la respuesta, el programa se cerrara!");
                            bandera = true;
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Error al ingresar el dato, por favor, verificar que sea un numero entero mayor a 1.Para continuar presione cualquier tecla. Si desea salir escriba (salir) .");                   
                    string respuestaSalir=Console.ReadLine();

                    if(respuestaSalir == "salir")
                    {
                        bandera = true;
                        Console.WriteLine("Saliendo... Bye bye!");
                    }
                    else
                    {
                        bandera = false;
                        Console.WriteLine("Regresando al programa, espere...");
                    }
                }
            } while (bandera==false);


        }
    }
}
