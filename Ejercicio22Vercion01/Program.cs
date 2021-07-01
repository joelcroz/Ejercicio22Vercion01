using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22Vercion01
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Clear();
			double temperaturaActual, temperaturaConvertida;
			Console.WriteLine("Opciones Disponibles");
			Console.WriteLine("(C)elsius a Fahrenheit");
			Console.WriteLine("(F)ahrenheit a Celsius");
			Console.Write("Ingrese C o F:");
			var opcionTemperatura = Console.ReadLine();
            if (opcionTemperatura.ToUpper()=="C" || opcionTemperatura.ToUpper()=="F")
            {
				if (opcionTemperatura.ToUpper() == "C")
                {
					Console.Write("Ingrese una temperatura en grados centigrados:");
					temperaturaActual = Convert.ToDouble(Console.ReadLine());
					temperaturaConvertida = 1.8 * temperaturaActual + 32;
					Console.WriteLine($"{temperaturaActual} ºC equivalen a {temperaturaConvertida} grados F");

                }
                else
                {
					Console.Write("Ingrese una temperatura en grados Fahrenheit:");
					temperaturaActual = Convert.ToDouble(Console.ReadLine());
					temperaturaConvertida = (temperaturaActual - 32) * 5 / 9;
					Console.WriteLine($"{temperaturaActual} ºF equivalen a {temperaturaConvertida} grados C");
				}
            }
            else
            {
				Console.WriteLine("Opcion no valida... Fin del programa");
            }


			Console.WriteLine();
		}
    }
}
