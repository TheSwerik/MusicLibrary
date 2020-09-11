using MusicLibrary;

namespace Music
{
    internal static class Program
    {
        internal static void Main(string[] args) { AlleMeineEntchen(); }

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