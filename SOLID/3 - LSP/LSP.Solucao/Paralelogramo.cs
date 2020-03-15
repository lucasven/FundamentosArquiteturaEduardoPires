using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Solucao
{
    public abstract class Paralelogramo
    {
        protected Paralelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; }
        public double Largura { get; }
        public double Area { get { return Altura * Largura; } }
    }
}
