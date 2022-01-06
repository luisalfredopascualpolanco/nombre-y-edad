using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto13._1
{
    class Program
    {
        class Personas
        {
            private string nombre;
            private int edad;
            public void Cargar()
            {
                Console.Write("Dame el nombre de la persona: ");
                nombre = Console.ReadLine();

                Console.Write("Dame la edad de la persona: ");
                edad = int.Parse(Console.ReadLine());
            }

            public void Imprimir()
            {
                Console.WriteLine("El nombre de la persona es "+ nombre + " y su edad es " + edad);
            }

            public void MayorDeEdad()
            {
                if (edad >= 18)
                {
                    Console.WriteLine(nombre+ " es mayor de edad.");
                }
                else
                {
                    Console.WriteLine(nombre + " es menor de edad.");
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Personas persona = new Personas();

                persona.Cargar();
                persona.Imprimir();
                persona.MayorDeEdad();
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
