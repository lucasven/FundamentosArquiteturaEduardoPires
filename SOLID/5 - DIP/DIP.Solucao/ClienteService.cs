using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Solucao
{
    public class ClienteService : IClienteService
    {
        public ClienteService(IEmailService emailService, IClienteRepository clienteRepository)
        {
            EmailService = emailService;
            ClienteRepository = clienteRepository;
        }

        public IEmailService EmailService { get; }
        public IClienteRepository ClienteRepository { get; }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados Inválidos";

            ClienteRepository.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem vindo", "Parabéns! Você está cadastrado.");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
