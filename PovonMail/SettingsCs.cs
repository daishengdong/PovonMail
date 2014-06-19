using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PovonMail
{
    public class SettingsCs
    {
        private string name = null;
        private string emailAddr = null;
        private string password = null;
        private string sendServer = null;
        private string sendPort = null;
        private string receiveServer = null;
        private string receivePort = null;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string EmailAddr 
        {
            get
            {
                return emailAddr;
            }
            set
            {
                emailAddr = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string SendServer {
            get
            {
                return sendServer;
            }
            set
            {
                sendServer = value;
            }
        }

        public string SendPort {
            get
            {
                return sendPort;
            }
            set
            {
                sendPort = value;
            }
        }

        public string ReceiveServer {
            get
            {
                return receiveServer;
            }
            set
            {
                receiveServer = value;
            }
        }

        public string ReceivePort {
            get
            {
                return receivePort;
            }
            set
            {
                receivePort = value;
            }
        }
    }
}
