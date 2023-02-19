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


    //public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    //{
    //    private Developer developerx;

    //    public SeniorDevSalaryCalculator(Developer developerx)
    //    {
    //        this.developerx = developerx;
    //    }

    //    public override double CalculateSalary() => developerx.HourlyRate * developerx.WorkingHours * 1.2;
    //}

    //public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    //{
    //    private Developer developerx;

    //    public JuniorDevSalaryCalculator(Developer developerx)
    //    {
    //        this.developerx = developerx;
    //    }

    //    public override double CalculateSalary() => developerx.HourlyRate * developerx.WorkingHours;
    //}
}
