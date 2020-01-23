using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class ImageFlipper
    {
        //static void Main(string[] args)
        //{
        //    string[] files = Directory.GetFiles(@"/Users/maciej_kuchar/myPictures", "*.jpg");
        //    string newDir = @"/Users/maciej_kuchar/modifiedMyPictures";
        //    Directory.CreateDirectory(newDir);

        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();

        //    foreach (var f in files)
        //    {
        //        string filename = Path.GetFileName(f);
        //        var bitmap = new Bitmap(f);

        //        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
        //        bitmap.Save(Path.Combine(newDir, filename));
        //        Console.WriteLine($"przetwarzam {f}");
        //    }
        //    stopwatch.Stop();
        //    Console.WriteLine("czas " + stopwatch.ElapsedMilliseconds + "ms");
        //}
    }
}
