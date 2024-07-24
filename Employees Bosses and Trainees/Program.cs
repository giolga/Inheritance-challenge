using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Bosses_and_Trainees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee kumi = new Employee("El Kumi", "Kumi", 155000);
            kumi.Work();
            kumi.Pause();

            Boss me = new Boss("prelude", "gio", "gioLGA", 255000);
            me.Lead();

            Trainee mike = new Trainee(32, 8, "Michael", "Chandler", 15500);
            mike.Learn();
            mike.Work();

            Console.ReadKey();
        }
    }
}
