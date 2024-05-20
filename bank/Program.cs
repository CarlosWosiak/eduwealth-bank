using bank;

AccountManagement bankManagement = new AccountManagement();

AccountHolder john = new AccountHolder("John", 0);

//await ExchangeRateServiceA.GetExchangeRateAsync("JPY");
//await ExchangeRateServiceB.GetExchangeRateAsync("JPY");

// await Task.WhenAny(
//     ExchangeRateServiceA.GetExchangeRateAsync("JPY"),
//     ExchangeRateServiceB.GetExchangeRateAsync("JPY")
// );

var serviceA = ExchangeRateServiceA.GetExchangeRateAsync("JPY");
var serviceB = ExchangeRateServiceB.GetExchangeRateAsync("JPY");
var getCurrency = Task.WhenAny(serviceA, serviceB);

await getCurrency;


var remainingTasks = new[] { serviceA, serviceB }.Except(new[] { getCurrency });
foreach (var remainingTask in remainingTasks)
{
    try
    {
        await remainingTask;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"A remaining task completed with an error: {ex.Message}");
    }
}


//
// var aggregateTask = Task.WhenAll(ExchangeRateServiceA.GetExchangeRateAsync("JPY"),
//     ExchangeRateServiceB.GetExchangeRateAsync("JPY")
// );


// try
// {
//
//     await aggregateTask.ConfigureAwait(false);
// }
// catch (AggregateException e)
// {
//     Console.WriteLine(e.Message);
// }
// catch(Exception e)
// {
//     Console.WriteLine(e.Message);
// }