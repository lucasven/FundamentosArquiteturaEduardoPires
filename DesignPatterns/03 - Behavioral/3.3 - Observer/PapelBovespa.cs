using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal valor) : base(simbolo, valor)
        {
        }
    }
}
