namespace bank;

public class AccountManagement
{
    public async Task AddFunds(AccountHolder accountHolder, float amount)
    {
        Console.WriteLine($"Adding funds to the account...");
        await Task.Delay(2000);
        accountHolder.Balance += amount;
    }
}