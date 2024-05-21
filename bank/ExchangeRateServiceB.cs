namespace bank;

public static class ExchangeRateServiceB
{
    public static async Task<int> GetExchangeRateAsync(string currency)
    {
        Console.WriteLine("Getting the exchangeRate from Service B");
        var watch = System.Diagnostics.Stopwatch.StartNew();

        var randomNumberGenerator = new Random();
        var randomTimeToReturn = randomNumberGenerator.Next(1000, 10000);

        await Task.Delay(randomTimeToReturn);
        watch.Stop();

        var exchangeRate = randomNumberGenerator.Next(100, 200);
        return exchangeRate;
    }
}