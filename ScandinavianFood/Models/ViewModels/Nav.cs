using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ScandinavianFood.Models
{
    public static class Nav
    {
        public static string IsActive(this HtmlHelper html, string control)
        {
            var routeData = html.ViewContext.RouteData;

            string routeControl = (string)routeData.Values["controller"];

            if(control == routeControl)
            {
                return "active";
            }

            return "";
        }
    }
}
