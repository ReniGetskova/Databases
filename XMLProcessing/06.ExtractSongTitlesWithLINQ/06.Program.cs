namespace _06.ExtractSongTitlesWithLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("../../../catalog.xml");
            var songsTitles =
                from song in doc.Descendants("title")
                select song.Value;

            foreach (var songs in songsTitles)
            {
                Console.WriteLine(songs);
            }
        }
    }
}
