namespace _07.CreateXMLFileWithPersonData
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            using (StreamReader reader = new StreamReader("../../person.txt"))
            {
                person.Name = reader.ReadLine();
                person.Address = reader.ReadLine();
                person.PhoneNumber = reader.ReadLine();
            }

            XElement personData = new XElement("person", new XElement("name", person.Name), new XElement("address", person.Address), new XElement("phone", person.PhoneNumber));
            Console.WriteLine("Person data was saved in file person.xml ");
            personData.Save("../../person.xml");
        }
    }
}
