using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Web;


public class Program
{
    static void Main(string[] args)
    {
        string path = "data.txt";
        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("username: myUsername");
                sw.WriteLine("password: myPassword");
            }
        }
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        Console.ReadLine();
    }
}
    

