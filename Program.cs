using System;
using System.Collections.Generic;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var devReports = new List<BaseSalaryCalculator>
            {
                new SeniorSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1",Level = "Senior Developer", HourlyRate = 30.5, WorkingHours = 160}),
                new JuniorSalaryCalculator (new DeveloperReport{Id = 2, Name = "Dev2",Level = "Junior Developer", HourlyRate = 20, WorkingHours = 150}),
                new SeniorSalaryCalculator (new DeveloperReport{Id = 3, Name = "Dev3",Level = "Senior Developer", HourlyRate = 30.5, WorkingHours = 180})
            };
            var calculator = new SalaryCalculator(devReports);
            Console.WriteLine("The total salaries of the workers is {0} dollars", calculator.CalculateTotalSalaries());
            Console.ReadLine();
        }
    }
}
