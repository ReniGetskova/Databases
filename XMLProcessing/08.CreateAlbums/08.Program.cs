namespace _08.CreateAlbums
{
    using System.Text;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            var writer = new XmlTextWriter("../../albums.xml", Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteStartElement("albums");

            using (var reader = XmlReader.Create("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    switch (reader.Name)
                    {
                        case "album":
                            if (reader.IsStartElement())
                            {
                                writer.WriteStartElement("album");
                            }

                            break;
                        case "name":
                            writer.WriteElementString("title", reader.ReadElementContentAsString());
                            break;
                        case "artist":
                            writer.WriteElementString("artist", reader.ReadElementContentAsString());
                            writer.WriteEndElement();
                            break;
                    }
                }
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
