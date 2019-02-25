using Microsoft.Extensions.DependencyInjection;
using SC91Training.Foundation.SitecoreExtensions.Repositories;
using SC91Training.Foundation.SitecoreExtensions.Services;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Foundation.SitecoreExtensions
{
    public class Configurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(ITrackerService), typeof(TrackerService));
            serviceCollection.AddTransient(typeof(IRenderingPropertiesRepository), typeof(RenderingPropertiesRepository));
        }
    }
}