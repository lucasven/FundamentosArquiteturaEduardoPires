using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //valida aniversario da conta
            //debita
            return FormatarTransacao();
        }
    }
}
