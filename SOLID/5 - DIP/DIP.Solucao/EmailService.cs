using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SOLID.DIP.Solucao
{
    public class EmailService : IEmailService
    {
        public void Enviar(string de, string para, string assunto, string mensagem)
        {
            var mail = new MailMessage(de, para);

            var cliente = new SmtpClient()
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Host = "smtp.google.com"
            };

            mail.Subject = assunto;
            mail.Body = mensagem;
            cliente.Send(mail);
        }
    }
}
