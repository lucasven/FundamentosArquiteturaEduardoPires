using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Solucao
{
    public class CPF
    {
        public string Numero { get; set; }
        public bool Validar()
        {
            return Numero.Length == 11;
        }
    }
}
