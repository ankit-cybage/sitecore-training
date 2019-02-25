using Microsoft.Extensions.DependencyInjection;
using SC91Training.Feature.Navigation.Repositories;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Feature.Navigation.Infrastructure
{
    public class Configurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(INavigationRepository), typeof(NavigationRepository));
        }
    }
}