using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.Web;

namespace me.lisen.Util.Config
{
    public class Config
    {
        /// <summary>
        /// 获取config
        /// </summary>
        /// <param name="key">获取的节点</param>
        /// <returns>节点的字</returns>
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// 设置节点值
        /// </summary>
        /// <param name="key">节点</param>
        /// <param name="value">值</param>
        public static void SaveValue(string key,string value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(HttpContext.Current.Server.MapPath("~/XmlConfig/system.config"));
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            xNode = doc.SelectSingleNode("//appSettings");
            xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='"+key+"']");
            if (xElem1 != null)
            {
                xElem1.SetAttribute("value",value);
            }
            else
            {
                xElem2 = doc.CreateElement("add");
                xElem2.SetAttribute("key",key);
                xElem2.SetAttribute("value",value);
                xNode.AppendChild(xElem2);
            }
            doc.Save(HttpContext.Current.Server.MapPath("~/XmlConfig/system.config"));
        }
    }
}
