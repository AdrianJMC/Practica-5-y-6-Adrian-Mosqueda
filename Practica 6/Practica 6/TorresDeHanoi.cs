using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    public static class TorresDeHanoi
    {
        public static void Resolver(int n, char origen, char destino, char auxiliar, ref string resultado)
        {
            if (n == 1)
            {
                resultado += $"Mover disco 1 de {origen} a {destino}\n";
            }
            else
            {
                Resolver(n - 1, origen, auxiliar, destino, ref resultado);
                resultado += $"Mover disco {n} de {origen} a {destino}\n";
                Resolver(n - 1, auxiliar, destino, origen, ref resultado);
            }
        }
    }
}

