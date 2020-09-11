using Music;

namespace Test.Songs
{
    internal static class MarcoBrosSong
    {
        private static int _octaveShift = 1;

        internal static void Song()
        {
            Player.Bpm = 180;

            for (var i = 0; i < 3; i++) BassLine1();
            BassLine1Short();

            for (var j = 0; j < 2; j++)
            {
                for (var i = 0; i < 2; i++) Melody1();
                Melody1_1();
                for (var i = 0; i < 2; i++) Melody1();
                Melody1_2();

                for (var i = 0; i < 2; i++) Melody1();
                Melody1_1();
                for (var i = 0; i < 2; i++) Melody1();
                Melody1_3();

                _octaveShift++;
            }

            _octaveShift -= 2;

            for (var j = 0; j < 2; j++)
            {
                Melody2();
                Melody2(2);
                Melody2(4);
                Melody2(2);

                _octaveShift++;
            }

            _octaveShift -= 2;

            for (var i = 0; i < 6; i++) BassLine2();
        }

        #region Melody2

        private static void Melody2(int noteShift = 0)
        {
            var d = Note.D - noteShift;
            var g = Note.G - noteShift;
            var localOctaveShift = 0;
            if ((int) d == -11)
            {
                localOctaveShift = 1;
                d = Note.As;
            }

            Player.PlayNote(d.Frequency(3 + _octaveShift - localOctaveShift), Duration.Eighth);
            Player.Pause(Duration.Eighth);
            Player.PlayNote(d.Frequency(3 + _octaveShift - localOctaveShift), Duration.Eighth);
            Player.Pause(Duration.Eighth);
            Player.PlayNote(d.Frequency(3 + _octaveShift - localOctaveShift), Duration.Eighth);
            Player.Pause(Duration.Eighth);
            Player.PlayNote(g.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(d.Frequency(3 + _octaveShift - localOctaveShift), Duration.Eighth);
            Player.Pause(Duration.Eighth);
            Player.PlayNote(d.Frequency(3 + _octaveShift - localOctaveShift), Duration.Eighth);
            Player.Pause(Duration.Eighth);
            Player.PlayNote(d.Frequency(3 + _octaveShift - localOctaveShift), Duration.Eighth);
            Player.PlayNote(g.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(d.Frequency(3 + _octaveShift - localOctaveShift), Duration.Eighth);
            Player.PlayNote(g.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(d.Frequency(3 + _octaveShift - localOctaveShift), Duration.Eighth);
        }

        #endregion

        #region BassLine2

        private static void BassLine2()
        {
            Player.PlayNote(Note.G.Frequency(1 + _octaveShift), Duration.Quarter);
            Player.PlayNote(Note.D.Frequency(1 + _octaveShift), Duration.Quarter);
        }

        #endregion

        #region BassLine1

        private static void BassLine1()
        {
            Player.PlayNote(Note.G.Frequency(1 + _octaveShift), Duration.Quarter);
            Player.PlayNote(Note.D.Frequency(1 + _octaveShift), Duration.Quarter);
            Player.PlayNote(Note.A.Frequency(1 + _octaveShift), Duration.Quarter);
            Player.PlayNote(Note.E.Frequency(1 + _octaveShift), Duration.Quarter);
        }

        private static void BassLine1Short()
        {
            Player.PlayNote(Note.G.Frequency(1 + _octaveShift), Duration.Quarter);
            Player.PlayNote(Note.D.Frequency(1 + _octaveShift), Duration.Quarter);
            Player.PlayNote(Note.A.Frequency(1 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.E.Frequency(1 + _octaveShift), Duration.Half);
        }

        #endregion

        #region Melody1

        private static void Melody1()
        {
            Player.PlayNote(Note.A.Frequency(2 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.D.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.Pause(Duration.Eighth);
        }

        private static void Melody1_1()
        {
            Player.PlayNote(Note.A.Frequency(2 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.D.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.G.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.F.Frequency(3 + _octaveShift), Duration.Quarter);
            Player.Pause(Duration.Quarter);
        }

        private static void Melody1_2()
        {
            Player.PlayNote(Note.A.Frequency(2 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.D.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.A.Frequency(2 + _octaveShift), Duration.Quarter);
            Player.Pause(Duration.Quarter);
        }

        private static void Melody1_3()
        {
            Player.PlayNote(Note.A.Frequency(2 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.D.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.C.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.F.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.D.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.PlayNote(Note.D.Frequency(3 + _octaveShift), Duration.Eighth);
            Player.Pause(Duration.Eighth);
        }

        #endregion
    }
}