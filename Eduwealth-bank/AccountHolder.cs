namespace Eduwealth;

public class AccountHolder
{
    public string Name { get; set; }
    public string Currency { get; set; }
    public float Balance { get; set; }
    

    public AccountHolder(string name, float balance, string currency)
    {
        Name = name;
        Balance = balance;
        Currency = currency;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"{Name} has {Balance} Dollars");
    }
    
    public async Task<float> GetBalance()
    {
        await Task.Delay(2000);
        return Balance;
    }

}
