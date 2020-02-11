using System;

namespace AddDaysToDate
{
    class Sup
    {   
        public static int FindYear(int year, int addDay, int day, int month)
        {

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
            }
            return year;
        }
        public static int FindMonth(int day, int month, int year, int addDay)
        {
            int z = day + addDay;
            bool x = true;
            while (x == true)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {

                    if (1 <= z && z <= 31)
                    {
                        x = false;
                        return month;
                    }
                    else if (month == 12 && z > 31)
                    {
                        z = z - 31;
                        month = 1;
                        x = true;
                    }
                    else
                    {
                        z = z - 31;
                        month++;
                        x = true;
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (1 <= z && z <= 30)
                    {
                        x = false;
                        return month;
                    }
                    else
                    {
                        z = z - 31;
                        month++;
                        x = true;
                    }
                }
                else
                {
                    if (year % 4 == 0)
                    {
                        if (1 <= z && z <= 29)
                        {
                            x = false;
                            return month;
                        }
                        else
                        {
                            z = z - 29;
                            month++;
                            x = true;
                        }
                    }
                    else if (year % 4 != 0)
                    {
                        if (1 <= z && z <= 28)
                        {
                            x = false;
                            return month;
                        }
                        else
                        {
                            z = z - 28;
                            month++;
                            x = true;
                        }
                    }
                }

            }
            return month;
        }
        public static int FindDay(int day, int month, int year, int addDay)
        {
            int z = (day + addDay) % 365;
            addDay = z;
            bool x = true;
            while (x == true)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {

                    if (1 <= z && z <= 31)
                    {
                        x = false;
                        return month;
                    }
                    else if (month == 12 && z > 31)
                    {
                        z = z - 31;
                        month = 1;
                        x = true;
                    }
                    else
                    {
                        z = z - 31;
                        month++;
                        x = true;
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (1 <= z && z <= 30)
                    {
                        x = false;
                        return month;
                    }
                    else
                    {
                        z = z - 31;
                        month++;
                        x = true;
                    }
                }
                else
                {
                    if (year % 4 == 0)
                    {
                        if (1 <= z && z <= 29)
                        {
                            x = false;
                            return month;
                        }
                        else
                        {
                            z = z - 29;
                            month++;
                            x = true;
                        }
                    }
                    else if (year % 4 != 0)
                    {
                        if (1 <= z && z <= 28)
                        {
                            x = false;
                            return month;
                        }
                        else
                        {
                            z = z - 28;
                            month++;
                            x = true;
                        }
                    }
                }

            }
            return addDay;

        }

    }

}


