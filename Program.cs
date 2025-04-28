using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Lucas");
          

            Console.WriteLine("ingrese su edad..");
            p1.Edad= int.Parse( Console.ReadLine() );
            Console.WriteLine("ingrese su nacionalidad..");
            p1.Nacionalidad = Console.ReadLine();


            Console.WriteLine("El nombre de la persona es : " + p1.Nombre);

            Console.WriteLine("su edad es : " + p1.Edad + " años ");

            Console.WriteLine("La nacionalidad es: " + p1.Nacionalidad);

            Console.WriteLine(p1.saludar());
            string nombre;
            Console.WriteLine("ingrese nombre de la persona : ");
            nombre =Console.ReadLine();
            Console.WriteLine(p1.saludar(nombre));

            Console.ReadKey();  
        }
    }
}
