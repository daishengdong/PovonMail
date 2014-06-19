using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PovonMail.CommonStaticVar
{
    public class CommonStaticVariables
    {
        // 配置文件地址
        public static string settingsFilePath = Environment.CurrentDirectory + @"\settings.xml";

        // 接收的邮件
        public static string receivedMailsDirectoryPath = Environment.CurrentDirectory + @"\Received Mails";

        // WriteFrm 载入时的三种类型
        public enum TYPE { WRITE, REPLY, FORWARD};
    }
}
