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

        // A utility function for converting between different time units
        public static int DaysFromOneDateToAnother(int startMonth, int startDay, int endMonth, int endDay)
        {
            // Check that startMonth is before endMonth
            if (startMonth > endMonth)
            {
                return -1;
            }
            int[] daysInMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int days = 0;
            // Add days in start month
            for (int i = startMonth; i < daysInMonths.Length; i++)
            {
                days += daysInMonths[i];
            }
            // Subtract days in end month
            for (int i = endMonth; i < daysInMonths.Length; i++)
            {
                days -= daysInMonths[i];
            }
            // Add remaining days
            days += endDay - startDay;
            return days;
        }
    }
}
