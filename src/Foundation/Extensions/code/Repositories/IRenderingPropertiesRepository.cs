﻿using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC91Training.Foundation.SitecoreExtensions.Repositories
{
    public interface IRenderingPropertiesRepository
    {
        T Get<T>(Rendering rendering);
    }
}