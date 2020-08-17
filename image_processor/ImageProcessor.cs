using System;
using System.Drawing;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (String filename in filenames)
        {
            Bitmap bm = new Bitmap(filename);
            
            for (int i = 0; i < bm.Height; i++)
            {
                for (int j = 0; j < bm.Width; j++)
                {
                    Color og = bm.GetPixel(j, i);
                    bm.SetPixel(j, i, Color.FromArgb(255 - og.R, 255 - og.G, 255 - og.B));
                }
            }

            bm.Save("foo.jpg");
        }
    }
}