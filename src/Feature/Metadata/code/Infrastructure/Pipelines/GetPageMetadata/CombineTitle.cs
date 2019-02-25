using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Feature.Metadata.Infrastructure.Pipelines.GetPageMetadata
{
    public class CombineTitle
    {
        public void Process(GetPageMetadataArgs args)
        {
            args.Metadata.Title = args.Metadata.PageTitle + args.Metadata.SiteTitle;
        }
    }
}