//http://josedbaez.com/2016/09/synthesis-rendering-parameters-helper/
using System;
using System.Linq;
using System.Web.Mvc;
using Foundation.CSSGridLayout.RenderingParameters;
using Sitecore.Common;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc;
using Sitecore.Mvc.Presentation;
using Sitecore.SecurityModel;
using Sitecore.Web;
using Synthesis;

namespace Foundation.CSSGridLayout.Helpers
{
    public static class RenderingParameters
    {
        public static T GetRenderingParameters<T>(this HtmlHelper htmlHelper) where T : BaseRenderingParameters
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { htmlHelper.Sitecore().CurrentRendering.Parameters });
        }

        public static T GetRenderingParameters<T>() where T : BaseRenderingParameters
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { RenderingContext.Current.Rendering.Parameters });
        }

        public static string GetRenderingParameters(this HtmlHelper htmlHelper, string key)
        {
            if (!htmlHelper.Sitecore().CurrentRendering.Parameters.Contains(key)) return string.Empty;
            return htmlHelper.Sitecore().CurrentRendering.Parameters[key];
        }
    }

}