using System.Web;
using System.Web.Mvc;

namespace Hotel_Project_MsSQL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
