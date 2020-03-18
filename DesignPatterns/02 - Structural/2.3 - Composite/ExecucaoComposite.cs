using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class ExecucaoComposite
    {
        public static void Executar()
        {
            var validacaoCadastro = new Mensagem("o cadastro não foi realizado");

            var usuarioFormErro = new Mensagem("o usuário informou um nome inválido");

            var tamanhoNomeForm = new InputFormatMessage("o nome precisa possuir mais de 2 caracteres");
            var nomeVazioForm = new InputFormatMessage("O nome não pode possuir numeros");

            usuarioFormErro.AdicionarFilha(tamanhoNomeForm);
            usuarioFormErro.AdicionarFilha(nomeVazioForm);

            validacaoCadastro.AdicionarFilha(usuarioFormErro);

            var domainUsuarioErro = new Mensagem("Problemas ao processar o cadastro de usuario");

            var cpfUsuarioDomain = new DomainMessage("O CPF informado está em uso!");
            var emailUsuarioDomain = new DomainMessage("O Email informado está em uso!");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);

            validacaoCadastro.AdicionarFilha(domainUsuarioErro);

            validacaoCadastro.ExibirMensagens(2);
        }
    }
}
