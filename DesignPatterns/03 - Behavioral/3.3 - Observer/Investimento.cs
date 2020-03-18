using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly List<IObservador> observadores = new List<IObservador>();

        public string Simbolo { get; }

        protected Investimento(string simbolo, decimal valor)
        {
            Simbolo = simbolo;
            _valor = valor;
        }

        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value) return;

                _valor = value;
                Notificar();
            }
        }

        public void Subscribe(IObservador observador)
        {
            observadores.Add(observador);
            Console.WriteLine($"Notificando que {observador.Nome} está recebendo atualizações de {Simbolo}\n\n");
        }

        public void UnSubscribe(IObservador observador)
        {
            observadores.Remove(observador);
            Console.WriteLine($"Notificando que {observador.Nome} NÃO está recebendo atualizações de {Simbolo}\n\n");
        }

        private void Notificar()
        {
            foreach (var invest in observadores)
            {
                invest.Notificar(this);
            }
        }
    }
}
