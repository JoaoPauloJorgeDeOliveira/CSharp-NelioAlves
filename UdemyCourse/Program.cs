using System;
using System.Globalization;
using UdemyCourse.Entities;
using UdemyCourse.Entities.Enums;

namespace UdemyCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior / MidLevel / Senior):  ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);

            Worker w = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int qtdContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdContracts; i++)
                w.AddContract();

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            int year = dateTime.Year;
            int month = dateTime.Month;

            Console.WriteLine("Name: "  + w.Name);
            Console.WriteLine("Department: " + w.Department.Name);
            Console.WriteLine("Income for " + month + "/" + year + ": " + w.Income(year,month).ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}
