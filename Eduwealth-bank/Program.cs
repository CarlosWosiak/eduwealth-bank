using Eduwealth;

AccountManagement bankManagement = new AccountManagement();

AccountHolder john = new AccountHolder("John", 1000, "USD");
AccountHolder jonas = new AccountHolder("Jonas", 0, "JPY");

try
{
    await bankManagement.MakeInternationalTransaction(john, jonas, 100);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
