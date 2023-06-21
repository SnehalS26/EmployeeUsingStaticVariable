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

        public static int GetCount()
        {
            return count;
        }

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
        //first always call base class constructor
        public SalesManager(string name , double basicSal , double comm) : base(name, basicSal)
        {
            this.comm = comm;
        }

        public override void CalculateSalary()
        {
            hra = basicSal * 0.40;
            ta = basicSal * 0.20;
            da = basicSal * 0.15;
            pf = basicSal * 0.12;

            totalSal = hra + ta + da;

            grossSal = (hra + ta + da + comm) - pf;
        }
        public override string ToString()
        {
            return $"id = {empid} \nName = {name} \nGross = {grossSal}";
        }
    }
}
