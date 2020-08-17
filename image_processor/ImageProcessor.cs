﻿using System;
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
        
        for (int i = 0; i < bm.Height; i++)
        {
            for (int j = 0; j < bm.Width; j++)
            {
                Color og = bm.GetPixel(j, i);
                bm.SetPixel(j, i, Color.FromArgb(255 - og.R, 255 - og.G, 255 - og.B));
            }
        }

        bm.Save($"{name}_inverse{extension}");
    }
}