using System;
using System.Collections.Generic;

namespace Test
{
    internal static class Program
    {
        private static int _loopCount;

        internal static void Main(string[] args)
        {
            var songs = new List<Action> {LoopSettings, Song.AlleMeineEntchen, Song.MarcoBros};
            while (true)
            {
                ClearConsole();
                Console.WriteLine("Select a Song:");
                Console.WriteLine("[0]\tQuit");
                for (var i = 0; i < songs.Count; i++)
                    Console.WriteLine($"[{i + 1}]\t{songs[i].Method.Name}");
                Console.WriteLine();

                var input = Console.ReadKey().KeyChar - '0';
                ClearLine();

                if (input == 0) Environment.Exit(0);
                if (input <= 0 || input > songs.Count) continue;

                if (_loopCount <= 1)
                {
                    Console.Write("Now Playing: {0}", songs[input - 1].Method.Name);
                    songs[input - 1].Invoke();
                }
                else
                {
                    for (var i = 0; i < _loopCount; i++)
                    {
                        if (input == 1 && i > 0) return;
                        ClearLine();
                        Console.Write("Now Playing: {0}\tIteration: {1}", songs[input - 1].Method.Name, i + 1);
                        songs[input - 1].Invoke();
                    }
                }
            }
        }

        private static void LoopSettings()
        {
            while (true)
            {
                ClearConsole();
                Console.WriteLine("Loop? [y/n]");
                var input = Console.ReadKey().KeyChar;
                if (input != 'y' && input != 'n') continue;
                if (input == 'n') return;

                Console.WriteLine("\rHow Often? [0 = infinitely]");
                _loopCount = Console.ReadKey().KeyChar - '0';
                if (_loopCount == 0) _loopCount = int.MaxValue;
                if (_loopCount > 0) return;

                if (_loopCount < 0) _loopCount = 0;
            }
        }

        private static void ClearConsole()
        {
            for (var i = 0; i < 100; i++)
            {
                ClearLine();
                Console.SetCursorPosition(0, i);
            }

            Console.SetCursorPosition(0, 0);
        }

        private static void ClearLine() { Console.Write($"\r{new string(' ', Console.BufferWidth - 1)}\r"); }
    }
}