using System;

Console.WriteLine($"=== 계좌 개설 ===");
BankAccount ba1 = new BankAccount("홍길동", "1001", 100000);
BankAccount ba2 = new BankAccount("이순신", "1002", 50000);
BankAccount.ShowTotalAccounts();
Console.WriteLine();

Console.WriteLine($"=== 거래 ===");
ba1.Deposit(50000);
ba2.Deposit(30000);
ba1.Withdraw(200000);
ba1.Withdraw(100000);
Console.WriteLine();

Console.WriteLine($"=== 최종 계좌 정보 ===");
ba1.ShowInfo();
ba2.ShowInfo();
Console.WriteLine();
Console.WriteLine();
