using System;

namespace Employee
{
    class Employee
    {
        private string firstName, lastName;
        private decimal monthSalary;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName{
            get { return lastName; }
            set { lastName = value; }
        }
        public decimal MonthlySalary
        {
            get { return monthSalary; }
            set { if (value <= 0M) throw new ArgumentOutOfRangeException("Value cannot be negative.");
                  else monthSalary = value; }
        }
        
        public Employee(string constFirstName, string constLastName, decimal constMonthlySalary) {
            firstName = constFirstName;
            lastName = constLastName;
            monthSalary = constMonthlySalary;
        }//end constructor

        public decimal IncreaseSalary(decimal salary) {
            decimal adjustedSalary;
            adjustedSalary = salary * 1.1M;
            return adjustedSalary;
        }//end method

        public decimal AnnualSalary(decimal salary) {
            decimal annualSalary;
            annualSalary = salary * 12;
            return annualSalary;
        }//end salary


        
    }//end class
}//end namespace
