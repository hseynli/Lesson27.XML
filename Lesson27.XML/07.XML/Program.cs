using System.Xml;

XmlTextWriter xmlWriter = new XmlTextWriter("books.xml", null);

xmlWriter.WriteStartDocument();                  // Başlıq XML - <?xml version="1.0"?>
xmlWriter.WriteStartElement("ListOfBooks");      // Köl element - <ListOfBooks>
xmlWriter.WriteStartElement("Book");             // Kitab 1 - <Book
xmlWriter.WriteStartAttribute("FontSize");       // Atribut - FontSize
xmlWriter.WriteString("8");                      // ="8"
xmlWriter.WriteEndAttribute();                   // >
xmlWriter.WriteString("Title-1");                // Title-1
xmlWriter.WriteEndElement();                     // </Book>
xmlWriter.WriteEndElement();                     // </ListOfBooks>

xmlWriter.Close();

// Delay.
Console.ReadKey();