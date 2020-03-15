using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Solucao
{
    public class CadastroProduto : ICadastroProduto
    {
        public void SalvarBanco()
        {
            //salva o produto no banco
        }

        public void ValidarDados()
        {
            //valida os dados do produto
        }
    }
}
