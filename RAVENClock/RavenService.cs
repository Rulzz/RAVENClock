﻿using System;

namespace RAVENClock
{
    public class RavenService
    {
        DisplayRavenClock displayRaven = new DisplayRavenClock();
        public String generateRavenClock(String inputDateString, UserPreference preference)
        {
            DateFormatter formatDate;
            String time = "";
            if (preference.getDateType().Equals(DateType.HHMMSS.ToString())) {
                formatDate = new HHMMSSFormatter();
                time = formatDate.format(inputDateString);
            } else if (preference.getDateType().Equals(DateType.Timestamp.ToString())) {
                formatDate = new TimestampFormatter();
                time = formatDate.format(inputDateString);
            } else if (preference.getDateType().Equals(DateType.DateTime.ToString())) {
                formatDate = new DateTimeFormatter();
                time = formatDate.format(inputDateString);
            } else {
                Console.Write("INVALID date format. Use any among these formats : HHMMSS, Timestamp, DateTime");
                return "";
            }

            String displayedTime = getClockString(time);

            return displayRaven.display(displayedTime, preference);

        }

        //expected time String in format - HH:MM:SS
        public string getClockString(string time)
        {
            String displayedTime = "";

            string[] timeComponents = time.Split(':');

            if(timeComponents.Length<3)
            {
                Console.Write("INVALID date format. Use any among these formats : HHMMSS, Timestamp, DateTime");
                return "";
            }

            int hours = Int32.Parse(timeComponents[0]);
            int minutes = Int32.Parse(timeComponents[1]);
            int seconds = Int32.Parse(timeComponents[2]);

            if((seconds/2)%2==0)
            {
                displayedTime = displayedTime + "S ";
            } else
            {
                displayedTime = displayedTime + "O ";
            }

            displayedTime = displayedTime + getTimeDisplayString(4, hours / 5, "H", 0, "");
            displayedTime = displayedTime + getTimeDisplayString(4, hours % 5, "H", 0, "");

            displayedTime = displayedTime + getTimeDisplayString(11, minutes / 5, "M", 3, "H");
            displayedTime = displayedTime + getTimeDisplayString(4, minutes % 5, "M", 0, "");

            return displayedTime;
        }

        private string getTimeDisplayString(int length, int displayTill, String timeStr, int indicatorFreq, String indicatorStr)
        {
            string displayedTime = "";
            for (int idx = 1; idx <= length; idx++)
            {
                if (idx <= displayTill)
                {
                    if (indicatorFreq>0 && idx%indicatorFreq==0)
                    {
                        displayedTime = displayedTime + indicatorStr;
                    } else
                    {
                        displayedTime = displayedTime + timeStr;
                    }
                }
                else
                {
                    displayedTime = displayedTime + "O";
                }

            }
            displayedTime = displayedTime + " ";
            return displayedTime;
        }
    }
}