using Music;

namespace Test.Songs
{
    internal static class MarcoBrosSong
    {
        private const int OctaveShift = 1;

        internal static void Song()
        {
            Player.Bpm = 180;

            // for (var i = 0; i < 3; i++) BassLine1();
            // BassLine1Short();

            for (var i = 0; i < 2; i++) Melody1();
            Melody1_1();

            for (var i = 0; i < 2; i++) Melody1();
            Melody1_2();
        }

        #region BassLine1

        private static void BassLine1()
        {
            Player.PlayNote(Note.G.Frequency(1 + OctaveShift), Duration.Quarter);
            Player.PlayNote(Note.D.Frequency(1 + OctaveShift), Duration.Quarter);
            Player.PlayNote(Note.A.Frequency(1 + OctaveShift), Duration.Quarter);
            Player.PlayNote(Note.E.Frequency(1 + OctaveShift), Duration.Quarter);
        }

        private static void BassLine1Short()
        {
            Player.PlayNote(Note.G.Frequency(1 + OctaveShift), Duration.Quarter);
            Player.PlayNote(Note.D.Frequency(1 + OctaveShift), Duration.Quarter);
            Player.PlayNote(Note.A.Frequency(1 + OctaveShift), Duration.Eighth);
            Player.PlayNote(Note.E.Frequency(1 + OctaveShift), Duration.Half);
        }

        #endregion

        #region Melody1

        private static void Melody1()
        {
            Player.PlayNote(Note.A.Frequency(2 + OctaveShift), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(), Duration.Eighth);
            Player.PlayNote(Note.D.Frequency(), Duration.Eighth);
            Player.Pause(Duration.Eighth);
        }

        private static void Melody1_1()
        {
            Player.PlayNote(Note.A.Frequency(2 + OctaveShift), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(), Duration.Eighth);
            Player.PlayNote(Note.D.Frequency(), Duration.Eighth);
            Player.PlayNote(Note.G.Frequency(), Duration.Eighth);
            Player.PlayNote(Note.F.Frequency(), Duration.Quarter);
            Player.Pause(Duration.Quarter);
        }

        private static void Melody1_2()
        {
            Player.PlayNote(Note.A.Frequency(2 + OctaveShift), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(), Duration.Eighth);
            Player.PlayNote(Note.D.Frequency(), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(), Duration.Eighth);
            Player.PlayNote(Note.A.Frequency(2 + OctaveShift), Duration.Quarter);
            Player.Pause(Duration.Quarter);
        }

        #endregion
    }
}