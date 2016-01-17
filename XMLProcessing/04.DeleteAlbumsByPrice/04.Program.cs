namespace _04.DeleteAlbumsByPrice
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalog.xml");
            XmlElement root = xmlDoc.DocumentElement;
            double price = 20;
            XmlNodeList albums = root.SelectNodes("album");
            List<string> candidatesForDeleting = GetAlbumsThatHaveExactPrice(root, price);
            foreach (string name in candidatesForDeleting)
            {
                foreach (XmlNode album in albums)
                {
                    if (album.FirstChild.InnerText == name)
                    {
                        root.RemoveChild(album);
                        Console.WriteLine("Deleted album: {0}", name);
                    }
                }
            }

            xmlDoc.Save("../../afterDelete.xml");
        }

        private static List<string> GetAlbumsThatHaveExactPrice(XmlElement element, double price)
        {
            List<string> albumsWithExactPrice = new List<string>();
            XmlNodeList albums = element.GetElementsByTagName("album");
            foreach (XmlNode item in albums)
            {
                if (double.Parse(item["price"].InnerText) > price)
                {
                    albumsWithExactPrice.Add(item["name"].InnerText.ToString());
                }
            }

            return albumsWithExactPrice;
        }
    }
}
