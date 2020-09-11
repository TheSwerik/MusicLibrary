using MusicLibrary;

namespace Music
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            MusicLibrary.Music.PlayNote(Note.C2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.D2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.E2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.F2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G2, Duration.Quarter);
            MusicLibrary.Music.PlayNote(Note.G2, Duration.Quarter);
        }
    }
}