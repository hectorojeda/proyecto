using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATOS DE UNA ESFERA");
            //instancias
            super superficie = new super();
            
            Console.WriteLine("MUESTRA LA SUPERFICIE DE UNA ESFERA");
            Console.WriteLine("El radio es: {0}", superficie.r);
            Console.WriteLine("La superficie es: {0}", superficie.su = 4 * Math.PI * Math.Pow(superficie.r,2));
        
        }
    }
}
