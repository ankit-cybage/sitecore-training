using SC91Training.Feature.Navigation.Repositories;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SC91Training.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        private readonly INavigationRepository navigationRepository;

        public NavigationController() : this(ServiceLocator.ServiceProvider.GetService(typeof(INavigationRepository)) as INavigationRepository)
        {

        }

        public NavigationController(INavigationRepository navigationRepository)
        {
            this.navigationRepository = navigationRepository;
        }

        public ActionResult PrimaryMenu()
        {
            var items = this.navigationRepository.GetPrimaryMenu();
            return this.View("PrimaryMenu", items);
        }
    }
}