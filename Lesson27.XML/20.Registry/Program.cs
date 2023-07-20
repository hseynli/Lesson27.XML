using Microsoft.Win32;

#pragma warning disable CA1416 // Validate platform compatibility
// Lazım olan yerə yönəlirik və onu edit etmək üçün təyin edirik.
RegistryKey key = Registry.CurrentUser;
RegistryKey subKey = key.OpenSubKey("Software", true);
RegistryKey subSubKey = subKey.CreateSubKey("TechEvo");

// Reyestrə məlumat yazmağa başlayırıq.
subSubKey.SetValue("TheStringName", "I contain string value.");
subSubKey.SetValue("TheInt32Name", 1234567890);

// Tipi birbaşa olaraq təyin etmək olar.
subSubKey.SetValue("AnotherName", 1234567890, RegistryValueKind.String);

subKey.Close();
subSubKey.Close();
#pragma warning restore CA1416 // Validate platform compatibility

// Delay.
Console.ReadKey();