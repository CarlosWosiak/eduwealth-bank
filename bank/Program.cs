// See https://aka.ms/new-console-template for more information

using bank;

AccountManagement bankManagement = new AccountManagement();

AccountHolder john = new AccountHolder("John", 0);

await bankManagement.GetTheBestFixedIncomeOption(john);