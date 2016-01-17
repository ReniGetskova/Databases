using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10.TraverseDirectoryUsingXDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            var xDocument = new XDocument();
            xDocument.Add(CreateFileSystemXmlTree("../../../"));
            xDocument.Save("../../traverseWithXElement.xml");
        }


        private static XElement CreateFileSystemXmlTree(string source)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(source);
            var result = new XElement(
                "dir",
                new XAttribute("name", directoryInfo.Name),
                Directory.GetDirectories(source).Select(dir => CreateFileSystemXmlTree(dir)),
                directoryInfo.GetFiles().Select(fileName => new XElement("file", new XAttribute("name", fileName.Name), new XAttribute("size", fileName.Length))));

            return result;
        }
    }
}
