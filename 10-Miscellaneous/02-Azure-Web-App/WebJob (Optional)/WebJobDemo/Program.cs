using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTime();
        }
        public static void DisplayTime()
        {
            Console.WriteLine(DateTime.UtcNow.TimeOfDay);
        }
    }
}
