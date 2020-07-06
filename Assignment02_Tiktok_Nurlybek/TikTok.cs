using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Tiktok_Nurlybek
{

    enum Audience { World, Group, Special }
    class TikTok
    {
        //FIELDS//
        private static int _ID;

        //PROPERTIES//
        public string Originator { get; }
        public int Length { get; }
        public string HashTag { get; }
        public Audience Audience { get; }
        public string Id { get; }

        //CONSTRUCTORS//

        public TikTok(string originator, int length, string hashTag, Audience audience)
        {
           
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;

        }

        private TikTok(string id, string originator, int length, string hashTag, Audience audience)
        {
            Id = id;
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
        }

        public override string ToString()
        {
            return "";
        }

        public static TikTok Parse(string line)
        {
           line.Split('\t');
        }
    }
}
