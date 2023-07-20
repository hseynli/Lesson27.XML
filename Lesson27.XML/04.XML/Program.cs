using System.Xml;

var document = new XmlDocument();
document.Load("books.xml");

XmlNode root = document.DocumentElement;

// Nəticə "document.DocumentElement=ListOfBooks"
Console.WriteLine("document.DocumentElement = {0}\n", root.LocalName);

foreach (XmlNode books in root.ChildNodes)
{
    Console.WriteLine("Found Book:");
    foreach (XmlNode book in books.ChildNodes)
    {
        Console.WriteLine(book.Name + ": " + book.InnerText);
    }
    Console.WriteLine(new string('-', 40));
}

// Delay.
Console.ReadKey();