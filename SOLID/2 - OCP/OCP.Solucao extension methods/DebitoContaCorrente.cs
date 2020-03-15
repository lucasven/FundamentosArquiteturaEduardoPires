using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Solucao_extension_methods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            //logica de negocio ....
            return debitoConta.FormatarTransacao();
        }
    }
}
