using Microsoft.Win32;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// RegistryKey klasına reference-in alınması.
RegistryKey myKey = Registry.LocalMachine;
RegistryKey software = myKey.OpenSubKey("Software");
RegistryKey microsoft = software.OpenSubKey("Microsoft");

Console.WriteLine("{0} - {1} elementi var.", microsoft.Name, microsoft.SubKeyCount);

software.Close();
microsoft.Close();

// Mövcüd olmayan açarı açmağa cəhd göstərmək. software dəyişəninə NULL dəyəri mənimsədiləcəkdir.
software = myKey.OpenSubKey("NonExistName");

try
{
    // Reference-i olmayan dəyişənə müracitə etmək cəhdi.
    Console.WriteLine("Müraciət edirik: {0}.", software.Name);
}
catch (Exception e)
{
    Console.WriteLine("{0}\n{1}", e.Message, e.GetType());
}

// Delay.
Console.ReadKey();