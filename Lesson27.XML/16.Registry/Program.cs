using Microsoft.Win32;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Registry - əməliyyat sistemində mövcüd olan reyesterlərə müraciət etmək üçün yaradılan klasdır.
// RegistryKey - alt açarları baxmaq, yenisini yaratmaq və redaktə etmək üçün yaradılan klasır.

RegistryKey[] keys = new RegistryKey[] { Registry.ClassesRoot,
                                                     Registry.CurrentUser,
                                                     Registry.LocalMachine,
                                                     Registry.Users,
                                                     Registry.CurrentConfig,
                                                     Registry.PerformanceData
												   };

foreach (RegistryKey key in keys)
    Console.WriteLine("{0} - cəmi elementlərin sayı: {1}.", key.Name, key.SubKeyCount);

// Delay.
Console.ReadKey();