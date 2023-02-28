using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnMensaje
{
    internal class Program
    {
        /// <summary>
        /// 22/02/2023
        /// Jaider Andres Oquendo Zapata.
        /// programa que permite cargar el nombre y la edad de una persona. 
        /// Muestra los datos cargados. E imprimir un mensaje si es mayor de edad.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese su nombre.");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Por favor ingrese su edad.");
            int Edad = Convert.ToInt16( Console.ReadLine());

            Console.WriteLine("Los datos cargados son: ");
            Console.WriteLine(DatosCargados( Nombre, Edad));

            //estructura de desicion logica para si es mayor de edad imprima mensaje.
            if (Edad>=18)
            {
                Console.WriteLine(Mensaje(Nombre,  Edad));
            }

            Console.ReadKey(); 

        }
        //metodos.
        static string DatosCargados(string Nombre, int Edad)
        { 
            return ("Nombre: "+ Nombre + " Edad: "+Edad+ " años."); 

        }
        static string Mensaje(string Nombre, int Edad)
        {
            return (Nombre + " eres una persona mayor de edad, tienes " + Edad + " años, dizfruta tu vida siendo buena persona. ");

        }
    }
}
