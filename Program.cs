﻿namespace EmployeeWageNonStatic
{
    public class Method
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("***** Welcome to the employee wage computation Program for Non Static Methods. *****");

            EmpWageNonStatic Emp = new EmpWageNonStatic();
            Emp.Employee();

        }
    }
}