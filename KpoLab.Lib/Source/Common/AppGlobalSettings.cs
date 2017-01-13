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

        private static IDataHelpersFactory _DataHelpersFactory = null;
        public static IDataHelpersFactory DataHelpersFactory
        {
            get
            {
                return _DataHelpersFactory;
            }
        }

        private static int _TestMode = 0;
        public static int TestMode
        {
            get
            {
                return _TestMode;
            }
        }

        public static void Initialize()
        {
            var cfgHelper = new ConfigurationUtility();
            _LogPath = cfgHelper.GetSetting("LogPath");
            _DataFileName = cfgHelper.GetSetting("DataFileName");

            string cfgTestMode = cfgHelper.GetSetting("TestMode");
            Int32.TryParse(cfgTestMode, out _TestMode);
            if (_TestMode == 0)
            {
                _DataHelpersFactory = new DataHelpersFactory();
            }
            else
            {
                _DataHelpersFactory = new MockDataHelpersFactory();
            }
        }
    }
}
