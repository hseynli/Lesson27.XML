using System.Xml.XPath;

double sum = 0;

// XPath sənədinin yaradılması.
XPathDocument document = new XPathDocument("books.xml");
XPathNavigator navigator = document.CreateNavigator();

// Əvvəlcədən kompayl etməklə sorğunu icra etmək.
XPathExpression expression = navigator.Compile("sum(ListOfBooks/Book/Price/text())");

Console.WriteLine(expression.ReturnType);

if (expression.ReturnType == XPathResultType.Number)
{
    sum = (double)navigator.Evaluate(expression);
    Console.WriteLine(sum);
}

// Əvvəldəcən kompayl etmədən nəticənin cəmləməsi.
// Seçimdən əlavə riyazi əməliyyat icra olunur.
sum = (double)navigator.Evaluate("sum(//Price/text())*10");
Console.WriteLine(sum);

// Delay.
Console.ReadKey();