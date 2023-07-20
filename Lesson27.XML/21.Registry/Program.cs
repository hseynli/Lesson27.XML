using Microsoft.Win32;

// Reyestrdə lazım olan yerə gedirik və ancaq oxumaq üçün açırıq,
// Reyestrdə yolu birbaşa olaraq qeyd etmək olar.
RegistryKey key = Registry.CurrentUser;
RegistryKey subKey = key.OpenSubKey(@"Software\TechEvo");

// Məlumatları oxuyuruq və lazım olan tipə çevirik.
string value1 = subKey.GetValue("TheStringName") as string;
int value2 = Convert.ToInt32(subKey.GetValue("TheInt32Name"));
int value3 = Convert.ToInt32(subKey.GetValue("AnotherName"));

subKey.Close();

// Oxunmanın uğurlu olduğunu yoxlamaq üçün əldə olunan məlumatları ekranda çıxarırıq.
Console.WriteLine("String: {0}\nInt32: {1}\nAnother: {2}", value1, value2, value3);

// Задержка.
Console.ReadKey();