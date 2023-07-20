using System.Text;
using System.Xml;

XmlTextWriter xmlWriter = new XmlTextWriter("books.xml", Encoding.Unicode);

xmlWriter.WriteStartDocument();                  // <?xml version="1.0"?>
xmlWriter.WriteStartElement("ListOfBooks");      // <ListOfBooks>
xmlWriter.WriteComment("Şərh sətri.");
xmlWriter.WriteEndElement();                     // </ListOfBooks>

xmlWriter.Close();

// Delay.
Console.ReadKey();