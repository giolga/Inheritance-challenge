﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Bosses_and_Trainees
{
    internal class Boss : Employee
    {

        public string CompanyCar { get; set; }

        public Boss(string companyCar, string name, string firstName, int salary) : base(name, firstName, salary)
        {
            this.CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine("I'm boss, Yo soy {0} {1}", Name, FirstName);
        }
    }
}
