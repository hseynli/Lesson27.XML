using System.Xml.XPath;
using System.Xml;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// XPath sənədinin yaradılması.
XPathDocument document = new XPathDocument("books.xml");

// XPathDocument-in yeganə məqsədi naviqatorun yaradılmasıdır.
XPathNavigator navigator = document.CreateNavigator();

// XPathDocument ilə naviqator yaradanda ancaq sənəd ancaq readonly olacaqdır.
Console.WriteLine("Naviqator ancaq oxumaq üçün yaradılmışdır. Xassə CanEdit = {0}.", navigator.CanEdit);

// XmlDocument istifadə edərək naviqatoru redaktə etmək üçün də istifadə etmək olar.
XmlDocument xmldoc = new XmlDocument();
xmldoc.Load("books.xml");

navigator = xmldoc.CreateNavigator();
Console.WriteLine("Naviqator sənədi redaktə etmək üçün də imkana sahib oldur. Xassə CanEdit = {0}.", navigator.CanEdit);

// İndi XML sənədə hansısa məlumatı da yazmaq olar.
// Book noduna yönəlirik.
navigator.MoveToChild("ListOfBooks", "");
navigator.MoveToChild("Book", "");

// Məlumatları yazmağa başlayırıq.
navigator.InsertBefore("<InsertBefore>insert_before</InsertBefore>");
navigator.InsertAfter("<InsertAfter>insert_after</InsertAfter>");
navigator.AppendChild("<AppendChild>append_child</AppendChild>");

navigator.MoveToNext("Book", "");

navigator.InsertBefore("<InsertBefore>1111111111</InsertBefore>");
navigator.InsertAfter("<InsertAfter>2222222222</InsertAfter>");
navigator.AppendChild("<AppendChild>3333333333</AppendChild>");

// Dəyişiklikləri yadda saxlayırıq.
xmldoc.Save("books.xml");

// Delay.
Console.ReadKey();