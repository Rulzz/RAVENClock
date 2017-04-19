using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RAVENClock
{
    class UserInput
    {
        static void Main(string[] args)
        {
            UserPreference preference = new UserPreference();

            Console.Write("Which letter should hour light be displayed?");
            String hourColor = Console.ReadLine();
            preference.setHourColor(hourColor);

            Console.Write("Which letter should miniutes light be displayed?");
            String minColor = Console.ReadLine();
            preference.setMinColor(minColor);

            Console.Write("Which letter should off light be displayed?");
            String offColor = Console.ReadLine();
            preference.setOffColor(offColor);

            Console.Write("Enter Time... ");
            String inputDateString = Console.ReadLine();
            preference.setInputDateString(inputDateString);

            Console.Write("Enter Time Format... Ex. HHMMSS, Timestamp, DateTime");
            String DateTyprString = Console.ReadLine();
            preference.setDateType(DateTyprString);

            
            
            
            Console.ReadKey();
        }
    }
}
