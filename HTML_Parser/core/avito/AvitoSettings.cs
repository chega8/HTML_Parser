namespace HTML_Parser.core.avito


{
    class AvitoParserSettings : IParserSettings
    {

        public AvitoParserSettings(int startPoint, int endPoint, string lowerCost, string upperCost)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;

            this.lowerCost = lowerCost;
            this.upperCost = upperCost;
        }

        public string BaseUrl { get; set; } = "https://www.avito.ru/samara/kvartiry/sdam/1-komnatnye?p=2&pmax=17000&pmin=10000";
        public string Prefix { get; set; } = "p{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }

        string lowerCost = "10000";
        string upperCost = "17000";

        public string GetNewUrl()
        {
            string url = BaseUrl;

            string part1 = "https://www.avito.ru/samara/kvartiry/sdam/1-komnatnye?";
            string part2 = $"&pmax={upperCost}&pmin={lowerCost}";
            url = $"{part1}/{Prefix}/{part2}";
            return url;
        }
    }
}
