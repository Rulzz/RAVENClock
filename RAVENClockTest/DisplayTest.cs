using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RAVENClock;

namespace RAVENClockTest
{
    [TestClass]
    public class DisplayTest
    {
        DisplayRavenClock ravenDisplay = new DisplayRavenClock();

        [TestMethod]
        public void display_H_M_S_O()
        {
            String input = "S HHHO HOOO MMHMMHMOOOO MMOO";
            String output = ravenDisplay.display(input, getPreference("H", "M", "S", "O"));
            String expectedOutput = "S HHHO HOOO MMHMMHMOOOO MMOO";
            StringAssert.Equals(expectedOutput, output);
        }

        [TestMethod]
        public void display_Hr_Min_Sec_Off()
        {
            String input = "S HHHO HOOO MMHMMHMOOOO MMOO";
            String output = ravenDisplay.display(input, getPreference("Hr", "Min", "Sec", "Off"));
            String expectedOutput = "Sec HrHrHrOff HrOffOffOff MinMinHrMinMinHrMinOffOffOffOff MinMinOffOff";
            StringAssert.Equals(expectedOutput, output);
        }

        [TestMethod]
        public void display_R_Y_Y_O()
        {
            String input = "S HHHO HOOO MMHMMHMOOOO MMOO";
            String output = ravenDisplay.display(input, getPreference("R", "Y", "Y", "O"));
            String expectedOutput = "Y RRRO ROOO YYRYYRYOOOO YYOO";
            StringAssert.Equals(expectedOutput, output);
        }

        private UserPreference getPreference(String hourColor, String minColor, String secColor, String offColor)
        {
            UserPreference preference = new UserPreference();
            preference.setHourColor(hourColor);
            preference.setMinColor(minColor);
            preference.setSecColor(secColor);
            preference.setOffColor(offColor);
            preference.setDateType("HHMMSS");
            return preference;
        }
    }
}
