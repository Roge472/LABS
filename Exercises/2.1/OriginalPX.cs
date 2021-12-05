using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace DraftLab.OriginalPX
{
    // Large class
    public class OriginalPX
    {
        public string ExhibitType { get; set; }
        public string DocumentName { get; set; }
        public string AuthorName { get; set; }
        public DateTime EditTime { get; set; }
        public DateTime Created { get; set; }
        public string[] HeaderText { get; set; }
        public string[] HeaderCertificate { get; set; }
        public string[] FooterCertificate { get; set; }
        public string[] BodyText { get; set; }
        public string[] DocumentColor { get; set; }
        public List<MemoryStream>[] AttachedDocuments { get; set; }
        public string[] FooterSize { get; set; }

        public OriginalPX Decrypt(string json)
        {
            Console.WriteLine("Some long encryption algorithm for 99+ lines of code. Algorithm number 1.");
            var obj = JsonConvert.DeserializeObject<OriginalPX>(json);
            return obj;
        }

        public string Encrypt()
        {
            Console.WriteLine("Some long encryption algorithm for 99+ lines of code.  Algorithm number 2.");
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            return json;
        }
    }

    public class OriginalPZ
    {
        public string ArchiveType { get; set; }
        public string DocumentName { get; set; }
        public string AuthorName { get; set; }
        public DateTime EditTime { get; set; }
        public DateTime Created { get; set; }
        public List<OriginalPX> Exhibits { get; set; }
        public string[] HeaderText { get; set; }
        public string[] HeaderSize { get; set; }
        public string[] HeaderCertificate { get; set; }
        public string[] FooterCertificate { get; set; }
        public string[] BodyText { get; set; }
        public string[] DocumentColor { get; set; }
        public List<MemoryStream>[] AttachedDocuments { get; set; }
        public string[] FooterText { get; set; }
        public string[] FooterSize { get; set; }

        public OriginalPX Decrypt(string json)
        {
            Console.WriteLine("Some long encryption algorithm for 99+ lines of code. Algorithm number 1.");
            var obj = JsonConvert.DeserializeObject<OriginalPX>(json);
            return obj;
        }

        public string Encrypt()
        {
            Console.WriteLine("Some long encryption algorithm for 99+ lines of code.  Algorithm number 2.");
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            return json;
        }
    }
}
