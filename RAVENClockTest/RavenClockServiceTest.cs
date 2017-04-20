using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RAVENClock;

namespace RAVENClockTest
{
    [TestClass]
    public class RavenClockServiceTest
    {
        RavenService services = new RavenService();

        [TestMethod]
        public void timeInput_16_37_16()
        {
            String output = services.getClockString("16:37:16");
            StringAssert.Equals("S HHHO HOOO MMHMMHMOOOO MMOO", output);
        }

        [TestMethod]
        public void timeInput_06_37_06()
        {
            String output = services.getClockString("06:37:06");
            StringAssert.Equals("O HOOO HOOO MMHMMHMOOOO MMOO", output);
        }

        [TestMethod]
        public void timeInput_23_59_59()
        {
            String output = services.getClockString("23:59:59");
            StringAssert.Equals("S HHHH HHHO MMHMMHMMHMM MMMM", output);
        }

        [TestMethod]
        public void timeInput_00_00_00()
        {
            String output = services.getClockString("00:00:00");
            StringAssert.Equals("S OOOO OOOO OOOOOOOOOOO OOOO", output);
        }
    }
}
