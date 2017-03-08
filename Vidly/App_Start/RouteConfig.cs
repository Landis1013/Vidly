﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // ATTRIBUTE ROUTING w/ REGEX CONSTRAINTS
            //  (Section 2, Lecture 13)
            // OTHER CONSTRAINTS ->     min, max, minlength, maxlength, int, float, guid
            routes.MapMvcAttributeRoutes();

            // ATTRIBUTE ROUTING w/ REGEX CONSTRAINTS


            //// Custom Routing - OLD SCHOOL 
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { controller="Movies", action="ByReleaseDate"},
            //    new { year = @"\d{4}", month = @"\d{2}" }
            //);


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
