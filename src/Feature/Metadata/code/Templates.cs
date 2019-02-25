using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Feature.Metadata
{
    public struct Templates
    {
        public struct PageMetadata
        {
            public static ID ID = new ID("{7151D154-C39E-4078-8C45-96EC0A628612}");

            public struct Fields
            {
                public static readonly ID BrowserTitle = new ID("{FE97D518-F783-42A8-9D9A-E7A4D3930229}");
                public static readonly ID Description = new ID("{5D946EF3-B589-4BD8-BC05-E87D78A3DB87}");
                public static readonly ID Keywords = new ID("{8E84F385-34D5-4D93-9D64-352D1F22CBC5}");
                public static readonly ID CanIndex = new ID("{3BD4528C-9302-42EA-A882-F7F3B8803714}");
                public static readonly ID CanFollow = new ID("{59B6ED1E-0BE8-492F-8633-25D824ECA388}");
                public static readonly ID CustomMetadata = new ID("{9FA08368-A16E-46B5-B1D2-E23BD4A1D849}");
            }
        }

        public struct SiteMetadata
        {
            public static readonly ID ID = new ID("{0E59EC44-8BFB-47C3-B97B-AF58C5541FB2}");

            public struct Fields
            {
                public static readonly ID SiteBrowserTitle = new ID("{97F99752-9ED8-4D4D-88C6-216C3216DEF6}");
            }
        }
    }
}