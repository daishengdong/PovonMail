using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;
using PovonMail.CommonStaticVar;

namespace PovonMail.XMLHandle
{
    class ReceivedMailXMLHandler
    {
        private XmlDocument mails = null;
        private XmlElement curMail = null;
        private XmlElement curElem = null;
        private XmlElement root = null;
        private string xmlFilePath = null;
        
        public ReceivedMailXMLHandler(string xmlFilePath)
        {
            this.xmlFilePath = xmlFilePath;
            mails = new XmlDocument();
            mails.Load(xmlFilePath);
            root = mails.DocumentElement;
        }

        public List<MailCs> getAllEmail()
        {
            XmlNodeList allMails = root.ChildNodes;
            List<MailCs> allMailList = new List<MailCs>();
            foreach (XmlElement mail in allMails)
            {
                MailCs curMail = new MailCs();
                curMail.FromName = mail.GetElementsByTagName("fromName").Item(0).InnerText;
                curMail.From = mail.GetElementsByTagName("from").Item(0).InnerText;
                curMail.ToName = mail.GetElementsByTagName("toName").Item(0).InnerText;
                curMail.To = mail.GetElementsByTagName("to").Item(0).InnerText;
                curMail.Subject = mail.GetElementsByTagName("subject").Item(0).InnerText;
                curMail.Body = mail.GetElementsByTagName("body").Item(0).InnerText;
                curMail.Date = Convert.ToDateTime(mail.GetElementsByTagName("date").Item(0).InnerText);
                if (!allMailList.Contains(curMail))
                {
                    allMailList.Add(curMail);
                }
            }
            return allMailList;
        }

        public MailCs search(string fromName, string from, string subject, string date)
        {
            string searchString = "/mails/mail[fromName='" + fromName + "' and from='" + from + "' and subject='" + subject + "'and date='" + date + "']";
            curMail = (XmlElement)root.SelectSingleNode( searchString );
            if (curMail == null)
            {
                return null;
            }

            MailCs retMail= new MailCs();
            retMail.FromName = curMail.GetElementsByTagName("fromName").Item(0).InnerText;
            retMail.From = curMail.GetElementsByTagName("from").Item(0).InnerText;
            retMail.ToName = curMail.GetElementsByTagName("toName").Item(0).InnerText;
            retMail.To = curMail.GetElementsByTagName("to").Item(0).InnerText;
            retMail.Subject = curMail.GetElementsByTagName("subject").Item(0).InnerText;
            retMail.Body = curMail.GetElementsByTagName("body").Item(0).InnerText;
            retMail.Date = Convert.ToDateTime(curMail.GetElementsByTagName("date").Item(0).InnerText);
            return retMail;
        }

        public void delete(string fromName, string from, string subject, string date)
        {
            string searchString = "/mails/mail[fromName='" + fromName + "' and from='" + from + "' and subject='" + subject + "'and date='" + date + "']";
            curMail = (XmlElement)root.SelectSingleNode(searchString);
            curMail.ParentNode.RemoveChild(curMail);

            save();
        }

        public void add(MailCs newMails)
        {
            curMail = mails.CreateElement("mail");

            curElem = mails.CreateElement("fromName");
            curElem.InnerText = newMails.FromName;
            curMail.AppendChild(curElem);

            curElem = mails.CreateElement("from");
            curElem.InnerText = newMails.From;
            curMail.AppendChild(curElem);

            curElem = mails.CreateElement("toName");
            curElem.InnerText = newMails.ToName;
            curMail.AppendChild(curElem);

            curElem = mails.CreateElement("to");
            curElem.InnerText = newMails.To;
            curMail.AppendChild(curElem);

            curElem = mails.CreateElement("subject");
            curElem.InnerText = newMails.Subject;
            curMail.AppendChild(curElem);

            curElem = mails.CreateElement("body");
            curElem.InnerText = newMails.Body;
            curMail.AppendChild(curElem);

            curElem = mails.CreateElement("date");
            curElem.InnerText = newMails.Date.ToString();
            curMail.AppendChild(curElem);

            root.AppendChild(curMail);

            save();
        }

        private void save()
        {
            mails.Save(xmlFilePath);
        }
    }
}
