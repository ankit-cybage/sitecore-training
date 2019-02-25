using SC91Training.Feature.Metadata.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Feature.Metadata.Infrastructure.Pipelines.GetPageMetadata
{
    public class GetPageMetadataArgs : Sitecore.Pipelines.PipelineArgs
    {
        public GetPageMetadataArgs(IMetadata metadata, Item item)
        {
            this.Metadata = metadata;
            this.Item = item;
        }

        public IMetadata Metadata { get; }
        public Item Item { get; }
    }
}