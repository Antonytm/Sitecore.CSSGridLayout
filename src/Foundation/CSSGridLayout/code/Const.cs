﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foundation.CSSGridLayout
{
    public static class Const
    {
        public static class Templates
        {
            public const string ContainerParameters = "{17C48067-F64F-4E65-8A79-3CF72D633DB5}";
        }

        public static class RenderingParameters
        {
            public static class Names
            {
                public static class Container
                {
                    public const string GridTemplateColumns = "GridTemplateColumns";
                    public const string GridTemplateRows = "GridTemplateRows";
                    public const string GridTemplateColumnsPredefined = "GridTemplateColumnsPredefined";
                    public const string GridTemplateRowsPredefined = "GridTemplateRowsPredefined";
                    public const string Display = "Display";
                    public const string GridColumnGap = "GridColumnGap";
                    public const string GridRowGap = "GridRowGap";
                    public const string GridGap = "GridGap";
                    public const string JustifyItems = "JustifyItems";
                    public const string AlignItems = "AlignItems";
                    public const string PlaceItems = "PlaceItems";
                }

                public static class Item
                {
                    public const string GridColumn = "GridColumn";
                    public const string GridColumnStart = "GridColumnStart";
                    public const string GridColumnEnd = "GridColumnEnd";
                    public const string GridRow = "GridRow";
                    public const string GridRowStart = "GridRowStart";
                    public const string GridRowEnd = "GridRowEnd";
                    public const string GridArea = "GridArea";
                    public const string JustifySelf = "JustifySelf";
                    public const string AlignSelf = "AlignSelf";
                    public const string PlaceSelf = "PlaceSelf";
                }
            }
        }
    }
}