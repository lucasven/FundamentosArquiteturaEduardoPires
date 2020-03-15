using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.OCP.Solucao_extension_methods
{
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public decimal Valor { get; set; }
        public string NumeroTransacao { get; set; }

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            // Numero da transacao formatado
            return NumeroTransacao;
        }
    }
}
