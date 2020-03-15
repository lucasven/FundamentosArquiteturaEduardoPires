using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Solucao_extension_methods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            //logica de negocio ....
            return debitoConta.FormatarTransacao();
        }
    }
}
