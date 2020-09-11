using System;
using System.Collections.Generic;

namespace Test
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            Song.MarcoBros();
            Environment.Exit(0);

            var songs = new List<Action> {Song.AlleMeineEntchen, Song.MarcoBros};
            while (true)
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("Select a Song:");
                Console.WriteLine("[0]\tQuit");
                for (var i = 0; i < songs.Count; i++)
                    Console.WriteLine($"[{i + 1}]\t{songs[i].Method.Name}");
                Console.WriteLine();

                var input = Console.ReadKey().KeyChar - '0';
                Console.Write("\r      \r");

                if (input == 0) Environment.Exit(0);
                if (input <= 0 || input > songs.Count) continue;

                Console.WriteLine("Now Playing: {0}", songs[input - 1].Method.Name);
                songs[input - 1].Invoke();
            }
        }
    }
}