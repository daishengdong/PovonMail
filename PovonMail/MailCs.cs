using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PovonMail
{
    public class MailCs
    {
        string fromName = null;
        string from = null;
        string toName = null;
        string to = null;
        string subject = null;
        string body = null;
        DateTime date;

        public string FromName
        {
            get
            {
                return fromName;
            }
            set
            {
                fromName = value;
            }
        }

        public string From
        {
            get
            {
                return from;
            }
            set
            {
                from = value;
            }
        }

        public string ToName
        {
            get
            {
                return toName;
            }
            set
            {
                toName = value;
            }
        }

        public string To 
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public string Body 
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
    }
}
