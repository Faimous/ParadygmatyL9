using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class ImageFlipperParallel
    {
        public ImageFlipperParallel()
        {       
        }

        //static void Main(string[] args)
        //{
        //    string[] files = Directory.GetFiles(@"/Users/maciej_kuchar/myPictures", "*.jpg");
        //    string newDir = @"/Users/maciej_kuchar/modifiedMyPictures";
        //    Directory.CreateDirectory(newDir);

        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();

        //    Parallel.ForEach(files, (currentFile) =>
        //    {
        //        string filename = Path.GetFileName(currentFile);
        //        var bitmap = new Bitmap(currentFile);

        //        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
        //        bitmap.Save(Path.Combine(newDir, filename));

        //        Console.WriteLine($"Processing {filename} na watku {Thread.CurrentThread.ManagedThreadId}");
        //    });

        //    stopwatch.Stop();
        //    Console.WriteLine("czas " + stopwatch.ElapsedMilliseconds + "ms");
        //}
    }
}
