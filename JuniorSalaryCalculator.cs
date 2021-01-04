using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{
    class JuniorSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorSalaryCalculator (DeveloperReport developerReport) : base(developerReport)
        {

        }
        public override double CalculateSalary() => DeveloperReport.WorkingHours * DeveloperReport.HourlyRate;
        
    }
}
