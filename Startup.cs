using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(GraphTutorial_MVC_Csharp.Startup))]
namespace GraphTutorial_MVC_Csharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}