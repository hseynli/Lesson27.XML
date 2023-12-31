﻿using System.Collections.Specialized;
using System.Configuration;

// 1 (Köhnəlib)
string value = ConfigurationSettings.AppSettings["Foo"];
Console.WriteLine(value);
Console.WriteLine(new string('-', 12));

// 2
NameValueCollection appSettings = ConfigurationManager.AppSettings;

Console.WriteLine(appSettings["Foo"]);
Console.WriteLine(appSettings[0]);

Console.WriteLine(new string('-', 12));

// 3
for (int i = 0; i < appSettings.Count; i++)
{
    Console.WriteLine(appSettings[i]);
}

Console.WriteLine(new string('-', 12));

// 4
foreach (string item in appSettings)
{
    Console.WriteLine(appSettings[item]);
}

// Delay.
Console.ReadKey();