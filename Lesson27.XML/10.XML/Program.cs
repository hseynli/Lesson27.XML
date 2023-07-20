using System.Xml;

XmlTextWriter xmlWriter = new XmlTextWriter("books.xml", null);

// Sənədi format etmək (boşluqlar ilə).
xmlWriter.Formatting = Formatting.Indented;

// Elementləri ayırmaq üçün tabulyasiyadan istifadə etmək.
xmlWriter.IndentChar = '\t';

// Tabulyasiya üçün bir simvoldan istifadə etmək.
xmlWriter.Indentation = 1;

// Analoji olaraq format etmək üçün 4 boşluqda istifadə etmək olar.
//xmlWriter.IndentChar = ' ';
//xmlWriter.Indentation = 4;

// Default olaraq Xml fayllarda sətirlər " ilə işarələnir
// ' ilə bu şəkildə qeyd etmək olar:
xmlWriter.QuoteChar = '\'';

xmlWriter.WriteStartDocument();

xmlWriter.WriteStartElement("ListOfBooks");
xmlWriter.WriteStartElement("ListOfBooks", "http://localhost/test");
xmlWriter.WriteStartElement("prefix", "ListOfBooks", "http://localhost/test");

xmlWriter.Close();

// Delay.
Console.ReadKey();