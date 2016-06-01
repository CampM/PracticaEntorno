using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************
Autor: Moisés Campón García
Fecha creación: 27/03/2016
Última modificación: 2/03/2016
Versión: 1.00
***********************************/

namespace WindowsFormsApplication1
{
    public static class Estatica
    {
        

        /// <summary>
        /// Metodo encargado de realizar la conversion a Grados Centigrados
        /// </summary>
        /// <param name="fahrenheit">Grados a convertir</param>
        /// <returns>Grados Centigrados</returns>
        public static float ConvvertirACentigrados(float fahrenheit)
        {
            float centigrados = (fahrenheit - 32) * 5 / 9f;
            return centigrados;
        }

        /// <summary>
        /// Metodo encargado de la conversion a Grados fahrenheit
        /// </summary>
        /// <param name="centigrados">Grados a convertir</param>
        /// <returns>Grados Fahrenheit</returns>
        public static float ConvvertirAFahrenheit(float centigrados)
        {
            float fahrenheit = centigrados * 9 / 5 + 32f;
            return fahrenheit;
        }

        
    }
}
