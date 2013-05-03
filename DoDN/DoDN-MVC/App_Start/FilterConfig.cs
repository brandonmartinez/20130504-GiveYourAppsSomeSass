using System.Web.Mvc;

namespace DoDN_MVC
{
    public class FilterConfig
    {
        #region Static Methods

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        #endregion
    }
}