using System;

namespace VistaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nombre;

            nombre = "Joaquin";
            //nombre= Console.ReadLine(); //scanf le pide el dato al usuario

            string edadString = Console.ReadLine(); //readline devuelve un string, no puede guardar lo escrito en un int, hay que parsearlo.

            //int edad = int.Parse(edadString); //guardo lo que hay en string en un numero en "edad".
            
            int edadParseada; //edad int donde se va a guardar el dato string.
            
            bool resultadoParse = int.TryParse(edadString, out edadParseada); //si lo pudo convertir en "resultadoPArse se guardara un true(!=0) o false (0))

            Console.WriteLine("se pudo convertir? " + resultadoParse);

            if(resultadoParse!=false)
            {
                Console.WriteLine($"La edad es {edadParseada} y el nombre es {nombre}");
            }
            else
            {
                Console.WriteLine("error al ingresar el dato");
            }

            string precioString = Console.ReadLine(); //pido el numero float

           
            float precio; 


            bool precioResultado = float.TryParse(precioString, out precio); // lo parseo y lo guardo en la variable flotante.


            if(precioResultado!=false)
            {
                Console.WriteLine($"El precio es {precio}");
            }
            else
            {
                Console.WriteLine("error al parsear el precio");
            }

            //CONVERSIONES EXPLICITAS O IMPLICITAS.
            
            float valorConComa = 41.23f;  

            int entero = (int)valorConComa; //explicito: posible perdida de datos. (41)


            float flotante = entero; //conversion implicita: no hay perdida de datos. (41.00)


            // ARRAYS:

            string[] nombres = new string[5]; //forma 1

            nombres[0] = "Lucas";
            nombres[1] = "joaquin";
            nombres[2] = "carlos";

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write(nombres[i]);
            }

            /////////////////////////////
            
            string[] paises = { "Brasil", "argentina", "peru" }; //forma 2

            for(int i=0; i<paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }

            //FOREACH: cuando queremos mostrar todo el array sin importar la condicion del for.

            foreach(string item in paises) //item puede llamarse "pais" o como quieras para ser mas apreciativo.
            {
                Console.WriteLine(item);
            }


            //Console.WriteLine(edad);

            //Console.WriteLine(nombre);

            //Console.WriteLine("la edad es: " + edad "y el nombre es" + nombre); //dos maneras de hacerlo.

            //Console.WriteLine($"La edad es {edad} y el nombre es {nombre}"); //el signo pesos es para que funcionen las {} y no lo tome como "string"

            // Console.WriteLine("Hola {0} su edad es {1} ", nombre, edad); //

            // Console.WriteLine("Hello World!");
        }
    }
}
