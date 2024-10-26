using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryexam4_speed_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int speed, speedlimit, speeding;
            int demeritpts = 0;
            Console.Write("What is the speedlimit in km/hr? ");
            speedlimit = int.Parse(Console.ReadLine());

            Console.Write("What is the speed of your car in km/hr? ");
            speed = int.Parse(Console.ReadLine());

            if (speed > speedlimit)
            {
                speeding = speed - speedlimit;
                demeritpts = speeding / 5;
                if (demeritpts <= 12)
                {
                    Console.WriteLine($"Your demerit points is {demeritpts}");
                }
                else
                {
                    Console.WriteLine("License is Suspended.");
                }
            }
            else
            {
                Console.WriteLine("Speed is OK. Drive safe! ");
            }
        }
    }
}
