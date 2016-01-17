namespace JSONProcessing
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //zad. 1 -> download rss content
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw", "../../rss.xml");
            //Console.WriteLine("Download rss content and save it to file rss.xml");

            //zad.2 -> load xml file
            XDocument doc = XDocument.Load("../../rss.xml");

            //zad.3 -> xml to json
            string jsonFromXml = JsonConvert.SerializeXNode(doc, Newtonsoft.Json.Formatting.Indented);
            //Console.WriteLine(jsonFromXml);

            //zad.4 -> using LINQ-to-JSON select all video titles and print them on the console
            var jsonObject = JObject.Parse(jsonFromXml);
            var titles = jsonObject["feed"]["entry"].Select(entry => entry["title"]);
            Console.WriteLine("Titles of the videos:\n");
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

            //zad.5 -> parse json
            var jsonTemplate = new
            {
                id = string.Empty,
                title = string.Empty,
                published = string.Empty
            };
            var videos = jsonObject["feed"]["entry"].Select(video => JsonConvert.DeserializeAnonymousType(video.ToString(), jsonTemplate));

            //zad.6 -> Using the POCOs create a HTML page that shows all videos from the RSS
            var htmlCreator = new StreamWriter("../../videos.html");
            htmlCreator.Write("<html><head><title>Videos from Telerik RSS</title><meta charset=\"UTF-8\"></head><body>");
            foreach (var video in videos)
            {
                htmlCreator.WriteLine(
                    "<div style=\"display: inline-block;\"><iframe width=420 height=315 src=\"https://www.youtube.com/embed/"
                    + video.id.Substring(video.id.LastIndexOf(":") + 1) + "\"></iframe><br />"
                    + "<a style=\"text-decoration: none; font-family: Arial; color: #444;\""
                    + " href=\"https://youtu.be/"
                    + video.id.Substring(video.id.LastIndexOf(":") + 1) + "\" target=\"_blank\">" + video.title + "</a></div"
                    + ">");
            }

            htmlCreator.Write("</body></html>");
            htmlCreator.Close();
        }
    }
}
