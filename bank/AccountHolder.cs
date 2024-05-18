namespace bank;

public class AccountHolder
{
    private string Name { get; set; }
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
}