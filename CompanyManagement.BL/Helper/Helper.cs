using MailKit.Security;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.BL.Helper
{
    public class Helper
    {
        public static void SendEmail(string firstName, string lastName, string personelMail, string toMail)
        {
            MimeMessage mail = new MimeMessage();

            mail.From.Add(new MailboxAddress("Gürtaş Metal İnsan Kaynakları", "hr-ik@hotmail.com"));
            mail.To.Add(new MailboxAddress($"{firstName} {lastName}", $"{toMail}"));
            mail.Subject = "Gürtaş ERP Kullanıcı Bilgileriniz";

            mail.Body = new TextPart("plain")
            {
                Text = $"Şirketimize hoşgeldiniz {firstName}. \n\n Kullanıcı Adınız : {personelMail} \n\n Şifreniz : Company_123 \n\n Şifrenizi kimseyle paylaşmayın!"
            };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("hr-ik@hotmail.com", "H&R-ik123");
            smtp.Send(mail);
            smtp.Disconnect(true);
        }
    }
}
