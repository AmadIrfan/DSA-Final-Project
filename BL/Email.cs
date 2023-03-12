using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace OutLets.BL
{
    internal class Email
    {
        private String _id;
       private String _email;
        private String _body;
        private String _subject;
        public Email(String id,String email,String body,String subject) {
            this._email = email;
            this._id = id;
            this._body = body;
            this._subject = subject;
        }

        public string Body { get => _body; set => _body = value; }
        public string emailText { get => _email; set => _email = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Id { get => _id; set => _id = value; }
    }
}
