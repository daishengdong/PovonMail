using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;
using PovonMail.CommonStaticVar;

namespace PovonMail.XMLHandle
{
    class SettingsXMLHandler
    {
        private XmlDocument settings = null;
        private XmlElement curSetting = null;
        private XmlElement curElem = null;
        private XmlElement root = null;
        
        public SettingsXMLHandler() {
            settings = new XmlDocument();
            settings.Load(CommonStaticVariables.settingsFilePath);
            root = settings.DocumentElement;
        }

        public List<string> getAllEmailAddr()
        {
            XmlNodeList allEmailAddr = root.ChildNodes;
            List<string> allEmailAddrList = new List<string>();
            foreach (XmlElement emailAddr in allEmailAddr)
            {
                if (!allEmailAddrList.Contains(emailAddr.GetElementsByTagName("emailAddr").Item(0).InnerText))
                {
                    allEmailAddrList.Add(emailAddr.GetElementsByTagName("emailAddr").Item(0).InnerText);
                }
            }
            return allEmailAddrList;
        }

        public void update(SettingsCs newSettings)
        {
            string searchString = "/settings/setting[emailAddr='" + newSettings.EmailAddr+ "']";
            curSetting = (XmlElement)root.SelectSingleNode( searchString );

            curSetting.GetElementsByTagName("name").Item(0).InnerText = newSettings.Name;
            curSetting.GetElementsByTagName("emailAddr").Item(0).InnerText = newSettings.EmailAddr;
            curSetting.GetElementsByTagName("password").Item(0).InnerText = newSettings.Password;
            curSetting.GetElementsByTagName("sendServer").Item(0).InnerText = newSettings.SendServer;
            curSetting.GetElementsByTagName("sendPort").Item(0).InnerText = newSettings.SendPort;
            curSetting.GetElementsByTagName("receiveServer").Item(0).InnerText = newSettings.ReceiveServer;
            curSetting.GetElementsByTagName("receivePort").Item(0).InnerText = newSettings.ReceivePort;

            save();
        }

        public SettingsCs search(string emailAddr)
        {
            string searchString = "/settings/setting[emailAddr='" + emailAddr + "']";
            curSetting = (XmlElement)root.SelectSingleNode( searchString );

            SettingsCs retSetting = new SettingsCs();
            retSetting.Name = curSetting.GetElementsByTagName("name").Item(0).InnerText;
            retSetting.EmailAddr = curSetting.GetElementsByTagName("emailAddr").Item(0).InnerText;
            retSetting.Password = curSetting.GetElementsByTagName("password").Item(0).InnerText;
            retSetting.SendServer = curSetting.GetElementsByTagName("sendServer").Item(0).InnerText;
            retSetting.SendPort = curSetting.GetElementsByTagName("sendPort").Item(0).InnerText;
            retSetting.ReceiveServer = curSetting.GetElementsByTagName("receiveServer").Item(0).InnerText;
            retSetting.ReceivePort = curSetting.GetElementsByTagName("receivePort").Item(0).InnerText;
            return retSetting;
        }

        public void remove(string emailAddr)
        {
            string searchString = "/settings/setting[emailAddr='" + emailAddr + "']";
            curSetting = (XmlElement)root.SelectSingleNode(searchString);
            curSetting.ParentNode.RemoveChild(curSetting);

            save();
        }

        public void add( SettingsCs newSettings )
        {
            curSetting = settings.CreateElement("setting");

            curElem = settings.CreateElement("name");
            curElem.InnerText = newSettings.Name;
            curSetting.AppendChild(curElem);

            curElem = settings.CreateElement("emailAddr");
            curElem.InnerText = newSettings.EmailAddr;
            curSetting.AppendChild(curElem);

            curElem = settings.CreateElement("password");
            curElem.InnerText = newSettings.Password;
            curSetting.AppendChild(curElem);

            curElem = settings.CreateElement("sendServer");
            curElem.InnerText = newSettings.SendServer;
            curSetting.AppendChild(curElem);

            curElem = settings.CreateElement("sendPort");
            curElem.InnerText = newSettings.SendPort;
            curSetting.AppendChild(curElem);

            curElem = settings.CreateElement("receiveServer");
            curElem.InnerText = newSettings.ReceiveServer;
            curSetting.AppendChild(curElem);

            curElem = settings.CreateElement("receivePort");
            curElem.InnerText = newSettings.ReceivePort;
            curSetting.AppendChild(curElem);

            root.AppendChild(curSetting);

            save();
        }

        private void save()
        {
            settings.Save(CommonStaticVariables.settingsFilePath);
        }
    }
}
