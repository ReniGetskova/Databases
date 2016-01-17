namespace _09.TraverseDirectory
{
    using System.IO;
    using System.Text;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new XmlTextWriter("../../traverseWithXmlWriter.xml", Encoding.UTF8))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("directoriesRoot");
                CreateFileSystemXmlTreeUsingXmlWriter("../../..", writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }

        private static void CreateFileSystemXmlTreeUsingXmlWriter(string source, XmlWriter writer)
        {
            var directoryInfo = new DirectoryInfo(source);
            var folders = directoryInfo.GetDirectories();

            foreach (var folder in folders)
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("name", folder.Name);
                CreateFileSystemXmlTreeUsingXmlWriter(folder.FullName, writer);
                writer.WriteEndElement();
            }

            var files = directoryInfo.GetFiles();
            foreach (var file in files)
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", file.Name);
                writer.WriteAttributeString("size", file.Length.ToString());
                writer.WriteEndElement();
            }
        }
    }
}

