
using OpenClosed.Model;

namespace OpenClosed
{
    //public class SalaryCalculator
    //{
    //    private readonly IEnumerable<Developer> _developer;

    //    public SalaryCalculator(List <Developer> developer)
    //    {
    //            _developer = developer;
    //    }

    //    public double CalculateTotalSalaries()
    //    {
    //        double totalSalaries = 0D ;

    //        foreach (var devReport in _developer)
    //        {
    //            totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
    //        }

    //        return totalSalaries;
    //    }
    //}

    public class SalaryCalculator
    {
        private readonly List<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator(List<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devCalc in _developerCalculation)
            {
                totalSalaries += devCalc.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}
