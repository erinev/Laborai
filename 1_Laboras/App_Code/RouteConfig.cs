using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace _1_Laboras
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.EnableFriendlyUrls();
        }
    }
}