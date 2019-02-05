namespace P05.DateModifier
{
    using System;
    using System.Globalization;

    public class DateModifier
    {
        private DateTime startDate;
        private DateTime endDate;

        public DateModifier(DateTime startDateStr, DateTime endDateStr)
        {
            this.startDate = startDateStr;
            this.endDate = endDateStr;            
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public DateTime EndDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }

        public double CalculateDifferenceInDays()
        {
            return Math.Abs((EndDate - StartDate).TotalDays);
        }
    }
}
