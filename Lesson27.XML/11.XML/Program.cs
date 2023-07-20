using System.Xml.XPath;

// XPath sənədinin oxunması.
XPathDocument document = new XPathDocument("books.xml");
XPathNavigator navigator = document.CreateNavigator();

// XPath ilə birbaşa sorğu.
XPathNodeIterator iterator1 = navigator.Select("ListOfBooks/Book/Title");

foreach (var item in iterator1)
    Console.WriteLine(item);

Console.WriteLine(new string('-', 20));

// XPath sorğusunu kompayl etmək
XPathExpression expr = navigator.Compile("ListOfBooks/Book[2]/Price");
XPathNodeIterator iterator2 = navigator.Select(expr);

foreach (var item in iterator2)
    Console.WriteLine(item);

// Delay.
Console.ReadKey();