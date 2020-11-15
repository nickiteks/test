using Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace components
{
    public partial class ComponentMailSender : Component
    {
        private string _mail;
        private string _password;
        private string _error;
        private List<string> emails;
        private Regex _reg = new Regex(pattern);
        private const string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-
!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-
9]{2,17}))$";
        public ComponentMailSender()
        {
            InitializeComponent();
        }

        public ComponentMailSender(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public string Mail
        {
            get { return _mail; }
            set { if (!_reg.IsMatch(value)) { _mail = value; } }
        }
        /// <summary>
        /// Пароль электронной почты, с которой будут отправляться письма
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        /// <summary>
        /// Ошибка при отправке сообщений
        /// </summary>
        public string GetError { get { return _error; } }
        /// <summary>
        /// Добавление адреса в рассылку
        /// </summary>
        /// <param name="mail"></param>
        public void AddAddressee(string mail)
        {
            if (emails == null)
            {
                emails = new List<string>();
            }
            if (_reg.IsMatch(mail))
            {
                emails.Add(mail);
            }
        }
        public StatusResult SendMessage(string subject, string message)
        {
            MailMessage objMailMessage = new MailMessage();
            SmtpClient objSmtpClient = null;
            if (string.IsNullOrEmpty(subject))
            {
            return StatusResult.NoSubject;
            }
            if (string.IsNullOrEmpty(message))
            {
                return StatusResult.NoMessage;
            }
            if (emails == null || emails.Count == 0)
            {
                return StatusResult.NoAddressees;
            }
            try
            {
                objMailMessage.From = new MailAddress(_mail);
                for (int i = 0; i < emails.Count; ++i)
                {
                    objMailMessage.To.Add(new MailAddress(emails[i]));
                }
                objMailMessage.Subject = subject;
                objMailMessage.Body = message;
                objMailMessage.SubjectEncoding = Encoding.UTF8;
                objMailMessage.BodyEncoding = Encoding.UTF8;
                objSmtpClient = new SmtpClient("smtp.gmail.com", 587);
                objSmtpClient.UseDefaultCredentials = false;
                objSmtpClient.EnableSsl = true;
                objSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                objSmtpClient.Credentials = new NetworkCredential(_mail, _password);
                objSmtpClient.Send(objMailMessage);
                return StatusResult.EmailsSend;
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return StatusResult.HaveError;
            }
            finally
            {
                objMailMessage = null;
                objSmtpClient = null;
            }
        }
    }
}
