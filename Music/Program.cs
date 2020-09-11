namespace Music
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            // Console.Beep(300, 400);
            // Console.Beep(400, 400);
            // Console.Beep(500, 400);
            // Console.Beep(37, 400);
            // Console.Beep(300, 400);
            // Console.Beep(400, 400);
            // Console.Beep(500, 400);
            var scraper = new TableScraper();
            scraper.Scrape();
        }
    }
}