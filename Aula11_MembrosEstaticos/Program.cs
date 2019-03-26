using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_MembrosEstaticos
{
    public static class ConversorStatic
    {
        public static double CelsiusToFah(double temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }

        public static double FahToCelsius(double temperatura)
        {
            return (temperatura - 32) * 5/9;
        }
    }

    public class ConversorInstancia
    {
        public static double temperatura;

        public double CelsiusToFah()
        {
            return (temperatura * 9 / 5) + 32;
        }

        public double FahToCelsius()
        {
            return (temperatura - 32) * 5 / 9;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new ConversorInstancia();
            var c2 = new ConversorInstancia();
            ConversorInstancia.temperatura = 30;
            var celsius = c1.CelsiusToFah();
            ConversorInstancia.temperatura = 70;
            var fah = c1.FahToCelsius();

            Console.WriteLine(celsius);
            Console.WriteLine(fah);
            Console.ReadKey();

        }

        private static void TesteClasseStatic()
        {
            double temperatura = 35;
            temperatura = ConversorStatic.CelsiusToFah(temperatura);
            Console.WriteLine(temperatura);
        }
    }
}
