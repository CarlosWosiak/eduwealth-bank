namespace bank;

public class CreditCompany
{
    public async Task<float> GetCreditScore(AccountHolder accountHolder)
    {
        Console.WriteLine($"Checking score for {accountHolder.Name}");
        await Task.Delay(5000);
        var randomNumberGenerator = new Random();
        return randomNumberGenerator.Next(300, 850);
    }
}