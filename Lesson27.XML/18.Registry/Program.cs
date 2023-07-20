using Microsoft.Win32;

Console.OutputEncoding = System.Text.Encoding.UTF8;

RegistryKey myKey = Registry.CurrentUser;

// İkinci arqument onu göstərir ki, yeni dəyər yazıla bilər.
RegistryKey wKey = myKey.OpenSubKey("Software", true);

try
{
    Console.WriteLine("{0}-da ümumi yazı sayı: {1}.", wKey.Name, wKey.SubKeyCount);

    // Yeni açarın yazılma cəhdi.
    RegistryKey newKey = wKey.CreateSubKey("TechEvo");
    // Yazı HKEY_CURRENT_USER\Software\... ünvanına uyğun şəkildə yazıdı

    Console.WriteLine("\'{0}\' uğurla reyestrə yazıldı!", newKey.Name);
    Console.WriteLine("İndi yazı sayı {0} oldu.", wKey.SubKeyCount);
}
catch (Exception e)
{
    // Əgər xəta baş versə, onda onun haqqında məlumatı ekranda əks elətdiririk.
    Console.WriteLine(e.Message);
}
finally
{
    // Açarı mütləq bağlamaq lazımdır.
    myKey.Close();
}

// Delay.
Console.ReadKey();