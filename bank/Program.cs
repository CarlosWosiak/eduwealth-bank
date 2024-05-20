using bank;

AccountManagement bankManagement = new AccountManagement();

AccountHolder john = new AccountHolder("John", 0);

//await ExchangeRateServiceA.GetExchangeRateAsync("JPY");
//await ExchangeRateServiceB.GetExchangeRateAsync("JPY");

await Task.WhenAny(
    ExchangeRateServiceA.GetExchangeRateAsync("JPY"),
    ExchangeRateServiceB.GetExchangeRateAsync("JPY")
    );