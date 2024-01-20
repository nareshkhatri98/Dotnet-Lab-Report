using System;
namespace lab2
{
     class EmployeeDetails
    {
        protected int empId;
        protected string empName;
        protected char empGender;
        protected string empAddress;
        protected string empPosition;

        public EmployeeDetails(int empId, string empName, char empGender, string empAddress, string empPosition)
        {
            this.empId = empId;
            this.empName = empName;
            this.empGender = empGender;
            this.empAddress = empAddress;
            this.empPosition = empPosition;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Gender: " + empGender);
            Console.WriteLine("Address: " + empAddress);
            Console.WriteLine("Position: " + empPosition);
        }
    }

    class SalaryInfo : EmployeeDetails
    {
        private double salary;

        public SalaryInfo(int empId, string empName, char empGender, string empAddress, string empPosition, double salary)
            : base(empId, empName, empGender, empAddress, empPosition)
        {
            this.salary = salary;
        }

        public void CalcTax()
        {
            double taxRate;
            if (salary <= 400000)
            {
                taxRate = 0.01;
            }
            else if (salary <= 800000)
            {
                taxRate = 0.1;
            }
            else
            {
                taxRate = 0.2;
            }

            double taxAmount = salary * taxRate;
            double finalSalary = salary - taxAmount;

            Console.WriteLine("Original Salary: " + salary);
            Console.WriteLine("Tax Deducted: " + taxAmount);
            Console.WriteLine("Final Salary: " + finalSalary);
        }
    }
}
