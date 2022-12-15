using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter 0 for welcome program \n Enter 1 for UC1");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {

                case 0:
                      Console.WriteLine("Welcome to Employee Wage Computation Program");
                    break;
                case 1:
                    Random random= new Random();
                    int empCheck=random.Next(0, 2);
                    EmployeeWadgeUC1.EmployeeUC1(empCheck);
                    break;
                default:
                    Console.WriteLine("Please Input Correct option");
                    break;

            }
        }

    }
}
