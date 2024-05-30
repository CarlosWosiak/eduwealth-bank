// See https://aka.ms/new-console-template for more information

using bank;

AccountManagement bankManagement = new AccountManagement();

AccountHolder john = new AccountHolder("John", 0);
;   
john.ShowBalance();

bankManagement.TakeLoan(john, 1500);

john.ShowBalance();
