﻿using System;
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
        public string GridColumnGap => GetStringValue(Const.RenderingParameters.Names.Container.GridColumnGap);
        public string GridRowGap => GetStringValue(Const.RenderingParameters.Names.Container.GridRowGap);
        public string GridGap => GetStringValue(Const.RenderingParameters.Names.Container.GridGap);
        public string Display => GetItemParameterValue(Const.RenderingParameters.Names.Container.Display);
        public string JustifyItems => GetItemParameterValue(Const.RenderingParameters.Names.Container.JustifyItems);
        public string AlignItems => GetItemParameterValue(Const.RenderingParameters.Names.Container.AlignItems);
        public string PlaceItems => GetStringValue(Const.RenderingParameters.Names.Container.PlaceItems);

        public string DisplayStyles
        {
            get
            {
                var style = string.IsNullOrEmpty(Display) ? "grid" : Display;
                return $"display:{style};";
            }
        }

        public string GapStyles
        {
            get
            {
                if (!string.IsNullOrEmpty(GridGap))
                {
                    return $"grid-gap: {GridGap};";
                }

                return $"grid-column-gap:{GridColumnGap}; grid-row-gap:{GridRowGap};";
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

        public string JustifyItemsStyles
        {
            get
            {
                if (!string.IsNullOrEmpty(JustifyItems))
                {
                    return $"justify-items: {JustifyItems};";
                }

                return string.Empty;
            }
        }

        public string AlignItemsStyles
        {
            get
            {
                if (!string.IsNullOrEmpty(AlignItems))
                {
                    return $"align-items: {AlignItems};";
                }

                return string.Empty;
            }
        }

        public string PlaceItemsStyles
        {
            get
            {
                if (!string.IsNullOrEmpty(PlaceItems))
                {
                    return $"place-items: {PlaceItems};";
                }

                return AlignItemsStyles + JustifyItemsStyles;
            }
        }

        public string Styles
        {
            get { return DisplayStyles + ColumnsStyles + RowStyles + GapStyles + PlaceItemsStyles; }
        }
    }
}