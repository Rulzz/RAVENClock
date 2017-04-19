using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RAVENClock
{
    class UserPreference
    {
        private String hourColor;
        private String minColor;
        private String offColor;
        private String inputDateString;
        private String dateType;

        public String getHourColor()
        {
            return hourColor;
        }
        public void setHourColor(String hourColor)
        {
            this.hourColor = hourColor;
        }

        public String getMinColor()
        {
            return minColor;
        }
        public void setMinColor(String minColor)
        {
            this.minColor = minColor;
        }

        public String getOffColor()
        {
            return offColor;
        }
        public void setOffColor(String offColor)
        {
            this.offColor = offColor;
        }

        public String getInputDateString()
        {
            return inputDateString;
        }
        public void setInputDateString(String inputDateString)
        {
            this.inputDateString = inputDateString;
        }

        public String getDateType()
        {
            return dateType;
        }
        public void setDateType(String dateType)
        {
            this.dateType = dateType;
        }
    }
}
