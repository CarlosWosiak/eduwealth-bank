namespace Eduwealth;

public class AccountManagement
{
    public async Task AddFunds(AccountHolder accountHolder, float amount)
    {
        Console.WriteLine("Adding funds to the account...");
        await Task.Delay(2000);
        accountHolder.Balance += amount;
    }

    public async Task RemoveFunds(AccountHolder accountHolder, float amount)
    {
        Console.WriteLine("Removing funds to the account...");
        await Task.Delay(2000);
        accountHolder.Balance += amount;
    }

    public async Task MakeTransfer(AccountHolder sender, AccountHolder receiver, float amount)
    {
        Console.WriteLine($"Initializing a transaction of {amount} from {sender.Name} to {receiver.Name}");
        var senderFundsCall = sender.GetBalance();
        var receiverFundsCall = receiver.GetBalance();

        var funds = await Task.WhenAll(senderFundsCall, receiverFundsCall);

        if (senderFundsCall.Result < amount)
        {
            throw new Exception("The transaction is impossible, the sender does not have the required amount");
        }
        
        sender.Balance -= amount;
        receiver.Balance += amount;
    }
    
}