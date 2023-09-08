using System.Web;
using System.Web.Mvc;

namespace GraphTutorial_MVC_Csharp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
