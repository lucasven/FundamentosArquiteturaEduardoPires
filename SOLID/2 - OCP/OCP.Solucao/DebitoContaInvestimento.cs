using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //debita conta investimneto
            //isentar taxas
            return FormatarTransacao();
        }
    }
}
