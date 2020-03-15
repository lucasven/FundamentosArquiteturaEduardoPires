using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Solucao_extension_methods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            //logica de negocio ....
            return debitoConta.FormatarTransacao();
        }
    }
}
