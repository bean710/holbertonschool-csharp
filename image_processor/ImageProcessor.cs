using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Class for image processing methods
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Inverts images
    /// </summary>
    /// <param name="filenames">Array of filenames of images to invert</param>
    public static void Inverse(string[] filenames)
    {
        ChangeFiles(filenames, "_inverse", (byte[] bytes) => {

            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = (byte)(255 - bytes[i]);
                
        });
    }

    public static void Grayscale(string[] filenames, double threshold)
    {
        ChangeFiles(filenames, "_bw", (byte[] bytes) => {

            Console.WriteLine($"Length: {bytes.Length} mod 3: {bytes.Length % 3}");
            for (int i = 0; i < bytes.Length - 2; i += 3)
            {
                Color c = Color.FromArgb(bytes[i], bytes[i + 1], bytes[i + 2]);
                byte val = 0;

                if (c.GetBrightness() >= threshold)
                    val = 255;

                bytes[i] = val;
                bytes[i + 1] = val;
                bytes[i + 2] = val;
            }

        });
    }

    public static void ChangeFiles(string[] filenames, string app, Action<byte[]> f)
    {
        Parallel.ForEach(filenames, (filename) => {
            Thread t = new Thread(()=>BitmapHelper(f, filename, app));

            t.Start();
        });
    }

    /// <summary>
    /// Helper function to create locked bitmaps for altering images
    /// </summary>
    /// <param name="f">Function to use to actually change the pixel array</param>
    /// <param name="filename">The name of the original image</param>
    /// <param name="app">The text to append after the file name, but before the extension</param>
    public static void BitmapHelper(Action<byte[]> f, string filename, string app)
    {
        string name = Path.GetFileNameWithoutExtension(filename);
        string extension = Path.GetExtension(filename);

        Bitmap bm = new Bitmap(filename);

        Rectangle rect = new Rectangle(0, 0, bm.Width, bm.Height);
        System.Drawing.Imaging.BitmapData bmData =
            bm.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
            bm.PixelFormat);

        IntPtr p = bmData.Scan0;

        int bytes = Math.Abs(bmData.Stride) * bm.Height;
        byte[] rgbValues = new byte[bytes];

        System.Runtime.InteropServices.Marshal.Copy(p, rgbValues, 0, bytes);

        f(rgbValues);

        System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, p, bytes);

        bm.UnlockBits(bmData);
        
        bm.Save($"{name}{app}{extension}");
    }
}