﻿using System;
using System.Web.Routing;

namespace FriendlyURLsSample
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
          RouteConfig.RegisterRoutes(RouteTable.Routes);  // <- FriendlyURLsを有効に
        }
    }
}