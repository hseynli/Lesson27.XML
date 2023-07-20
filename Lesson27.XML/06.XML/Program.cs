using System.Xml;

var reader = new XmlTextReader("books.xml");

while (reader.Read())
{
    if (reader.NodeType == XmlNodeType.Element)
    {
        if (reader.HasAttributes)
        {
            while (reader.MoveToNextAttribute())
            {
                Console.WriteLine("{0} = {1}", reader.Name, reader.Value);
            }
        }
    }
}

// Delay.
Console.ReadKey();