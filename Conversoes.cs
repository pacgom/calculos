using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão.
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão de Temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFarenheit,
            FarenheitCelsius
        }

        /// <summary>
        /// Conversão de temperaturas.
        /// </summary>
        /// <param name="conversao"> Conversão a efeturar.</param>
        /// <param name="temperatura">A temperatura a converter. </param>
        /// <returns>Retorna o resultado da conversão. </returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFarenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FarenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }
    }

}
