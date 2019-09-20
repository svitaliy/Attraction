using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park
{
    static class AttractionSettings
    {
        public static int GetValueByKey(string key)
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings[key]);
        }

    }
}
