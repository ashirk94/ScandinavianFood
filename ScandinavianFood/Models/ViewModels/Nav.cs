using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ScandinavianFood.Models
{
    public static class Nav
    {
        public static string Active(this HtmlHelper html, string control)
        {
            var routeData = html.ViewContext.RouteData;

            var routeControl = (string)routeData.Values["controller"];

            var returnActive = control == routeControl;

            return returnActive ? "active" : "";
        }
    }
}
