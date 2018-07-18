using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Globalization;
using Synthesis;
using Synthesis.FieldTypes.Adapters;

namespace Foundation.CSSGridLayout.RenderingParameters
{
    public class ItemRenderingParameters : BaseRenderingParameters
    {
        public ItemRenderingParameters(Sitecore.Mvc.Presentation.RenderingParameters parameters) : base(parameters)
        {
        }

        public string GridColumn => GetStringValue(Const.RenderingParameters.Names.Item.GridColumn);
        public string GridRow => GetStringValue(Const.RenderingParameters.Names.Item.GridRow);
        public string GridArea => GetStringValue(Const.RenderingParameters.Names.Item.GridArea);
    }
}