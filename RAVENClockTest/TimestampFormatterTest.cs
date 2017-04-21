using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RAVENClock;

namespace RAVENClockTest
{
    [TestClass]
    public class TimestampFormatterTest
    {
        TimestampFormatter timestampFormatter = new TimestampFormatter();
        [TestMethod]
        public void time_1492734999()
        {
            String output = timestampFormatter.format("1492734999");
            StringAssert.Equals("00:36:39", output);
        }
        [TestMethod]
        public void time_977483727()
        {
            String output = timestampFormatter.format("977483727");
            StringAssert.Equals("11:15:27", output);
        }
        [TestMethod]
        public void time_977493409()
        {
            String output = timestampFormatter.format("977493409");
            StringAssert.Equals("13:56:49", output);
        }
    }
}
