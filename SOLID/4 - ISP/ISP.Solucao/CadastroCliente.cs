using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            //envia email para o cliente
        }

        public void SalvarBanco()
        {
            //salva no banco
        }

        public void ValidarDados()
        {
            //valida os dados do cliente
        }
    }
}
