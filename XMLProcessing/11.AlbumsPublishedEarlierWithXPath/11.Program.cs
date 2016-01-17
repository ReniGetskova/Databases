namespace _11.AlbumsPublishedEarlierWithXPath
{
    using System;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            string xPathQuery = "/albums/album[year>2005]/name";
            XmlNodeList earlierAlbums = doc.SelectNodes(xPathQuery);
            foreach (XmlElement name in earlierAlbums)
            {
                Console.WriteLine(name.InnerText);
            }
        }
    }
}
