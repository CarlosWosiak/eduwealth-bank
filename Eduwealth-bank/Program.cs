// See https://aka.ms/new-console-template for more information

using Eduwealth;

AccountManagement bankManagement = new AccountManagement();

AccountHolder john = new AccountHolder("John", 0);

john.ShowBalance();

await bankManagement.AddFunds(john, 100);

john.ShowBalance();
