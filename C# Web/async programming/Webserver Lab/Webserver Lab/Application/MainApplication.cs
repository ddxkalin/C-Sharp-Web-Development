namespace WebserverLab.Application
{
    using Controllers;
    using Server.Contracts;
    using Server.Routing.Contracts;

    public class MainApplication : IApplication
    {
        public void Configure(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.Get(
                "/",
                req => new HomeController().Index());

            appRouteConfig.Get(
                "/register",
                req => new UserController().RegisterGet());

            appRouteConfig.Post(
                "/register",
                req => new UserController().RegisterPost(req.FormData["name"]));

            appRouteConfig.Get(
                "/user/{(?<name>[a-z]+)}",
                req => new UserController().Details(req.UrlParameters["name"]));
        }
    }
}