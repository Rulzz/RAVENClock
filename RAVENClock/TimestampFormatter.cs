using System;

namespace RAVENClock
{
    public class TimestampFormatter : DateFormatter
    {
        public string format(string dateTimestampString)
        {
            long timestamp = Int32.Parse(dateTimestampString);
            TimeSpan timeSpan = TimeSpan.FromSeconds(timestamp);
            DateTime localDateTime = new DateTime(timeSpan.Ticks);
            return localDateTime.ToString("HH:mm:ss");
        }
    }
}