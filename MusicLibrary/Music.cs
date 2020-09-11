using System;

namespace MusicLibrary
{
    public static class Music
    {
        public static int Bpm = 120;
        public static double Bps => (double) Bpm / 60;
        public static void PlayNote(int frequency, int duration) { Console.Beep(frequency, duration); }
    }
}