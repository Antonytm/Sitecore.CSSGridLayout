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
        public string GridColumnStart => GetStringValue(Const.RenderingParameters.Names.Item.GridColumnStart);
        public string GridRowStart => GetStringValue(Const.RenderingParameters.Names.Item.GridRowStart);
        public string GridColumnEnd => GetStringValue(Const.RenderingParameters.Names.Item.GridColumnEnd);
        public string GridRowEnd => GetStringValue(Const.RenderingParameters.Names.Item.GridRowEnd);
        public string JustifySelf => GetStringValue(Const.RenderingParameters.Names.Item.JustifySelf);

        public string ColumnStyles
        {
            get
            {
                if (!string.IsNullOrEmpty(GridColumn))
                {
                    return $"grid-column: {GridColumn};";
                }

                return $"grid-column-start:{GridColumnStart}; grid-column-end:{GridColumnEnd};";
            }
        }

        public string RowStyles
        {
            get
            {
                if (!string.IsNullOrEmpty(GridRow))
                {
                    return $"grid-row: {GridRow};";
                }

                return $"grid-row-start:{GridRowStart}; grid-row-end:{GridRowEnd};";
            }
        }

        public string LocationStyles
        {
            get
            {
                if (!string.IsNullOrEmpty(GridArea))
                {
                    return $"grid-area: {GridArea};";
                }

                return RowStyles + ColumnStyles;
            }
        }

        public string JustifySelfStyles
        {
            get
            {
                if (!string.IsNullOrEmpty(JustifySelf))
                {
                    return $"justify-self: {JustifySelf};";
                }

                return string.Empty;
            }
        }

        public string Styles
        {
            get
            {
                return LocationStyles + JustifySelfStyles;
            }
        }
    }
}