namespace Lodging_System.Models;

public class Suite
{
    public string SuiteType { get; set; }
    public int Capacity { get; set; }
    public decimal DailyRate { get; set; }

    public Suite(string suiteType, int capacity, decimal dailyRate)
    {
        SuiteType = suiteType;
        Capacity = capacity;
        DailyRate = dailyRate;
    }
}