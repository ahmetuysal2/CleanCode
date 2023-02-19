
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
        private readonly List<BaseSalaryCalculator> _calculationList;

        public SalaryCalculator(List<BaseSalaryCalculator> calculationList)
        {
            _calculationList = calculationList;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var calculation in _calculationList)
            {
                totalSalaries += calculation.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}
