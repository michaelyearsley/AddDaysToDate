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
            int addDay = Sup.FindaddDay(int.Parse(Console.ReadLine()), month, day, year);
            year = Sup.FindYear(year, addDay);

            //Sup.adddaytoDate(day, month, year, addDay);


            // finds months with 31
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {

                if (31 < (day + addDay) && month < 12)
                {
                    month = (month + addDay);
                    day = 1;
                    Console.WriteLine("{0}/{1}/{2}", month, day, year);
                }
                else if (31 < (day + addDay) && month == 12)
                {
                    month = 1;
                    day = 1;
                    year = (year + 1);
                    Console.WriteLine("{0}/{1}/{2}", month, day, year);
                }
                else if (31 == (day + addDay))
                {
                    day = 31;
                    Console.WriteLine("{0}/{1}/{2}", month, day, year);
                }
                else if (31 > (day + addDay))
                {

                }
            }

            // finds months with 30
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {

                if (30 < (day + addDay))
                {
                    month = (month + 1);
                    day = 1;
                    Console.WriteLine("{0}/{1}/{2}", month, day, year);

                }
                else if (30 <= (day + addDay))
                {
                    day = 30;
                    Console.WriteLine("{0}/{1}/{2}", month, day, year);
                }
                else if (30 > (day + addDay))
                {
                    Console.WriteLine("{0}/{1}/{2}", month, day, year);
                }

            }

            // finds months with 29
            if (month == 2)
            {

                if (29 < (day + addDay))
                {
                    month = (month + 1);
                    day = 1;
                    Console.WriteLine("{0}/{1}/{2}", month, day, year);
                }
                else if (29 > (day + addDay))
                {
                    day = day + addDay;
                    Console.WriteLine("{0}/{1}/{2}", month, day, year);
                }
                else if (29 == (day + addDay))
                {
                    day = 29;
                    Console.WriteLine("{0}/{1}/{2}", month, day, year);
                }

            }
        }
    }
}
