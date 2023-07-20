using System.Collections;
using System.Collections.Specialized;
using System.Configuration;

NameValueCollection allAppSettings = ConfigurationManager.AppSettings;
Int32 counter = 0;
IEnumerator settingEnumerator = allAppSettings.Keys.GetEnumerator();

while (settingEnumerator.MoveNext())
{
    Console.WriteLine("Key: {0}  Value: {1}", allAppSettings.Keys[counter], allAppSettings[counter]);
    counter++;
}

// Delay.
Console.ReadKey();