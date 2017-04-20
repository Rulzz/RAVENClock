using System;

namespace RAVENClock
{
    public class DateTimeFormatter : DateFormatter
    {
        public string format(string dateString)
        {
            DateTime enteredDate = DateTime.Parse(dateString);
            return enteredDate.ToString("HH:mm:ss");
        }
    }
}