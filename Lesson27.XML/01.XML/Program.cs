using System.Xml;

// QEYD: book.xml faylının Properties hissəsində
// Copy to Output Directory xassəsində Copy always dəyərini seçin.
// Belə olduqda book.xml faylı *.exe faylı olan qovluğa həmişə kopyalanacaqdır.

// XML sənədin yüklənməsi.
XmlDocument document = new XmlDocument();
document.Load("books.xml");

// XML-in tərkini ekrana çıxarmaq.
Console.WriteLine(document.InnerText);

Console.WriteLine(new string('-', 20));

// XML sənədin kodunun ekrana çıxarılması.
Console.WriteLine(document.InnerXml);

// Delay.
Console.ReadKey();