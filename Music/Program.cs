using MusicLibrary;

namespace Music
{
    internal static class Program
    {
        internal static void Main(string[] args) { AlleMeineEntchen(); }

        private static void AlleMeineEntchen()
        {
            MusicLibrary.Music.Bpm = 180;
            MusicLibrary.Music.PlayNote(Note.C2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.E2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.F2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G2, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G2, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G2, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Full);
            MusicLibrary.Music.PlayNote(Note.A2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.A2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G2, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Full);
            MusicLibrary.Music.PlayNote(Note.F2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.F2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.F2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.F2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.E2, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.E2, Duration.Quarter);
            MusicLibrary.Music.Pause(Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.C2, Duration.Quarter);
        }
    }
}