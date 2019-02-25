using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Feature.Identity
{
    public struct Templates
    {
        public struct Identity
        {
            public static readonly ID ID = new ID("{DAB65993-AE9F-4813-AD07-075E901F75BA}");

            public struct Fields
            {
                public static readonly ID Logo = new ID("{250717F5-880C-4902-A265-8156F008C76E}");
                public static readonly ID LogoTagLine = new ID("{3710498A-37DC-44E7-A2F0-EE8520AEDF29}");
                public static readonly ID Copyright = new ID("{EF4F53B3-8781-4289-8BDB-18B7F387AE32}");
                public static readonly ID OrganisationName = new ID("{8429B80B-60F8-431A-81C3-096C4DC4CF90}");
                public static readonly ID OrganisationAddress = new ID("{54796228-B4FA-4511-8DB9-23FD951C5F4F}");
                public static readonly ID OrganisationPhone = new ID("{4BB898A2-9390-4B05-8362-4615CE026F7B}");
                public static readonly ID OrganisationEmail = new ID("{F79393DC-C508-477E-BE44-887F2C62E07B}");
            }
        }
    }
}