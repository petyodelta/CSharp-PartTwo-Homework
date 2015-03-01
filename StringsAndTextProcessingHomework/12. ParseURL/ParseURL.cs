//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;

class ParseURL
{
    static void Main()
    {
        Console.Write("Enter url: ");
        string url = Console.ReadLine();

        int indexProtokol = url.IndexOf(':');
        string protokol = url.Substring(0, indexProtokol);

        int indexServer = url.IndexOf('/', indexProtokol + 3);
        string server = url.Substring(indexProtokol + 3, 
                                      indexServer - indexProtokol - 3);

        string resource = url.Substring(indexServer);

        Console.WriteLine("[protocol] = {0}", protokol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}

