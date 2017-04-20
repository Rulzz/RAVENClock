using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RAVENClock
{
    public class UserPreference
    {
        private String hourColor;
        private String minColor;
        private String secColor;
        private String offColor;
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

        public String getSecColor()
        {
            return secColor;
        }
        public void setSecColor(String secColor)
        {
            this.secColor = secColor;
        }

        public String getOffColor()
        {
            return offColor;
        }
        public void setOffColor(String offColor)
        {
            this.offColor = offColor;
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
