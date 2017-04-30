using System.Web;
using System.Web.Mvc;

namespace Programacion_3_TP_FInal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
