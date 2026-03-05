using System;

class BankAccount {
    private static int _totalAccounts;

    private string _accountNumber;
    private string _ownerName;
    private int _balance;

    static BankAccount() {
        _totalAccounts = 0;
    }

    public BankAccount(string ownerName, string accountNumber, int balance) {
        _ownerName = ownerName;
        _accountNumber = accountNumber;
        _balance = balance;

        _totalAccounts++;
        Console.WriteLine($"[{_accountNumber}] {_ownerName}계좌가 개설되었습니다.");
    }

    public void Deposit(int amount) {
        _balance += amount;
        Console.WriteLine($"{amount}원 입금 완료. 잔액 : {_balance:N0}원");
    }
    
    public void Withdraw(int amount) {
        if (amount > _balance) {
            Console.WriteLine($"{amount}원 출금 실패. 잔액이 부족합니다.");
        } else {
            _balance -= amount;
            Console.WriteLine($"{amount}원 출금 완료. 잔액 : {_balance:N0}원");
        }
    }

    public void ShowInfo() {
        Console.WriteLine($"계좌번호 : {_accountNumber}, 예금주 : {_ownerName}, 잔액 : {_balance:N0}원");
    }


    public static void ShowTotalAccounts() {
        Console.WriteLine($"현재 총 계좌 수 : {_totalAccounts}개");
    }
}