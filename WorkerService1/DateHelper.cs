using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1;
/// <summary>
/// A helper class for date operations.
/// </summary>
public static class DateHelper
{
    /// <summary>
    /// Converts the provided date string from UTC to a specific timezone format.
    /// </summary>
    /// <param name="inputDate">The input date string in UTC. Should be in ISO 8601 format (yyyy-MM-ddTHH:mm:ssZ).</param>
    /// <param name="timeZoneOffset">The timezone offset from UTC. A positive value means ahead of UTC, a negative value means behind UTC.</param>
    /// <returns>The converted date string in "yyyy-MM-ddTHH:mmzzz" format.</returns>
    public static string ConvertDateFormat(string inputDate, int timeZoneOffset)
    {
        // Parse the input string to a DateTimeOffset object.
        // DateTimeOffset represents a point in time, typically expressed as a date and time of day, relative to Coordinated Universal Time (UTC).
        DateTimeOffset dto = DateTimeOffset.Parse(inputDate);

        // Convert the DateTimeOffset to the specified timezone.
        // The ToOffset method returns a DateTimeOffset value that represents the same point in time as the original DateTimeOffset, 
        // but is offset from Coordinated Universal Time (UTC) by the specified amount.
        dto = dto.ToOffset(TimeSpan.FromHours(timeZoneOffset));

        // Format the date string according to the requested format and return it.
        return dto.ToString("yyyy-MM-ddTHH:mmzzz");
    }
}
