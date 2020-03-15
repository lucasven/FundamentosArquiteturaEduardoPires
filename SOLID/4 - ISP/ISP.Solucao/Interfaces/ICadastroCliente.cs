using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Solucao
{
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}
