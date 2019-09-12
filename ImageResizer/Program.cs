using System;
using System.Diagnostics;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = Path.Combine(Environment.CurrentDirectory, "images");
            string destinationPath = Path.Combine(Environment.CurrentDirectory, "output"); ;

            ImageProcess imageProcess = new ImageProcess();

            imageProcess.Clean(destinationPath);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            imageProcess.Pr_ResizeImages(sourcePath, destinationPath, 2.0);
            sw.Stop();
            Console.WriteLine($"原本，執行花費時間: {sw.ElapsedMilliseconds} ms");

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            imageProcess.ResizeImages(sourcePath, destinationPath, 2.0);
            sw2.Stop();
            Console.WriteLine($"後來，執行花費時間: {sw2.ElapsedMilliseconds} ms");

            Console.ReadKey();
        }
    }
}
