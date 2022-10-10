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
    }
}
