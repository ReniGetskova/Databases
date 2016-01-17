namespace _02.ExtractArtistsDOMParsing
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            XmlElement rootNode = doc.DocumentElement;

            foreach (var item in GetArtistAntAlbums(rootNode))
            {
                Console.WriteLine("Artist: {0}, has {1}, albums", item.Key, item.Value);
            }
        }

        private static Dictionary<string, int> GetArtistAntAlbums(XmlElement rootElement)
        {
            Dictionary<string, int> artistAndAlbums = new Dictionary<string, int>();
            XmlNodeList artists = rootElement.GetElementsByTagName("artist");
            foreach (XmlElement artist in artists)
            {
                var artistName = artist.InnerText;
                if (artistAndAlbums.ContainsKey(artistName))
                {
                    artistAndAlbums[artistName] += 1;
                }
                else
                {
                    artistAndAlbums.Add(artistName, 1);
                }
            }

            return artistAndAlbums;
        }
    }
}