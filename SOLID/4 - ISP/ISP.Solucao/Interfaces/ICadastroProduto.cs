using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Solucao
{
    public interface ICadastroProduto : ICadastro
    {
        void ValidarDados();
    }
}
