using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeUsingStaticVariable
{
    public class Inheritance
    {
        protected int empid;
        protected string name;
        protected double basicSal, totalSal, grossSal, hra, ta, da, pf;
        private static int count;

        public Inheritance(string name, double basicSal)
        {
            count++;
            empid = count;
            this.name = name;
            this.basicSal = basicSal;
        }
        // to allow method to be overriden we use virtual keyword

        public virtual void CalculateSalary()
        {
            hra = basicSal * 0.40;
            ta = basicSal * 0.20;
            da = basicSal * 0.15;
            pf = basicSal * 0.12;

            totalSal = hra + ta + da;

            grossSal = (hra + ta + da) - pf;
        }
        public override string ToString()
        {
            return $"id = {empid} \nName = {name} \nGross = {grossSal}";
        }
    }

    public class SalesManager : Inheritance
    {
        private double comm;
        // first always it calls to base class constructor
        // base keyword is used to call the base class members 

        public SalesManager(string name , double basicSal , double comm) : base(name, basicSal)  //parametric constructor
        {
            this.comm = comm;
        }


        // method which is sam in base class should override the implementation
        public override void CalculateSalary()
        {
            hra = basicSal * 0.40;
            ta = basicSal * 0.20;
            da = basicSal * 0.15;
            pf = basicSal * 0.12;

            totalSal = hra + ta + da;

            grossSal = (hra + ta + da + comm) - pf;
        }
        // ToString() --> gives the string representation of an object
        public override string ToString()
        {
            return $"id = {empid} \nName = {name} \nGross = {grossSal}";
        }
    }

    public class CEO : Inheritance
    {
        private double profit ;

        public CEO (string name , double basciSal , double profit) : base(name , basciSal)
        {
            this.profit = profit ;
        }
        public override void CalculateSalary()
        {
            hra = basicSal * 0.40;
            ta = basicSal * 0.20;
            da = basicSal * 0.15;
            pf = basicSal * 0.12;

            totalSal = hra + ta + da +profit;

            grossSal = (totalSal) - pf;
        }
        public override string ToString()
        {
            return $"id = {empid} \nName = {name} \nGross = {grossSal}";
        }
    }
}
