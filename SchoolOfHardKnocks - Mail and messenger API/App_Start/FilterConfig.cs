using System.Web;
using System.Web.Mvc;

namespace SchoolOfHardKnocks___Mail_and_messenger_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
