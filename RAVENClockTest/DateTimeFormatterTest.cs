using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RAVENClock;

namespace RAVENClockTest
{
    [TestClass]
    public class DateTimeFormatterTest
    {
        DateTimeFormatter dateTimeFormatter = new DateTimeFormatter();

        [TestMethod]
        public void test_shortDate_longTime()
        {
            String output = dateTimeFormatter.format("6/22/2009 07:00:00 AM");
            StringAssert.Equals("07:00:00", output);
        }

        [TestMethod]
        public void test_SortableDateTiem()
        {
            String output = dateTimeFormatter.format("2009-06-15T13:45:30");
            StringAssert.Equals("13:45:30", output);
        }
        
        [TestMethod]
        public void test_full_dateTime()
        {
            String output = dateTimeFormatter.format("Sunday, March 09, 2008 4:05:07 PM");
            StringAssert.Equals("16:05:07", output);
        }

       [TestMethod]
        public void test_german_time()
        {
            String output = dateTimeFormatter.format("9.3.2008 16:05:07");
            StringAssert.Equals("16:05:07", output);
        }
    }
}
