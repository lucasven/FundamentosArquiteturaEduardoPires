using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados Inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem vindo", "Parabéns! Você está cadastrado.");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
