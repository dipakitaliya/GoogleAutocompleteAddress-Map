using System.Web;
using System.Web.Mvc;

namespace Google_AutoComplete_Address
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
