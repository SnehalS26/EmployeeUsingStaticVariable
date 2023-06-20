using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Create a class Employee
Accept name & basic salary from the constructor
Class must auto generate the emp id using static

Create method CalculateSalary() for salary calculation
Hra 40 % of bs
Ta  20 % of bs
Da  15 % of bs
Pf  12 % of bs

Calculate the total salary & Gross salary of employee

Create Print method to display employee details
Create static method to display total count of employee
*/
namespace EmployeeUsingStaticVariable
{
    internal class Employee
    {
        private int empid;
        private string name;
        private double basicSal, totalSal, grossSal, hra, ta, da, pf;
        private static int count;

        public Employee(string name, double basicSal)
        {
            count++;
            empid = count;
            this.name = name;
            this.basicSal = basicSal;
        }

        public static int GetCount()
        {
            return count;
        }

        public void CalculateSalary()
        {
            hra = basicSal * 0.40;
            ta = basicSal * 0.20;
            da = basicSal * 0.15;
            pf = basicSal * 0.12;

            totalSal = hra + ta + da;

            grossSal = (hra + ta + da) - pf;
        }


        public string PrintDeatils()
        {
            return $"Emp id = {empid} \nEmp Name = {name} \nBasic Salary = {basicSal} \nTotal Salary = {totalSal} \nGross Salary = {grossSal}";
        }
    }
}
