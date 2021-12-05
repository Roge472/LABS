using System;
using System.IO;

namespace DraftLab.OriginalVideoService
{
    // Wrong property names
    public class VideoService
    {
        public void SaveVideo(Stream stream)
        {
            Console.WriteLine("Save video");
        }

        public void DownloadVideo(Stream stream)
        {
            Console.WriteLine("Write video");
        }
    }
}
