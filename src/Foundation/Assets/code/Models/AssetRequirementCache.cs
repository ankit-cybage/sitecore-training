using Sitecore.Caching;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Foundation.Assets.Models
{
    internal class AssetRequirementCache : CustomCache
    {
        public AssetRequirementCache(long maxSize) : base("SC91Training.Foundation.AssetRequirements", maxSize)
        {
        }

        public AssetRequirementList Get(ID cacheKey)
        {
            return (AssetRequirementList)this.GetObject(cacheKey.ToString());
        }

        public void Set(ID cacheKey, AssetRequirementList requirementList)
        {
            this.SetObject(cacheKey.ToString(), requirementList);
        }
    }
}