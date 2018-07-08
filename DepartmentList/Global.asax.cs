﻿using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DepartmentList.Models;

namespace DepartmentList
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            SqlProviderServices.SqlServerTypesAssemblyName ="Microsoft.SqlServer.Types, Version=13.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91";
            SqlServerTypes.Utilities.LoadNativeAssemblies(Server.MapPath("~/bin"));
            using (var context = new DepartmentContext())
            {
                context.Database.Initialize(true);
            }
        }
    }
}
