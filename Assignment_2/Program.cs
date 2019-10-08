// Matthew Webb CIDM-4360-70

using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 12;
            int day = 15;
            int year = 1990;
            
            tDate.latestDate="12/31/2100";
            tDate.earliestDate="1/1/1990";

            tDate d1= new tDate(ref month,ref day, ref year);
            d1.showDate('u',month,day,year);
            d1.showDate('e',month,day,year);

            string date1 = "01/15/1990";
            tDate d2 = new tDate(date1, ref month, ref day, ref year);
            d2.showDate('u',month,day,year);
            d2.showDate('e',month,day,year);

            string date2 = "15/11/1990";
            tDate d3 = new tDate (date2, ref month, ref day, ref year);
            d3.showDate('u',month,day,year);
            d3.showDate('e',month,day,year);

            string date3 = "11/11/1811";
            tDate d4 = new tDate (date3, ref month, ref day, ref year);
            d4.showDate('u',month,day,year);
            d4.showDate('e',month,day,year);

            
        }
    }
}
