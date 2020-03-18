using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class InputFormatMessage : IMessage
    {
        public string Nome { get; set; }
        public InputFormatMessage(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}
