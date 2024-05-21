using System.Net;
using System.Net.Mail;

namespace mailHandler
{
    public class MailHandler
    {

        public void SendMail(string address, string msg)
        {
            MailAddress from = new MailAddress(Config.mail_from, "Приложение");
            MailAddress to = new MailAddress(address);


            MailMessage message = new MailMessage(from, to);
            message.Subject = "Новый заказ!";

            message.Body = msg;


            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.Credentials = new NetworkCredential(Config.mail_from, Config.mail_pswd);
            smtp.EnableSsl = true;
            smtp.Send(message);
            Console.Read();
        }

    }
}
