using SC91Training.Foundation.SitecoreExtensions.Extensions;
using Sitecore;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Feature.Metadata.Infrastructure.Pipelines.GetPageMetadata
{
    public class SetFromContext
    {
        public void Process(GetPageMetadataArgs args)
        {
            args.Metadata.SiteTitle = this.GetSiteTitle(args.Item);
        }

        private string GetSiteTitle(Item item)
        {
            var contextItem = this.GetSiteMetadataItem(item);
            return contextItem?[Templates.SiteMetadata.Fields.SiteBrowserTitle] ?? string.Empty;
        }

        private Item GetSiteMetadataItem(Item contextItem)
        {
            return contextItem.GetAncestorOrSelfOfTemplate(Templates.SiteMetadata.ID) ?? Context.Site.GetContextItem(Templates.SiteMetadata.ID);
        }
    }
}