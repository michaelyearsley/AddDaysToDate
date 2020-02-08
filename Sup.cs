using System;

namespace AddDaysToDate
{
    class Sup
    {
        public static int FindaddDay(int addDay)
        {
            int x = addDay;
            if (x < 365)
            {
                addDay = x;
            }
            else if (x % 365 >= 0)
            {
                addDay = (x % 365);
            }
            else
            {

                return addDay;
            }
            return addDay;
        }
        public static int FindYear(int year, int addDay, int day, int month)
        {
            int x = Sup.dayCalculator(addDay, day, month, year);
            if (addDay >= 365)
            {
                if ((addDay % 365) == 0)
                {
                    year = year + (addDay / 365);
                }
                else
                {
                    year = year + (Convert.ToInt32(addDay / 365));
                }
                addDay = addDay % 365;
            }
            return year;
        }
        public static int findMonth(int day, int month, int year, int addDay)
        {
            int x = -1;
            int z = day + addDay;
            int l = 0;
            int lower = l;
            int u = 0;
            int upper = u;
            int v = month;
            int value1 = v;


            while (true)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    u =u +31;
                    x = findMonthValue(year, z, lower, upper, value1);
                    l = u + 1;
                    v++;
                    return x;

                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    u = u+30;
                    x = findMonthValue(year, z, lower, upper, value1);
                    l = u + 1;
                    v++;
                    return x;
                }
                else if (month == 2)
                {
                    u = u+29;
                    x = findMonthValue(year, z, lower, upper, value1);
                    l = u + 1;
                    v++;
                    return x;
                }
                month++;
            }
            return month;

        }
        public static int dayCalculator(int day, int month, int year, int addDay)
        {
            int x = addDay + day;
            switch (month - 1)
            {
                case 1:
                    x = x + 31;
                    break;
                case 2:
                    if (year % 4 == 0)
                        x = x + 60;
                    else
                        x = x + 59;
                    break;
                case 3:
                    if (year % 4 == 0)
                        x = x + 91;
                    else
                        x = x + 90;
                    break;
                case 4:
                    if (year % 4 == 0)
                        x = x + 121;
                    else
                        x = x + 120;
                    break;
                case 5:
                    if (year % 4 == 0)
                        x = x + 152;
                    else
                        x = x + 151;
                    break;
                case 6:
                    if (year % 4 == 0)
                        x = x + 182;
                    else
                        x = x + 181;
                    break;
                case 7:
                    if (year % 4 == 0)
                        x = x + 213;
                    else
                        x = x + 212;
                    break;
                case 8:
                    if (year % 4 == 0)
                        x = x + 244;
                    else
                        x = x + 243;
                    break;
                case 9:
                    if (year % 4 == 0)
                        x = x + 274;
                    else
                        x = x + 273;
                    break;
                case 10:
                    if (year % 4 == 0)
                        x = x + 305;
                    else
                        x = x + 304;
                    break;
                case 11:
                    if (year % 4 == 0)
                        x = x + 335;
                    else
                        x = x + 334;
                    break;
                case 12:
                    if (year % 4 == 0)
                        x = x + 366;
                    else
                        x = x + 365;
                    break;
            }
            return x;

        }
        public static int findMonthValue(int year, int z, int lower, int upper, int value1)
        {
            if (lower <= z && z <= upper) 
            {

                if (year % 4 == 0)
                {
                    z = value1;
                    return z;

                }
                else if (year % 4 != 0)
                {
                    if (z <= upper - 1)
                    {
                        z = value1;
                        return z;
                    }
                    else
                    {
                        z = value1 + 1;
                        return z;
                    }
                    
                }
                else
                {
                    return z;
                }

            }



        }

    }
}

