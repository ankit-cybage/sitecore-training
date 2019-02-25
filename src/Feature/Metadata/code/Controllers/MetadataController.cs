using SC91Training.Feature.Metadata.Repositories;
using Sitecore.DependencyInjection;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SC91Training.Feature.Metadata.Controllers
{
    public class MetadataController : SitecoreController
    {
        public MetadataController() : this(ServiceLocator.ServiceProvider.GetService(typeof(MetadataRepository)) as MetadataRepository)
        {
            
        }

        public MetadataController(MetadataRepository metadataRepository)
        {
            this.MetadataRepository = metadataRepository;
        }

        public ActionResult PageMetadata()
        {
            var metadata = this.MetadataRepository.Get(RenderingContext.Current.Rendering.Item);
            return this.View(metadata);
        }

        public MetadataRepository MetadataRepository { get; }
    }
}