using System.Web;
using System.Web.Mvc;

namespace TranNguyenThaouyen_2011068936
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
