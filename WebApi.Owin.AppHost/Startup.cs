using System.Web.Http;
using Microsoft.Owin.Cors;
using Owin;

namespace WebApi.Owin.AppHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional});
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }
    }
}