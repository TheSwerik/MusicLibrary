using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Music
{
    public class TableScraper
    {
        private const string Url = "https://pages.mtu.edu/~suits/notefreqs.html";
        private static readonly HttpClient Client = new HttpClient();

        private static async Task<HtmlDocument> GetDocument(string url)
        {
            using var response = await Client.GetAsync(url);
            using var content = response.Content;
            var result = await content.ReadAsStringAsync();

            var document = new HtmlDocument();
            document.LoadHtml(result);
            return document;
        }

        public void Scrape()
        {
            var document = GetDocument(Url).Result;
            var info = document.DocumentNode.SelectSingleNode("(//center/center)").InnerHtml
                               .Replace("</td>", "")
                               .Split("<td align=\"center\">");
            Console.WriteLine(string.Join("\n", info));
        }
    }
}