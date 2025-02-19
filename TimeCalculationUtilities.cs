namespace ProgramOne
{
    public static class TimeCalculationUtilities
    {
        public static double MinutesAsHours(int minutes)
        {
            return minutes / 60.0;
        }

        public static int HoursAsMinutes(double hours)
        {
            return (int)(hours * 60);
        }
    }
}
