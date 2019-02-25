using Microsoft.Extensions.DependencyInjection;
using SC91Training.Feature.Metadata.Infrastructure.Pipelines.GetPageMetadata;
using SC91Training.Feature.Metadata.Repositories;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Feature.Metadata.Infrastructure
{
    public class Configurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton(typeof(CombineTitle), typeof(CombineTitle));
            serviceCollection.AddSingleton(typeof(SetFromContext), typeof(SetFromContext));
            serviceCollection.AddSingleton(typeof(SetFromPage), typeof(SetFromPage));
            serviceCollection.AddSingleton(typeof(MetadataRepository), typeof(MetadataRepository));
        }
    }
}