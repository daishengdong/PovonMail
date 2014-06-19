using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Windows.Forms;
namespace PovonMail.SecurityHandle
{
    class Base64Handler
    {
        public static bool isBase64Encoding(string message)
        {
            // 判断是不是 base64 编码，采用最简单的方式
            // 其他方法（正则表达式）都不正确
            return message.Length % 4 == 0 && message[message.Length - 1] == '=';
            // return System.Text.RegularExpressions.Regex.IsMatch(message, "^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{4}|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)$");
        }

        public static string EncodeBase64(string source)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(source);
            return Convert.ToBase64String(bytes);
        }

        public static string DecodeBase64(string result)
        {
            byte[] bytes = Convert.FromBase64String(result);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}