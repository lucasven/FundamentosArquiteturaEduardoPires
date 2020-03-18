using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class Pagamento
    {
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public MeioPagamento MeioPagamento { get; set; }
    }
}
