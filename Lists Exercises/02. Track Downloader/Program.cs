using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine()
                         .Split(' ');

            var songs = Console.ReadLine();
            var legalSongs = new List<string>();

            while (songs!="end")
            {
                var isInBannList = false;
                foreach (var bannedWord in bannedWords)
                {
                    if (songs.Contains(bannedWord))
                    {
                        isInBannList = true;
                        break;
                    }                   
                }
                if (!isInBannList)
                {
                    legalSongs.Add(songs);
                }
                songs = Console.ReadLine();
            }
            legalSongs.Sort();

            foreach (var song in legalSongs)
            {
                Console.WriteLine(song);
            }    
        }
    }
}
