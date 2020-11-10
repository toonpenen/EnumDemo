using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum WorkingDays
    {
        Monday, //0
        Tuesday, //1
        Wednesday, //2
        Thursday, //3
        Friday //4
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Workingdays d = (WorkingDays)4;
            //Console.WriteLine(d);

            //WorkingDays d = WorkingDays.Thursday;
            //Console.WriteLine((int)d);

            // enumerate values 0,1,2..
            foreach (int i in Enum.GetValues(typeof(WorkingDays)))
            {
                Console.WriteLine(i);
            }
            // enumerate Names Monday, Tuesday..
            foreach (string s in Enum.GetNames(typeof(WorkingDays)))
            {
                Console.WriteLine(s);
            }

        }
    }
}
