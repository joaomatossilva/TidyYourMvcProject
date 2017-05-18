using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMusicStore.Infrastructure.FeatureFolders
{
    public class ControllerFactory : DefaultControllerFactory
    {
        protected override Type GetControllerType(RequestContext requestContext, string controllerName)
        {
            return
                typeof(ControllerFactory).Assembly.GetType("MvcMusicStore.Features." + controllerName +
                                                            "." + controllerName + "Controller");
        }
    }
}