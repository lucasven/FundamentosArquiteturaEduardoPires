using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class Calculadora
    {
        private int valorAtual;

        public void Operacao(char operador, int valor)
        {
            switch(operador)
            {
                case '+': valorAtual += valor; break;
                case '-': valorAtual -= valor; break;
                case '*': valorAtual *= valor; break;
                case '/': valorAtual /= valor; break;
            }
            Console.WriteLine("(dado {1} {2}) - Valor atual = {0,3}", valorAtual, operador, valor);
        }
    }
}
