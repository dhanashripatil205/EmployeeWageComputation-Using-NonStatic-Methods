﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageNonStatic
{
    public class EmpWageNonStatic
    {
        public void Employee()
        {
            int Is_Full_Time = 1;
            Random R = new Random();
            int empCheck = R.Next(2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}
