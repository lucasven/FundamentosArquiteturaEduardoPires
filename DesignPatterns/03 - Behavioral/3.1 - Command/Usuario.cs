using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class Usuario
    {
        private readonly Calculadora calculadora = new Calculadora();
        private readonly List<Commander> commands = new List<Commander>();
        private int total;

        public void Adicionar(char operacao, int valor)
        {
            Commander command = new CalculadoraCommand(calculadora, operacao, valor);
            command.Executar();

            commands.Add(command);
            total++;
        }

        public void Desfazer(int niveis)
        {
            Console.WriteLine("\n-------- Retornar {0} níveis", niveis);

            for (int i = 0; i < niveis; i++)
            {
                if (total >= commands.Count - 1) continue;
                var command = commands[--total];
                command.Desfazer();
            }
        }

        public void Retornar(int niveis)
        {
            Console.WriteLine("\n-------- Retornar {0} níveis", niveis);

            for (int i = 0; i < niveis; i++)
            {
                if (total >= commands.Count - 1) continue;
                var command = commands[total++];
                command.Executar();
            }
        }
    }
}
