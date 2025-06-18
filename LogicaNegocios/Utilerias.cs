using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public static class Utilerias
    {
        public static bool validaCampo(string valor, int longitudMinima)
        {
            return valor.Length >= longitudMinima;
        }

    }
}
