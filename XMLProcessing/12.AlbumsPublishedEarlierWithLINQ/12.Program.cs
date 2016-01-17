namespace _12.AlbumsPublishedEarlierWithLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("../../../catalog.xml");
            var earlierAlbums =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) > 2005
                select album.Element("name").Value;

            foreach (var album in earlierAlbums)
            {
                Console.WriteLine(album);
            }
        }
    }
}
