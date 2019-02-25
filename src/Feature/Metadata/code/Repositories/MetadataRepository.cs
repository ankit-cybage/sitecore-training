using SC91Training.Feature.Metadata.Infrastructure.Pipelines.GetPageMetadata;
using SC91Training.Feature.Metadata.Models;
using Sitecore.Data.Items;
using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Feature.Metadata.Repositories
{
    public class MetadataRepository
    {
        public IMetadata Get(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            var args = new GetPageMetadataArgs(new MetadataViewModel(), item);
            CorePipeline.Run("metadata.getPageMetadata", args);
            return args.Metadata;
        }
    }
}