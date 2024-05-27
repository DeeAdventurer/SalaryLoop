using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for input
            Console.Write("Enter hours worked: ");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate of pay: ");
            double rateOfPay = Convert.ToDouble(Console.ReadLine());

            // Calculate the salary
            double salary = hoursWorked * rateOfPay;

            // Display the result
            Console.WriteLine($"Employee's salary: R{salary:F2}");
        }
    }
}
