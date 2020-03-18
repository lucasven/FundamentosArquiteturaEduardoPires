using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Mensagem : IMessage, IEnumerable<IMessage>
    {
        private readonly List<IMessage> lista = new List<IMessage>();

        public string Nome { get; set; }
        public Mensagem(string nome)
        {
            Nome = nome;
        }

        public void AdicionarFilha(IMessage filha)
        {
            lista.Add(filha);
        }

        public void RemoverFilha(IMessage filha)
        {
            lista.Remove(filha);
        }

        public IMessage ObterFilha(int index)
        {
            return lista[index];
        }
        public IMessage ObterFilha(string nome)
        {
            return lista.First(c => c.Nome == nome);
        }

        public IEnumerable<IMessage> ObterLista()
        {
            return lista;
        }

        public IEnumerator<IMessage> GetEnumerator()
        {
            return ((IEnumerable<IMessage>)lista).GetEnumerator();
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);

            foreach (var mensagem in lista)
            {
                mensagem.ExibirMensagens(sub + 2);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IMessage>)lista).GetEnumerator();
        }
    }
}
