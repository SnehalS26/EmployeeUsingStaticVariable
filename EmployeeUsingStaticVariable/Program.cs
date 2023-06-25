using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeUsingStaticVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesManager salesManager = new SalesManager("nikita", 25000, 3000);
            salesManager.CalculateSalary();
            Console.WriteLine(salesManager);  // ToString() get called implicitly

            Inheritance inheritance = new Inheritance("sneh", 15000);
            inheritance.CalculateSalary();
            Console.WriteLine(inheritance);

            CEO ceo = new CEO("Pankaj", 20000, 20);
            ceo.CalculateSalary();  //call calculate salary
            Console.WriteLine(ceo);  //print 










            //Employee emp1 = new Employee("Snehal", 10000);
            //emp1.CalculateSalary();

            //Employee emp2 = new Employee("Sneha", 20000);
            //emp2.CalculateSalary();

            ////instance Method
            //Console.WriteLine(emp1.PrintDeatils());
            //Console.WriteLine(emp2.PrintDeatils());

            //Console.WriteLine(Employee.GetCount());  //print class method
        }
    }
}
