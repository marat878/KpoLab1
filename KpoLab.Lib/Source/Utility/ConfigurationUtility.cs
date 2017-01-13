using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace KpoLab.Lib.Utility
{
    public class ConfigurationUtility
    {
        public string GetSetting(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            return (key == null) ? string.Empty : value;
        } 
    }
}
