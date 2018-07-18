using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
using Synthesis;

namespace Foundation.CSSGridLayout.RenderingParameters
{
    public class BaseRenderingParameters
    {
        protected Sitecore.Mvc.Presentation.RenderingParameters _parameters;

        public BaseRenderingParameters(Sitecore.Mvc.Presentation.RenderingParameters parameters)
        {
            _parameters = parameters;
        }

        protected bool GetCheckBoxValue(string key)
        {
            if (_parameters.Contains(key))
                return _parameters[key] == "1";
            return false;
        }

        protected string GetStringValue(string key)
        {
            if (_parameters.Contains(key))
                return _parameters[key];
            return null;
        }

        protected string GetItemParameterValue(string parameter, string field)
        {

            if (!String.IsNullOrEmpty(GetStringValue(parameter))
                && ID.IsID(GetStringValue(parameter))
                && Sitecore.Context.Database.GetItem(new ID(GetStringValue(parameter))) != null
                && Sitecore.Context.Database.GetItem(new ID(GetStringValue(parameter))).Fields[field] != null)
            {
                return
                    Sitecore.Context.Database.GetItem(new ID(GetStringValue(parameter))).Fields[field]
                        .Value;
            }
            return null;
        }
    }
}