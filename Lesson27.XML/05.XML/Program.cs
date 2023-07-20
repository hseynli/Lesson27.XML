using System.Xml;

var reader = new XmlTextReader("books.xml");

// Atributların oxunması
while (reader.Read())
{
    if (reader.NodeType == XmlNodeType.Element)
    {
        // Tipə görə yoxlama ona görə lazımdır ki, həm XmlNodeType.Element tapılacaq, həm də XmlNodeType.EndElement
        // və həmin elementlərin içində atributlar yoxdur.
        if (reader.Name.Equals("Title"))   // Şərhə salmaq.
        {
            Console.WriteLine("|{0}|", reader.GetAttribute("FontSize"));
        }
    }
}

// Delay.
Console.ReadKey();