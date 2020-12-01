using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Rushi", 50000, 1);
            o1.GetNetSalary();
            Employee o2 = new Employee("Udit", 100000);
            o2.GetNetSalary();
            Employee o3 = new Employee("Ravi");
            o3.GetNetSalary();
            Employee o4 = new Employee();
            o4.GetNetSalary();
            Employee o5 = new Employee("Rushi", 490000, -3);
            o5.GetNetSalary();
            Console.WriteLine(o1.Emp_No);
            Console.WriteLine(o2.Emp_No);
            Console.WriteLine(o3.Emp_No);
            Console.WriteLine(o4.Emp_No);
            Console.WriteLine(o5.Emp_No);
            Console.WriteLine(o4.EmpNo);
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o5.EmpNo);
            Console.ReadLine();
        }
    }

    public class Employee
    {
        private string Name;
        public int EmpNo;
        public decimal Basic_Sal;
        public short DeptNo;
        private static int count = 0;
        public double incomeTax = 0.5;
        public double pTax = 0.6;
        public Employee()
        {
            count++;
            this.Name = " ";
            this.EmpNo = count;
        }
        public Employee(String name, decimal basic_sal, short dept_no)
        {
            count++;
            this.EmpNo = count;
            this.Name = name;
            this.Basic_Sal = basic_sal;
            this.DeptNo = dept_no;
        }
        public Employee(String name, decimal basic_sal)
        {
            count++;
            this.EmpNo = count;
            this.Name = name;
            this.Basic_Sal = basic_sal;
            this.DeptNo = 0;

        }
        public Employee(String name)
        {
            count++;
            this.EmpNo = count;
            this.Name = name;
            this.basic_sal = 0;
            this.DeptNo = 0;
        }
        public string name
        {
            set
            {
                if (value == " " || value == null)
                {
                    Console.WriteLine("plz...enter some value");
                }
                else
                {
                    Name = value;
                }
            }

            get
            {
                return Name;
            }
        }
        public int Emp_No
        {
            get
            {
                return EmpNo;
            }
        }

        public decimal basic_sal
        {
            set
            {
                if (value > 10000)
                {

                    Basic_Sal = value;
                }
                else
                {
                    Console.WriteLine("enter value greater than 10000");
                }
            }

            get
            {
                return Basic_Sal;
            }
        }
        public short dept_no
        {
            set
            {
                if (value > 0)
                {

                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("deprt no. should be greater than 0");
                }
            }

            get
            {
                return DeptNo;
            }
        }
        public void GetNetSalary() {

            double salary = (double)this.Basic_Sal + ((double)this.Basic_Sal * incomeTax) - ((double)this.Basic_Sal * pTax);

            Console.WriteLine("net salary=" + salary);
        }
    
    }
}
