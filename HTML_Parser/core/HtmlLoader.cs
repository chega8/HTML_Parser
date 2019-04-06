﻿using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace HTML_Parser.core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            this.url = settings.GetNewUrl();
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = this.url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
