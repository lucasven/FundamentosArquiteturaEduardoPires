using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public interface IObservador
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
