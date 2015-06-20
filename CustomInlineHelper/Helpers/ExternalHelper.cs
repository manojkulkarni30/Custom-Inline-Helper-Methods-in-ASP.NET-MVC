using System.Web.Mvc;

namespace CustomInlineHelper.Helpers
{
    public static class ExternalHelper
    {
        public static MvcHtmlString ListItems(this HtmlHelper htmlHelper, string[] items)
        {
            var ulElement = new TagBuilder("ul");
            foreach (var item in items)
            {
                var liElement = new TagBuilder("li");
                liElement.SetInnerText(item);
                ulElement.InnerHtml += liElement.ToString();
            }
            return new MvcHtmlString(ulElement.ToString());
        }
    }
}