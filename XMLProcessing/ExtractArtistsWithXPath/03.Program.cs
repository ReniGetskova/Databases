namespace ExtractArtistsWithXPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../catalog.xml");
            XmlElement root = xmlDoc.DocumentElement;
            PrintFromCollection(GetArtistAntAlbums(root));
        }

        private static Dictionary<string, int> GetArtistAntAlbums(XmlElement rootElement)
        {
            Dictionary<string, int> artistAndAlbums = new Dictionary<string, int>();
            XmlNodeList artists = rootElement.SelectNodes("/albums/album/artist");
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

        private static void PrintFromCollection(Dictionary<string, int> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
