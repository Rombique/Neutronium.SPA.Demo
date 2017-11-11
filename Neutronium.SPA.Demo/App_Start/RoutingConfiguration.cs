﻿using Neutronium.Core.Navigation.Routing;
using Neutronium.SPA.Demo.Application.Navigation;
using Neutronium.SPA.Demo.ViewModel;
using Neutronium.SPA.Demo.ViewModel.Menu;

namespace Neutronium.SPA.Demo
{
    public class RoutingConfiguration
    {
        public static IRouterSolver Register()
        {
            var router = new Router();
            BuildRoutes(router);
            return router;
        }

        private static void BuildRoutes(IRouterBuilder routeBuilder) 
        {
            var convention = routeBuilder.GetTemplateConvention("{vm}");
            typeof(RoutingConfiguration).GetTypesFromSameAssembly()
                .InNamespace("Neutronium.SPA.Demo.ViewModel.Menu")
                .Register(convention);
        }
    }
}
