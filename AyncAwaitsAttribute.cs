namespace Acme.Collections
{
    internal class AyncAwaitsAttribute
    {

        // AYNC AWAIT
        public async Task<int> RetrieveDocsHomePage()
        {
            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/");

            Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: Finished downloading.");
            return content.Length;
        }

        // ATTRIBUTES
        public class HelpAttribute : Attribute
        {
            string _url;
            string _topic;

            public HelpAttribute(string url) => _url = url;

            public string Url => _url;

            public string Topic
            {
                get => _topic;
                set => _topic = value;
            }
        }

        [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features")]
        public class Widget
        {
            [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features",
            Topic = "Display")]
            public void Display(string text) { }
        }

    }

}
