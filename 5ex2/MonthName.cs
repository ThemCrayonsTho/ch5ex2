namespace _ch5ex2
{
    internal class MonthName
    {
        private int month;
        private int daysInMonth;

        public MonthName()
        {

        }

        public MonthName(int monthName, int daysNumMonth)
        {
            month = monthName;
            daysInMonth = daysNumMonth;
        }

        public int MonthNum
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }

        public int DaysInMonth
        {
            get
            {
                return daysInMonth;
            }
            set
            {
                daysInMonth = value; ;
            }
        }

        public override string ToString()
        {
            
        }

        public int Month()
        {
            string monthName;
            switch (month)
            {
                case '1':
                    monthName = "January";
                    break;
                case '2':
                    monthName = "February";
                    break;
                case '3':
                    monthName = "March";
                    break;
                case '4':
                    monthName = "April";
                    break;
                case '5':
                    monthName = "May";
                    break;
                case '6':
                    monthName = "February";
                    break;
                case '7':
                    monthName = "March";
                    break;
                case '8':
                    monthName = "April";
                    break;
                case '9':
                    monthName = "January";
                    break;
                case "10":
                    monthName = "February";
                    break;
                case "11":
                    monthName = "March";
                    break;
                case "12":
                    monthName = "April";
                    break;
                default:
                    monthName = "unknown";
                    break;
            }
            return monthName;
        }

        public void NumberOfDaysInMonth()
        {
            
        }
    }
}
