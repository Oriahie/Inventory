using System.Web;
using System.Web.Mvc;

namespace FindJobsFast_FJF_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
