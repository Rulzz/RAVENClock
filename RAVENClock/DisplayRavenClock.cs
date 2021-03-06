﻿using System;

namespace RAVENClock
{
    public class DisplayRavenClock
    {
        public String display(String displayedTime, UserPreference preference)
        {
            displayedTime = displayedTime.Replace("S", preference.getSecColor());
            displayedTime = displayedTime.Replace("H", preference.getHourColor());
            displayedTime = displayedTime.Replace("M", preference.getMinColor());
            displayedTime = displayedTime.Replace("O", preference.getOffColor());
            
            Console.WriteLine();
            Console.Write("RAVEN Clock Display : ");
            Console.WriteLine();
            Console.Write(displayedTime);

            return displayedTime;
        }
    }
}