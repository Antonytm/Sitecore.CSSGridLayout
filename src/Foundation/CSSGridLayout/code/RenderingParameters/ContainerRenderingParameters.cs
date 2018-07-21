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

        public string GridTemplateColumnsPredefined => GetItemParameterValue(Const.RenderingParameters.Names.Container.GridTemplateColumnsPredefined);
        public string GridTemplateRowsPredefined => GetItemParameterValue(Const.RenderingParameters.Names.Container.GridTemplateRowsPredefined);
        public string GridTemplateColumns => GetStringValue(Const.RenderingParameters.Names.Container.GridTemplateColumns);
        public string GridTemplateRows => GetStringValue(Const.RenderingParameters.Names.Container.GridTemplateRows);

        public string Display => GetItemParameterValue(Const.RenderingParameters.Names.Container.Display);

        public string DisplayStyles
        {
            get
            {
                var style = string.IsNullOrEmpty(Display) ? "grid" : Display;
                return $"display:{style};";
            }
        }

        public string ColumnsStyles
        {
            get
            {
                var style = string.IsNullOrEmpty(GridTemplateColumns) ? GridTemplateColumnsPredefined : GridTemplateColumns;
                return $"grid-template-columns:{style};";
            }
        }

        public string RowStyles
        {
            get
            {
                var style = string.IsNullOrEmpty(GridTemplateRows) ? GridTemplateRowsPredefined : GridTemplateRows;
                return $"grid-template-rows:{style};";
            }
        }

        public string Styles
        {
            get { return DisplayStyles + ColumnsStyles + RowStyles; }
        }
    }
}