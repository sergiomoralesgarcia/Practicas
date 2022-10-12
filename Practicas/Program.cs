using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practica1();
            //Practica2();
            Practica3();

        }

        #region Practica 1 Area Circulo
        static void Practica1()
        {
            
            // Ejercicio del área del círculo
            int edad = 25;
            int alumnos = 24;
            string curso = "DEINT";

            ///Console.WriteLine($"Tu edad es de {edad}");
            ///Console.WriteLine("edad: {0}", edad);
            // Console.WriteLine("Tu edad es de {0}", edad);
            //Console.WriteLine("En la clase de {0} hay {1} alumnos", curso, alumnos);
            Console.WriteLine("Intoduzca un número", curso, alumnos);
            int radio = int.Parse(Console.ReadLine());
            double area = Math.Pow(radio, 2) * Math.PI;
            Console.WriteLine($"El área del círculo de radio {radio} es {area}");

            

        }
        #endregion

        #region Practica 2 comprobar si puedes conducir
        static void Practica2()
        {
            const int PUEDE_CONDUCIR = 18;
            const string TIENE_CARNET = "S";

            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.WriteLine("Introduce tu edad:");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes carnet?(S/N)");
                string carnet = Console.ReadLine().ToUpper();
                if (carnet == TIENE_CARNET)
                {
                    Console.WriteLine("Puedes conducir");
                }
                else
                {
                    Console.WriteLine("No puedes conducir");
                }

            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }
        }
        #endregion

        #region Practica 3 comprobar si S/N está bien introducido
        static void Practica3()
        {
            const int PUEDE_CONDUCIR = 18;
            const string TIENE_CARNET = "S";
            
            string carnet = Console.ReadLine().ToUpper();

            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.WriteLine("Introduce tu edad:");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes carnet?(S/N)");
                carnet = Console.ReadLine().ToUpper();

                while (String.Equals(carnet, TIENE_CARNET))
                {
                    if (carnet == TIENE_CARNET)
                    {
                        Console.WriteLine("Puedes conducir");
                    }
                    else
                    {
                        Console.WriteLine("No puedes conducir");
                    }
                }
                Console.WriteLine("Se debe introducir N o S");
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }
        }
        #endregion
    }
}
