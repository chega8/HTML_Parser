using System.Collections.Generic;
using System.Linq;
using AngleSharp.Html.Dom;

namespace HTML_Parser.core.avito
{
    class AvitoParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();

            var items = document.QuerySelectorAll("span")
                .Where(i => i.ClassName != null && i.ClassName.Contains("price"));

            var links = document.QuerySelectorAll("a")
                .Where(i => i.ClassName != null && i.ClassName.Contains("item-description-title-link"));

            foreach (var item in links)
            {
                list.Add(item.GetAttribute("href"));
            }

            return list.ToArray();
        }
    }
}
