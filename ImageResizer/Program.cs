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

            decimal test1 = 0;
            decimal test2 = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            imageProcess.Pr_ResizeImages(sourcePath, destinationPath, 2.0);
            sw.Stop();
            test1 = sw.ElapsedMilliseconds;
            Console.WriteLine($"原本，執行花費時間: {test1} ms");

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            imageProcess.ResizeImages(sourcePath, destinationPath, 2.0);
            sw2.Stop();
            test2 = sw2.ElapsedMilliseconds;
            Console.WriteLine($"後來，執行花費時間: {test2} ms");

            decimal rtp = Math.Round((test2 / test1) * 100, 2);

            Console.WriteLine($"時間減少百分比: {rtp}");

            Console.ReadKey();
        }
    }
}
