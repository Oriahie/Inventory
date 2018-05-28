using System;
using System.Web.Mail;

namespace FindJobsFast_FJF_.Messaging
{
    public class SmtpEmailService
    {
        public SmtpEmailService()
        {

        }
        public string SendEmail(EmailMessage msg)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserver", "smtp.gmail.com");
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", "465");
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", "2");
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "Oriahie@gmail.com");
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "tennyson10");
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
                mail.From = "info@fjf.com";//msg.From;//
                mail.To = msg.Recipient;
                mail.Subject = msg.Subject;//"Find Jobs Fast - Your one time password";
                mail.BodyFormat = MailFormat.Html;
                mail.Body = msg.Body;//CustomizeEmailBody(customerName, PIN);
                SmtpMail.SmtpServer = "smtp.gmail.com:465";
                SmtpMail.Send(mail);
                return "Mail sent successfully";


            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}