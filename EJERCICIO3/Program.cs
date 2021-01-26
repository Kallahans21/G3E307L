using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido. Vamos a realizar la ecuación x= 4/3πr^3 , Para comenzar:");
            Console.WriteLine("Digite el valor del radio: ");
            //Declaración de variables y proceso de datos
            Double r, x;
            r = Double.Parse(Console.ReadLine());
            x = ((4 * 3.1415926554) / 3) * Math.Pow(Convert.ToDouble(r), 3);

            //salida de datos
            Console.WriteLine("El resultado de X en esta ecuación, es de: " + x);
            Console.ReadKey();

        }
    }
}
