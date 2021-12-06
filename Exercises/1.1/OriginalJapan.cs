using System;
using System.Collections.Generic;

namespace DraftLab.OriginalJapan
{
    public class Ninja
    {
        public string Name { get; set; }
        public DateTime AgeOfBirth { get; set; }
        public List<string> Weapons { get; set; }
        public int KilledNumber { get; set; }
    }

    public class Samurai
    {
        public string Name { get; set; }
        public DateTime AgeOfBirth { get; set; }
        public string LordName { get; set; }
        public List<string> Weapons { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
    }
}
