using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutSunday
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            string[] day = new string[20];

            for (int i = 0; i < day.Length; i++)
            {
                if (i == 0)
                {
                    day[i] = today.DayOfWeek.ToString();
                }
                else
                {
                    today = today.AddDays(1);

                    if (today.DayOfWeek == DayOfWeek.Sunday)
                    {
                        today = today.AddDays(1);

                        day[i] = today.DayOfWeek.ToString();
                    }
                    else
                    {
                        day[i] = today.DayOfWeek.ToString();
                    }
                }                
            }

            foreach (var item in day)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }

    }
}
