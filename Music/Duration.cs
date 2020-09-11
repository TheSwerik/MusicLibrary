namespace Music
{
    public static class Duration
    {
        public static double Quarter => 1000 / Player.Bps;
        public static double Half => Quarter * 2;
        public static double Full => Half * 2;
        public static double Eighth => Quarter / 2;
        public static double Sixteenth => Eighth / 2;
        public static double Demisemiquaver => Sixteenth / 4;
    }
}