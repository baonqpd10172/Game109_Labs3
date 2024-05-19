using System;
using System.IO;


    public class Program
    {
        static void Main(string[] args)
        {
        string username = "1";
        string password = "123";
        string time = " 1/10/2000";
        var sw = new StringWriter();
        sw.WriteLine("UserName:" + username);
        sw.WriteLine("Password:" + password);
        var content = sw.ToString();

        var sr = new StringReader(content);
        string line1 = sr.ReadLine();
        Console.WriteLine("Line 1: " + line1);
        string line2 = sr.ReadLine();
        Console.WriteLine("Line 2: "+ line2);

        string line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        Console.ReadLine();
        }
    }

