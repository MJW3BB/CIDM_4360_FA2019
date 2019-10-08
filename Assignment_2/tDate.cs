// Matthew Webb CIDM4360

using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class tDate
    {
        public static string earliestDate;
        public static string latestDate;

        public tDate(ref int month, ref int day, ref int year)
        {
            if((month>0&&month<=12)&&(day>0&&day<=31)&&(year>0))
            {
                // do nothing
            }
            else
            {
                char[] delimiterChars = {'/'};
                string[] eDate = earliestDate.Split(delimiterChars);
                List<int> w = new List<int>();

                foreach (var number in eDate)
                {
                    int num = Convert.ToInt32(number);
                    w.Add(num);
                }

                month = w[0];
                day = w[1];
                year = w[2];
            }
        }

        public tDate(string date1, ref int month, ref int day, ref int year)
        {
            string date = date1;
            char[] delimiterChars = {'/'};
            string[] expression = date.Split(delimiterChars);
            List<int> x = new List<int>();

            foreach (var number in expression)
            {
                int num = Convert.ToInt32(number);
                x.Add(num);
            }

            if ((x[0]>0&&x[0]<=12)&&(x[1]>0&&x[11]<=31)&&(x[2]>0))
            {
                month = x[0];
                day = x[1];
                year = x[2];
            }
            else
            {
                string[] eDate = earliestDate.Split(delimiterChars);
                List<int> w = new List<int>();

                foreach (var number in eDate)
                {
                    int num = Convert.ToInt32(number);
                    w.Add(num);
                }

                month = w[0];
                day = w[1];
                year = w[2];
            }
        }

        public void showDate(char country, int month, int day, int year)
        {
            if (country == 'u')
            {
                Console.WriteLine($"{month}/{day}/{year}");
            }
            else if (country == 'e')
            {
                Console.WriteLine($"{day}/{month}/{year}");
            }
        }
    }
    
}