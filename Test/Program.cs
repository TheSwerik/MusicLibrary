using System;
using System.Collections.Generic;
using MusicLibrary;

namespace Music
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            var songs = new List<Action> {AlleMeineEntchen, AlleMeineEntchen};
            var input = '@';
            while (input != '0')
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("Select a Song:");
                Console.WriteLine("[0]\tQuit");
                for (var i = 0; i < songs.Count; i++)
                    Console.WriteLine($"[{i + 1}]\t{songs[i].Method.Name}");

                input = Console.ReadKey().KeyChar;
                var intInput = input - '0';
                if (intInput <= 0 || intInput > songs.Count) continue;

                Console.WriteLine("\nNow Playing: {0}", songs[intInput - 1].Method.Name);
                songs[intInput - 1].Invoke();
            }
        }

        private static void AlleMeineEntchen()
        {
            MusicLibrary.Music.Bpm = 180;
            MusicLibrary.Music.PlayNote(Note.C, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.E, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.F, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Full);
            MusicLibrary.Music.PlayNote(Note.A, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Full);
            MusicLibrary.Music.PlayNote(Note.F, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.F, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.F, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.F, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.E, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.E, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.C, Duration.Quarter);
        }
    }
}