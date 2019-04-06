using AngleSharp.Html.Dom;

namespace HTML_Parser.core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
