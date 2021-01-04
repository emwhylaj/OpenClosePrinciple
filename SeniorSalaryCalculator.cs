using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{
    public class SeniorSalaryCalculator : BaseSalaryCalculator {
        public SeniorSalaryCalculator(DeveloperReport report) : base(report)
        {

        }
        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
    }
}
