using System;
using System.Diagnostics.Contracts;

class BankAccount {
    private readonly string _accountNumber;
    private string _ownerName;
    private int _balance;

    public BankAccount(string accountNumber, string ownerName) {
        _accountNumber = accountNumber;
        _ownerName = ownerName;
    }
    
    public string AccountNumber { get => _accountNumber; }
    public string OwnerName { 
        get => _ownerName;
        set => _ownerName = value;
    }
    public int Balance { 
        get => _balance; 
        private set => _balance = Math.Clamp(value, 0, Int32.MaxValue);
    }

    public void Deposit(int amount) {
        if (amount >= 0) Balance += amount;
    }

    public bool Withdraw(int amount) {
        if (amount <= Balance) {
            Balance -= amount;
            return true;
        } else { return false; }
    }
}