using System;
using System.Net;
using System.Net.Mail;

namespace MeusPedidos_Brunno.Classes
{
    public class MailSystem
    {

        public void sendEmail()
        {
            SmtpClient client = new SmtpClient("mysmtpserver");
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("username", "password");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("whoever@me.com");
            mailMessage.To.Add("receiver@me.com");
            mailMessage.Body = "body";
            mailMessage.Subject = "subject";
            client.Send(mailMessage);
        }

        public void CreateSMTPMail(string server, string body, string from)
        {
            string to = "bigercc@gmail.com";

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Obrigado por se candidatar.";
            message.Body = body;

            SmtpClient client = new SmtpClient(server);
            client.Port = 25; //or 587

            // Credentials are necessary if the server requires the client 
            // to authenticate before it will send e-mail on the client's behalf.

            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                            ex.ToString());
            }
        }
    }


}
