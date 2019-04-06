using AngleSharp.Html.Parser;
using System;

namespace HTML_Parser.core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;
        HtmlLoader loader;
        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }


        public IParser<T> Parser { get => parser; set => parser = value; }

        public IParserSettings ParserSettings
        {
            get => parserSettings;

            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }
        // Событие будет возвращать спрашенные за итерацию данные
        public event Action<object, T> OnNewData;
        // Событие отвечает за информирование при завершенни работы парсера
        public event Action<object> OnCompleted;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }
        
        public void Start()
        {
            isActive = true;
            // Асинхронно запускать не нужно, код и так работает асинхронно
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }
        // Ассинхронный метод, который контролирует процесс парсинга
        private async void Worker()
        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();
                // Ассинхронно парсим страницу и получаем документ
                var document = await domParser.ParseDocumentAsync(source);

                var result = parser.Parse(document);

                OnNewData?.Invoke(this, result);
            }

            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
