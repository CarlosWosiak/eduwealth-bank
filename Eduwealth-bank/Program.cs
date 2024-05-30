// See https://aka.ms/new-console-template for more information

using Eduwealth;

AccountManagement bankManagement = new AccountManagement();

AccountHolder john = new AccountHolder("John", 1000);
AccountHolder clara = new AccountHolder("Clara", 0);

await bankManagement.MakeTransfer(john, clara, 400);

john.ShowBalance();
clara.ShowBalance();
