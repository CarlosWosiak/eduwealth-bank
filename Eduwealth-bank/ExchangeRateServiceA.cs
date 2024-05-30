namespace Eduwealth;

public static class ExchangeRateServiceA
{
    public static async Task GetExchangeRateAsync(string currency)
    {
        Console.WriteLine("Exception thrown");
        throw new Exception();
        Console.WriteLine("Getting the exchangeRate from Service A");
        var watch = System.Diagnostics.Stopwatch.StartNew();

        var randomNumberGenerator = new Random();
        var randomTimeToReturn = randomNumberGenerator.Next(1000, 10000);
        if (randomNumberGenerator.Next(1,2) == 1)
        {
            Console.WriteLine("Exception thrown");
            throw new Exception();
        }

        await Task.Delay(randomTimeToReturn);
        watch.Stop();

        var exchangeRate = randomNumberGenerator.Next(100, 200);
        Console.WriteLine($"It took {watch.ElapsedMilliseconds}ms to get the ExchangeRate");
        Console.WriteLine($"The exchange rate from USD to ${currency} is 1 USD to {exchangeRate:#,##} {currency}");
    }
}