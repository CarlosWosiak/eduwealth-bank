namespace Eduwealth;

public static class FixedIncomeSource
{
    public static async Task<FixedIncome> GetFixedIncomeMonthlyRate(string investmentName)
    {
        await Task.Delay(2000);
        var randomNumberGenerator = new Random();
        var monthlyRate =  randomNumberGenerator.NextDouble() * 5;
        return new FixedIncome(investmentName, monthlyRate);
    }
}

public class FixedIncome
{
    public double MonthlyRate;
    public string Name;

    public FixedIncome(string name, double monthlyRate)
    {
        Name = name;
        MonthlyRate = monthlyRate;
    }
}