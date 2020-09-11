using System;
using System.Threading;

namespace MusicLibrary
{
    public static class Music
    {
        public static int Bpm = 120;
        public static double Bps => (double) Bpm / 60;

        #region Pause

        public static void Pause(int duration) { Thread.Sleep(duration); }
        public static void Pause(double duration) { Thread.Sleep((int) Math.Round(duration)); }

        #endregion

        #region PlayNote

        public static void PlayNote(int frequency, int duration) { Console.Beep(frequency, duration); }

        public static void PlayNote(double frequency, int duration) { PlayNote((int) Math.Round(frequency), duration); }

        public static void PlayNote(int frequency, double duration) { PlayNote(frequency, (int) Math.Round(duration)); }

        public static void PlayNote(double frequency, double duration)
        {
            PlayNote((int) Math.Round(frequency), (int) Math.Round(duration));
        }

        public static void PlayNote(Note note, double duration)
        {
            PlayNote((int) Math.Round(note.Frequency()), (int) Math.Round(duration));
        }

        public static void PlayNote(Note note, int duration) { PlayNote((int) Math.Round(note.Frequency()), duration); }

        #endregion
    }
}