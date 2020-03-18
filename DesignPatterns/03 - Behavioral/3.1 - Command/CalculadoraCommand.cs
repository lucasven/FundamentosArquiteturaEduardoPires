using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    internal class CalculadoraCommand : Commander
    {
        private readonly Calculadora calculadora;
        private char operador;
        private int valor;

        public CalculadoraCommand(Calculadora calculadora, char operador, int valor)
        {
            this.calculadora = calculadora;
            this.operador = operador;
            this.valor = valor;
        }

        public char Operator
        {
            set => operador = value;
        }

        public char Operand
        {
            set => operador = value;
        }

        public override void Desfazer()
        {
            calculadora.Operacao(Desfazer(operador), valor);
        }

        public override void Executar()
        {
            calculadora.Operacao(operador, valor);
        }

        private static char Desfazer(char operador)
        {
            switch(operador)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("operador desconhecido");
            }
        }
    }
}
