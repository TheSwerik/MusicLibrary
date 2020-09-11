using System;
using System.Threading;

namespace MusicLibrary
{
    public static class Music
    {
        public static int Bpm = 120;
        public static double Bps => (double) Bpm / 60;
        public static void Pause(int duration) { Thread.Sleep(duration); }
        public static void Pause(double duration) { Thread.Sleep((int) Math.Round(duration)); }
        public static void PlayNote(int frequency, int duration) { Console.Beep(frequency, duration); }
        public static void PlayNote(Note frequency, int duration) { Console.Beep((int) frequency, duration); }

        public static void PlayNote(int frequency, double duration)
        {
            Console.Beep(frequency, (int) Math.Round(duration));
        }

        public static void PlayNote(Note frequency, double duration)
        {
            Console.Beep((int) frequency, (int) Math.Round(duration));
        }
    }
}