using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            //????????????????produto nao tem email, pra que serve então????????????????
        }

        public void SalvarBanco()
        {
            //salvar o produto no banco
        }

        public void ValidarDados()
        {
            //valida os dados do produto
        }
    }
}
