using Sitecore.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SC91Training.Foundation.SitecoreExtensions.Attributes
{
    public class SkipAnalyticsTrackingAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.RequestContext.HttpContext.Request.IsAjaxRequest() && Tracker.IsActive)
            {
                Tracker.Current?.CurrentPage?.Cancel();
            }
        }
    }
}