using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Foundation.Assets
{
    public struct Templates
    {
        public struct RenderingAssets
        {
            public static readonly ID ID = new ID("{DCC27C5A-4F5D-4F08-80BC-AF8F6074AD85}");

            public struct Fields
            {
                public static readonly ID ScriptFiles = new ID("{AFD27EDA-8FE9-48CF-8358-9C0BFE46EBFF}");
                public static readonly ID StylingFiles = new ID("{7F462060-A5CE-4A19-8D28-CC5188643BFA}");
                public static readonly ID InlineScript = new ID("{61E389A2-F1B2-4F73-9CB7-CE59EB8BDC96}");
                public static readonly ID InlineStyling = new ID("{1B1CA496-A20B-4526-B831-8C87562E3C77}");
            }
        }

        public struct PageAssets
        {
            public static readonly ID ID = new ID("{992A3C77-E709-4792-AB5D-DC7F567905A5}");

            public struct Fields
            {
                public static readonly ID JavascriptCodeTop = new ID("{48A266F7-80E3-4225-887C-DCCBB28CC836}");
                public static readonly ID JavascriptCodeBottom = new ID("{2F886AB2-A613-413C-9C00-04619FCB9FAA}");
                public static readonly ID CssCode = new ID("{6DE78F9B-D3CF-4EA8-B1C6-6A4991F2DE24}");
                public static readonly ID InheritAssets = new ID("{9355399F-1B63-4769-8C03-1BFF8B30B9D0}");
            }
        }

        public struct HasTheme
        {
            public static readonly ID ID = new ID("{5B6F8720-3A93-4DA1-92A0-C3E85E01219A}");

            public struct Fields
            {
                public static readonly ID Theme = new ID("{53B5AF0A-265F-4E60-B2B2-4576CE0BECCF}");
            }
        }
    }
}