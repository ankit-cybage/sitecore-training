using SC91Training.Foundation.Assets.Models;
using SC91Training.Foundation.Assets.Repositories;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Pipelines.Response.GetPageRendering;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Foundation.Assets.Pipelines.GetPageRendering
{
    public class AddPageAssets : GetPageRenderingProcessor
    {
        public override void Process(GetPageRenderingArgs args)
        {
            this.AddAssets(PageContext.Current.Item);
        }

        protected void AddAssets(Item item)
        {
            var styling = this.GetPageAssetValue(item, Templates.PageAssets.Fields.CssCode);
            if (!string.IsNullOrWhiteSpace(styling))
            {
                AssetRepository.Current.AddInlineStyling(styling, true);
            }
            var scriptBottom = this.GetPageAssetValue(item, Templates.PageAssets.Fields.JavascriptCodeBottom);
            if (!string.IsNullOrWhiteSpace(scriptBottom))
            {
                AssetRepository.Current.AddInlineScript(scriptBottom, ScriptLocation.Body, true);
            }
            var scriptHead = this.GetPageAssetValue(item, Templates.PageAssets.Fields.JavascriptCodeTop);
            if (!string.IsNullOrWhiteSpace(scriptHead))
            {
                AssetRepository.Current.AddInlineScript(scriptHead, ScriptLocation.Head, true);
            }
        }

        private string GetPageAssetValue(Item item, ID assetField)
        {
            if (item.DescendsFrom(Templates.PageAssets.ID))
            {
                var assetValue = item[assetField];
                if (!string.IsNullOrWhiteSpace(assetValue))
                {
                    return assetValue;
                }
            }

            return GetInheritedPageAssetValue(item, assetField);
        }

        private static string GetInheritedPageAssetValue(Item item, ID assetField)
        {
            var inheritedAssetItem = item.Axes.GetAncestors().FirstOrDefault(i => i.DescendsFrom(Templates.PageAssets.ID) && MainUtil.GetBool(item[Templates.PageAssets.Fields.InheritAssets], false) && string.IsNullOrWhiteSpace(item[assetField]));
            return inheritedAssetItem?[assetField];
        }
    }
}