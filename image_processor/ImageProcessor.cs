using System;
using System.Drawing;
using System.IO;
using System.Threading;

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
        foreach (String filename in filenames)
        {
            Thread t = new Thread(()=>InvImg(filename));
            t.Start();
        }
    }

    /// <summary>
    /// Threadable function to invert the image
    /// </summary>
    /// <param name="filename">Filename of image to invert</param>
    private static void InvImg(string filename)
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

        for (int i = 0; i < rgbValues.Length; i++)
            rgbValues[i] = (byte)(255 - rgbValues[i]);

        System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, p, bytes);

        bm.UnlockBits(bmData);
        
        bm.Save($"{name}_inverse{extension}");
    }

    public static void Grayscale(string[] filenames)
    {

    }
}