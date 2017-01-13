using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KpoLab.Lib
{
    public static class LogHelper
    {
        public static void ErrorLog(Exception ex)
        {
            File.AppendAllText("error.log", string.Format("{0:dd-MM-yyyy HH:mm:ss} -- {1}\n", DateTime.Now, ex.Message));
        }

        public static void ErrorLog(string message)
        {
            File.AppendAllText("error.log", string.Format("{0:dd-MM-yyyy HH:mm:ss} -- {1}\n", DateTime.Now, message));
        }
    }
}
