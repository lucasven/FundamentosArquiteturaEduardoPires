using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
