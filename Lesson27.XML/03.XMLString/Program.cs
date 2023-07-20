using System.Xml;

string xmlData = "<?xml version='1.0' encoding='utf-8' ?><Book><Title>CLR via C#</Title></Book>";

StringReader stringReader = new StringReader(xmlData);
XmlTextReader reader = new XmlTextReader(stringReader);

while (reader.Read())
{
    Console.WriteLine("{0,-15} {1,-10} {2,-10}",
        reader.NodeType.ToString(),
        reader.Name,
        reader.Value);
}

reader.Close();

// Delay.
Console.ReadKey();