using System;
using System.Collections.Generic;
using System.Text;

namespace AddDaysToDate
{
    class Sup
    {
        public static int FindaddDay(int addDay, int day, int month, int year)
        {
            int x = Sup.dayCalculator(addDay, day, month, year);
            if (x % 365 == 0)
            {
                addDay = 0;
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
        public static int FindYear(int year, int addDay)
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
                addDay = addDay % 365;
            }
            return year;
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
                        x = x + 336;
                    else
                        x = x + 335;
                    break;
            }
            return x;
        }
        //public static int FindMonth(int day, int month, int year, int addDay)
        //    if 
        //    switch (y)
        //    {
        //        case 1:
        //            x = x + 31;
        //            break;
        //        case 2:
        //            if (year % 4 == 0)
        //                x = x + 60;
        //            else
        //                x = x + 59;
        //            break;
        //        case 3:
        //            if (year % 4 == 0)
        //                x = x + 91;
        //            else
        //                x = x + 90;
        //            break;
        //        case 4:
        //            if (year % 4 == 0)
        //                x = x + 121;
        //            else
        //                x = x + 120;
        //            break;
        //        case 5:
        //            if (year % 4 == 0)
        //                x = x + 152;
        //            else
        //                x = x + 151;
        //            break;
        //        case 6:
        //            if (year % 4 == 0)
        //                x = x + 182;
        //            else
        //                x = x + 181;
        //            break;
        //        case 7:
        //            if (year % 4 == 0)
        //                x = x + 213;
        //            else
        //                x = x + 212;
        //            break;
        //        case 8:
        //            if (year % 4 == 0)
        //                x = x + 244;
        //            else
        //                x = x + 243;
        //            break;
        //        case 9:
        //            if (year % 4 == 0)
        //                x = x + 274;
        //            else
        //                x = x + 273;
        //            break;
        //        case 10:
        //            if (year % 4 == 0)
        //                x = x + 305;
        //            else
        //                x = x + 304;
        //            break;
        //        case 11:
        //            if (year % 4 == 0)
        //                x = x + 335;
        //            else
        //                x = x + 334;
        //            break;
        //        case 12:
        //            if (year % 4 == 0)
        //                x = x + 336;
        //            else
        //                x = x + 335;
        //            break;



        //    }

       
            
        
    }
}
