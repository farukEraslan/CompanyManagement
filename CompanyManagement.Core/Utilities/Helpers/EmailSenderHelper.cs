namespace CompanyManagement.Core.Utilities.Helpers
{
    public class EmailSenderHelper
    {
        public static void SendEmail(string name, string mailBody, string toMail)
        {
            MimeMessage mail = new MimeMessage();

            mail.From.Add(new MailboxAddress("Company Management", "hr-ik@hotmail.com"));
            mail.To.Add(new MailboxAddress(name, toMail));
            mail.Subject = "Şifre Kurtarma E-Postası";

            mail.Body = new TextPart("plain")
            {
                Text = $"Şifre sıfırlama için oluşturulan kodunuz : {mailBody}"
            };

            var smtp = new SmtpClient();
            smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("hr-ik@hotmail.com", "H&R-ik123");
            smtp.Send(mail);
            smtp.Disconnect(true);
        }
    }
}
