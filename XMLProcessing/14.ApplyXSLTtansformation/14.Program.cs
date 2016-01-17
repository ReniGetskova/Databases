namespace _14.ApplyXSLTtansformation
{
    using System.Xml.Xsl;

    class Program
    {
        static void Main(string[] args)
        {
            string pathToXmlFile = "../../../catalog.xml";
            XslCompiledTransform catalogXslt = new XslCompiledTransform();
            catalogXslt.Load("../../catalog.xslt");
            catalogXslt.Transform(pathToXmlFile, "../../catalog.html");
        }
    }
}
