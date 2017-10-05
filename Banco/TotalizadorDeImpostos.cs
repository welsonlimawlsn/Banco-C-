using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class TotalizadorDeImpostos
    {
        public double Total { get; private set; }
        public void Adiciona(ITributavel t)
        {
            Total += t.CalcularTrubutos();
        }
    }
}
