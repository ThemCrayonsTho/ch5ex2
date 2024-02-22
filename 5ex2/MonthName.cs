namespace _ch5ex2
{
    internal class MonthName
    {
        private int month;
        private int daysInMonth;

        public MonthName()
        {

        }

        public MonthName(int monthName)
        {
            month = monthName;
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
        public int DaysinMonth
        {
            get
            {
                return daysInMonth;
            }
            set
            {
                daysInMonth = value;
            }
        }

        public override string ToString()
        {
            return "month: " + Month() + "number of days in the month: " + NumberOfDays();
        }

        public string Month()
        {
            string monthName;
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    monthName = "unknown";
                    break;
            }
            return monthName;
        }
        public int NumberOfDays()
        {
            int numberOfDays;
            switch (daysInMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    numberOfDays = 31;
                    break;
                case 2:
                    numberOfDays = 29;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    numberOfDays = 30;
                    break;
            }
            return numberOfDays;
        }

    }
}
