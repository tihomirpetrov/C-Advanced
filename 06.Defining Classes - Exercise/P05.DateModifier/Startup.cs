namespace P05.DateModifier
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            string startDateStr = Console.ReadLine();
            string endDateStr = Console.ReadLine();
            DateTime startDate = DateTime.Parse(startDateStr, CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.Parse(endDateStr, CultureInfo.InvariantCulture);

            DateModifier dateModifier = new DateModifier(startDate, endDate);

            Console.WriteLine(dateModifier.CalculateDifferenceInDays());
        }       
    }
}