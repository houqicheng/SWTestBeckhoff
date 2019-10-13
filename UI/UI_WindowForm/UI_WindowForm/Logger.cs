using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UI_WindowForm
{
   public class Logger
    {
        private static bool _isLogEnable;
        private static string _filePath = @"C:\TempSample\Log.txt";

        public static void SetLogEnable(bool isEnable)
        {
            _isLogEnable = isEnable;
        }
        public static void WriteLog(string message)
        {
            if (!_isLogEnable)
            {
                return;
            }
            //string filePath = @"C:\TempSample\Log.txt";
            FileStream fs;
            StreamWriter sw;
            if (File.Exists(_filePath))
            {
                fs = new FileStream(_filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(_filePath, FileMode.Create, FileAccess.Write);
            }
            sw = new StreamWriter(fs);
            sw.Write(DateTime.Now.ToString("yyyy/MM/dd HH/mm/ss.fff") + ":" + message + "\r\n");

            sw.Close();
            fs.Close();
        }

        public static string ReadLog()
        {
            FileStream fs;
            StreamReader sr;
            string result = "";
            if (!File.Exists(_filePath))
            {
                return "";
            }
            else
            {
                fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);                
                result = sr.ReadToEnd();                
            }
            sr.Close();
            fs.Close();
            return result;
        }             
    }
}
