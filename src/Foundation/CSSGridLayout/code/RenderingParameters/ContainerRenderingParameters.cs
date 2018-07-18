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
    public class ContainerRenderingParameters : BaseRenderingParameters
    {
        public ContainerRenderingParameters(Sitecore.Mvc.Presentation.RenderingParameters parameters) : base(parameters)
        {
        }

        public string GridTemplateColumns => GetStringValue(Const.RenderingParameters.Names.Container.GridTemplateColumns);
        public string GridTemplateRows => GetStringValue(Const.RenderingParameters.Names.Container.GridTemplateRows);
    }
}