using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Tiktok_Nurlybek
{
    static class TikTokManager
    {
        //FIELDS//

        private static List<TikTok> TIKTOKS;

        private static string Filename;

        //CONSTRUCTOR//

        static TikTokManager()
        {
            TIKTOKS = new List<TikTok>();

            TextReader reader = new StreamReader(Filename);

            string line0 = reader.ReadLine();
            while(line0 != null)
            {
                line0 = reader.ReadLine();
                TikTok.Parse(line0);
              
            }
            reader.Close();
        }

        //METHODS//

        public static void Initialize()
        {

        }
        public static void Show()
        {

        }
        public static void Show(string hashtag)
        {

        }
        public static void Show(int length)
        {

        }
        public static void Show(Audience audience)
        {

        }
    }
}
