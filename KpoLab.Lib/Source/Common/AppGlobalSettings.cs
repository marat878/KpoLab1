using System;
using System.Collections.Generic;
using System.Linq;
using KpoLab.Lib.Utility;

namespace KpoLab.Lib
{
    public static class AppGlobalSettings
    {
        private static string _LogPath = "";
        public static string LogPath
        {
            get
            {
                return _LogPath;
            }
        }

        private static string _DataFileName = "";
        public static string DataFileName
        {
            get
            {
                return _DataFileName;
            }
        }

        public static void Initialize()
        {
            var cfgHelper = new ConfigurationUtility();
            _LogPath = cfgHelper.GetSetting("LogPath");
            _DataFileName = cfgHelper.GetSetting("DataFileName");
        }
    }
}
