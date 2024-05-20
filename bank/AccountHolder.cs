// ReSharper disable All
namespace bank;

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

public static class DataBase
{
    public static async Task<User[]> GetUsers()
    {
        return await Task.FromResult(new User[]{ });
    }
    
    public static async Task<Product[]> GetProducts()
    {
        return await Task.FromResult(new Product[]{ });
    }
}


public class User
{
}

public class Product
{
}

public class Deal();