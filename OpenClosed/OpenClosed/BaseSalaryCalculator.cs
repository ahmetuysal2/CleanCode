using OpenClosed.Model;


namespace OpenClosed
{
    public abstract class BaseSalaryCalculator
    {
        protected  Developer developer { get; set; }

        public BaseSalaryCalculator(Developer developer)
        {
            this.developer = developer;
        }

        public abstract double CalculateSalary();
    }


    public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(Developer developer) : base(developer)
        {
        }
        public override double CalculateSalary() => developer.HourlyRate * developer.WorkingHours * 1.2;
    }

    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(Developer developer) : base(developer)
        {
        }
        public override double CalculateSalary() => developer.HourlyRate * developer.WorkingHours;
    }
}
