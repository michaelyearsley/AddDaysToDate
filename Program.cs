using System;

namespace AddDaysToDate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take user input into a varriable and covert it to int
            Console.Write("month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Year (YYYY): ");
            //int year = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            //Reads out user input
            Console.WriteLine("The date you entered date mm/dd/yyyy: {0}/{1}/{2}", month, day, year);
            // Takes user input for amout of days covert to int

            Console.Write("Enter numbers of days you want to add: ");
            //int addDay = int.Parse(Console.ReadLine());
            int addDay = int.Parse(Console.ReadLine());
            //find year
            year = Sup.FindYear(year, addDay, day, month);
            
            //find Month
            month = Sup.FindMonth(day, month, year, addDay);
            
            //find day
            day = Sup.FindDay(day, month, year, addDay);
           

            //print out date (day, month, year, addDay);
            Console.WriteLine(" Your new date with a {3} days add is (dd/mm/yyyy) {0}/{1}/{2}", day, month, year, addDay);

        }
    }
}
