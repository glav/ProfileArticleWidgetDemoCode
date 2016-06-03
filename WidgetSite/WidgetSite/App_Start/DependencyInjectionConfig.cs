using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;
using WidgetSite.Models;
using WidgetComponents.Contracts;
using WidgetComponents.Infrastructure;
using SimpleInjector;
using WidgetComponents.Data;
using WidgetComponents.Domain;

namespace WidgetSite
{
    public static class DependencyInjection
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public static void ConfigureDependencies(this IAppBuilder app)
        {
            // 1. Create a new Simple Injector container
            var container = new SimpleInjector.Container();

            // 2. Configure the container (register)
            container.Register<ILoggingService, LoggingService>(Lifestyle.Transient);
            container.Register<IDataRepository, DataRepository>(Lifestyle.Singleton);
            container.Register<ILookupService, LookupService>(Lifestyle.Transient);
            container.Register<ICostCalculationService, CostCalculationService>(Lifestyle.Transient);

            System.Web.Mvc.DependencyResolver.SetResolver(new SimpleInjector.Integration.Web.Mvc.SimpleInjectorDependencyResolver(container));
        }
    }
}