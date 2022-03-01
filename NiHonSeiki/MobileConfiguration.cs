// Code from http://developers.de/blogs/andreas_lehmann/archive/2009/05/26/a-simple-implementation-of-config-files-for-windows-mobile.aspx

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;

namespace NiHonSeiki
{
    public static class MobileConfiguration
   {
        public static NameValueCollection Settings;


      

        static MobileConfiguration()
        {
             string mobileExecuteFullPathFile = Assembly.GetExecutingAssembly().GetName().CodeBase;
             string configFile = mobileExecuteFullPathFile.Substring(0,mobileExecuteFullPathFile.Length-14) + "app.config";


            if (!File.Exists(configFile))
            {
                throw new FileNotFoundException(string.Format("Application configuration file '{0}' not found.", configFile));
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(configFile);
            XmlNodeList nodeList = xmlDocument.GetElementsByTagName("appSettings");
            Settings = new NameValueCollection();

            foreach (XmlNode node in nodeList)
            {
                foreach (XmlNode key in node.ChildNodes)
                {
                    Settings.Add(key.Attributes["key"].Value, key.Attributes["value"].Value);
                }
            }
      }
  }
}
