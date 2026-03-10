using System;

BankAccount bankAccount = new BankAccount("123-456", "홍길동");

Console.WriteLine($"계좌번호 : {bankAccount.AccountNumber}");
Console.WriteLine($"예금주 : {bankAccount.OwnerName}");
Console.WriteLine($"잔액 : {bankAccount.Balance:N0}원");

int amount = 50000;
Console.WriteLine($"=== {amount:N0}원 입금 ===");
bankAccount.Deposit( amount );
Console.WriteLine($"잔액 : {bankAccount.Balance:N0}원");

amount = 20000;
Console.WriteLine($"=== {amount:N0}원 출금 ===");
Console.WriteLine($"출금 성공 : {bankAccount.Withdraw(amount)}");
Console.WriteLine($"잔액 : {bankAccount.Balance:N0}원");

amount = 100000;
Console.WriteLine($"=== {amount:N0}원 출금 시도 ===");
Console.WriteLine($"출금 성공 : {bankAccount.Withdraw(amount)}");
Console.WriteLine($"잔액 : {bankAccount.Balance:N0}원");

Console.WriteLine();
Console.WriteLine();
