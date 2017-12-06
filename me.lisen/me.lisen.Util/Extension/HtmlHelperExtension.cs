using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace me.lisen.Util.Extension
{
    public static class HtmlHelperExtension
    {
        /// <summary>
        /// 获取控制器名称
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static string GetControllerName(this HtmlHelper htmlHelper)
        {
            return htmlHelper.ViewContext.RouteData.Values["Controller"].ToString();
        }

        /// <summary>
        /// 获取动作名称
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static string GetActionName(this HtmlHelper htmlHelper)
        {
            return htmlHelper.ViewContext.RouteData.Values["Action"].ToString();
        }
    }
}
