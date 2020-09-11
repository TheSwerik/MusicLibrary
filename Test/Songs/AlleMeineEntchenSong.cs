using Music;

namespace Test.Songs
{
    internal static class AlleMeineEntchenSong
    {
        internal static void Song()
        {
            Player.Bpm = 180;
            Player.PlayNote(Note.C, Duration.Quarter);
            Player.PlayNote(Note.D, Duration.Quarter);
            Player.PlayNote(Note.E, Duration.Quarter);
            Player.PlayNote(Note.F, Duration.Quarter);
            Player.PlayNote(Note.G, Duration.Quarter);
            Player.Pause(Duration.Quarter);
            Player.PlayNote(Note.G, Duration.Quarter);
            Player.Pause(Duration.Quarter);
            Player.PlayNote(Note.A, Duration.Quarter);
            Player.PlayNote(Note.A, Duration.Quarter);
            Player.PlayNote(Note.A, Duration.Quarter);
            Player.PlayNote(Note.A, Duration.Quarter);
            Player.PlayNote(Note.G, Duration.Quarter);
            Player.Pause(Duration.Full);
            Player.PlayNote(Note.A, Duration.Quarter);
            Player.PlayNote(Note.A, Duration.Quarter);
            Player.PlayNote(Note.A, Duration.Quarter);
            Player.PlayNote(Note.A, Duration.Quarter);
            Player.PlayNote(Note.G, Duration.Quarter);
            Player.Pause(Duration.Full);
            Player.PlayNote(Note.F, Duration.Quarter);
            Player.PlayNote(Note.F, Duration.Quarter);
            Player.PlayNote(Note.F, Duration.Quarter);
            Player.PlayNote(Note.F, Duration.Quarter);
            Player.PlayNote(Note.E, Duration.Quarter);
            Player.Pause(Duration.Quarter);
            Player.PlayNote(Note.E, Duration.Quarter);
            Player.Pause(Duration.Quarter);
            Player.PlayNote(Note.D, Duration.Quarter);
            Player.PlayNote(Note.D, Duration.Quarter);
            Player.PlayNote(Note.D, Duration.Quarter);
            Player.PlayNote(Note.D, Duration.Quarter);
            Player.PlayNote(Note.C, Duration.Quarter);
        }
    }
}