using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter 0 for welcome program \n Enter 1 for Employee Attendance UC1 \n Enter 2 for Calculating Employee Wage UC2");
            int option = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            switch (option)
            {

                case 0:
                      Console.WriteLine("Welcome to Employee Wage Computation Program");
                    break;
                case 1:
                    EmployeeWadgeUC1.EmployeeUC1(empCheck);
                    break;
                case 2:
                    EmployeeWadgeUC2.EmployeeUC2(empCheck);
                    break;
                default:
                    Console.WriteLine("Please Input Correct option");
                    break;

            }
        }

    }
}
