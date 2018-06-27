using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class EmployeeTest
    {
            public static void Main(string [] args) {
            Employee Andrew = new Employee("Andrew", "Connelly", 2000.00M);
            Employee Rebecca = new Employee("Rebecca", "Connelly", 1600.00M);

            decimal salaryIncreaseAndrew = Andrew.IncreaseSalary(Andrew.MonthlySalary);
            decimal salaryIncreaseRebecca = Rebecca.IncreaseSalary(Rebecca.MonthlySalary);

            decimal annualSalaryAndrew = Andrew.AnnualSalary(Andrew.MonthlySalary);
            decimal annualSalaryRebecca = Rebecca.AnnualSalary(Rebecca.MonthlySalary);

           
            Console.WriteLine("Andrew's monthly salary after increase is: {0:C}, his annual salary is: {1:C}", salaryIncreaseAndrew, annualSalaryAndrew);
            Console.WriteLine("Rebecca's monthly salary after increase is: {0:C}, her annual salary is: {1:C}", salaryIncreaseRebecca, annualSalaryRebecca);
            Console.ReadKey();
            }//end main method
                
    }//end class
}//end namespace
