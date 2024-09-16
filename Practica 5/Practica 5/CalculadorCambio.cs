using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    public static class CalculadorCambio
    {
        public static void CalcularCambio(decimal cambio, decimal[] denominaciones, int index, ref string resultado)
        {
            if (cambio ==0 || index >= denominaciones.Length)
            {
                return;
            }

            int cantidaMonedas = (int)(cambio / denominaciones[index]);
            if (cantidaMonedas > 0)
            {
                resultado += $"{cantidaMonedas} monedas de {denominaciones[index]:C2}\n";
            }

            cambio -= cantidaMonedas * denominaciones[index];
            cambio = Math.Round(cambio, 2);


            CalcularCambio(cambio, denominaciones, index + 1, ref resultado);
        }
    }
}
