using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Feature.Navigation
{
    public struct Templates
    {
        public struct NavigationRoot
        {
            public static readonly ID ID = new ID("{9FC31F73-1C5C-4F70-8D00-700473E6E60E}");
        }

        public struct Navigable
        {
            public static readonly ID ID = new ID("{CE779CE9-C596-4093-8F5E-0F591E35C0E3}");

            public struct Fields
            {
                public static readonly ID ShowInNavigation = new ID("{8B00C609-CFEF-4C94-A8E5-16A36D6552EB}");
                public static readonly ID NavigationTitle = new ID("{CEA08A6A-CC4D-4742-9064-B3A253AB9496}");
                public static readonly ID ShowChildren = new ID("{120154E6-2197-4408-9229-F2F1C30B69D6}");
            }
        }

        public struct Link
        {
            public static readonly ID ID = new ID("{EA283B88-5943-4367-B768-C7251F678521}");

            public struct Fields
            {
                public static readonly ID Link = new ID("{25DB62E1-98DC-4DBB-ABEB-43EF8AF79581}");
            }
        }

        public struct LinkMenuItem
        {
            public static readonly ID ID = new ID("{99D6013D-2FC4-4ABF-8338-85282859D147}");

            public struct Fields
            {
                public static readonly ID Icon = new ID("{B0E3682C-719E-423F-B5CF-FBA88A749BDC}");
                public static readonly ID DividerBefore = new ID("{68228AA0-F823-40B0-B4B8-8809DF54F6B7}");
            }
        }
    }
}