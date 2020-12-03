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
            DateTime today = DateTime.Today;  // ประกาศตัวแปรชนิด DateTime กำหนดค่า เป็นวันปัจจุบัน

            string[] day = new string[20]; // ประกาศตัวแปรแบบอาเรย์ชนิด string ความยาว 20

            for (int i = 0; i < day.Length; i++)  // for loop จำนวนครั้งตามความยาวของตัวแปร day
            {
                if (i == 0) // เช็คว่าเป็นตำแหน่งแรกของอาเรย์
                {
                    // yes
                    
                    day[i] = today.DayOfWeek.ToString(); // เก็บค่าวันเช่น Monday ลงในอาเรย์
                }
                else // ถ้าไม่ใช่ตำแหน่งแรกของอาเรย์
                {
                    // no

                    today = today.AddDays(1);   // เพิ่มวัน 1 วัน ให้กับตัวแปร today

                    if (today.DayOfWeek == DayOfWeek.Sunday)    // หลังจากเพิ่มวันก็เช็คว่าเป็นวันอาทิตย์ไหม
                    {
                        // yes

                        today = today.AddDays(1);   // เพิ่มวันอีก 1 วันให้กับตัวแปร today

                        day[i] = today.DayOfWeek.ToString();    // เก็บค่าวันเช่น Monday ลงในอาเรย์
                    }
                    else
                    {
                        // no

                        day[i] = today.DayOfWeek.ToString();    // เก็บค่าวันเช่น Monday ลงในอาเรย์
                    }
                }                
            }

            foreach (var item in day)   // loop foreach อ่านค่าในตัวแปรเดย์ มาเก็[ที่ตัวแปร item วนตามความยาวของตัวแปร day
            {
                Console.WriteLine(item);    // คำสั่ง print
            }


            Console.ReadLine();
        }

    }
}
