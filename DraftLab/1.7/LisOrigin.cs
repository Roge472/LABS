using System;

namespace DraftLab.LisOrigin
{
    public abstract class FileService
    {
        public int Id { get; set; }

        public abstract void Cache();
        public abstract void Download();
        public abstract void Upload();
    }

    public class BlobStorage : FileService
    {
        public override void Cache()
        {
            Console.WriteLine("Do cache.");
        }

        public override void Download()
        {
            Console.WriteLine("Do download.");
        }

        public override void Upload()
        {
            Console.WriteLine("Do upload.");
        }
    }

    public class StreamingService : BlobStorage
    {
        public override void Cache()
        {
            base.Cache();
            Console.WriteLine("Chache stream data.");
        }

        public override void Download()
        {
            base.Download();
            Console.WriteLine("Chache stream data.");
        }

        public override void Upload()
        {
            throw new NotImplementedException("Streaming service doesn't have this realisation.");
        }
    }
}
