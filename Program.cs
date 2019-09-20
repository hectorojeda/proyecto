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
            area area = new area();
            volumen volumen = new volumen();
            
            Console.WriteLine("MUESTRA LA SUPERFICIE DE UNA ESFERA");
            Console.WriteLine("El radio es: {0}", superficie.r);
            Console.WriteLine("La superficie es: {0}", superficie.su = 4 * Math.PI * Math.Pow(superficie.r,2));
            Console.WriteLine("El area es: {0}", a.ar = Math.PI * Math.Pow(a.r,2));
            Console.WriteLine("El volumen es :{0}",volumen.vol=(4/3)*Math.PI*Math.Pow(volumen.r,3));
        
        }
    }
}
