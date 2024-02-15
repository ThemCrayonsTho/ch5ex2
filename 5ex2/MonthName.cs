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
            throw new System.NotImplementedException();
        }

        public void Mnth()
        {
            throw new System.NotImplementedException();
        }

        public void NumberOfDaysInMonth()
        {
            throw new System.NotImplementedException();
        }
    }
}
