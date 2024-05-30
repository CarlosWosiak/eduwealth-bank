#pragma warning disable CS8602 // Dereference of a possibly null reference.
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


    public void TakeLoan(AccountHolder accountHolder, float amount)
    {
        var loanApproval = IsCreditEnoughToTakeTheLoan(accountHolder, amount);
        Console.WriteLine($"John had his loan request approved? {(loanApproval ? "yes" : "no")}");
        if (loanApproval)
        {
            accountHolder.Balance += amount;
        }
    }

    private static bool IsCreditEnoughToTakeTheLoan(AccountHolder accountHolder, float amount)
    {
        if (amount <= 0)
        {
            throw new Exception("The amount informed is not valid");
        }

        var equimail = new CreditCompany();
        var creditSecure = new CreditCompany();
        var equimailCredit = equimail.GetCreditScore(accountHolder);
        var creditSecureCredit = creditSecure.GetCreditScore(accountHolder);

        Task.WaitAll(equimailCredit, creditSecureCredit);
        
        var averageCredit = (equimailCredit.Result + creditSecureCredit.Result) / 2;
        Console.WriteLine($"The average credit score for {accountHolder.Name} is {averageCredit}");;
        switch (amount)
        {
            case < 1000:
                return averageCredit > 300;
            case <= 1000 and < 5000:
                return averageCredit > 450;
            case <= 5000 and < 10000:
                return averageCredit > 600;
            case > 10000:
                return averageCredit >= 800;
            default:
                return false;
        }
    }

    public async Task GetTheBestFixedIncomeOption(AccountHolder accountHolder)
    {
        Console.WriteLine("Checking for options...");
        var fixedIncomeOptions = await Task.WhenAll(
            FixedIncomeSource.GetFixedIncomeMonthlyRate("Invest Core"),
            FixedIncomeSource.GetFixedIncomeMonthlyRate("Global F11"),
            FixedIncomeSource.GetFixedIncomeMonthlyRate("World bond")
            );
        
        var bestOption = fixedIncomeOptions.MaxBy(fixedIncomeOption => fixedIncomeOption.MonthlyRate);
        Console.WriteLine($"The best fixed income option for {accountHolder.Name} is {bestOption.Name} with a monthly rate of {bestOption.MonthlyRate:#.##}%");
    }
}