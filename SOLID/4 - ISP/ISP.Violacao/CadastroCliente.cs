using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            //enviar e-mail para o cliente
        }

        public void SalvarBanco()
        {
            //insert na tabela de cliente
        }

        public void ValidarDados()
        {
            //validar cpf, email
        }
    }
}
