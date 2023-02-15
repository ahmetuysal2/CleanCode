using OpenClosed.Model;


namespace OpenClosed
{
    public abstract class BaseSalaryCalculatorWithOpenClosed
    {
        protected  Developer developer { get; set; }

        public BaseSalaryCalculatorWithOpenClosed(Developer developer)
        {
            this.developer = developer;
        }

        public abstract double CalculateSalary();
    }


    public class SeniorDevSalaryCalculator : BaseSalaryCalculatorWithOpenClosed
    {
        public SeniorDevSalaryCalculator(Developer developer) : base(developer)
        {
        }
        public override double CalculateSalary() => developer.HourlyRate * developer.WorkingHours * 1.2;
    }

    public class JuniorDevSalaryCalculator : BaseSalaryCalculatorWithOpenClosed
    {
        public JuniorDevSalaryCalculator(Developer developer) : base(developer)
        {
        }
        public override double CalculateSalary() => developer.HourlyRate * developer.WorkingHours;
    }
}
