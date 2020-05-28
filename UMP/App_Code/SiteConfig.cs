using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using etdl.UMP.Web.BL;
using System.Configuration;

namespace UMP
{
    public class SiteConfig : ISiteConfig
    {
        public string ConnectionString
        {
            get {
                return ConfigurationManager.ConnectionStrings["ConnectingString"].ConnectionString;
            }
        }
    }
}