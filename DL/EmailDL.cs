using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using OutLets.BL;
using System.Windows.Forms;
using Dnp.Net;

namespace OutLets.DL
{
    internal class EmailDL
    {

        public static List<BL.Email> emails = new List<BL.Email>();

         public  static bool addEmailToList(BL.Email temp) {

            emails.Add(temp);
            return true;
         }
        public static bool getDataFromFile()
        {
            String path = "Emails.csv";
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                    while (!file.EndOfStream)
                    {
                        String record = file.ReadLine();
                        string[] splittedRecord = record.Split(',');
                        string id = splittedRecord[0];
                        string email = splittedRecord[1];
                        string subject = splittedRecord[2];
                        string body = splittedRecord[3];
                        BL.Email temp = new BL.Email(id, email, subject, body);
                        addEmailToList(temp);
                    }
                return true;
            }
            return false;
        }
        public static bool putDataToFile(BL.Email Temp)
        {
            String path = "Emails.csv";
            using (StreamWriter user = new StreamWriter(path))
            {
                {
                    foreach (BL.Email em in emails)
                    {
                        var row = string.Format("{0},{1},{2},{3},",Temp.Id, Temp.emailText,Temp.Subject,Temp.Body);
                        user.WriteLine(row);
                        user.Flush();
                    }
                }
            }
            return true;

        }

        public static bool SendMailAtLoginTime(String mail,String body,String Subject)
        {
        
            try
            {
                String fromMail = "ai.amadirfan@gmail.com";
                String pass = "iuinenlpflmnolwn";
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = Subject;
                message.To.Add(new MailAddress(mail));
                message.Body = "<html><body>"+body+" </body></html>";
                message.IsBodyHtml = true;
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromMail, pass),
                    EnableSsl = true,
                };
                smtpClient.Send(message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"warn");
            }
            return true;
        }
        public static bool SendMail(String mail,String body,String subject)
        {
        
            try
            {
                String fromMail = "ai.amadirfan@gmail.com";
                String pass = "iuinenlpflmnolwn";
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = subject;
                message.To.Add(new MailAddress(mail));
                message.Body = "<html><body>"+body+" </body></html>";
                message.IsBodyHtml = true;
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromMail, pass),
                    EnableSsl = true,
                };
                smtpClient.Send(message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString(),"warn");
            }
            return true;
        }
    }
}
