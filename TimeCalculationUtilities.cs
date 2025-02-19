namespace ProgramOne
{
    // A utility class for converting between different time units
    public static class TimeCalculationUtilities
    {
        // Convert minutes to hours (example: 90 minutes = 1.5 hours)
        public static double MinutesAsHours(int minutes)
        {
            // Divide by 60.0 (decimal) to get fractional hours
            return minutes / 60.0;
        }

        // Convert hours to minutes (example: 1.5 hours = 90 minutes)
        public static int HoursAsMinutes(double hours)
        {
            // Multiply by 60 to get minutes, (int) converts to whole number
            return (int)(hours * 60);
        }
    }
}
