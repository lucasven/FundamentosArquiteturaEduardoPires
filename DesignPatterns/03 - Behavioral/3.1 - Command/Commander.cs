using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    internal abstract class Commander
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
