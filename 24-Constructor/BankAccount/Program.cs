using System;

// 기본 생성자로 계좌 생성
BankAccount account1 = new BankAccount();
account1.PrintInfo();

// 매개변수가 있는 생성자로 계좌 생성
BankAccount account2 = new BankAccount("홍길동", 10000);
account2.PrintInfo();

// 입금 테스트
account2.Deposit(5000);
account2.PrintInfo();

// 출금 테스트
account2.Withdraw(3000);
account2.PrintInfo();

// 잔액 부족 테스트
account2.Withdraw(20000);
account2.PrintInfo();