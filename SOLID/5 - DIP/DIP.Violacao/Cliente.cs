using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public CPF CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && CPF.Validar();
        }
    }
}
