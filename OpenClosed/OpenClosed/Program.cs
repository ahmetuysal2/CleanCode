using OpenClosed;
using OpenClosed.Model;

public class Program
{
    static void Main(string[] args)
    {
        var calculationList = new List<BaseSalaryCalculator>
        {
            new SeniorDevSalaryCalculator(new Developer {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
            new JuniorDevSalaryCalculator(new Developer {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
            new SeniorDevSalaryCalculator(new Developer {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
        };
        var calculator = new SalaryCalculator(calculationList);
        Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
    }
}

