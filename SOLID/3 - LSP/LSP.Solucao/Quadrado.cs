using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Solucao
{
    public class Quadrado:Paralelogramo
    {
        public Quadrado(int altura, int largura):base(altura, largura)
        {
            if (largura != altura)
                throw new Exception("Os dois lados do quadrado devem ser iguais");
        }
    }
}
