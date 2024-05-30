namespace Eduwealth;

public class AccountHolder
{
    public string Name { get; set; }
    public float Balance { get; set; }
    

    public AccountHolder(string name, float balance)
    {
        Name = name;
        Balance = balance;
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
