using System;
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
                }

                public static class Item
                {
                    public const string GridColumn = "GridColumn";
                    public const string GridRow = "GridRow";
                    public const string GridArea = "GridArea";
                }
            }
        }
    }
}