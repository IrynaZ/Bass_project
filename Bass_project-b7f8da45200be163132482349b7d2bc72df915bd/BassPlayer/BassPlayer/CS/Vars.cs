using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public static class Vars
    {
        public static List<string> Files = new List<string>();
        public static int CurrentTrackNumber;

        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }

        public static bool FileAlreadyExistsInFiles(string file)
        {
            foreach (string f in Files)
            {
                if (f == file)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool FileIsMP3(string file)
        {
            string fileName = GetFileName(file);
            string[] tmp = fileName.Split('.');
            string extension = tmp[tmp.Length - 1];
            if (extension == "mp3")
            {
                return true;
            }
            return false;
        }
    }
}
