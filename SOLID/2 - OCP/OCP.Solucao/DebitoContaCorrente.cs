using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //debita conta corrente
            return FormatarTransacao();
        }
    }
}
