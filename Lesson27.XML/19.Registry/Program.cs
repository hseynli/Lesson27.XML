using Microsoft.Win32;

Console.OutputEncoding = System.Text.Encoding.UTF8;

RegistryKey myKey = Registry.CurrentUser;

// Silmək üçün edit olunma səlahiyyəti olmalıdır.
RegistryKey wKey = myKey.OpenSubKey("Software", true);

// Ekrana bütün açarların adlarını çıxarırıq.
string[] keyNames = wKey.GetSubKeyNames();

foreach (string name in keyNames)
{
    if (name == "TechEvo")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(new string(' ', 5) + name);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
        Console.WriteLine(new string(' ', 5) + name);
}

// Burada həmin açarı silməyə cəhd edirik.
try
{
    Console.WriteLine("{0}-da ümumi yazı sayı: {1}.", wKey.Name, wKey.SubKeyCount);
#pragma warning disable CA1416 // Validate platform compatibility
    wKey.DeleteSubKey("TechEvo");
#pragma warning restore CA1416 // Validate platform compatibility

    Console.WriteLine("\'TechEvo\' yazısı reyestrdən uğurla silindi!");
    Console.WriteLine("İndi yazı sayı {0} oldu.", wKey.SubKeyCount);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
#pragma warning disable CA1416 // Validate platform compatibility
    wKey.Close();
#pragma warning restore CA1416 // Validate platform compatibility
}

// Delay.
Console.ReadKey();