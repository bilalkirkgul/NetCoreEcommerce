using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Ecommerce.UI.CoreMVC.Helper
{
    public class MailHelper
    {
        public static bool SendActivationCode(string FirstName, string mail, Guid activationCode)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(mail);
            msg.Subject = "BilalNetCoreEccomerce Activation Kodu ";
            msg.IsBodyHtml = true;
            msg.Body = string.Format("<!DOCTYPE html><html><head><title>BilalNetCoreEccomerce</title></head><body><h2>Merhaba {0} sitemize hoşgeldiniz</h2><p>Hesabınızı aktifleştirmek için lütfen <a href='http://localhost:61710/Account/ActivationUser/{1}'>link</a>'e tıklayınız</p></body></html>", FirstName, activationCode);
            msg.From = new MailAddress("guid34coder@outlook.com", "BilalNetCoreEccomerce");


            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            NetworkCredential credential = new NetworkCredential("guid34coder@outlook.com", "Coder159");
            client.Credentials = credential;
            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
