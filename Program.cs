using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine($"4 + 2 = {Aritmetica.Somar(4,2)}");
            Console.WriteLine($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");

            double t1 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFarenheit, 36);
            double t2 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.FarenheitCelsius, 100);
            Console.WriteLine($"36º Celcius = {t1}º Farenheit" );
            Console.WriteLine($"100º Farenheit = {t2}º Celcius");

            Console.ReadKey();
        }
    }
}
