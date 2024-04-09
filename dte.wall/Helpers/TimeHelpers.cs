using dte.wall.Data;

namespace dte.wall.Helpers
{
    public static class TimeHelpers
    {
        /// <summary>
        /// Timezone offset of the session
        /// </summary>
        public static readonly TimeSpan EventOffset = TimeSpan.FromHours(1);

        /// <summary>
        /// Date of the event
        /// </summary>
        public static readonly DateOnly EventDate = new(2024, 04, 18);

        /// <summary>
        /// Get start time of session as datetime offset based on event time zone
        /// </summary>
        public static DateTimeOffset GetStartOffset(this Session session)
        {
            return new DateTimeOffset(session.StartsAt, EventOffset);
        }

        /// <summary>
        /// Get end time of session as datetime offset based on event time zone
        /// </summary>
        public static DateTimeOffset GetEndOffset(this Session session)
        {
            return new DateTimeOffset(session.EndsAt, EventOffset);
        }

        /// <summary>
        /// Get end time of session as datetime offset based on event time zone
        /// </summary>
        public static DateTimeOffset GetStartOffset(this Summary summary)
        {
            return new DateTimeOffset(summary.Start, EventOffset);
        }

        /// <summary>
        /// Get end time of session as datetime offset based on event time zone
        /// </summary>
        public static DateTimeOffset GetEndOffset(this Summary summary)
        {
            return new DateTimeOffset(summary.End, EventOffset);
        }

        /// <summary>
        /// Get a <see cref="DateTimeOffset"/> by <paramref name="time"/> on the <see cref="TimeHelpers.EventDate"/>
        /// </summary>
        public static DateTimeOffset GetOffsetByTime(string? time)
        {
            if (string.IsNullOrEmpty(time))
            {
                return DateTimeOffset.Now;
            }

            var timeOfDay = TimeOnly.Parse(time);

            return new (EventDate, timeOfDay, EventOffset);
        }

        public static string AsDifferenceText(this Session? session, DateTimeOffset referenceTime)
        {
            if (session == null){
                return $"See you at {EventDate.ToShortDateString()}";
            }

            var diff = session.GetStartOffset().Subtract(referenceTime);

            if (diff.TotalMinutes < 1)
            {
                return "We will start shortly";
            }

            if (diff.Days > 0 || diff.TotalHours > 12)
            {
                return $"Almost, only {diff.Days} days and {diff.Hours} hours left";
            }

            if (diff.TotalHours < 1)
            {
                return $"Next session in {Math.Round(diff.TotalMinutes, 0)} minutes";
            }

            return $"We will start in {Math.Round(diff.TotalHours, 0)} hours";
        } 
    }
}