using System;
using System.Globalization;
using System.Collections.Generic;
using UdemyCourse.Entities.Enums;

namespace UdemyCourse.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract()
        {
            Console.WriteLine("Enter #" + (Contracts.Count + 1) + " contract data:");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duration (hours): ");
            int duration = int.Parse(Console.ReadLine());

            HourContract c = new HourContract(date, valuePerHour, duration);
            Contracts.Add(c);
        }

        public void RemoveContract(HourContract c)
        {
            Contracts.Remove(c);
        }

        public double Income(int year, int month)
        {
            // Achando todos os contratos naquele mês e ano:
            List<HourContract> Contracts2 = Contracts.FindAll(contract => (contract.Date.Year == year && contract.Date.Month == month));
            // Somando incomes povindos de contratos:
            double TotalSalary = BaseSalary;
            foreach (HourContract contract in Contracts2)
                TotalSalary += contract.TotalValue();
      
            return  TotalSalary;
        }
    }
}
