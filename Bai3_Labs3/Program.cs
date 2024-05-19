using System;
using System.IO;


    public class Program
    {
        static void create(string path)
    {
        Directory.CreateDirectory(path);

        string filePath = Path.Combine(path, "data.txt");
        StreamWriter streamWriter = new StreamWriter(filePath);
        streamWriter.WriteLine("Mssv: Pd10172");
        streamWriter.WriteLine("Ho Va Ten: Nguyen Quoc Bao");
    }
    static void copy(string sourcePath, string destinationPath)
    {
        if(Directory.Exists(destinationPath) == false)
        {
            Directory.CreateDirectory(destinationPath);

            string[] fileList = Directory.GetFiles(sourcePath);
            foreach (string file in fileList)
            {
                string fileName = Path.GetFileName(file); 
                string destFile = Path.Combine(destinationPath, fileName);
                File.Copy(file, destFile, true);
            }
        }
    }
    static void Main(string[] args)
    {
        string path1 = "data";
        string path2 = "data";
        create(path1);
        copy(path1, path2);
    }
    }

