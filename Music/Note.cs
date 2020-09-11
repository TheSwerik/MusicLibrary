using System;

namespace Music
{
    public static class NoteMethods
    {
        private const double Step = 1.0 / 12.0;
        public static double A4Frequency = 440;

        public static double Frequency(this Note note, int octave = 4)
        {
            if (octave < 0 && octave > 12) throw new ArgumentException("Octave has to be between 0 and 12");
            return A4Frequency * Math.Pow(2, ((int) note + 12 * (octave - 4)) * Step);
        }
    }

    public enum Note
    {
        C = -9,
        Cs = -8,
        Db = Cs,
        D = -7,
        Ds = -6,
        Eb = Ds,
        E = -5,
        F = -4,
        Fs = -3,
        Gb = Fs,
        G = -2,
        Gs = -1,
        Ab = Gs,
        A = 0,
        As = 1,
        Bb = As,
        B = 2,
        H = B
    }
}