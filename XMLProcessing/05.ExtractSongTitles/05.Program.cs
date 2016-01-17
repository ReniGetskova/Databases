namespace _05.ExtractSongTitles
{
    using System;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = new XmlTextReader("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }   
            }
        }
    }
}
