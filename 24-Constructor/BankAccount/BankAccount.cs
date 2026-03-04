using System;

class BankAccount {
    private string _owner;
    private int _balance;

    public BankAccount() {
        _owner = "익명";
        _balance = 0;
    }
    
    public BankAccount(string owner, int balance) {
        _owner = owner;
        _balance += balance;
    }

    public void Deposit(int amount) {
        if (amount < 0) {
            Console.WriteLine($"입금 금액은 0원 이상이어야 합니다.");
        } else {
            _balance += amount;
        }
    }

    public void Withdraw(int amount) {
        if (amount > _balance) {
            Console.WriteLine($"잔액이 부족합니다");
            return;
        } else {
            _balance -= amount;
        }
    }
    
    public void PrintInfo() {
        Console.WriteLine($"[{_owner}] 잔액 : {_balance:N0}원");
    }
}